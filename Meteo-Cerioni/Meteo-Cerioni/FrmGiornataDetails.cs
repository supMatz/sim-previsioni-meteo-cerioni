using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meteo_Cerioni
{
    public partial class FrmGiornataDetails : Form
    {
        Giornata Giornata;
        private readonly List<Giornata> GiornatePrecedenti;


        public FrmGiornataDetails(Giornata giornata, List<Giornata> giornatePrecedenti)
        {
            InitializeComponent();
            Giornata = giornata;
            GiornatePrecedenti = giornatePrecedenti;

            InitializeListView();
            PopolaDatiOrari();
            AggiornaStatistiche();
        }

        private void InitializeListView()
        {
            //crea le colonne
            lvDatiOrari.Columns.Clear();
            lvDatiOrari.Columns.Add("Ora", 60);
            lvDatiOrari.Columns.Add("Temperatura", 100);
            lvDatiOrari.Columns.Add("Umidità", 100);
            lvDatiOrari.Columns.Add("Direzione Vento", 120);
            lvDatiOrari.Columns.Add("Velocità Vento", 100);
            lvDatiOrari.Columns.Add("Pressione", 90);

            lvDatiOrari.View = View.Details;
            lvDatiOrari.FullRowSelect = true;
            lvDatiOrari.GridLines = true;
        }

        private void PopolaDatiOrari()
        {
            lvDatiOrari.Items.Clear();

            foreach (var ora in Giornata.Meteo.TemperaturePerOrario.OrderBy(kvp => kvp.Key))
            {
                var item = new ListViewItem(ora.Key.ToString(@"hh\:mm"));

                //temperatura
                item.SubItems.Add($"{ora.Value:F1}°C");

                //umidità
                if (Giornata.Meteo.UmiditaPerOrario.TryGetValue(ora.Key, out double umidita))
                    item.SubItems.Add($"{umidita:F1}%");
                else
                    item.SubItems.Add("N/D");

                //vento
                if (Giornata.Meteo.VentoPerOrario.TryGetValue(ora.Key, out var vento))
                {
                    item.SubItems.Add(vento.Direzione.ToString());
                    item.SubItems.Add($"{vento.Velocita:F1} km/h");
                }
                else
                {
                    item.SubItems.AddRange(new[] { "N/D", "N/D" });
                }

                //pressione
                if (Giornata.Meteo.PressionePerOrario.TryGetValue(ora.Key, out double pressione))
                    item.SubItems.Add($"{pressione:F1} hPa");
                else
                    item.SubItems.Add("N/D");

                lvDatiOrari.Items.Add(item);
            }
        }

        private void AggiornaStatistiche()
        {
            // Calcola tutte le statistiche
            int aumenti = CalcolaAumentiTemperatura(Giornata.Meteo.TemperaturePerOrario);
            bool sottoZero = TemperaturaSottoZero(Giornata.Meteo.TemperaturePerOrario);
            int superamenti = CalcolaSuperamentiMediaPrecedente(Giornata, GiornatePrecedenti);
            Vento.eDirezioneVento direzioneVento = CalcolaDirezionePrevalente();
            string previsione = PrevediProssimeOre();

            // Aggiorna le label
            lblStat1.Text = $"{lblStat1.Text.Split(':')[0]}: {aumenti}";
            lblStat2.Text = $"{lblStat2.Text.Split(':')[0]}: {(sottoZero ? "Sì" : "No")}";
            lblStat3.Text = $"{lblStat3.Text.Split(':')[0]}: {superamenti}";
            lblStat4.Text = $"{lblStat4.Text.Split(':')[0]}: {Giornata.Meteo.UmiditàMedia:F1}%";
            lblStat5.Text = $"{lblStat5.Text.Split(':')[0]}: {direzioneVento}";
            lblStat6.Text = $"{lblStat6.Text.Split(':')[0]}: {previsione}";
        }

        private string PrevediProssimeOre()
        {
            double pressioneMedia = Giornata.Meteo.PressionePerOrario.Values.Average();

            if (pressioneMedia < 1000) return "Pioggia";
            if (pressioneMedia > 1020) return "Sereno";
            return "Variabile";
        }

        private Vento.eDirezioneVento CalcolaDirezionePrevalente()
        {
            int[] conteggi = new int[Enum.GetValues(typeof(Vento.eDirezioneVento)).Length];

            foreach (var vento in Giornata.Meteo.VentoPerOrario.Values)
            {
                int indice = (int)vento.Direzione;
                conteggi[indice]++;
            }

            int indicePrevalente = 0;
            int maxConteggio = conteggi[0];

            for (int i = 1; i < conteggi.Length; i++)
            {
                if (conteggi[i] > maxConteggio)
                {
                    maxConteggio = conteggi[i];
                    indicePrevalente = i;
                }
            }

            //restituisci la direzione prevalente
            return (Vento.eDirezioneVento)indicePrevalente;
        }

        private int CalcolaAumentiTemperatura(Dictionary<TimeSpan, double> temperature)
        {
            short a = 0;
            double temperaturaPrecedente = temperature.Values.First();

            foreach (var temperatura in temperature.Values.Skip(1))
            {
                if (temperatura > temperaturaPrecedente)
                    a++;
                temperaturaPrecedente = temperatura;
            }

            return a;
        }

        private bool TemperaturaSottoZero(Dictionary<TimeSpan, double> temperature)
        {
            return temperature.Values.Any(t => t < 0);
        }

        private int CalcolaSuperamentiMediaPrecedente(Giornata giornata, List<Giornata> giorni)
        {
            //trova il giorno precedente
            var giornoPrecedente = giorni.FirstOrDefault(g => g.Data == giornata.Data.AddDays(-1));
            if (giornoPrecedente == null)
                return 0;

            double mediaPrecedente = giornoPrecedente.TemperaturaMedia;
            return giornata.Meteo.TemperaturePerOrario.Values.Count(t => t > mediaPrecedente);
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

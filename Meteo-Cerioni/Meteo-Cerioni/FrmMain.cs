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
    public partial class FrmMain : Form
    {
        List<Giornata> Giorni;
        public FrmMain()
        {
            Giorni = new List<Giornata>();

            InitializeComponent();
            
            dtpDataInizio.MinDate = DateTime.Today;
            dtpDataInizio.MaxDate = DateTime.Today.AddMonths(2); // modificabile in base a quanti mesi si vuole andare avanti
        }


        #region Eventi Form
        private void btGeneraPrevisioni_Click(object sender, EventArgs e)
        {
            lvGiorni.Items.Clear();
            pnlPrevisioni.Enabled = true;

            InitializeMeteoGiorni(Giorni, dtpDataInizio.Value);
            AggiornaListView(lvGiorni, Giorni);
        }
        private void btPulisci_Click(object sender, EventArgs e)
        {
            pnlPrevisioni.Enabled = false;
            lvGiorni.Items.Clear();
        }
        private void btStatistiche_Click(object sender, EventArgs e)
        {
            if (lvGiorni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleziona una giornata dalla lista.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ottieni la giornata selezionata
            var selectedItem = lvGiorni.SelectedItems[0];
            var giornata = Giorni.FirstOrDefault(g => g.Data.ToShortDateString() == selectedItem.Text);

            if (giornata != null)
            {
                //apri la nuova form
                FrmGiornataDetails dettaglioForm = new FrmGiornataDetails(giornata, Giorni);
                dettaglioForm.ShowDialog();
            }
        }
        #endregion

        #region Metodi
        private void AggiornaListView(ListView lv, List<Giornata> giorni)
        {
            lv.Items.Clear();

            foreach(Giornata g in giorni)
                CreaListViewItem(g, lv);
        }
        
        private void CreaListViewItem(Giornata g, ListView lv)
        {
            ListViewItem lvi = new ListViewItem(g.Data.ToString().Substring(0,10));
            lvi.SubItems.Add(Math.Round(g.TemperaturaMedia, 2).ToString() + "°C");
            lvi.SubItems.Add(g.Meteo.CondizioneMeteo.ToString());
            lvi.SubItems.Add(g.Meteo.Precipitazioni.ToString() + "mm");
            lvi.SubItems.Add(g.Meteo.UmiditàMedia.ToString() + '%');
            lvi.SubItems.Add(g.Meteo.Vento.ToString() + "km/h");

            lv.Items.Add(lvi);
        }

        private void InitializeMeteoGiorni(List<Giornata> giorni, DateTime dataInizio)
        {
            int numeroGiorni = (dataInizio.AddMonths(2) - dataInizio).Days + 1; //numero di giorni per cui generare previsioni con la data di fine inclusa

            for (int i = 0; i < numeroGiorni; i++)
            {
                DateTime data = dataInizio.AddDays(i);
                Giornata giornata = new Giornata(data);
                giorni.Add(giornata);
            }
        }
        #endregion
    }
}

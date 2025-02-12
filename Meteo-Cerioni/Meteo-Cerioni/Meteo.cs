using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteo_Cerioni
{
    public class Meteo
    {
        public Meteo()
        {
            TemperaturePerOrario = new Dictionary<TimeSpan, double>();
            UmiditaPerOrario = new Dictionary<TimeSpan, double>();
            PressionePerOrario = new Dictionary<TimeSpan, double>();
            VentoPerOrario = new Dictionary<TimeSpan, Vento>();
        }

        #region Enum
        public enum eCondizioneMeteo
        {
            Soleggiato,
            Nuvoloso,
            Piovoso,
            Nebbia,
            Tempesta
        }
        #endregion

        #region Variabili
        private double _vento;
        private double _umidità;
        private double _pressioneAtmosferica;
        private double _precipitazioni;
        private double _probabilitàPioggia;
        #endregion

        #region Proprietà
        public Dictionary<TimeSpan, double> TemperaturePerOrario { get; set; }
        public Dictionary<TimeSpan, double> UmiditaPerOrario { get; set; }
        public Dictionary<TimeSpan, double> PressionePerOrario { get; set; }
        public Dictionary<TimeSpan, Vento> VentoPerOrario { get; set; }

        public double Vento
        {
            get { return _vento; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(Vento), "Il valore del vento non può essere negativo.");
                _vento = value;
            }
        }

        public double UmiditàMedia
        {
            get { return _umidità; }
            set
            {
                if (value < 0 || value > 100) throw new ArgumentOutOfRangeException(nameof(UmiditàMedia), "L'umidità deve essere compresa tra 0 e 100%.");
                else
                    _umidità = value;
            }
        }

        public double PressioneAtmosferica
        {
            get { return _pressioneAtmosferica; }
            set
            {
                if (value < 800 || value > 1100) throw new ArgumentOutOfRangeException(nameof(PressioneAtmosferica), "La pressione atmosferica deve essere compresa tra 800 e 1100 hPa.");
                else
                    _pressioneAtmosferica = value;
            }
        }

        public double Precipitazioni
        {
            get { return _precipitazioni; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(Precipitazioni), "Le precipitazioni non possono essere negative.");
                else
                    _precipitazioni = value;
            }
        }

        public double ProbabilitàPioggia
        {
            get { return _probabilitàPioggia; }
            set
            {
                if (value < 0 || value > 100) throw new ArgumentOutOfRangeException(nameof(ProbabilitàPioggia), "La probabilità di pioggia deve essere compresa tra 0 e 100%.");
                else
                    _probabilitàPioggia = value;
            }
        }

        public eCondizioneMeteo CondizioneMeteo { get; set; }
        #endregion

        #region Metodi
        public override string ToString()
        {
            return $"Vento: {Vento} m/s, Umidità: {UmiditàMedia}%, " +
                   $"Pressione: {PressioneAtmosferica} hPa, " +
                   $"Precipitazioni: {Precipitazioni} mm, " +
                   $"Descrizione: {CondizioneMeteo.ToString()}, " +
                   $"Probabilità di Pioggia: {ProbabilitàPioggia}%";
        }

        public void CalcoloUmidità()
        {
            Random rnd = new Random();

            //genera valori di umidità per ogni ora
            for (int ora = 0; ora < 24; ora++)
            {
                TimeSpan orario = new TimeSpan(ora, 0, 0);
                double umidita = Math.Round(50 + (rnd.NextDouble() * 50), 1); // Valori tra 50% e 100%
                UmiditaPerOrario[orario] = umidita;
            }

            //calcola la media giornaliera
            UmiditàMedia = Math.Round(UmiditaPerOrario.Values.Average(), 1);
        }

        private Vento.eDirezioneVento CalcolaDirezionePrevalente()
        {
            var conteggi = VentoPerOrario.Values
                .GroupBy(v => v.Direzione)
                .Select(g => new { Direzione = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .ToList();

            //gestione pareggi (seleziona casualmente tra le direzioni con lo stesso conteggio massimo)
            var maxCount = conteggi.First().Count;
            var candidates = conteggi.Where(x => x.Count == maxCount).Select(x => x.Direzione).ToList();

            return candidates.Count > 1
                ? candidates[new Random().Next(candidates.Count)]
                : conteggi.First().Direzione;
        }
        #endregion
    }
}

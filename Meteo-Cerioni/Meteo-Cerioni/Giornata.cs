using System;
using System.Collections.Generic;
using System.Linq;

namespace Meteo_Cerioni
{
    public class Giornata
    {
        public Giornata(DateTime data)
        {
            Data = data;
            Meteo = GeneraTemperature(Data.Month);
            TemperaturaMedia = CalcolaMediaTemperature(Meteo);
            Meteo.CalcoloUmidità(); //calcolo finale dell'umidità
        }

        #region Variabili Globali
        private static readonly Random rnd = new Random();
        private static readonly double[] medieTemperature = { 5, 7, 10, 14, 18, 22, 25, 24, 20, 15, 10, 6 };
        #endregion

        #region Proprietà
        public DateTime Data { get; set; }
        public Meteo Meteo { get; }
        public double TemperaturaMedia { get; private set; }
        #endregion

        #region Metodi
        private Meteo GeneraTemperature(int mese)
        {
            var m = new Meteo();

            for (int ora = 0; ora < 24; ora++)
            {
                var orario = new TimeSpan(ora, 0, 0);

                //popola tutti i dizionari per ogni orario
                m.TemperaturePerOrario[orario] = Math.Round(medieTemperature[mese - 1] + (rnd.NextDouble() * 10 - 5), 1); // Temperatura
                m.UmiditaPerOrario[orario] = Math.Round(50 + (rnd.NextDouble() * 50), 1); //umidità (50% - 100%)
                m.PressionePerOrario[orario] = Math.Round(1000 + (rnd.NextDouble() * 20), 1); //pressione (1000 - 1020 hPa)
                m.VentoPerOrario[orario] = new Vento
                {
                    Velocita = Math.Round(rnd.NextDouble() * 30, 1), // Velocità (0 - 30 km/h)
                    Direzione = (Vento.eDirezioneVento)rnd.Next(Enum.GetValues(typeof(Vento.eDirezioneVento)).Length) //direzione casuale
                };
            }

            m.Vento = Math.Round(rnd.NextDouble() * 10, 1);
            m.PressioneAtmosferica = Math.Round(1000 + rnd.NextDouble() * 20, 1);
            m.Precipitazioni = Math.Round(rnd.NextDouble() * 10, 1);
            m.CondizioneMeteo = (Meteo.eCondizioneMeteo)rnd.Next(5);
            m.ProbabilitàPioggia = Math.Round(rnd.NextDouble() * 100, 1);

            return m;
        }
        private double CalcolaMediaTemperature(Meteo meteo)
        {
            return meteo.TemperaturePerOrario.Values.Average();
        }
        #endregion
    }
}
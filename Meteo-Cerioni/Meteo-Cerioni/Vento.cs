using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteo_Cerioni
{
    public class Vento
    {
        #region Variabili
        double _velocità;
        #endregion

        #region Enum
        public enum eDirezioneVento
        {
            Nord,
            NordOvest,
            NordEst,
            Sud,
            SudOvest,
            SudEst,
            Est,
            Ovest
        }
        #endregion

        #region Proprietà
        public double Velocita
        {
            get => _velocità;
            set
            {
                if (value < 0 || value > 100) throw new ArgumentOutOfRangeException(nameof(Velocita), "Velocità non valida");
                else
                    _velocità = value;
            }
        }
        public eDirezioneVento Direzione { get; set; }
        #endregion
    }
}

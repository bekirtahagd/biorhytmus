using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biorhytmus
{
    [Serializable]
    class LokaleDaten
    {
        private bool istEingeloggt = false;
        private Benutzer angemeldeterBenutzer;



        #region Setter and Getter
        public void setIstEingeloggt(bool value)
        {
            istEingeloggt = value;
        }
        public bool getIstEingeloggt()
        {
            return istEingeloggt;
        }
        public void setBenutzer(Benutzer value)
        {
            angemeldeterBenutzer = value;
        }
        public Benutzer getBenutzer()
        {
            return angemeldeterBenutzer;
        }
        #endregion
    }
}

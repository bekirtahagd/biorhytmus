using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biorhytmus
{
    public class FarbSchema
    {
        // Variables
        private Color backColor;
        private Color foreColor;

        //Constructor
        public FarbSchema(Color pBackColor, Color pForeColor)
        {
            backColor = pBackColor;
            foreColor = pForeColor;
        }
        public FarbSchema() { }

        // Setter and Getter
        public void setBackColor(Color value)
        {
            backColor = value;
        }
        public Color getBackColor()
        {
            return backColor;
        }

        public void setForeColor(Color value)
        {
            foreColor = value;
        }
        public Color getForeColor()
        {
            return foreColor;
        }

    }
}

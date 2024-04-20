using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biorhytmus
{
    class SchemaSammlung
    {
        public FarbSchema getFormSchema(bool dunkel)
        {
            if (dunkel)
                return new FarbSchema(SystemColors.WindowFrame, SystemColors.ControlDark);
            else
                return new FarbSchema(SystemColors.InactiveCaption, SystemColors.ControlText);
        }
        public FarbSchema getButtonSchema(bool dunkel)
        {
            if (dunkel)
                return new FarbSchema(SystemColors.Control, Color.Transparent);
            else
                return new FarbSchema(SystemColors.ControlText, Color.Transparent);
        }
        public FarbSchema getLabelSchema(bool dunkel)
        {
            if (dunkel)
                return new FarbSchema(Color.Transparent, SystemColors.Control);
            else
                return new FarbSchema(Color.Transparent, SystemColors.ControlText);
        }
        public FarbSchema getDmPanelSchema(bool dunkel)
        {
            if (dunkel)
                return new FarbSchema(SystemColors.Menu, Color.Transparent);
            else
                return new FarbSchema(SystemColors.WindowFrame, Color.Transparent);
        }

        public FarbSchema getSpecialButtonSchema(bool dunkel)
        {
            if (dunkel)
                return new FarbSchema(SystemColors.Menu, Color.Transparent);
            else
                return new FarbSchema(Color.Magenta, Color.Magenta);
        }
    }
}

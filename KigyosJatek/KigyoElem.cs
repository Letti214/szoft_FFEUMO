using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyosJatek
{
    internal class KigyoElem : PictureBox
    {
        public static int Méret = 20;

        public KigyoElem()
        {
            Width = KigyoElem.Méret;
            Height = KigyoElem.Méret;
            BackColor = Color.Fuchsia;
        }
    }
}

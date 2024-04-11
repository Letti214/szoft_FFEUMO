using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyosJatek
{
    internal class Alma : PictureBox
    {
        public static int méret = 20;
        public Alma()
        {
            Height = Alma.méret;
            Width = Alma.méret;
            BackColor = Color.Red;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak3
{
    internal class SzamoloGomb : VillogoGomb
    {
        int i = 1;
        public SzamoloGomb()
        {
            MouseClick += SzamoloGomb_MouseClick;
            Text = i.ToString();
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if(i==10) { i=0; }
            i++;
            Text = i.ToString();
        }
    }
}

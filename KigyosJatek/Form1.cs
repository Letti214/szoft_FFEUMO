namespace KigyosJatek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int fej_x = 100;
        int fej_y = 100;
        int ir�ny_x = 1;
        int ir�ny_y = 0;
        int l�p�sSz�m = 0;
        int hossz = 5;
        List<KigyoElem> k�gy� = new List<KigyoElem>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�sSz�m++;
            fej_x += ir�ny_x * KigyoElem.M�ret;
            fej_y += ir�ny_y * KigyoElem.M�ret;

            foreach (object item in Controls)
            {
                if (item is KigyoElem)
                {
                    KigyoElem k = (KigyoElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            KigyoElem ke = new KigyoElem();
            k�gy�.Add(ke);
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);

            if (l�p�sSz�m % 2 == 0) ke.BackColor = Color.Yellow;

            if (k�gy�.Count > hossz)
            {
                KigyoElem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int alma_x = random.Next(0,1000);
            int alma_y = random.Next(0,1000);
            Alma a = new Alma();
            a.Top = alma_y;
            a.Left = alma_x;
            Controls.Add(a);
        }
    }
}
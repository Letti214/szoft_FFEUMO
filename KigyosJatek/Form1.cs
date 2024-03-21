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
        int irány_x = 1;
        int irány_y = 0;
        int lépésSzám = 0;
        int hossz = 5;
        List<KigyoElem> kígyó = new List<KigyoElem>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésSzám++;
            fej_x += irány_x * KigyoElem.Méret;
            fej_y += irány_y * KigyoElem.Méret;

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
            kígyó.Add(ke);
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);

            if (lépésSzám % 2 == 0) ke.BackColor = Color.Yellow;

            if (kígyó.Count > hossz)
            {
                KigyoElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
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
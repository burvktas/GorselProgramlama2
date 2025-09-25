using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int üstSaat = 17, üstDakika = 50, üstSaniye = 50, üstSalise = 0;
        int SistemMilisaniye = 0;
        int SistemSaniye = 0;
        int SistemDakika = 0;
        int SistemSaat = 0;
        bool dogruluk = false;

        private void timer2_Tick(object sender, EventArgs e)
        {
            SistemMilisaniye--;

            if (SistemMilisaniye < 0)
            {
                SistemMilisaniye = 99;
                SistemSaniye--;
            }

            if (SistemSaniye < 0)
            {
                SistemSaniye = 59;
                SistemDakika--;
            }

            if (SistemDakika < 0)
            {
                SistemDakika = 59;
                SistemSaat--;
            }

            AltSalise.Text = SistemMilisaniye.ToString();
            AltSaniye.Text = SistemSaniye.ToString();
            AltDakika.Text = SistemDakika.ToString();
            AltSaat.Text = SistemSaat.ToString();

            if (SistemSaat == 0 && SistemDakika == 0 && SistemSaniye == 0 && SistemMilisaniye == 0)
            {
                timer2.Stop();
                MessageBox.Show("Süre doldu!");
                Application.Exit();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dogruluk == false)
            {
                timer1.Start();

                DateTime now = DateTime.Now;

                SistemMilisaniye = now.Millisecond;
                SistemSaniye = now.Second;
                SistemDakika = now.Minute;
                SistemSaat = now.Hour;
                
                SistemMilisaniye = SistemMilisaniye / 10;



            }
            else
            {
                timer2.Start();
            }
                button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ÜstSalise.Text = üstSalise.ToString();
            ÜstSaniye.Text = üstSaniye.ToString();
            ÜstDakika.Text = üstDakika.ToString();
            ÜstSaat.Text =  üstSaat.ToString();
            üstSalise++;
            if (üstSalise == 100)
            {
                üstSaniye++;
                üstSalise = 0;
            }
            if(üstSaniye == 60)
            {
                üstSaniye = 0;
                üstDakika++;
            }
            if(üstDakika == 60)
            {
                üstDakika = 0;
                üstSaat++;
            }
            if (üstSalise == SistemMilisaniye && üstSaniye == SistemSaniye && üstDakika == SistemDakika && üstSaat == SistemSaat)
            {
                button1.Enabled = true;
                timer1.Stop();
                dogruluk = true;

            }
        }
    }
}

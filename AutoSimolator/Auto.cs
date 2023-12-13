using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace AutoSimolator
{
    public class Auto
    {
        string marke;
        int ps;
        int tankFeullstand = 0;
        bool istMotorGestartet = false;
        int aktuelleGeschwindikeit = 0;
        int aktuellerGang = 1;

        public int AktuelleGeschwindikeit
        {
            get { return aktuelleGeschwindikeit; }
        }
        public int AktuellerGang
        {
            get { return aktuellerGang; }
        }
        public int PS
        {
            get { return ps; }
        }
        public bool IstMotorGestartet
        {
            get { return istMotorGestartet; }
        }


        public int TankFeullstand
        {
            get { return tankFeullstand; }
          
       
        }

        public Auto(string Markeinput, int PSinput)
        {
            ps = PSinput;
            marke = Markeinput;
        }
        
        public void auftanken()
        {
            tankFeullstand = 100;
        }

        
        public void SchalteMotorAus()
        {
            istMotorGestartet = false;
            BerechneGang();


        }

        public void SchalteMotorEin()
        {
            if (tankFeullstand > 0)
            {
                istMotorGestartet = true;
            }
            else
            {
                MessageBox.Show("Out of fuel!");
            }
        }

        public void BerechneGang()
        {
            if (aktuelleGeschwindikeit <= 10)
            {
                aktuellerGang = 1;
            }
            else if (aktuelleGeschwindikeit <= 20)
            {
                aktuellerGang = 2;
            }
            else if (aktuelleGeschwindikeit <= 40)
            {
                aktuellerGang = 3;
            }
            else if (aktuelleGeschwindikeit <= 70)
            {
                aktuellerGang = 4;
            }
            else if (aktuelleGeschwindikeit <= 100)
            {
                aktuellerGang = 5;
            }
            else
            {
                aktuellerGang = 6;
            }
        }

        public void GibGas()
        {
            if (aktuelleGeschwindikeit < ps)
            {
                aktuelleGeschwindikeit += 1;
            }

            BerechneGang();

            //zählermachen
            if (tankFeullstand - (aktuellerGang / 5) >= 0 && tankFeullstand-1 >=0)
            {
                if ((aktuellerGang / 2) <= 0)
                {
                    tankFeullstand--;
                }
                else
                {
                    tankFeullstand = tankFeullstand - (aktuellerGang / 2);
                }
            }
            else
            {
                SchalteMotorAus();
                aktuelleGeschwindikeit = 0;
                return;
            }


            int beschleunigung = 2 * aktuellerGang;
            double sleeptime = 100000 / ps / beschleunigung;
            Thread.Sleep(Convert.ToInt32(sleeptime));
        }



        public override string ToString()
        {
            return this.marke;
        }
    }
}

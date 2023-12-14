using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
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
        int zahlerfullstand = 0;

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
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.glas_get_filled_with_water_in_sink_97294);
            simpleSound.Play();
        }

        
        public void SchalteMotorAus()
        {
            istMotorGestartet = false;
            BerechneGang();
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.car_engine_starting_43705);
            simpleSound.Play();


        }

        public void SchalteMotorEin()
        {
            if (tankFeullstand > 0)
            {
                istMotorGestartet = true;
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.carengine_5998);
                simpleSound.Play();

               /* while (IstMotorGestartet == true)
                {
                    Application.DoEvents();
                    Thread.Sleep(8000);
                    SoundPlayer simpleSound2 = new SoundPlayer(@"C:\Users\MarvinHegi\OneDrive - Luzerner IT Solution GmbH\Marvin\Bassislehrjahr\oop\AutoSimolator\Sounds\car-acceleration-inside-car-7087.wav");
                    simpleSound2.Play();
                    
                } */
            }
            else
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.car_engine_starting_43705);
                simpleSound.Play();
                throw new Exception("Out of fuel!");
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
            FuellstandBerechnen();

            

            int beschleunigung = 2 * aktuellerGang;
            double sleeptime = 100000 / ps / beschleunigung;
            Thread.Sleep(Convert.ToInt32(sleeptime));
        }

        public void Bremse()
        {
            if (aktuelleGeschwindikeit > 0)
            {
                aktuelleGeschwindikeit --;
            }

            BerechneGang();
            


            // noch bessere Rechnung
          
            double sleeptime = 100000 / ps / 8;
            Thread.Sleep(Convert.ToInt32(sleeptime));
        }

        public void FuellstandBerechnen()
        {
            if (zahlerfullstand % 10 == 0)
            {
                if (tankFeullstand - (aktuellerGang / 5) >= 0 && tankFeullstand - 1 >= 0)
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
                    SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.crash_1_154890);
                    simpleSound.Play();
                    
                    return;
                }
            }
            zahlerfullstand++;
            if (tankFeullstand < 0)
            {
                tankFeullstand = 0;
            }
        }



        public override string ToString()
        {
            return this.marke;
        }

        public void Hupen()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.car_horn_6408);
            simpleSound.Play();
        }
    }
}

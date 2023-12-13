using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSimolator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Marken = {"Porsche", "Opel", "Ferrari" };
            string[] PS = { "250", "90", "370" };
            for (int i = 0; i < Marken.Length; i++) {
                Auto auto = new Auto(Marken[i], Convert.ToInt32(PS[i]));
                comboBoxAutoWahlen.Items.Add(auto);
            }


        }

        private void comboBoxAutoWahlen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAutoWahlen.SelectedItem != null)
            {
                Auto auto = comboBoxAutoWahlen.SelectedItem as Auto;

                labelAutoPSValue.Text = auto.PS.ToString();
                textBoxKMH.Text = auto.AktuelleGeschwindikeit.ToString();
                progressBarTank.Value = auto.TankFeullstand;
                auto.BerechneGang();
                textBoxGear.Text = auto.AktuellerGang.ToString();
                if (auto.IstMotorGestartet == true)
                {
                    panelMotorAnAus.BackColor = Color.Green;
                }
                else
                {
                    panelMotorAnAus.BackColor = Color.Red;
                }
            }
        }

        private void pictureBoxTank_Click(object sender, EventArgs e)
        {
            if (comboBoxAutoWahlen.SelectedItem != null)
            {
               
                    Auto auto = comboBoxAutoWahlen.SelectedItem as Auto;
                if (auto.IstMotorGestartet != true)
                {
                    if (auto.AktuelleGeschwindikeit <= 0)
                    {
                        auto.auftanken();
                    }
                    else{
                        MessageBox.Show("Stop driving and slow down your car!");
                    }
                }
                else
                {
                    MessageBox.Show("Shut down the engine");
                }
                progressBarTank.Value = auto.TankFeullstand;
            }
            else
            {
                MessageBox.Show("No Car Selected");
            }

        }

        private void pictureBoxSchlussel_Click(object sender, EventArgs e)
        {
            if (comboBoxAutoWahlen.SelectedItem != null)
            {
                Auto auto = comboBoxAutoWahlen.SelectedItem as Auto;
                if (auto.IstMotorGestartet == true)
                {
                    auto.SchalteMotorAus();
                    if (auto.IstMotorGestartet != true)
                    {
                        panelMotorAnAus.BackColor = Color.Red;
                    }
                    textBoxKMH.Text = auto.AktuelleGeschwindikeit.ToString();
                    textBoxGear.Text = auto.AktuellerGang.ToString();
                }
                else
                {
                    auto.SchalteMotorEin();
                    if (auto.IstMotorGestartet == true)
                    {
                        panelMotorAnAus.BackColor = Color.Green;
                    }
                }
            }
            else
            {
                MessageBox.Show("No Car Selected");
            }

        }
        public bool Gasgeben = false;
        private void buttonGas_MouseDown(object sender, MouseEventArgs e)
        {
            if (comboBoxAutoWahlen.SelectedItem != null)
            {
                Auto auto = comboBoxAutoWahlen.SelectedItem as Auto;
                Gasgeben = true;
                if (auto.IstMotorGestartet == true)
                {
                    while (Gasgeben == true)
                    {
                        Application.DoEvents();
                        auto.GibGas();
                        textBoxKMH.Text = auto.AktuelleGeschwindikeit.ToString();
                        textBoxGear.Text = auto.AktuellerGang.ToString();
                        progressBarTank.Value = auto.TankFeullstand;
                        if (auto.IstMotorGestartet != true)
                        {
                            panelMotorAnAus.BackColor = Color.Red;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("start engine");
                }
            }
            else
            {
                MessageBox.Show("No Car Selected");

            }
        }

        private void buttonGas_MouseUp(object sender, MouseEventArgs e)
        {
            Gasgeben = false;
        }


        bool bremsen = false;
        private void buttonBremse_MouseDown(object sender, MouseEventArgs e)
        {
            if (comboBoxAutoWahlen.SelectedItem != null)
            {
                Auto auto = comboBoxAutoWahlen.SelectedItem as Auto;
                bremsen = true;

                while (bremsen == true)
                {
                    Application.DoEvents();
                    auto.Bremse();
                    textBoxKMH.Text = auto.AktuelleGeschwindikeit.ToString();
                    textBoxGear.Text = auto.AktuellerGang.ToString();

                }
            }
            else
            {
                MessageBox.Show("No Car Selected");

            }

        }

        private void buttonBremse_MouseUp(object sender, MouseEventArgs e)
        {
            bremsen = false;
        }
    }
}

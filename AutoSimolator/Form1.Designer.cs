namespace AutoSimolator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAutowahlen = new System.Windows.Forms.Label();
            this.comboBoxAutoWahlen = new System.Windows.Forms.ComboBox();
            this.labelAutoPSValue = new System.Windows.Forms.Label();
            this.labelAutoPS = new System.Windows.Forms.Label();
            this.panelBackgroundTacho = new System.Windows.Forms.Panel();
            this.progressBarTank = new System.Windows.Forms.ProgressBar();
            this.pictureBoxTankKlein = new System.Windows.Forms.PictureBox();
            this.labelgear = new System.Windows.Forms.Label();
            this.labelkmh = new System.Windows.Forms.Label();
            this.textBoxKMH = new System.Windows.Forms.TextBox();
            this.textBoxGear = new System.Windows.Forms.TextBox();
            this.panelMotorAnAus = new System.Windows.Forms.Panel();
            this.buttonGas = new System.Windows.Forms.Button();
            this.buttonBremse = new System.Windows.Forms.Button();
            this.pictureBoxTank = new System.Windows.Forms.PictureBox();
            this.pictureBoxHupe = new System.Windows.Forms.PictureBox();
            this.pictureBoxSchlussel = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelBackgroundTacho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTankKlein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchlussel)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAutowahlen
            // 
            this.labelAutowahlen.AutoSize = true;
            this.labelAutowahlen.Location = new System.Drawing.Point(71, 24);
            this.labelAutowahlen.Name = "labelAutowahlen";
            this.labelAutowahlen.Size = new System.Drawing.Size(79, 16);
            this.labelAutowahlen.TabIndex = 0;
            this.labelAutowahlen.Text = "Auto wählen";
            // 
            // comboBoxAutoWahlen
            // 
            this.comboBoxAutoWahlen.FormattingEnabled = true;
            this.comboBoxAutoWahlen.Location = new System.Drawing.Point(162, 20);
            this.comboBoxAutoWahlen.Name = "comboBoxAutoWahlen";
            this.comboBoxAutoWahlen.Size = new System.Drawing.Size(197, 24);
            this.comboBoxAutoWahlen.TabIndex = 1;
            this.comboBoxAutoWahlen.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutoWahlen_SelectedIndexChanged);
            // 
            // labelAutoPSValue
            // 
            this.labelAutoPSValue.AutoSize = true;
            this.labelAutoPSValue.Location = new System.Drawing.Point(374, 23);
            this.labelAutoPSValue.Name = "labelAutoPSValue";
            this.labelAutoPSValue.Size = new System.Drawing.Size(14, 16);
            this.labelAutoPSValue.TabIndex = 2;
            this.labelAutoPSValue.Text = "0";
            // 
            // labelAutoPS
            // 
            this.labelAutoPS.AutoSize = true;
            this.labelAutoPS.Location = new System.Drawing.Point(400, 24);
            this.labelAutoPS.Name = "labelAutoPS";
            this.labelAutoPS.Size = new System.Drawing.Size(25, 16);
            this.labelAutoPS.TabIndex = 3;
            this.labelAutoPS.Text = "PS";
            // 
            // panelBackgroundTacho
            // 
            this.panelBackgroundTacho.BackColor = System.Drawing.Color.Silver;
            this.panelBackgroundTacho.Controls.Add(this.progressBarTank);
            this.panelBackgroundTacho.Controls.Add(this.pictureBoxTankKlein);
            this.panelBackgroundTacho.Controls.Add(this.labelgear);
            this.panelBackgroundTacho.Controls.Add(this.labelkmh);
            this.panelBackgroundTacho.Controls.Add(this.textBoxKMH);
            this.panelBackgroundTacho.Controls.Add(this.textBoxGear);
            this.panelBackgroundTacho.Location = new System.Drawing.Point(103, 76);
            this.panelBackgroundTacho.Name = "panelBackgroundTacho";
            this.panelBackgroundTacho.Size = new System.Drawing.Size(322, 144);
            this.panelBackgroundTacho.TabIndex = 5;
            // 
            // progressBarTank
            // 
            this.progressBarTank.Location = new System.Drawing.Point(46, 106);
            this.progressBarTank.Name = "progressBarTank";
            this.progressBarTank.Size = new System.Drawing.Size(259, 23);
            this.progressBarTank.TabIndex = 13;
            // 
            // pictureBoxTankKlein
            // 
            this.pictureBoxTankKlein.Image = global::AutoSimolator.Properties.Resources.Tank;
            this.pictureBoxTankKlein.Location = new System.Drawing.Point(17, 106);
            this.pictureBoxTankKlein.Name = "pictureBoxTankKlein";
            this.pictureBoxTankKlein.Size = new System.Drawing.Size(23, 24);
            this.pictureBoxTankKlein.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTankKlein.TabIndex = 13;
            this.pictureBoxTankKlein.TabStop = false;
            // 
            // labelgear
            // 
            this.labelgear.AutoSize = true;
            this.labelgear.Location = new System.Drawing.Point(238, 18);
            this.labelgear.Name = "labelgear";
            this.labelgear.Size = new System.Drawing.Size(37, 16);
            this.labelgear.TabIndex = 11;
            this.labelgear.Text = "Gear";
            // 
            // labelkmh
            // 
            this.labelkmh.AutoSize = true;
            this.labelkmh.Location = new System.Drawing.Point(14, 18);
            this.labelkmh.Name = "labelkmh";
            this.labelkmh.Size = new System.Drawing.Size(36, 16);
            this.labelkmh.TabIndex = 10;
            this.labelkmh.Text = "km/h";
            // 
            // textBoxKMH
            // 
            this.textBoxKMH.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxKMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBoxKMH.ForeColor = System.Drawing.Color.Lime;
            this.textBoxKMH.Location = new System.Drawing.Point(17, 37);
            this.textBoxKMH.Multiline = true;
            this.textBoxKMH.Name = "textBoxKMH";
            this.textBoxKMH.ReadOnly = true;
            this.textBoxKMH.Size = new System.Drawing.Size(207, 54);
            this.textBoxKMH.TabIndex = 8;
            this.textBoxKMH.Text = "0";
            this.textBoxKMH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGear
            // 
            this.textBoxGear.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBoxGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBoxGear.ForeColor = System.Drawing.Color.Cyan;
            this.textBoxGear.Location = new System.Drawing.Point(241, 37);
            this.textBoxGear.Multiline = true;
            this.textBoxGear.Name = "textBoxGear";
            this.textBoxGear.ReadOnly = true;
            this.textBoxGear.Size = new System.Drawing.Size(64, 54);
            this.textBoxGear.TabIndex = 7;
            this.textBoxGear.Text = "1";
            this.textBoxGear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelMotorAnAus
            // 
            this.panelMotorAnAus.BackColor = System.Drawing.Color.Red;
            this.panelMotorAnAus.Location = new System.Drawing.Point(103, 50);
            this.panelMotorAnAus.Name = "panelMotorAnAus";
            this.panelMotorAnAus.Size = new System.Drawing.Size(322, 28);
            this.panelMotorAnAus.TabIndex = 12;
            // 
            // buttonGas
            // 
            this.buttonGas.Location = new System.Drawing.Point(303, 240);
            this.buttonGas.Name = "buttonGas";
            this.buttonGas.Size = new System.Drawing.Size(105, 198);
            this.buttonGas.TabIndex = 0;
            this.buttonGas.Text = "Gas";
            this.buttonGas.UseVisualStyleBackColor = true;
            this.buttonGas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonGas_MouseDown);
            this.buttonGas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonGas_MouseUp);
            // 
            // buttonBremse
            // 
            this.buttonBremse.Location = new System.Drawing.Point(120, 240);
            this.buttonBremse.Name = "buttonBremse";
            this.buttonBremse.Size = new System.Drawing.Size(162, 198);
            this.buttonBremse.TabIndex = 6;
            this.buttonBremse.Text = "Bremse";
            this.buttonBremse.UseVisualStyleBackColor = true;
            this.buttonBremse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBremse_MouseDown);
            this.buttonBremse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonBremse_MouseUp);
            // 
            // pictureBoxTank
            // 
            this.pictureBoxTank.Image = global::AutoSimolator.Properties.Resources.Tank;
            this.pictureBoxTank.Location = new System.Drawing.Point(32, 188);
            this.pictureBoxTank.Name = "pictureBoxTank";
            this.pictureBoxTank.Size = new System.Drawing.Size(54, 50);
            this.pictureBoxTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTank.TabIndex = 9;
            this.pictureBoxTank.TabStop = false;
            this.pictureBoxTank.Click += new System.EventHandler(this.pictureBoxTank_Click);
            // 
            // pictureBoxHupe
            // 
            this.pictureBoxHupe.Image = global::AutoSimolator.Properties.Resources.Hupe;
            this.pictureBoxHupe.Location = new System.Drawing.Point(32, 132);
            this.pictureBoxHupe.Name = "pictureBoxHupe";
            this.pictureBoxHupe.Size = new System.Drawing.Size(54, 50);
            this.pictureBoxHupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHupe.TabIndex = 8;
            this.pictureBoxHupe.TabStop = false;
            // 
            // pictureBoxSchlussel
            // 
            this.pictureBoxSchlussel.Image = global::AutoSimolator.Properties.Resources.Schlussel;
            this.pictureBoxSchlussel.Location = new System.Drawing.Point(32, 76);
            this.pictureBoxSchlussel.Name = "pictureBoxSchlussel";
            this.pictureBoxSchlussel.Size = new System.Drawing.Size(54, 50);
            this.pictureBoxSchlussel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSchlussel.TabIndex = 7;
            this.pictureBoxSchlussel.TabStop = false;
            this.pictureBoxSchlussel.Click += new System.EventHandler(this.pictureBoxSchlussel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMotorAnAus);
            this.Controls.Add(this.pictureBoxTank);
            this.Controls.Add(this.pictureBoxHupe);
            this.Controls.Add(this.pictureBoxSchlussel);
            this.Controls.Add(this.buttonBremse);
            this.Controls.Add(this.buttonGas);
            this.Controls.Add(this.panelBackgroundTacho);
            this.Controls.Add(this.labelAutoPS);
            this.Controls.Add(this.labelAutoPSValue);
            this.Controls.Add(this.comboBoxAutoWahlen);
            this.Controls.Add(this.labelAutowahlen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBackgroundTacho.ResumeLayout(false);
            this.panelBackgroundTacho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTankKlein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchlussel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAutowahlen;
        private System.Windows.Forms.ComboBox comboBoxAutoWahlen;
        private System.Windows.Forms.Label labelAutoPSValue;
        private System.Windows.Forms.Label labelAutoPS;
        private System.Windows.Forms.Panel panelBackgroundTacho;
        private System.Windows.Forms.TextBox textBoxKMH;
        private System.Windows.Forms.TextBox textBoxGear;
        private System.Windows.Forms.Button buttonGas;
        private System.Windows.Forms.Button buttonBremse;
        private System.Windows.Forms.PictureBox pictureBoxSchlussel;
        private System.Windows.Forms.PictureBox pictureBoxHupe;
        private System.Windows.Forms.PictureBox pictureBoxTank;
        private System.Windows.Forms.Label labelkmh;
        private System.Windows.Forms.Label labelgear;
        private System.Windows.Forms.Panel panelMotorAnAus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxTankKlein;
        private System.Windows.Forms.ProgressBar progressBarTank;
    }
}


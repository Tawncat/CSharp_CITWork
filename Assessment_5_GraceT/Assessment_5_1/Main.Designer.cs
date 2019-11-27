namespace Assessment_5_1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnMiles = new System.Windows.Forms.Button();
            this.lblKph = new System.Windows.Forms.Label();
            this.btnFeet = new System.Windows.Forms.Button();
            this.btnMetre = new System.Windows.Forms.Button();
            this.btnKnot = new System.Windows.Forms.Button();
            this.lblConvert = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtHint = new System.Windows.Forms.TextBox();
            this.txtRound = new System.Windows.Forms.TextBox();
            this.lblPlaces = new System.Windows.Forms.Label();
            this.btnMach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInput.Location = new System.Drawing.Point(80, 94);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // btnMiles
            // 
            this.btnMiles.Location = new System.Drawing.Point(35, 148);
            this.btnMiles.Name = "btnMiles";
            this.btnMiles.Size = new System.Drawing.Size(85, 23);
            this.btnMiles.TabIndex = 1;
            this.btnMiles.Text = "Miles (mphr)";
            this.btnMiles.UseVisualStyleBackColor = true;
            this.btnMiles.Click += new System.EventHandler(this.BtnMiles_Click);
            // 
            // lblKph
            // 
            this.lblKph.AutoSize = true;
            this.lblKph.Location = new System.Drawing.Point(186, 97);
            this.lblKph.Name = "lblKph";
            this.lblKph.Size = new System.Drawing.Size(128, 13);
            this.lblKph.TabIndex = 2;
            this.lblKph.Text = "kilometres per hour (k/ph)";
            // 
            // btnFeet
            // 
            this.btnFeet.Location = new System.Drawing.Point(126, 148);
            this.btnFeet.Name = "btnFeet";
            this.btnFeet.Size = new System.Drawing.Size(85, 23);
            this.btnFeet.TabIndex = 3;
            this.btnFeet.Text = "Feet (ft/ph)";
            this.btnFeet.UseVisualStyleBackColor = true;
            this.btnFeet.Click += new System.EventHandler(this.BtnFeet_Click);
            // 
            // btnMetre
            // 
            this.btnMetre.Location = new System.Drawing.Point(217, 148);
            this.btnMetre.Name = "btnMetre";
            this.btnMetre.Size = new System.Drawing.Size(85, 23);
            this.btnMetre.TabIndex = 4;
            this.btnMetre.Text = "Metres (m/ph)";
            this.btnMetre.UseVisualStyleBackColor = true;
            this.btnMetre.Click += new System.EventHandler(this.BtnMetre_Click);
            // 
            // btnKnot
            // 
            this.btnKnot.Location = new System.Drawing.Point(308, 148);
            this.btnKnot.Name = "btnKnot";
            this.btnKnot.Size = new System.Drawing.Size(85, 23);
            this.btnKnot.TabIndex = 5;
            this.btnKnot.Text = "Knots";
            this.btnKnot.UseVisualStyleBackColor = true;
            this.btnKnot.Click += new System.EventHandler(this.BtnKnot_Click);
            // 
            // lblConvert
            // 
            this.lblConvert.AutoSize = true;
            this.lblConvert.Location = new System.Drawing.Point(228, 132);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(63, 13);
            this.lblConvert.TabIndex = 7;
            this.lblConvert.Text = "Convert To:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(161, 194);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 8;
            // 
            // lblAnswer
            // 
            this.lblAnswer.Location = new System.Drawing.Point(267, 194);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(100, 23);
            this.lblAnswer.TabIndex = 9;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(434, 243);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // txtHint
            // 
            this.txtHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHint.Location = new System.Drawing.Point(24, 21);
            this.txtHint.Multiline = true;
            this.txtHint.Name = "txtHint";
            this.txtHint.ReadOnly = true;
            this.txtHint.Size = new System.Drawing.Size(472, 50);
            this.txtHint.TabIndex = 11;
            this.txtHint.Text = "Enter a value in kilometres per hour.  You can also specify how many decimal plac" +
    "es to round to.\r\n\r\nClick a button to convert to that unit.";
            this.txtHint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRound
            // 
            this.txtRound.Location = new System.Drawing.Point(320, 94);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(25, 20);
            this.txtRound.TabIndex = 12;
            this.txtRound.Text = "5";
            // 
            // lblPlaces
            // 
            this.lblPlaces.AutoSize = true;
            this.lblPlaces.Location = new System.Drawing.Point(351, 97);
            this.lblPlaces.Name = "lblPlaces";
            this.lblPlaces.Size = new System.Drawing.Size(80, 13);
            this.lblPlaces.TabIndex = 13;
            this.lblPlaces.Text = "Decimal Places";
            // 
            // btnMach
            // 
            this.btnMach.Location = new System.Drawing.Point(399, 148);
            this.btnMach.Name = "btnMach";
            this.btnMach.Size = new System.Drawing.Size(85, 23);
            this.btnMach.TabIndex = 14;
            this.btnMach.Text = "Sound (mach)";
            this.btnMach.UseVisualStyleBackColor = true;
            this.btnMach.Click += new System.EventHandler(this.BtnMach_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(521, 278);
            this.ControlBox = false;
            this.Controls.Add(this.btnMach);
            this.Controls.Add(this.lblPlaces);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.txtHint);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblConvert);
            this.Controls.Add(this.btnKnot);
            this.Controls.Add(this.btnMetre);
            this.Controls.Add(this.btnFeet);
            this.Controls.Add(this.lblKph);
            this.Controls.Add(this.btnMiles);
            this.Controls.Add(this.txtInput);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assessment 5 DLL - Speed Calculations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnMiles;
        private System.Windows.Forms.Label lblKph;
        private System.Windows.Forms.Button btnFeet;
        private System.Windows.Forms.Button btnMetre;
        private System.Windows.Forms.Button btnKnot;
        private System.Windows.Forms.Label lblConvert;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtHint;
        private System.Windows.Forms.TextBox txtRound;
        private System.Windows.Forms.Label lblPlaces;
        private System.Windows.Forms.Button btnMach;
    }
}


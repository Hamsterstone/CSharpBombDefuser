namespace CSharpBombDefuser
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnWire1 = new System.Windows.Forms.Button();
            this.btnWire2 = new System.Windows.Forms.Button();
            this.btnWire3 = new System.Windows.Forms.Button();
            this.btnWire4 = new System.Windows.Forms.Button();
            this.btnWire5 = new System.Windows.Forms.Button();
            this.btnWire6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCountDown = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.lblLossesNumber = new System.Windows.Forms.Label();
            this.lblWinsNumber = new System.Windows.Forms.Label();
            this.cbxMute = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnWire1
            // 
            this.btnWire1.FlatAppearance.BorderSize = 0;
            this.btnWire1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWire1.Image = ((System.Drawing.Image)(resources.GetObject("btnWire1.Image")));
            this.btnWire1.Location = new System.Drawing.Point(102, 220);
            this.btnWire1.Name = "btnWire1";
            this.btnWire1.Size = new System.Drawing.Size(20, 85);
            this.btnWire1.TabIndex = 0;
            this.btnWire1.UseVisualStyleBackColor = true;
            this.btnWire1.Click += new System.EventHandler(this.AllButtonPress);
            // 
            // btnWire2
            // 
            this.btnWire2.FlatAppearance.BorderSize = 0;
            this.btnWire2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWire2.Image = ((System.Drawing.Image)(resources.GetObject("btnWire2.Image")));
            this.btnWire2.Location = new System.Drawing.Point(131, 220);
            this.btnWire2.Name = "btnWire2";
            this.btnWire2.Size = new System.Drawing.Size(20, 85);
            this.btnWire2.TabIndex = 1;
            this.btnWire2.UseVisualStyleBackColor = true;
            this.btnWire2.Click += new System.EventHandler(this.AllButtonPress);
            // 
            // btnWire3
            // 
            this.btnWire3.FlatAppearance.BorderSize = 0;
            this.btnWire3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWire3.Image = ((System.Drawing.Image)(resources.GetObject("btnWire3.Image")));
            this.btnWire3.Location = new System.Drawing.Point(164, 220);
            this.btnWire3.Name = "btnWire3";
            this.btnWire3.Size = new System.Drawing.Size(20, 85);
            this.btnWire3.TabIndex = 2;
            this.btnWire3.UseVisualStyleBackColor = true;
            this.btnWire3.Click += new System.EventHandler(this.AllButtonPress);
            // 
            // btnWire4
            // 
            this.btnWire4.FlatAppearance.BorderSize = 0;
            this.btnWire4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWire4.Image = ((System.Drawing.Image)(resources.GetObject("btnWire4.Image")));
            this.btnWire4.Location = new System.Drawing.Point(199, 220);
            this.btnWire4.Name = "btnWire4";
            this.btnWire4.Size = new System.Drawing.Size(20, 85);
            this.btnWire4.TabIndex = 3;
            this.btnWire4.UseVisualStyleBackColor = true;
            this.btnWire4.Click += new System.EventHandler(this.AllButtonPress);
            // 
            // btnWire5
            // 
            this.btnWire5.FlatAppearance.BorderSize = 0;
            this.btnWire5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWire5.Image = ((System.Drawing.Image)(resources.GetObject("btnWire5.Image")));
            this.btnWire5.Location = new System.Drawing.Point(230, 220);
            this.btnWire5.Name = "btnWire5";
            this.btnWire5.Size = new System.Drawing.Size(20, 85);
            this.btnWire5.TabIndex = 4;
            this.btnWire5.UseVisualStyleBackColor = true;
            this.btnWire5.Click += new System.EventHandler(this.AllButtonPress);
            // 
            // btnWire6
            // 
            this.btnWire6.FlatAppearance.BorderSize = 0;
            this.btnWire6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWire6.Image = ((System.Drawing.Image)(resources.GetObject("btnWire6.Image")));
            this.btnWire6.Location = new System.Drawing.Point(258, 220);
            this.btnWire6.Name = "btnWire6";
            this.btnWire6.Size = new System.Drawing.Size(20, 85);
            this.btnWire6.TabIndex = 5;
            this.btnWire6.UseVisualStyleBackColor = true;
            this.btnWire6.Click += new System.EventHandler(this.AllButtonPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCountDown
            // 
            this.lblCountDown.BackColor = System.Drawing.Color.Black;
            this.lblCountDown.ForeColor = System.Drawing.Color.Red;
            this.lblCountDown.Location = new System.Drawing.Point(74, 78);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(222, 83);
            this.lblCountDown.TabIndex = 6;
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(12, 319);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(50, 13);
            this.lblWins.TabIndex = 7;
            this.lblWins.Text = "Defused:";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Location = new System.Drawing.Point(12, 348);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(54, 13);
            this.lblLosses.TabIndex = 8;
            this.lblLosses.Text = "Exploded:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 378);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Location = new System.Drawing.Point(243, 378);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(13, 13);
            this.lblTotalNumber.TabIndex = 12;
            this.lblTotalNumber.Text = "0";
            // 
            // lblLossesNumber
            // 
            this.lblLossesNumber.AutoSize = true;
            this.lblLossesNumber.Location = new System.Drawing.Point(243, 348);
            this.lblLossesNumber.Name = "lblLossesNumber";
            this.lblLossesNumber.Size = new System.Drawing.Size(13, 13);
            this.lblLossesNumber.TabIndex = 11;
            this.lblLossesNumber.Text = "0";
            // 
            // lblWinsNumber
            // 
            this.lblWinsNumber.AutoSize = true;
            this.lblWinsNumber.Location = new System.Drawing.Point(243, 319);
            this.lblWinsNumber.Name = "lblWinsNumber";
            this.lblWinsNumber.Size = new System.Drawing.Size(13, 13);
            this.lblWinsNumber.TabIndex = 10;
            this.lblWinsNumber.Text = "0";
            // 
            // cbxMute
            // 
            this.cbxMute.AutoSize = true;
            this.cbxMute.Location = new System.Drawing.Point(347, 319);
            this.cbxMute.Name = "cbxMute";
            this.cbxMute.Size = new System.Drawing.Size(50, 17);
            this.cbxMute.TabIndex = 13;
            this.cbxMute.Text = "Mute";
            this.cbxMute.UseVisualStyleBackColor = true;
            this.cbxMute.CheckedChanged += new System.EventHandler(this.MuteStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSharpBombDefuser.Properties.Resources.BombEdited;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(393, 409);
            this.Controls.Add(this.cbxMute);
            this.Controls.Add(this.lblTotalNumber);
            this.Controls.Add(this.lblLossesNumber);
            this.Controls.Add(this.lblWinsNumber);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.btnWire6);
            this.Controls.Add(this.btnWire5);
            this.Controls.Add(this.btnWire4);
            this.Controls.Add(this.btnWire3);
            this.Controls.Add(this.btnWire2);
            this.Controls.Add(this.btnWire1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Bomb Defuser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWire1;
        private System.Windows.Forms.Button btnWire2;
        private System.Windows.Forms.Button btnWire3;
        private System.Windows.Forms.Button btnWire4;
        private System.Windows.Forms.Button btnWire5;
        private System.Windows.Forms.Button btnWire6;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.Label lblLossesNumber;
        private System.Windows.Forms.Label lblWinsNumber;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbxMute;
    }
}


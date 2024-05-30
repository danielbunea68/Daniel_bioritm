namespace Miruna_Daniel_bioritm
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
			this.button_generare = new System.Windows.Forms.Button();
			this.dateTimePickerN = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerB = new System.Windows.Forms.DateTimePicker();
			this.label_nastere = new System.Windows.Forms.Label();
			this.label_bioritm = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label_zile = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label_nrzile = new System.Windows.Forms.Label();
			this.button_zodie = new System.Windows.Forms.Button();
			this.label_zodie = new System.Windows.Forms.Label();
			this.pictureBox_zodie = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_zodie)).BeginInit();
			this.SuspendLayout();
			// 
			// button_generare
			// 
			this.button_generare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button_generare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_generare.Location = new System.Drawing.Point(535, 54);
			this.button_generare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button_generare.Name = "button_generare";
			this.button_generare.Size = new System.Drawing.Size(152, 47);
			this.button_generare.TabIndex = 0;
			this.button_generare.Text = "Generare Bioritm";
			this.button_generare.UseVisualStyleBackColor = false;
			this.button_generare.Click += new System.EventHandler(this.button_generare_Click);
			// 
			// dateTimePickerN
			// 
			this.dateTimePickerN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerN.Location = new System.Drawing.Point(16, 63);
			this.dateTimePickerN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dateTimePickerN.Name = "dateTimePickerN";
			this.dateTimePickerN.Size = new System.Drawing.Size(151, 23);
			this.dateTimePickerN.TabIndex = 1;
			this.dateTimePickerN.ValueChanged += new System.EventHandler(this.dateTimePickerN_ValueChanged);
			// 
			// dateTimePickerB
			// 
			this.dateTimePickerB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerB.Location = new System.Drawing.Point(232, 63);
			this.dateTimePickerB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dateTimePickerB.Name = "dateTimePickerB";
			this.dateTimePickerB.Size = new System.Drawing.Size(192, 23);
			this.dateTimePickerB.TabIndex = 2;
			this.dateTimePickerB.ValueChanged += new System.EventHandler(this.dateTimePickerB_ValueChanged);
			// 
			// label_nastere
			// 
			this.label_nastere.AutoSize = true;
			this.label_nastere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_nastere.Location = new System.Drawing.Point(16, 28);
			this.label_nastere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_nastere.Name = "label_nastere";
			this.label_nastere.Size = new System.Drawing.Size(120, 25);
			this.label_nastere.TabIndex = 3;
			this.label_nastere.Text = "Data nasterii";
			// 
			// label_bioritm
			// 
			this.label_bioritm.AutoSize = true;
			this.label_bioritm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_bioritm.Location = new System.Drawing.Point(228, 28);
			this.label_bioritm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_bioritm.Name = "label_bioritm";
			this.label_bioritm.Size = new System.Drawing.Size(115, 25);
			this.label_bioritm.TabIndex = 4;
			this.label_bioritm.Text = "Data bioritm";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(492, 501);
			this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.trackBar1.Maximum = 30;
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(557, 56);
			this.trackBar1.TabIndex = 5;
			this.trackBar1.Value = 1;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(4, 108);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1045, 389);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(493, 546);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(313, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Numarul de zile pentru reprezentarea bioritmului";
			// 
			// label_zile
			// 
			this.label_zile.AutoSize = true;
			this.label_zile.Location = new System.Drawing.Point(687, 546);
			this.label_zile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_zile.Name = "label_zile";
			this.label_zile.Size = new System.Drawing.Size(0, 17);
			this.label_zile.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(28, 520);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 29);
			this.label2.TabIndex = 9;
			this.label2.Text = "fizic";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(111, 520);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 29);
			this.label3.TabIndex = 10;
			this.label3.Text = "emotional";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Green;
			this.label4.Location = new System.Drawing.Point(253, 520);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 29);
			this.label4.TabIndex = 11;
			this.label4.Text = "intelectual";
			// 
			// label_nrzile
			// 
			this.label_nrzile.AutoSize = true;
			this.label_nrzile.BackColor = System.Drawing.Color.Fuchsia;
			this.label_nrzile.Location = new System.Drawing.Point(817, 549);
			this.label_nrzile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_nrzile.Name = "label_nrzile";
			this.label_nrzile.Size = new System.Drawing.Size(0, 17);
			this.label_nrzile.TabIndex = 12;
			// 
			// button_zodie
			// 
			this.button_zodie.BackColor = System.Drawing.Color.Red;
			this.button_zodie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_zodie.Location = new System.Drawing.Point(1070, 46);
			this.button_zodie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button_zodie.Name = "button_zodie";
			this.button_zodie.Size = new System.Drawing.Size(152, 55);
			this.button_zodie.TabIndex = 13;
			this.button_zodie.Text = "Afla zodia";
			this.button_zodie.UseVisualStyleBackColor = false;
			this.button_zodie.Click += new System.EventHandler(this.button_zodie_Click);
			// 
			// label_zodie
			// 
			this.label_zodie.AutoSize = true;
			this.label_zodie.BackColor = System.Drawing.Color.Lime;
			this.label_zodie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_zodie.Location = new System.Drawing.Point(1081, 168);
			this.label_zodie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_zodie.Name = "label_zodie";
			this.label_zodie.Size = new System.Drawing.Size(61, 25);
			this.label_zodie.TabIndex = 14;
			this.label_zodie.Text = "Zodia";
			// 
			// pictureBox_zodie
			// 
			this.pictureBox_zodie.Location = new System.Drawing.Point(1057, 259);
			this.pictureBox_zodie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureBox_zodie.Name = "pictureBox_zodie";
			this.pictureBox_zodie.Size = new System.Drawing.Size(311, 238);
			this.pictureBox_zodie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_zodie.TabIndex = 15;
			this.pictureBox_zodie.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.pictureBox_zodie);
			this.Controls.Add(this.label_zodie);
			this.Controls.Add(this.button_zodie);
			this.Controls.Add(this.label_nrzile);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label_zile);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.label_bioritm);
			this.Controls.Add(this.label_nastere);
			this.Controls.Add(this.dateTimePickerB);
			this.Controls.Add(this.dateTimePickerN);
			this.Controls.Add(this.button_generare);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_zodie)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_generare;
        private System.Windows.Forms.DateTimePicker dateTimePickerN;
        private System.Windows.Forms.DateTimePicker dateTimePickerB;
        private System.Windows.Forms.Label label_nastere;
        private System.Windows.Forms.Label label_bioritm;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_zile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_nrzile;
        private System.Windows.Forms.Button button_zodie;
        private System.Windows.Forms.Label label_zodie;
        private System.Windows.Forms.PictureBox pictureBox_zodie;
    }
}


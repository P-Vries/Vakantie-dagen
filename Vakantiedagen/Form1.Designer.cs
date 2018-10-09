namespace Vakantiedagen
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
            this.rdbAfdeling1 = new System.Windows.Forms.RadioButton();
            this.rdbAfdeling2 = new System.Windows.Forms.RadioButton();
            this.rdbAfdeling3 = new System.Windows.Forms.RadioButton();
            this.rdbAfdelingO = new System.Windows.Forms.RadioButton();
            this.dtpGeboorteDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbAfdeling1
            // 
            this.rdbAfdeling1.AutoSize = true;
            this.rdbAfdeling1.Location = new System.Drawing.Point(12, 12);
            this.rdbAfdeling1.Name = "rdbAfdeling1";
            this.rdbAfdeling1.Size = new System.Drawing.Size(72, 17);
            this.rdbAfdeling1.TabIndex = 0;
            this.rdbAfdeling1.Text = "Afdeling 1";
            this.rdbAfdeling1.UseVisualStyleBackColor = true;
            // 
            // rdbAfdeling2
            // 
            this.rdbAfdeling2.AutoSize = true;
            this.rdbAfdeling2.Location = new System.Drawing.Point(12, 35);
            this.rdbAfdeling2.Name = "rdbAfdeling2";
            this.rdbAfdeling2.Size = new System.Drawing.Size(72, 17);
            this.rdbAfdeling2.TabIndex = 1;
            this.rdbAfdeling2.Text = "Afdeling 2";
            this.rdbAfdeling2.UseVisualStyleBackColor = true;
            // 
            // rdbAfdeling3
            // 
            this.rdbAfdeling3.AutoSize = true;
            this.rdbAfdeling3.Location = new System.Drawing.Point(12, 58);
            this.rdbAfdeling3.Name = "rdbAfdeling3";
            this.rdbAfdeling3.Size = new System.Drawing.Size(72, 17);
            this.rdbAfdeling3.TabIndex = 2;
            this.rdbAfdeling3.Text = "Afdeling 3";
            this.rdbAfdeling3.UseVisualStyleBackColor = true;
            // 
            // rdbAfdelingO
            // 
            this.rdbAfdelingO.AutoSize = true;
            this.rdbAfdelingO.Checked = true;
            this.rdbAfdelingO.Location = new System.Drawing.Point(12, 81);
            this.rdbAfdelingO.Name = "rdbAfdelingO";
            this.rdbAfdelingO.Size = new System.Drawing.Size(56, 17);
            this.rdbAfdelingO.TabIndex = 3;
            this.rdbAfdelingO.TabStop = true;
            this.rdbAfdelingO.Text = "Overig";
            this.rdbAfdelingO.UseVisualStyleBackColor = true;
            // 
            // dtpGeboorteDatum
            // 
            this.dtpGeboorteDatum.Location = new System.Drawing.Point(205, 10);
            this.dtpGeboorteDatum.Name = "dtpGeboorteDatum";
            this.dtpGeboorteDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpGeboorteDatum.TabIndex = 4;
            // 
            // dtpBeginDatum
            // 
            this.dtpBeginDatum.Location = new System.Drawing.Point(205, 48);
            this.dtpBeginDatum.Name = "dtpBeginDatum";
            this.dtpBeginDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpBeginDatum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aantal dagen waar recht op is: ";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(263, 102);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 13);
            this.lblOut.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Geboorte datum: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Begin datum: ";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(9, 102);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 10;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 137);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBeginDatum);
            this.Controls.Add(this.dtpGeboorteDatum);
            this.Controls.Add(this.rdbAfdelingO);
            this.Controls.Add(this.rdbAfdeling3);
            this.Controls.Add(this.rdbAfdeling2);
            this.Controls.Add(this.rdbAfdeling1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbAfdeling1;
        private System.Windows.Forms.RadioButton rdbAfdeling2;
        private System.Windows.Forms.RadioButton rdbAfdeling3;
        private System.Windows.Forms.RadioButton rdbAfdelingO;
        private System.Windows.Forms.DateTimePicker dtpGeboorteDatum;
        private System.Windows.Forms.DateTimePicker dtpBeginDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBereken;
    }
}


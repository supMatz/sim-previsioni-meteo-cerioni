namespace Meteo_Cerioni
{
    partial class FrmGiornataDetails
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
            this.btOK = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblStat1 = new System.Windows.Forms.Label();
            this.lblStat2 = new System.Windows.Forms.Label();
            this.lblStat3 = new System.Windows.Forms.Label();
            this.lblStat4 = new System.Windows.Forms.Label();
            this.lblStat5 = new System.Windows.Forms.Label();
            this.lblStat6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvDatiOrari = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.Location = new System.Drawing.Point(531, 673);
            this.btOK.Margin = new System.Windows.Forms.Padding(4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(79, 55);
            this.btOK.TabIndex = 7;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(13, 20);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(200, 25);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Dettagli giornata :";
            // 
            // lblStat1
            // 
            this.lblStat1.AutoSize = true;
            this.lblStat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat1.Location = new System.Drawing.Point(44, 497);
            this.lblStat1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat1.Name = "lblStat1";
            this.lblStat1.Size = new System.Drawing.Size(151, 20);
            this.lblStat1.TabIndex = 8;
            this.lblStat1.Text = "Variazioni termiche :";
            // 
            // lblStat2
            // 
            this.lblStat2.AutoSize = true;
            this.lblStat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat2.Location = new System.Drawing.Point(44, 532);
            this.lblStat2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat2.Name = "lblStat2";
            this.lblStat2.Size = new System.Drawing.Size(199, 20);
            this.lblStat2.TabIndex = 9;
            this.lblStat2.Text = "Temperature sotto lo zero :";
            // 
            // lblStat3
            // 
            this.lblStat3.AutoSize = true;
            this.lblStat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat3.Location = new System.Drawing.Point(44, 563);
            this.lblStat3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat3.Name = "lblStat3";
            this.lblStat3.Size = new System.Drawing.Size(240, 20);
            this.lblStat3.TabIndex = 10;
            this.lblStat3.Text = "Superamenti media precedente :";
            // 
            // lblStat4
            // 
            this.lblStat4.AutoSize = true;
            this.lblStat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat4.Location = new System.Drawing.Point(44, 596);
            this.lblStat4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat4.Name = "lblStat4";
            this.lblStat4.Size = new System.Drawing.Size(195, 20);
            this.lblStat4.TabIndex = 11;
            this.lblStat4.Text = "Umidità media giornaliera :";
            // 
            // lblStat5
            // 
            this.lblStat5.AutoSize = true;
            this.lblStat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat5.Location = new System.Drawing.Point(44, 628);
            this.lblStat5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat5.Name = "lblStat5";
            this.lblStat5.Size = new System.Drawing.Size(230, 20);
            this.lblStat5.TabIndex = 12;
            this.lblStat5.Text = "Direzione prevalente del vento :";
            // 
            // lblStat6
            // 
            this.lblStat6.AutoSize = true;
            this.lblStat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat6.Location = new System.Drawing.Point(44, 659);
            this.lblStat6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat6.Name = "lblStat6";
            this.lblStat6.Size = new System.Drawing.Size(188, 20);
            this.lblStat6.TabIndex = 13;
            this.lblStat6.Text = "Previsione prossime 12h :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 454);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Statistiche giornaliere :";
            // 
            // lvDatiOrari
            // 
            this.lvDatiOrari.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lvDatiOrari.HideSelection = false;
            this.lvDatiOrari.Location = new System.Drawing.Point(12, 68);
            this.lvDatiOrari.Name = "lvDatiOrari";
            this.lvDatiOrari.Size = new System.Drawing.Size(595, 359);
            this.lvDatiOrari.TabIndex = 15;
            this.lvDatiOrari.UseCompatibleStateImageBehavior = false;
            // 
            // FrmGiornataDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(623, 741);
            this.Controls.Add(this.lvDatiOrari);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblStat6);
            this.Controls.Add(this.lblStat5);
            this.Controls.Add(this.lblStat4);
            this.Controls.Add(this.lblStat3);
            this.Controls.Add(this.lblStat2);
            this.Controls.Add(this.lblStat1);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lblData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGiornataDetails";
            this.Text = "GiornataDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblStat1;
        private System.Windows.Forms.Label lblStat2;
        private System.Windows.Forms.Label lblStat3;
        private System.Windows.Forms.Label lblStat4;
        private System.Windows.Forms.Label lblStat5;
        private System.Windows.Forms.Label lblStat6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvDatiOrari;
    }
}
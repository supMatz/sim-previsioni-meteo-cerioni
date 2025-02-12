namespace Meteo_Cerioni
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblData = new System.Windows.Forms.Label();
            this.lvGiorni = new System.Windows.Forms.ListView();
            this.chGiorno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTemperatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCondizioni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPrevisioni = new System.Windows.Forms.Panel();
            this.btPulisci = new System.Windows.Forms.Button();
            this.btStatistiche = new System.Windows.Forms.Button();
            this.dtpDataInizio = new System.Windows.Forms.DateTimePicker();
            this.btGeneraPrevisioni = new System.Windows.Forms.Button();
            this.chPrecipitazioni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUmiditàMedia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPrevisioni.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(16, 36);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(149, 20);
            this.lblData.TabIndex = 0;
            this.lblData.Text = " Inizio previsioni da :";
            // 
            // lvGiorni
            // 
            this.lvGiorni.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lvGiorni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGiorno,
            this.chTemperatura,
            this.chCondizioni,
            this.chPrecipitazioni,
            this.chUmiditàMedia,
            this.chVento});
            this.lvGiorni.FullRowSelect = true;
            this.lvGiorni.HideSelection = false;
            this.lvGiorni.Location = new System.Drawing.Point(17, 21);
            this.lvGiorni.Margin = new System.Windows.Forms.Padding(4);
            this.lvGiorni.Name = "lvGiorni";
            this.lvGiorni.Size = new System.Drawing.Size(709, 511);
            this.lvGiorni.TabIndex = 1;
            this.lvGiorni.UseCompatibleStateImageBehavior = false;
            this.lvGiorni.View = System.Windows.Forms.View.Details;
            // 
            // chGiorno
            // 
            this.chGiorno.Text = "Giorno";
            this.chGiorno.Width = 115;
            // 
            // chTemperatura
            // 
            this.chTemperatura.Text = "Temperatura";
            this.chTemperatura.Width = 105;
            // 
            // chCondizioni
            // 
            this.chCondizioni.Text = "Condizioni";
            this.chCondizioni.Width = 134;
            // 
            // pnlPrevisioni
            // 
            this.pnlPrevisioni.Controls.Add(this.btPulisci);
            this.pnlPrevisioni.Controls.Add(this.btStatistiche);
            this.pnlPrevisioni.Controls.Add(this.lvGiorni);
            this.pnlPrevisioni.Enabled = false;
            this.pnlPrevisioni.Location = new System.Drawing.Point(16, 86);
            this.pnlPrevisioni.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPrevisioni.Name = "pnlPrevisioni";
            this.pnlPrevisioni.Size = new System.Drawing.Size(925, 549);
            this.pnlPrevisioni.TabIndex = 2;
            // 
            // btPulisci
            // 
            this.btPulisci.Location = new System.Drawing.Point(766, 100);
            this.btPulisci.Margin = new System.Windows.Forms.Padding(4);
            this.btPulisci.Name = "btPulisci";
            this.btPulisci.Size = new System.Drawing.Size(127, 42);
            this.btPulisci.TabIndex = 6;
            this.btPulisci.Text = "Pulisci";
            this.btPulisci.UseVisualStyleBackColor = true;
            this.btPulisci.Click += new System.EventHandler(this.btPulisci_Click);
            // 
            // btStatistiche
            // 
            this.btStatistiche.Location = new System.Drawing.Point(766, 50);
            this.btStatistiche.Margin = new System.Windows.Forms.Padding(4);
            this.btStatistiche.Name = "btStatistiche";
            this.btStatistiche.Size = new System.Drawing.Size(127, 42);
            this.btStatistiche.TabIndex = 5;
            this.btStatistiche.Text = "Statistiche Giornata\r\n";
            this.btStatistiche.UseVisualStyleBackColor = true;
            this.btStatistiche.Click += new System.EventHandler(this.btStatistiche_Click);
            // 
            // dtpDataInizio
            // 
            this.dtpDataInizio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInizio.Location = new System.Drawing.Point(173, 36);
            this.dtpDataInizio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataInizio.Name = "dtpDataInizio";
            this.dtpDataInizio.Size = new System.Drawing.Size(265, 22);
            this.dtpDataInizio.TabIndex = 3;
            // 
            // btGeneraPrevisioni
            // 
            this.btGeneraPrevisioni.Location = new System.Drawing.Point(450, 33);
            this.btGeneraPrevisioni.Margin = new System.Windows.Forms.Padding(4);
            this.btGeneraPrevisioni.Name = "btGeneraPrevisioni";
            this.btGeneraPrevisioni.Size = new System.Drawing.Size(157, 28);
            this.btGeneraPrevisioni.TabIndex = 4;
            this.btGeneraPrevisioni.Text = "Genera Previsioni";
            this.btGeneraPrevisioni.UseVisualStyleBackColor = true;
            this.btGeneraPrevisioni.Click += new System.EventHandler(this.btGeneraPrevisioni_Click);
            // 
            // chPrecipitazioni
            // 
            this.chPrecipitazioni.Text = "Precipitazioni";
            this.chPrecipitazioni.Width = 126;
            // 
            // chUmiditàMedia
            // 
            this.chUmiditàMedia.Text = "Umidità Media";
            this.chUmiditàMedia.Width = 131;
            // 
            // chVento
            // 
            this.chVento.Text = "Vento";
            this.chVento.Width = 93;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(943, 648);
            this.Controls.Add(this.btGeneraPrevisioni);
            this.Controls.Add(this.dtpDataInizio);
            this.Controls.Add(this.pnlPrevisioni);
            this.Controls.Add(this.lblData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Previsioni Meteo";
            this.pnlPrevisioni.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ListView lvGiorni;
        private System.Windows.Forms.Panel pnlPrevisioni;
        private System.Windows.Forms.DateTimePicker dtpDataInizio;
        private System.Windows.Forms.Button btGeneraPrevisioni;
        private System.Windows.Forms.ColumnHeader chGiorno;
        private System.Windows.Forms.ColumnHeader chTemperatura;
        private System.Windows.Forms.Button btPulisci;
        private System.Windows.Forms.Button btStatistiche;
        private System.Windows.Forms.ColumnHeader chCondizioni;
        private System.Windows.Forms.ColumnHeader chPrecipitazioni;
        private System.Windows.Forms.ColumnHeader chUmiditàMedia;
        private System.Windows.Forms.ColumnHeader chVento;
    }
}


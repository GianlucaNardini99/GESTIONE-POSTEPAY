
namespace GESTIONE_POSTEPAY
{
    partial class MainPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.listViewClients = new System.Windows.Forms.ListView();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEuro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxMovement = new System.Windows.Forms.GroupBox();
            this.chartMovement = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btnBalance = new System.Windows.Forms.Button();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxMovement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovement)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.listViewClients);
            this.groupBoxClient.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxClient.Location = new System.Drawing.Point(27, 24);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(439, 283);
            this.groupBoxClient.TabIndex = 0;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Clienti";
            // 
            // listViewClients
            // 
            this.listViewClients.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewClients.BackColor = System.Drawing.SystemColors.Info;
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cSurname,
            this.cNumber,
            this.cEuro});
            this.listViewClients.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewClients.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listViewClients.FullRowSelect = true;
            this.listViewClients.GridLines = true;
            this.listViewClients.HideSelection = false;
            this.listViewClients.Location = new System.Drawing.Point(21, 28);
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(398, 241);
            this.listViewClients.TabIndex = 0;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            this.listViewClients.ItemActivate += new System.EventHandler(this.listViewClients_ItemActivate);
            // 
            // cName
            // 
            this.cName.Text = "Nome";
            this.cName.Width = 85;
            // 
            // cSurname
            // 
            this.cSurname.Text = "Cognome";
            this.cSurname.Width = 100;
            // 
            // cNumber
            // 
            this.cNumber.Text = "Numero Carta";
            this.cNumber.Width = 122;
            // 
            // cEuro
            // 
            this.cEuro.Text = "Euro";
            this.cEuro.Width = 83;
            // 
            // groupBoxMovement
            // 
            this.groupBoxMovement.Controls.Add(this.chartMovement);
            this.groupBoxMovement.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F);
            this.groupBoxMovement.Location = new System.Drawing.Point(479, 24);
            this.groupBoxMovement.Name = "groupBoxMovement";
            this.groupBoxMovement.Size = new System.Drawing.Size(379, 283);
            this.groupBoxMovement.TabIndex = 1;
            this.groupBoxMovement.TabStop = false;
            this.groupBoxMovement.Text = "Movimenti";
            // 
            // chartMovement
            // 
            this.chartMovement.BackColor = System.Drawing.SystemColors.Info;
            chartArea2.Name = "ChartArea1";
            this.chartMovement.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.ShadowColor = System.Drawing.Color.Black;
            this.chartMovement.Legends.Add(legend2);
            this.chartMovement.Location = new System.Drawing.Point(11, 28);
            this.chartMovement.Name = "chartMovement";
            this.chartMovement.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "€";
            series2.ShadowColor = System.Drawing.Color.Black;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartMovement.Series.Add(series2);
            this.chartMovement.Size = new System.Drawing.Size(358, 241);
            this.chartMovement.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Info;
            this.btnNew.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F);
            this.btnNew.Location = new System.Drawing.Point(36, 365);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 59);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "➕";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.Info;
            this.btnModify.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F);
            this.btnModify.Location = new System.Drawing.Point(211, 365);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(97, 59);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "✏️";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancel.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F);
            this.btnCancel.Location = new System.Drawing.Point(392, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 59);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "🗑️";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.SystemColors.Info;
            this.btnClient.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F);
            this.btnClient.Location = new System.Drawing.Point(567, 365);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(97, 59);
            this.btnClient.TabIndex = 5;
            this.btnClient.Text = "👤";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 333);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(137, 15);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Inserire Cliente";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(177, 333);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(161, 15);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Modificare Cliente";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(370, 333);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(152, 15);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "Eliminare Cliente ";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(555, 333);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(130, 15);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "Pagina Cliente ";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(723, 333);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(125, 15);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "Inserire Saldo";
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.SystemColors.Info;
            this.btnBalance.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F);
            this.btnBalance.Location = new System.Drawing.Point(739, 365);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(97, 59);
            this.btnBalance.TabIndex = 11;
            this.btnBalance.Text = "💶";
            this.btnBalance.UseVisualStyleBackColor = false;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBoxMovement);
            this.Controls.Add(this.groupBoxClient);
            this.Name = "MainPage";
            this.Text = "GESTORE CLIENTI";
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxMovement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMovement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.GroupBox groupBoxMovement;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMovement;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cSurname;
        private System.Windows.Forms.ColumnHeader cNumber;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.ColumnHeader cEuro;
    }
}


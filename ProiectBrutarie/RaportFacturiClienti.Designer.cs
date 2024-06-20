
namespace ProiectBrutarie
{
    partial class RaportFacturiClienti
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaportFacturiClienti));
            this.Facturi_clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza_brutarie1DataSet = new ProiectBrutarie.baza_brutarie1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Facturi_clientiTableAdapter = new ProiectBrutarie.baza_brutarie1DataSetTableAdapters.Facturi_clientiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Facturi_clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_brutarie1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Facturi_clientiBindingSource
            // 
            this.Facturi_clientiBindingSource.DataMember = "Facturi_clienti";
            this.Facturi_clientiBindingSource.DataSource = this.baza_brutarie1DataSet;
            // 
            // baza_brutarie1DataSet
            // 
            this.baza_brutarie1DataSet.DataSetName = "baza_brutarie1DataSet";
            this.baza_brutarie1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Facturi_clientiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProiectBrutarie.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(871, 485);
            this.reportViewer1.TabIndex = 0;
            // 
            // Facturi_clientiTableAdapter
            // 
            this.Facturi_clientiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(677, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Înapoi la meniu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RaportFacturiClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(908, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaportFacturiClienti";
            this.Text = "RaportFacturiClienti";
            this.Load += new System.EventHandler(this.RaportFacturiClienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Facturi_clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_brutarie1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Facturi_clientiBindingSource;
        private baza_brutarie1DataSet baza_brutarie1DataSet;
        private baza_brutarie1DataSetTableAdapters.Facturi_clientiTableAdapter Facturi_clientiTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}
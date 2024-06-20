
namespace ProiectBrutarie
{
    partial class RaportCmzAproviz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaportCmzAproviz));
            this.Comenzi_furnizoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza_brutarie1DataSet = new ProiectBrutarie.baza_brutarie1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comenzi_furnizoriTableAdapter1 = new ProiectBrutarie.baza_brutarie1DataSetTableAdapters.Comenzi_furnizoriTableAdapter();
            this.Comenzi_furnizoriTableAdapter = new ProiectBrutarie.baza_brutarie1DataSetTableAdapters.Comenzi_furnizoriTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.bazabrutarie1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Comenzi_furnizoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_brutarie1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazabrutarie1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Comenzi_furnizoriBindingSource
            // 
            this.Comenzi_furnizoriBindingSource.DataMember = "Comenzi_furnizori";
            this.Comenzi_furnizoriBindingSource.DataSource = this.baza_brutarie1DataSet;
            // 
            // baza_brutarie1DataSet
            // 
            this.baza_brutarie1DataSet.DataSetName = "baza_brutarie1DataSet";
            this.baza_brutarie1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.Comenzi_furnizoriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProiectBrutarie.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(28, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 432);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // comenzi_furnizoriTableAdapter1
            // 
            this.comenzi_furnizoriTableAdapter1.ClearBeforeFill = true;
            // 
            // Comenzi_furnizoriTableAdapter
            // 
            this.Comenzi_furnizoriTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(618, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Inapoi la meniu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bazabrutarie1DataSetBindingSource
            // 
            this.bazabrutarie1DataSetBindingSource.DataSource = this.baza_brutarie1DataSet;
            this.bazabrutarie1DataSetBindingSource.Position = 0;
            // 
            // RaportCmzAproviz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaportCmzAproviz";
            this.Text = "RaportCmzAproviz";
            this.Load += new System.EventHandler(this.RaportCmzAproviz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Comenzi_furnizoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_brutarie1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazabrutarie1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private baza_brutarie1DataSetTableAdapters.Comenzi_furnizoriTableAdapter comenzi_furnizoriTableAdapter1;
        private System.Windows.Forms.BindingSource Comenzi_furnizoriBindingSource;
        private baza_brutarie1DataSet baza_brutarie1DataSet;
        private baza_brutarie1DataSetTableAdapters.Comenzi_furnizoriTableAdapter Comenzi_furnizoriTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bazabrutarie1DataSetBindingSource;
    }
}
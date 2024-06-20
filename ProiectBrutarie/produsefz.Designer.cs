
namespace ProiectBrutarie
{
    partial class produsefz
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
            System.Windows.Forms.Label cod_produsLabel;
            System.Windows.Forms.Label nume_produsLabel;
            System.Windows.Forms.Label uMLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produsefz));
            this.baza_brutarie1DataSet = new ProiectBrutarie.baza_brutarie1DataSet();
            this.produsefurnizoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produse_furnizoriTableAdapter = new ProiectBrutarie.baza_brutarie1DataSetTableAdapters.Produse_furnizoriTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new ProiectBrutarie.baza_brutarie1DataSetTableAdapters.TableAdapterManager();
            this.cod_produsTextBox = new System.Windows.Forms.TextBox();
            this.nume_produsTextBox = new System.Windows.Forms.TextBox();
            this.uMTextBox = new System.Windows.Forms.TextBox();
            this.produse_furnizoriDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cod_produsLabel = new System.Windows.Forms.Label();
            nume_produsLabel = new System.Windows.Forms.Label();
            uMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza_brutarie1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsefurnizoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produse_furnizoriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // baza_brutarie1DataSet
            // 
            this.baza_brutarie1DataSet.DataSetName = "baza_brutarie1DataSet";
            this.baza_brutarie1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produsefurnizoriBindingSource
            // 
            this.produsefurnizoriBindingSource.DataMember = "Produse_furnizori";
            this.produsefurnizoriBindingSource.DataSource = this.baza_brutarie1DataSet;
            // 
            // produse_furnizoriTableAdapter
            // 
            this.produse_furnizoriTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Revenire la meniu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientiTableAdapter = null;
            this.tableAdapterManager.Comenzi_furnizoriTableAdapter = null;
            this.tableAdapterManager.Compozitie_produseTableAdapter = null;
            this.tableAdapterManager.Facturi_clientiTableAdapter = null;
            this.tableAdapterManager.FurnizoriTableAdapter = null;
            this.tableAdapterManager.JudetTableAdapter = null;
            this.tableAdapterManager.OraseTableAdapter = null;
            this.tableAdapterManager.Produse_furnizoriTableAdapter = this.produse_furnizoriTableAdapter;
            this.tableAdapterManager.ProduseTableAdapter = null;
            this.tableAdapterManager.ReteteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProiectBrutarie.baza_brutarie1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VânzăriTableAdapter = null;
            // 
            // cod_produsLabel
            // 
            cod_produsLabel.AutoSize = true;
            cod_produsLabel.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_produsLabel.Location = new System.Drawing.Point(63, 70);
            cod_produsLabel.Name = "cod_produsLabel";
            cod_produsLabel.Size = new System.Drawing.Size(127, 23);
            cod_produsLabel.TabIndex = 7;
            cod_produsLabel.Text = "Cod produs:";
            // 
            // cod_produsTextBox
            // 
            this.cod_produsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsefurnizoriBindingSource, "Cod_produs", true));
            this.cod_produsTextBox.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_produsTextBox.Location = new System.Drawing.Point(223, 64);
            this.cod_produsTextBox.Name = "cod_produsTextBox";
            this.cod_produsTextBox.Size = new System.Drawing.Size(100, 29);
            this.cod_produsTextBox.TabIndex = 8;
            // 
            // nume_produsLabel
            // 
            nume_produsLabel.AutoSize = true;
            nume_produsLabel.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nume_produsLabel.Location = new System.Drawing.Point(51, 115);
            nume_produsLabel.Name = "nume_produsLabel";
            nume_produsLabel.Size = new System.Drawing.Size(147, 23);
            nume_produsLabel.TabIndex = 8;
            nume_produsLabel.Text = "Nume produs:";
            // 
            // nume_produsTextBox
            // 
            this.nume_produsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsefurnizoriBindingSource, "Nume_produs", true));
            this.nume_produsTextBox.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume_produsTextBox.Location = new System.Drawing.Point(223, 109);
            this.nume_produsTextBox.Name = "nume_produsTextBox";
            this.nume_produsTextBox.Size = new System.Drawing.Size(100, 29);
            this.nume_produsTextBox.TabIndex = 9;
            // 
            // uMLabel
            // 
            uMLabel.AutoSize = true;
            uMLabel.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uMLabel.Location = new System.Drawing.Point(341, 73);
            uMLabel.Name = "uMLabel";
            uMLabel.Size = new System.Drawing.Size(51, 23);
            uMLabel.TabIndex = 9;
            uMLabel.Text = "UM:";
            // 
            // uMTextBox
            // 
            this.uMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsefurnizoriBindingSource, "UM", true));
            this.uMTextBox.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uMTextBox.Location = new System.Drawing.Point(430, 67);
            this.uMTextBox.Name = "uMTextBox";
            this.uMTextBox.Size = new System.Drawing.Size(100, 29);
            this.uMTextBox.TabIndex = 10;
            // 
            // produse_furnizoriDataGridView
            // 
            this.produse_furnizoriDataGridView.AutoGenerateColumns = false;
            this.produse_furnizoriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produse_furnizoriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.produse_furnizoriDataGridView.DataSource = this.produsefurnizoriBindingSource;
            this.produse_furnizoriDataGridView.Location = new System.Drawing.Point(22, 195);
            this.produse_furnizoriDataGridView.Name = "produse_furnizoriDataGridView";
            this.produse_furnizoriDataGridView.RowHeadersWidth = 51;
            this.produse_furnizoriDataGridView.RowTemplate.Height = 24;
            this.produse_furnizoriDataGridView.Size = new System.Drawing.Size(508, 257);
            this.produse_furnizoriDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_produs";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod_produs";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume_produs";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume_produs";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UM";
            this.dataGridViewTextBoxColumn3.HeaderText = "UM";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // produsefz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 464);
            this.Controls.Add(this.produse_furnizoriDataGridView);
            this.Controls.Add(uMLabel);
            this.Controls.Add(this.uMTextBox);
            this.Controls.Add(nume_produsLabel);
            this.Controls.Add(this.nume_produsTextBox);
            this.Controls.Add(cod_produsLabel);
            this.Controls.Add(this.cod_produsTextBox);
            this.Controls.Add(this.button1);
            this.Name = "produsefz";
            this.Text = "produsefz";
            this.Load += new System.EventHandler(this.produsefz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza_brutarie1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsefurnizoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produse_furnizoriDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private baza_brutarie1DataSet baza_brutarie1DataSet;
        private System.Windows.Forms.BindingSource produsefurnizoriBindingSource;
        private baza_brutarie1DataSetTableAdapters.Produse_furnizoriTableAdapter produse_furnizoriTableAdapter;
        private System.Windows.Forms.Button button1;
        private baza_brutarie1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cod_produsTextBox;
        private System.Windows.Forms.TextBox nume_produsTextBox;
        private System.Windows.Forms.TextBox uMTextBox;
        private System.Windows.Forms.DataGridView produse_furnizoriDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
namespace cexolimpiada2015
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dBTimpSpatiuDataSet = new cexolimpiada2015.DBTimpSpatiuDataSet();
            this.croaziereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.croaziereTableAdapter = new cexolimpiada2015.DBTimpSpatiuDataSetTableAdapters.CroaziereTableAdapter();
            this.iDCroazieraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipCroazieraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaPorturiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPasageriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTimpSpatiuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.croaziereBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCroazieraDataGridViewTextBoxColumn,
            this.tipCroazieraDataGridViewTextBoxColumn,
            this.listaPorturiDataGridViewTextBoxColumn,
            this.dataStartDataGridViewTextBoxColumn,
            this.dataFinalDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.nrPasageriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.croaziereBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "3 Zile",
            "5 Zile",
            "7 Zile"});
            this.listBox1.Location = new System.Drawing.Point(12, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(114, 17);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inchidere";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dBTimpSpatiuDataSet
            // 
            this.dBTimpSpatiuDataSet.DataSetName = "DBTimpSpatiuDataSet";
            this.dBTimpSpatiuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // croaziereBindingSource
            // 
            this.croaziereBindingSource.DataMember = "Croaziere";
            this.croaziereBindingSource.DataSource = this.dBTimpSpatiuDataSet;
            // 
            // croaziereTableAdapter
            // 
            this.croaziereTableAdapter.ClearBeforeFill = true;
            // 
            // iDCroazieraDataGridViewTextBoxColumn
            // 
            this.iDCroazieraDataGridViewTextBoxColumn.DataPropertyName = "ID_Croaziera";
            this.iDCroazieraDataGridViewTextBoxColumn.HeaderText = "ID_Croaziera";
            this.iDCroazieraDataGridViewTextBoxColumn.Name = "iDCroazieraDataGridViewTextBoxColumn";
            this.iDCroazieraDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCroazieraDataGridViewTextBoxColumn.Width = 20;
            // 
            // tipCroazieraDataGridViewTextBoxColumn
            // 
            this.tipCroazieraDataGridViewTextBoxColumn.DataPropertyName = "Tip_Croaziera";
            this.tipCroazieraDataGridViewTextBoxColumn.HeaderText = "Tip_Croaziera";
            this.tipCroazieraDataGridViewTextBoxColumn.Name = "tipCroazieraDataGridViewTextBoxColumn";
            // 
            // listaPorturiDataGridViewTextBoxColumn
            // 
            this.listaPorturiDataGridViewTextBoxColumn.DataPropertyName = "Lista_Porturi";
            this.listaPorturiDataGridViewTextBoxColumn.HeaderText = "Lista_Porturi";
            this.listaPorturiDataGridViewTextBoxColumn.Name = "listaPorturiDataGridViewTextBoxColumn";
            // 
            // dataStartDataGridViewTextBoxColumn
            // 
            this.dataStartDataGridViewTextBoxColumn.DataPropertyName = "Data_Start";
            this.dataStartDataGridViewTextBoxColumn.HeaderText = "Data_Start";
            this.dataStartDataGridViewTextBoxColumn.Name = "dataStartDataGridViewTextBoxColumn";
            // 
            // dataFinalDataGridViewTextBoxColumn
            // 
            this.dataFinalDataGridViewTextBoxColumn.DataPropertyName = "Data_Final";
            this.dataFinalDataGridViewTextBoxColumn.HeaderText = "Data_Final";
            this.dataFinalDataGridViewTextBoxColumn.Name = "dataFinalDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // nrPasageriDataGridViewTextBoxColumn
            // 
            this.nrPasageriDataGridViewTextBoxColumn.DataPropertyName = "Nr_Pasageri";
            this.nrPasageriDataGridViewTextBoxColumn.HeaderText = "Nr_Pasageri";
            this.nrPasageriDataGridViewTextBoxColumn.Name = "nrPasageriDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTimpSpatiuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.croaziereBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private DBTimpSpatiuDataSet dBTimpSpatiuDataSet;
        private System.Windows.Forms.BindingSource croaziereBindingSource;
        private DBTimpSpatiuDataSetTableAdapters.CroaziereTableAdapter croaziereTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCroazieraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipCroazieraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listaPorturiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPasageriDataGridViewTextBoxColumn;
    }
}
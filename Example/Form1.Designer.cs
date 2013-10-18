namespace Example
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new System.Data.DataSet();
            this.CustomerTable = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.custIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCellPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIdDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.custBirthDateDataGridViewTextBoxColumn,
            this.custCellPhoneDataGridViewTextBoxColumn,
            this.custPhoneDataGridViewTextBoxColumn,
            this.custAddrDataGridViewTextBoxColumn,
            this.custZipDataGridViewTextBoxColumn,
            this.custCityDataGridViewTextBoxColumn,
            this.custStateDataGridViewTextBoxColumn});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dataSet1, "Customer.CustName", true));
            this.dataGridView1.DataMember = "Customer";
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.CustomerTable});
            // 
            // CustomerTable
            // 
            this.CustomerTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9});
            this.CustomerTable.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "CustId"}, true)});
            this.CustomerTable.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn1};
            this.CustomerTable.TableName = "Customer";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.Caption = "Código";
            this.dataColumn1.ColumnName = "CustId";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.AllowDBNull = false;
            this.dataColumn2.Caption = "Nome";
            this.dataColumn2.ColumnName = "CustName";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Nascimento";
            this.dataColumn3.ColumnName = "CustBirthDate";
            this.dataColumn3.DataType = typeof(System.DateTime);
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Celular";
            this.dataColumn4.ColumnName = "CustCellPhone";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Tel.Residencial";
            this.dataColumn5.ColumnName = "CustPhone";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Endereço";
            this.dataColumn6.ColumnName = "CustAddr";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "CEP";
            this.dataColumn7.ColumnName = "CustZip";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "Município";
            this.dataColumn8.ColumnName = "CustCity";
            // 
            // dataColumn9
            // 
            this.dataColumn9.Caption = "UF";
            this.dataColumn9.ColumnName = "CustState";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sincronizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // custIdDataGridViewTextBoxColumn
            // 
            this.custIdDataGridViewTextBoxColumn.DataPropertyName = "CustId";
            this.custIdDataGridViewTextBoxColumn.Frozen = true;
            this.custIdDataGridViewTextBoxColumn.HeaderText = "Cód";
            this.custIdDataGridViewTextBoxColumn.Name = "custIdDataGridViewTextBoxColumn";
            this.custIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "CustName";
            this.custNameDataGridViewTextBoxColumn.Frozen = true;
            this.custNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            this.custNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custBirthDateDataGridViewTextBoxColumn
            // 
            this.custBirthDateDataGridViewTextBoxColumn.DataPropertyName = "CustBirthDate";
            this.custBirthDateDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.custBirthDateDataGridViewTextBoxColumn.Name = "custBirthDateDataGridViewTextBoxColumn";
            // 
            // custCellPhoneDataGridViewTextBoxColumn
            // 
            this.custCellPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustCellPhone";
            this.custCellPhoneDataGridViewTextBoxColumn.HeaderText = "Tel.Celular";
            this.custCellPhoneDataGridViewTextBoxColumn.Name = "custCellPhoneDataGridViewTextBoxColumn";
            // 
            // custPhoneDataGridViewTextBoxColumn
            // 
            this.custPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustPhone";
            this.custPhoneDataGridViewTextBoxColumn.HeaderText = "Tel.Residencial";
            this.custPhoneDataGridViewTextBoxColumn.Name = "custPhoneDataGridViewTextBoxColumn";
            // 
            // custAddrDataGridViewTextBoxColumn
            // 
            this.custAddrDataGridViewTextBoxColumn.DataPropertyName = "CustAddr";
            this.custAddrDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.custAddrDataGridViewTextBoxColumn.Name = "custAddrDataGridViewTextBoxColumn";
            // 
            // custZipDataGridViewTextBoxColumn
            // 
            this.custZipDataGridViewTextBoxColumn.DataPropertyName = "CustZip";
            this.custZipDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.custZipDataGridViewTextBoxColumn.Name = "custZipDataGridViewTextBoxColumn";
            // 
            // custCityDataGridViewTextBoxColumn
            // 
            this.custCityDataGridViewTextBoxColumn.DataPropertyName = "CustCity";
            this.custCityDataGridViewTextBoxColumn.HeaderText = "Municipio";
            this.custCityDataGridViewTextBoxColumn.Name = "custCityDataGridViewTextBoxColumn";
            // 
            // custStateDataGridViewTextBoxColumn
            // 
            this.custStateDataGridViewTextBoxColumn.DataPropertyName = "CustState";
            this.custStateDataGridViewTextBoxColumn.HeaderText = "UF";
            this.custStateDataGridViewTextBoxColumn.Name = "custStateDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Clientes XYZ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable CustomerTable;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCellPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custZipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custStateDataGridViewTextBoxColumn;
    }
}


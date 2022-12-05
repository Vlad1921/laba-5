namespace laba_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.laba4DataSet = new laba_5.laba4DataSet();
            this.abonentsPKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonents_PKTableAdapter = new laba_5.laba4DataSetTableAdapters.abonents_PKTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.adminsPKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admins_PKTableAdapter = new laba_5.laba4DataSetTableAdapters.Admins_PKTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privelegiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new laba_5.laba4DataSetTableAdapters.UsersTableAdapter();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laba4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsPKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsPKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.abonentDataGridViewTextBoxColumn,
            this.lCDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.abonentsPKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(213, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // laba4DataSet
            // 
            this.laba4DataSet.DataSetName = "laba4DataSet";
            this.laba4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abonentsPKBindingSource
            // 
            this.abonentsPKBindingSource.DataMember = "abonents PK";
            this.abonentsPKBindingSource.DataSource = this.laba4DataSet;
            // 
            // abonents_PKTableAdapter
            // 
            this.abonents_PKTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // abonentDataGridViewTextBoxColumn
            // 
            this.abonentDataGridViewTextBoxColumn.DataPropertyName = "Abonent";
            this.abonentDataGridViewTextBoxColumn.HeaderText = "Abonent";
            this.abonentDataGridViewTextBoxColumn.Name = "abonentDataGridViewTextBoxColumn";
            // 
            // lCDataGridViewTextBoxColumn
            // 
            this.lCDataGridViewTextBoxColumn.DataPropertyName = "LC";
            this.lCDataGridViewTextBoxColumn.HeaderText = "LC";
            this.lCDataGridViewTextBoxColumn.Name = "lCDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.privelegiiDataGridViewTextBoxColumn,
            this.idusersDataGridViewTextBoxColumn,
            this.idadminDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.adminsPKBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(74, 194);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(857, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // adminsPKBindingSource
            // 
            this.adminsPKBindingSource.DataMember = "Admins PK";
            this.adminsPKBindingSource.DataSource = this.laba4DataSet;
            // 
            // admins_PKTableAdapter
            // 
            this.admins_PKTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "e-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // privelegiiDataGridViewTextBoxColumn
            // 
            this.privelegiiDataGridViewTextBoxColumn.DataPropertyName = "privelegii";
            this.privelegiiDataGridViewTextBoxColumn.HeaderText = "privelegii";
            this.privelegiiDataGridViewTextBoxColumn.Name = "privelegiiDataGridViewTextBoxColumn";
            // 
            // idusersDataGridViewTextBoxColumn
            // 
            this.idusersDataGridViewTextBoxColumn.DataPropertyName = "id_users";
            this.idusersDataGridViewTextBoxColumn.HeaderText = "id_users";
            this.idusersDataGridViewTextBoxColumn.Name = "idusersDataGridViewTextBoxColumn";
            // 
            // idadminDataGridViewTextBoxColumn
            // 
            this.idadminDataGridViewTextBoxColumn.DataPropertyName = "id_admin";
            this.idadminDataGridViewTextBoxColumn.HeaderText = "id_admin";
            this.idadminDataGridViewTextBoxColumn.Name = "idadminDataGridViewTextBoxColumn";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.loginDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.usersBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(280, 365);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(455, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.laba4DataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // loginDataGridViewTextBoxColumn1
            // 
            this.loginDataGridViewTextBoxColumn1.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn1.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn1.Name = "loginDataGridViewTextBoxColumn1";
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn1.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "e-mail";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "e-mail";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 563);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laba4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsPKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsPKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private laba4DataSet laba4DataSet;
        private System.Windows.Forms.BindingSource abonentsPKBindingSource;
        private laba4DataSetTableAdapters.abonents_PKTableAdapter abonents_PKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource adminsPKBindingSource;
        private laba4DataSetTableAdapters.Admins_PKTableAdapter admins_PKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn privelegiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private laba4DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
    }
}


namespace Hackathon2_5
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tickNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flyingDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database1TableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Hackathon2_5.Database1DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.database1DataSet = new Hackathon2_5.Database1DataSet();
            this.database1TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1TableTableAdapter = new Hackathon2_5.Database1DataSetTableAdapters.Database1TableTableAdapter();
            this.database1TableTableAdapter1 = new Hackathon2_5.Database1DataSet1TableAdapters.Database1TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1TableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tickNumberDataGridViewTextBoxColumn,
            this.flyingDayDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.database1TableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 594);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tickNumberDataGridViewTextBoxColumn
            // 
            this.tickNumberDataGridViewTextBoxColumn.DataPropertyName = "TickNumber";
            this.tickNumberDataGridViewTextBoxColumn.HeaderText = "TickNumber";
            this.tickNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tickNumberDataGridViewTextBoxColumn.Name = "tickNumberDataGridViewTextBoxColumn";
            this.tickNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // flyingDayDataGridViewTextBoxColumn
            // 
            this.flyingDayDataGridViewTextBoxColumn.DataPropertyName = "FlyingDay";
            this.flyingDayDataGridViewTextBoxColumn.HeaderText = "FlyingDay";
            this.flyingDayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.flyingDayDataGridViewTextBoxColumn.Name = "flyingDayDataGridViewTextBoxColumn";
            this.flyingDayDataGridViewTextBoxColumn.Width = 150;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 150;
            // 
            // database1TableBindingSource1
            // 
            this.database1TableBindingSource1.DataMember = "Database1Table";
            this.database1TableBindingSource1.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1093, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 93);
            this.button1.TabIndex = 1;
            this.button1.Text = "看資料";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1TableBindingSource
            // 
            this.database1TableBindingSource.DataMember = "Database1Table";
            this.database1TableBindingSource.DataSource = this.database1DataSet;
            // 
            // database1TableTableAdapter
            // 
            this.database1TableTableAdapter.ClearBeforeFill = true;
            // 
            // database1TableTableAdapter1
            // 
            this.database1TableTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1TableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1TableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource database1TableBindingSource;
        private Database1DataSetTableAdapters.Database1TableTableAdapter database1TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flyingDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource database1TableBindingSource1;
        private Database1DataSet1TableAdapters.Database1TableTableAdapter database1TableTableAdapter1;
    }
}
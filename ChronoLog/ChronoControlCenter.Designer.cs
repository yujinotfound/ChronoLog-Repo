namespace ChronoLog
{
    partial class ChronoControlCenter
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
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chronoLogDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chronoLogDBDataSet1 = new ChronoLog.ChronoLogDBDataSet1();
            this.chronoLogDBTableAdapter = new ChronoLog.ChronoLogDBDataSet1TableAdapters.ChronoLogDBTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronoLogDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronoLogDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.timeStartDataGridViewTextBoxColumn,
            this.timeEndDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chronoLogDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(227, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(708, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeStartDataGridViewTextBoxColumn
            // 
            this.timeStartDataGridViewTextBoxColumn.DataPropertyName = "Time Start";
            this.timeStartDataGridViewTextBoxColumn.HeaderText = "Time Start";
            this.timeStartDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeStartDataGridViewTextBoxColumn.Name = "timeStartDataGridViewTextBoxColumn";
            this.timeStartDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeEndDataGridViewTextBoxColumn
            // 
            this.timeEndDataGridViewTextBoxColumn.DataPropertyName = "Time End";
            this.timeEndDataGridViewTextBoxColumn.HeaderText = "Time End";
            this.timeEndDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeEndDataGridViewTextBoxColumn.Name = "timeEndDataGridViewTextBoxColumn";
            this.timeEndDataGridViewTextBoxColumn.Width = 150;
            // 
            // chronoLogDBBindingSource
            // 
            this.chronoLogDBBindingSource.DataMember = "ChronoLogDB";
            this.chronoLogDBBindingSource.DataSource = this.chronoLogDBDataSet1;
            // 
            // chronoLogDBDataSet1
            // 
            this.chronoLogDBDataSet1.DataSetName = "ChronoLogDBDataSet1";
            this.chronoLogDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chronoLogDBTableAdapter
            // 
            this.chronoLogDBTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(16, 141);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(193, 26);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChronoControlCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ChronoControlCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChronoControlCenter";
            this.Load += new System.EventHandler(this.ChronoControlCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronoLogDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronoLogDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ChronoLogDBDataSet1 chronoLogDBDataSet1;
        private System.Windows.Forms.BindingSource chronoLogDBBindingSource;
        private ChronoLogDBDataSet1TableAdapters.ChronoLogDBTableAdapter chronoLogDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchBox;
    }
}
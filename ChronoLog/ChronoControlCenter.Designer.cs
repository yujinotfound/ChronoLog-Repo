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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChronoControlCenter));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chronoLogDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chronoLogDBDataSet1 = new ChronoLog.ChronoLogDBDataSet1();
            this.chronoLogDBTableAdapter = new ChronoLog.ChronoLogDBDataSet1TableAdapters.ChronoLogDBTableAdapter();
            this.logInButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chronologLogo = new System.Windows.Forms.PictureBox();
            this.logoName = new System.Windows.Forms.Label();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronoLogDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronoLogDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronologLogo)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(273, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(453, 516);
            this.dataGridView1.TabIndex = 0;
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
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logInButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(48, 385);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(166, 35);
            this.logInButton.TabIndex = 7;
            this.logInButton.Text = "Delete";
            this.logInButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(48, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 26);
            this.textBox1.TabIndex = 10;
            // 
            // chronologLogo
            // 
            this.chronologLogo.BackColor = System.Drawing.Color.Transparent;
            this.chronologLogo.Image = ((System.Drawing.Image)(resources.GetObject("chronologLogo.Image")));
            this.chronologLogo.Location = new System.Drawing.Point(-6, 1);
            this.chronologLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chronologLogo.Name = "chronologLogo";
            this.chronologLogo.Size = new System.Drawing.Size(287, 195);
            this.chronologLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chronologLogo.TabIndex = 11;
            this.chronologLogo.TabStop = false;
            // 
            // logoName
            // 
            this.logoName.AutoSize = true;
            this.logoName.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoName.Location = new System.Drawing.Point(77, 163);
            this.logoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(109, 21);
            this.logoName.TabIndex = 12;
            this.logoName.Text = "ChronoLog";
            this.logoName.Click += new System.EventHandler(this.logoName_Click);
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
            // ChronoControlCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 498);
            this.Controls.Add(this.logoName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chronologLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChronoControlCenter";
            this.Text = "AdMain";
            this.Load += new System.EventHandler(this.AdMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronoLogDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronoLogDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronologLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ChronoLogDBDataSet1 chronoLogDBDataSet1;
        private System.Windows.Forms.BindingSource chronoLogDBBindingSource;
        private ChronoLogDBDataSet1TableAdapters.ChronoLogDBTableAdapter chronoLogDBTableAdapter;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox chronologLogo;
        private System.Windows.Forms.Label logoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeEndDataGridViewTextBoxColumn;
    }
}
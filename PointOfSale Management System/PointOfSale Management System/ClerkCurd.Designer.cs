namespace PointOfSale_Management_System
{
    partial class ClerkCurd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1ADDclerk = new MetroFramework.Controls.MetroTile();
            this.metroTile2Update = new MetroFramework.Controls.MetroTile();
            this.metroTile3delete = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroTile4Refresh = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroTile5Back = new MetroFramework.Controls.MetroTile();
            this.pointOfSellDataSet = new PointOfSale_Management_System.PointOfSellDataSet();
            this.clerkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clerkTableAdapter = new PointOfSale_Management_System.PointOfSellDataSetTableAdapters.ClerkTableAdapter();
            this.clerkIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clerkNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.clerkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointOfSellDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clerkBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clerkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.metroTile3delete);
            this.metroPanel1.Controls.Add(this.metroTile2Update);
            this.metroPanel1.Controls.Add(this.metroTile1ADDclerk);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(156, 333);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile1ADDclerk
            // 
            this.metroTile1ADDclerk.ActiveControl = null;
            this.metroTile1ADDclerk.Location = new System.Drawing.Point(11, 16);
            this.metroTile1ADDclerk.Name = "metroTile1ADDclerk";
            this.metroTile1ADDclerk.Size = new System.Drawing.Size(128, 65);
            this.metroTile1ADDclerk.TabIndex = 2;
            this.metroTile1ADDclerk.Text = "ADD";
            this.metroTile1ADDclerk.UseSelectable = true;
            this.metroTile1ADDclerk.Click += new System.EventHandler(this.metroTile1ADDclerk_Click);
            // 
            // metroTile2Update
            // 
            this.metroTile2Update.ActiveControl = null;
            this.metroTile2Update.Location = new System.Drawing.Point(11, 98);
            this.metroTile2Update.Name = "metroTile2Update";
            this.metroTile2Update.Size = new System.Drawing.Size(128, 65);
            this.metroTile2Update.TabIndex = 3;
            this.metroTile2Update.Text = "Update";
            this.metroTile2Update.UseSelectable = true;
            this.metroTile2Update.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3delete
            // 
            this.metroTile3delete.ActiveControl = null;
            this.metroTile3delete.Location = new System.Drawing.Point(11, 178);
            this.metroTile3delete.Name = "metroTile3delete";
            this.metroTile3delete.Size = new System.Drawing.Size(128, 65);
            this.metroTile3delete.TabIndex = 4;
            this.metroTile3delete.Text = "Delete";
            this.metroTile3delete.UseSelectable = true;
            this.metroTile3delete.Click += new System.EventHandler(this.metroTile3delete_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroTile4Refresh);
            this.metroPanel2.Controls.Add(this.metroGrid1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(174, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(516, 333);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clerkIDDataGridViewTextBoxColumn,
            this.clerkNameDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.joinDateDataGridViewTextBoxColumn,
            this.DeptID});
            this.metroGrid1.DataSource = this.clerkBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(13, 16);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(483, 259);
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroTile5Back);
            this.metroPanel3.Controls.Add(this.textBox1);
            this.metroPanel3.Controls.Add(this.label1);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(174, 9);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(446, 48);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroTile4Refresh
            // 
            this.metroTile4Refresh.ActiveControl = null;
            this.metroTile4Refresh.Location = new System.Drawing.Point(381, 281);
            this.metroTile4Refresh.Name = "metroTile4Refresh";
            this.metroTile4Refresh.Size = new System.Drawing.Size(115, 49);
            this.metroTile4Refresh.TabIndex = 3;
            this.metroTile4Refresh.Text = "Refresh";
            this.metroTile4Refresh.UseSelectable = true;
            this.metroTile4Refresh.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // metroTile5Back
            // 
            this.metroTile5Back.ActiveControl = null;
            this.metroTile5Back.Location = new System.Drawing.Point(298, 3);
            this.metroTile5Back.Name = "metroTile5Back";
            this.metroTile5Back.Size = new System.Drawing.Size(136, 45);
            this.metroTile5Back.TabIndex = 4;
            this.metroTile5Back.Text = "Back";
            this.metroTile5Back.UseSelectable = true;
            this.metroTile5Back.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // pointOfSellDataSet
            // 
            this.pointOfSellDataSet.DataSetName = "PointOfSellDataSet";
            this.pointOfSellDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clerkBindingSource1
            // 
            this.clerkBindingSource1.DataMember = "Clerk";
            this.clerkBindingSource1.DataSource = this.pointOfSellDataSet;
            // 
            // clerkTableAdapter
            // 
            this.clerkTableAdapter.ClearBeforeFill = true;
            // 
            // clerkIDDataGridViewTextBoxColumn
            // 
            this.clerkIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.clerkIDDataGridViewTextBoxColumn.DataPropertyName = "ClerkID";
            this.clerkIDDataGridViewTextBoxColumn.HeaderText = "ClerkID";
            this.clerkIDDataGridViewTextBoxColumn.Name = "clerkIDDataGridViewTextBoxColumn";
            this.clerkIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clerkIDDataGridViewTextBoxColumn.Width = 5;
            // 
            // clerkNameDataGridViewTextBoxColumn
            // 
            this.clerkNameDataGridViewTextBoxColumn.DataPropertyName = "ClerkName";
            this.clerkNameDataGridViewTextBoxColumn.HeaderText = "ClerkName";
            this.clerkNameDataGridViewTextBoxColumn.Name = "clerkNameDataGridViewTextBoxColumn";
            this.clerkNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "Manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "Manager";
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            this.managerDataGridViewTextBoxColumn.ReadOnly = true;
            this.managerDataGridViewTextBoxColumn.Width = 76;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // joinDateDataGridViewTextBoxColumn
            // 
            this.joinDateDataGridViewTextBoxColumn.DataPropertyName = "JoinDate";
            this.joinDateDataGridViewTextBoxColumn.HeaderText = "JoinDate";
            this.joinDateDataGridViewTextBoxColumn.Name = "joinDateDataGridViewTextBoxColumn";
            this.joinDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DeptID
            // 
            this.DeptID.DataPropertyName = "DeptID";
            this.DeptID.HeaderText = "DeptID";
            this.DeptID.Name = "DeptID";
            this.DeptID.ReadOnly = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(11, 262);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(128, 68);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "View";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // clerkBindingSource
            // 
            this.clerkBindingSource.DataSource = typeof(DATAs.Clerk);
            // 
            // ClerkCurd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ClerkCurd";
            this.Text = "ClerkCurd";
            this.Load += new System.EventHandler(this.ClerkCurd_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointOfSellDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clerkBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clerkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile3delete;
        private MetroFramework.Controls.MetroTile metroTile2Update;
        private MetroFramework.Controls.MetroTile metroTile1ADDclerk;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile metroTile4Refresh;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTile metroTile5Back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource clerkBindingSource;
        private PointOfSellDataSet pointOfSellDataSet;
        private System.Windows.Forms.BindingSource clerkBindingSource1;
        private PointOfSellDataSetTableAdapters.ClerkTableAdapter clerkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clerkIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clerkNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptID;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}
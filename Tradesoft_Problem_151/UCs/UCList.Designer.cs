namespace Tradesoft_Problem_151.UCs
{
    partial class UCList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.gpbNoteManagement = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gpbList = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProducerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalogVendorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalogProducer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reliance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gpbNoteManagement.SuspendLayout();
            this.gpbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.Location = new System.Drawing.Point(14, 23);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(59, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gpbNoteManagement
            // 
            this.gpbNoteManagement.Controls.Add(this.btnRefresh);
            this.gpbNoteManagement.Controls.Add(this.btnRemove);
            this.gpbNoteManagement.Controls.Add(this.btnUpdate);
            this.gpbNoteManagement.Controls.Add(this.btnCreate);
            this.gpbNoteManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbNoteManagement.Location = new System.Drawing.Point(0, 0);
            this.gpbNoteManagement.Name = "gpbNoteManagement";
            this.gpbNoteManagement.Size = new System.Drawing.Size(285, 60);
            this.gpbNoteManagement.TabIndex = 0;
            this.gpbNoteManagement.TabStop = false;
            this.gpbNoteManagement.Text = "Управление записями";
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Location = new System.Drawing.Point(153, 23);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Location = new System.Drawing.Point(79, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(68, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gpbList
            // 
            this.gpbList.Controls.Add(this.dgv);
            this.gpbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbList.Location = new System.Drawing.Point(0, 60);
            this.gpbList.Name = "gpbList";
            this.gpbList.Size = new System.Drawing.Size(285, 90);
            this.gpbList.TabIndex = 0;
            this.gpbList.TabStop = false;
            this.gpbList.Text = "Список";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Index,
            this.ProducerName,
            this.VendorCode,
            this.Producer,
            this.AnalogVendorCode,
            this.AnalogProducer,
            this.Reliance});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 16);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(279, 71);
            this.dgv.TabIndex = 5;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Index.DataPropertyName = "Index";
            this.Index.HeaderText = "#";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 39;
            // 
            // ProducerName
            // 
            this.ProducerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProducerName.DataPropertyName = "Name";
            this.ProducerName.HeaderText = "Название";
            this.ProducerName.Name = "ProducerName";
            this.ProducerName.ReadOnly = true;
            this.ProducerName.Visible = false;
            // 
            // VendorCode
            // 
            this.VendorCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VendorCode.DataPropertyName = "VendorCode";
            this.VendorCode.HeaderText = "Артикул";
            this.VendorCode.Name = "VendorCode";
            this.VendorCode.ReadOnly = true;
            this.VendorCode.Width = 73;
            // 
            // Producer
            // 
            this.Producer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Producer.DataPropertyName = "Producer";
            this.Producer.HeaderText = "Производитель";
            this.Producer.Name = "Producer";
            this.Producer.ReadOnly = true;
            this.Producer.Width = 111;
            // 
            // AnalogVendorCode
            // 
            this.AnalogVendorCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AnalogVendorCode.DataPropertyName = "AnalogVendorCode";
            this.AnalogVendorCode.HeaderText = "Артикул аналога";
            this.AnalogVendorCode.Name = "AnalogVendorCode";
            this.AnalogVendorCode.ReadOnly = true;
            this.AnalogVendorCode.Width = 117;
            // 
            // AnalogProducer
            // 
            this.AnalogProducer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AnalogProducer.DataPropertyName = "AnalogProducer";
            this.AnalogProducer.HeaderText = "Производитель аналога";
            this.AnalogProducer.Name = "AnalogProducer";
            this.AnalogProducer.ReadOnly = true;
            this.AnalogProducer.Width = 155;
            // 
            // Reliance
            // 
            this.Reliance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Reliance.DataPropertyName = "Reliance";
            this.Reliance.HeaderText = "Доверие";
            this.Reliance.Name = "Reliance";
            this.Reliance.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Location = new System.Drawing.Point(219, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UCList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbList);
            this.Controls.Add(this.gpbNoteManagement);
            this.Name = "UCList";
            this.Size = new System.Drawing.Size(285, 150);
            this.gpbNoteManagement.ResumeLayout(false);
            this.gpbNoteManagement.PerformLayout();
            this.gpbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox gpbNoteManagement;
        private System.Windows.Forms.GroupBox gpbList;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProducerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalogVendorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalogProducer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reliance;
        private System.Windows.Forms.Button btnRefresh;
    }
}

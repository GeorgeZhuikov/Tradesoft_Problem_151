namespace Tradesoft_Problem_151.UCs
{
    partial class UCCreateUpdateGoods
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.txbVendorCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProducers = new System.Windows.Forms.ComboBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.AutoSize = true;
            this.btnAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(111, 209);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(59, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Создать";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txbVendorCode
            // 
            this.txbVendorCode.Location = new System.Drawing.Point(111, 7);
            this.txbVendorCode.Name = "txbVendorCode";
            this.txbVendorCode.Size = new System.Drawing.Size(178, 20);
            this.txbVendorCode.TabIndex = 0;
            this.txbVendorCode.TextChanged += new System.EventHandler(this.txbVendorCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Артикул: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Производитель: ";
            // 
            // cmbProducers
            // 
            this.cmbProducers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProducers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducers.DisplayMember = "Name";
            this.cmbProducers.FormattingEnabled = true;
            this.cmbProducers.Location = new System.Drawing.Point(111, 42);
            this.cmbProducers.Name = "cmbProducers";
            this.cmbProducers.Size = new System.Drawing.Size(178, 21);
            this.cmbProducers.TabIndex = 1;
            this.cmbProducers.ValueMember = "ID";
            this.cmbProducers.TextChanged += new System.EventHandler(this.cmbProducers_TextChanged);
            // 
            // pnl
            // 
            this.pnl.AutoSize = true;
            this.pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl.Location = new System.Drawing.Point(0, 78);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(0, 0);
            this.pnl.TabIndex = 6;
            // 
            // UCCreateUpdateGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.cmbProducers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txbVendorCode);
            this.Controls.Add(this.label1);
            this.Name = "UCCreateUpdateGoods";
            this.Size = new System.Drawing.Size(300, 235);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txbVendorCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProducers;
        private System.Windows.Forms.Panel pnl;
    }
}

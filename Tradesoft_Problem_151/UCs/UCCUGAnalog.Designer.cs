namespace Tradesoft_Problem_151.UCs
{
    partial class UCCUGAnalog
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
            this.cmbAnalog = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.chbReliance = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbAnalog
            // 
            this.cmbAnalog.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAnalog.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAnalog.DisplayMember = "VendorCode";
            this.cmbAnalog.FormattingEnabled = true;
            this.cmbAnalog.Location = new System.Drawing.Point(69, 8);
            this.cmbAnalog.Name = "cmbAnalog";
            this.cmbAnalog.Size = new System.Drawing.Size(178, 21);
            this.cmbAnalog.TabIndex = 0;
            this.cmbAnalog.ValueMember = "ID";
            this.cmbAnalog.SelectedValueChanged += new System.EventHandler(this.cmbAnalog_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Аналог: ";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.ForeColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(253, 7);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(23, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // chbReliance
            // 
            this.chbReliance.AutoSize = true;
            this.chbReliance.Checked = true;
            this.chbReliance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbReliance.Location = new System.Drawing.Point(69, 40);
            this.chbReliance.Name = "chbReliance";
            this.chbReliance.Size = new System.Drawing.Size(71, 17);
            this.chbReliance.TabIndex = 1;
            this.chbReliance.Text = "Доверие";
            this.chbReliance.UseVisualStyleBackColor = true;
            this.chbReliance.CheckedChanged += new System.EventHandler(this.chbReliance_CheckedChanged);
            // 
            // UCCUGAnalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbReliance);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cmbAnalog);
            this.Controls.Add(this.label2);
            this.Name = "UCCUGAnalog";
            this.Size = new System.Drawing.Size(300, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnalog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox chbReliance;
    }
}

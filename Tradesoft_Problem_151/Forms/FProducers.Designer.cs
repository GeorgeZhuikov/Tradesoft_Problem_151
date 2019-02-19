namespace Tradesoft_Problem_151.Forms
{
    partial class FProducers
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
            this.ucList = new Tradesoft_Problem_151.UCs.UCList();
            this.SuspendLayout();
            // 
            // ucList1
            // 
            this.ucList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucList.Location = new System.Drawing.Point(0, 0);
            this.ucList.Name = "ucList1";
            this.ucList.Size = new System.Drawing.Size(384, 361);
            this.ucList.TabIndex = 0;
            // 
            // Producers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.ucList);
            this.Name = "Producers";
            this.Text = "Список Производители";
            this.ResumeLayout(false);

        }

        #endregion

        private UCs.UCList ucList;
    }
}
namespace Tradesoft_Problem_151.Forms
{
    partial class FCreateUpdateProduer
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
            this.ucCreateUpdateProducer = new Tradesoft_Problem_151.UCs.UCCreateUpdateProducer();
            this.SuspendLayout();
            // 
            // ucCreateUpdateProducer1
            // 
            this.ucCreateUpdateProducer.Location = new System.Drawing.Point(12, 12);
            this.ucCreateUpdateProducer.Name = "ucCreateUpdateProducer1";
            this.ucCreateUpdateProducer.Size = new System.Drawing.Size(300, 74);
            this.ucCreateUpdateProducer.TabIndex = 0;
            // 
            // CreateUpdateProduer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ucCreateUpdateProducer);
            this.Name = "CreateUpdateProduer";
            this.Text = "Создать Производителя";
            this.ResumeLayout(false);

        }

        #endregion

        private UCs.UCCreateUpdateProducer ucCreateUpdateProducer;
    }
}
namespace Tradesoft_Problem_151.Forms
{
    partial class FCreateDB
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
            this.ucCreateDataBase = new Tradesoft_Problem_151.UCs.UCCreateDataBase();
            this.SuspendLayout();
            // 
            // ucCreateDataBase
            // 
            this.ucCreateDataBase.Location = new System.Drawing.Point(12, 12);
            this.ucCreateDataBase.Name = "ucCreateDataBase";
            this.ucCreateDataBase.Size = new System.Drawing.Size(300, 150);
            this.ucCreateDataBase.TabIndex = 0;
            // 
            // FCreateDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ucCreateDataBase);
            this.Name = "FCreateDB";
            this.Text = "Tradesoft Задание #151";
            this.ResumeLayout(false);

        }

        #endregion

        private UCs.UCCreateDataBase ucCreateDataBase;
    }
}
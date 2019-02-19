namespace Tradesoft_Problem_151
{
    partial class FMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.найтиСвязьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаПроизводителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucListGoods = new Tradesoft_Problem_151.UCs.UCList();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтиСвязьToolStripMenuItem,
            this.таблицаПроизводителиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // найтиСвязьToolStripMenuItem
            // 
            this.найтиСвязьToolStripMenuItem.Name = "найтиСвязьToolStripMenuItem";
            this.найтиСвязьToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.найтиСвязьToolStripMenuItem.Text = "Найти связь";
            this.найтиСвязьToolStripMenuItem.Click += new System.EventHandler(this.найтиСвязьToolStripMenuItem_Click);
            // 
            // таблицаПроизводителиToolStripMenuItem
            // 
            this.таблицаПроизводителиToolStripMenuItem.Name = "таблицаПроизводителиToolStripMenuItem";
            this.таблицаПроизводителиToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.таблицаПроизводителиToolStripMenuItem.Text = "Список Производители";
            this.таблицаПроизводителиToolStripMenuItem.Click += new System.EventHandler(this.таблицаПроизводителиToolStripMenuItem_Click);
            // 
            // ucListGoods
            // 
            this.ucListGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListGoods.Location = new System.Drawing.Point(0, 24);
            this.ucListGoods.Name = "ucListGoods";
            this.ucListGoods.Size = new System.Drawing.Size(584, 537);
            this.ucListGoods.TabIndex = 1;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.ucListGoods);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMain";
            this.Text = "Tradesoft Задание #151";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private UCs.UCList ucListGoods;
        private System.Windows.Forms.ToolStripMenuItem найтиСвязьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаПроизводителиToolStripMenuItem;
    }
}


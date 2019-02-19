namespace Tradesoft_Problem_151.UCs
{
    partial class UCFindLink
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
            this.txbOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbToFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txbSteps = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbOriginal
            // 
            this.txbOriginal.Location = new System.Drawing.Point(125, 6);
            this.txbOriginal.Name = "txbOriginal";
            this.txbOriginal.Size = new System.Drawing.Size(164, 20);
            this.txbOriginal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный товар: ";
            // 
            // txbToFind
            // 
            this.txbToFind.Location = new System.Drawing.Point(125, 41);
            this.txbToFind.Name = "txbToFind";
            this.txbToFind.Size = new System.Drawing.Size(164, 20);
            this.txbToFind.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Искомый товар: ";
            // 
            // btnFind
            // 
            this.btnFind.AutoSize = true;
            this.btnFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFind.Location = new System.Drawing.Point(125, 109);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(48, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txbSteps
            // 
            this.txbSteps.Location = new System.Drawing.Point(125, 74);
            this.txbSteps.Name = "txbSteps";
            this.txbSteps.Size = new System.Drawing.Size(164, 20);
            this.txbSteps.TabIndex = 2;
            this.txbSteps.Text = "5";
            this.txbSteps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSteps_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество шагов: ";
            // 
            // UCFindLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbSteps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txbToFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbOriginal);
            this.Controls.Add(this.label1);
            this.Name = "UCFindLink";
            this.Size = new System.Drawing.Size(300, 141);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbToFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txbSteps;
        private System.Windows.Forms.Label label3;
    }
}

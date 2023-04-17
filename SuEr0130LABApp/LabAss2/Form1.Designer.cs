namespace LabAss2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivison = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(328, 205);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(132, 25);
            this.txtNumber1.TabIndex = 0;
            this.txtNumber1.Text = "q";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(501, 205);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(132, 25);
            this.txtNumber2.TabIndex = 1;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(245, 269);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(100, 29);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(375, 269);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(100, 29);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(501, 269);
            this.btnMultiplication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(100, 29);
            this.btnMultiplication.TabIndex = 4;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivison
            // 
            this.btnDivison.Location = new System.Drawing.Point(628, 269);
            this.btnDivison.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDivison.Name = "btnDivison";
            this.btnDivison.Size = new System.Drawing.Size(100, 29);
            this.btnDivison.TabIndex = 5;
            this.btnDivison.Text = "/";
            this.btnDivison.UseVisualStyleBackColor = true;
            this.btnDivison.Click += new System.EventHandler(this.btnDivison_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnDivison);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivison;
    }
}


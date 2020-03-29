namespace Calculator
{
    partial class Form1
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
            this.add = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.no1 = new System.Windows.Forms.Label();
            this.no2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.Ans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(29, 167);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(192, 167);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(75, 23);
            this.multi.TabIndex = 1;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(273, 167);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 2;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(111, 166);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 3;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // no1
            // 
            this.no1.AutoSize = true;
            this.no1.Location = new System.Drawing.Point(24, 59);
            this.no1.Name = "no1";
            this.no1.Size = new System.Drawing.Size(70, 17);
            this.no1.TabIndex = 4;
            this.no1.Text = "Number 1";
            // 
            // no2
            // 
            this.no2.AutoSize = true;
            this.no2.Location = new System.Drawing.Point(24, 103);
            this.no2.Name = "no2";
            this.no2.Size = new System.Drawing.Size(70, 17);
            this.no2.TabIndex = 5;
            this.no2.Text = "Number 2";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(144, 59);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(199, 22);
            this.num1.TabIndex = 6;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(144, 103);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(199, 22);
            this.num2.TabIndex = 7;
            // 
            // Ans
            // 
            this.Ans.Location = new System.Drawing.Point(144, 234);
            this.Ans.Name = "Ans";
            this.Ans.ReadOnly = true;
            this.Ans.Size = new System.Drawing.Size(199, 22);
            this.Ans.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.no2);
            this.Controls.Add(this.no1);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.div);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Label no1;
        private System.Windows.Forms.Label no2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox Ans;
        private System.Windows.Forms.Label label1;
    }
}


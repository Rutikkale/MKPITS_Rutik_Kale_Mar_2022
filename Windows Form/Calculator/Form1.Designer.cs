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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Addtion_Button = new System.Windows.Forms.Button();
            this.Subtraction_Button = new System.Windows.Forms.Button();
            this.Multiplcation_Button = new System.Windows.Forms.Button();
            this.Division_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Calculator Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(39, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = " First Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Second Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            this.label4.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 22);
            this.textBox2.TabIndex = 5;
            // 
            // Addtion_Button
            // 
            this.Addtion_Button.Location = new System.Drawing.Point(42, 248);
            this.Addtion_Button.Name = "Addtion_Button";
            this.Addtion_Button.Size = new System.Drawing.Size(75, 23);
            this.Addtion_Button.TabIndex = 6;
            this.Addtion_Button.Text = "Addition";
            this.Addtion_Button.UseVisualStyleBackColor = true;
            this.Addtion_Button.Click += new System.EventHandler(this.Addtion_Button_Click);
            // 
            // Subtraction_Button
            // 
            this.Subtraction_Button.Location = new System.Drawing.Point(173, 248);
            this.Subtraction_Button.Name = "Subtraction_Button";
            this.Subtraction_Button.Size = new System.Drawing.Size(75, 23);
            this.Subtraction_Button.TabIndex = 7;
            this.Subtraction_Button.Text = "Subtraction";
            this.Subtraction_Button.UseVisualStyleBackColor = true;
            this.Subtraction_Button.Click += new System.EventHandler(this.Subtraction_Button_Click);
            // 
            // Multiplcation_Button
            // 
            this.Multiplcation_Button.Location = new System.Drawing.Point(302, 248);
            this.Multiplcation_Button.Name = "Multiplcation_Button";
            this.Multiplcation_Button.Size = new System.Drawing.Size(102, 23);
            this.Multiplcation_Button.TabIndex = 8;
            this.Multiplcation_Button.Text = "Multiplcation";
            this.Multiplcation_Button.UseVisualStyleBackColor = true;
            this.Multiplcation_Button.Click += new System.EventHandler(this.Multiplcation_Button_Click);
            // 
            // Division_Button
            // 
            this.Division_Button.Location = new System.Drawing.Point(465, 248);
            this.Division_Button.Name = "Division_Button";
            this.Division_Button.Size = new System.Drawing.Size(75, 23);
            this.Division_Button.TabIndex = 9;
            this.Division_Button.Text = "Division";
            this.Division_Button.UseVisualStyleBackColor = true;
            this.Division_Button.Click += new System.EventHandler(this.Division_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Division_Button);
            this.Controls.Add(this.Multiplcation_Button);
            this.Controls.Add(this.Subtraction_Button);
            this.Controls.Add(this.Addtion_Button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Addtion_Button;
        private System.Windows.Forms.Button Subtraction_Button;
        private System.Windows.Forms.Button Multiplcation_Button;
        private System.Windows.Forms.Button Division_Button;
    }
}


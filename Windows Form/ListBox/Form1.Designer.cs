namespace ListBox
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
            this.FruitslistBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add_button1 = new System.Windows.Forms.Button();
            this.Count_items_button2 = new System.Windows.Forms.Button();
            this.Sort_button3 = new System.Windows.Forms.Button();
            this.Remove_Specificitems_button4 = new System.Windows.Forms.Button();
            this.clear_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FruitslistBox1
            // 
            this.FruitslistBox1.FormattingEnabled = true;
            this.FruitslistBox1.ItemHeight = 16;
            this.FruitslistBox1.Items.AddRange(new object[] {
            "Banana",
            "Apple",
            "Mango",
            "Orange",
            "Blackbarry"});
            this.FruitslistBox1.Location = new System.Drawing.Point(32, 90);
            this.FruitslistBox1.Name = "FruitslistBox1";
            this.FruitslistBox1.Size = new System.Drawing.Size(120, 244);
            this.FruitslistBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Abb Items";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Add_button1
            // 
            this.Add_button1.Location = new System.Drawing.Point(306, 194);
            this.Add_button1.Name = "Add_button1";
            this.Add_button1.Size = new System.Drawing.Size(75, 23);
            this.Add_button1.TabIndex = 3;
            this.Add_button1.Text = "Add";
            this.Add_button1.UseVisualStyleBackColor = true;
            this.Add_button1.Click += new System.EventHandler(this.Add_button1_Click);
            // 
            // Count_items_button2
            // 
            this.Count_items_button2.Location = new System.Drawing.Point(387, 194);
            this.Count_items_button2.Name = "Count_items_button2";
            this.Count_items_button2.Size = new System.Drawing.Size(107, 23);
            this.Count_items_button2.TabIndex = 4;
            this.Count_items_button2.Text = "Count items";
            this.Count_items_button2.UseVisualStyleBackColor = true;
            this.Count_items_button2.Click += new System.EventHandler(this.Count_items_button2_Click);
            // 
            // Sort_button3
            // 
            this.Sort_button3.Location = new System.Drawing.Point(528, 194);
            this.Sort_button3.Name = "Sort_button3";
            this.Sort_button3.Size = new System.Drawing.Size(75, 23);
            this.Sort_button3.TabIndex = 5;
            this.Sort_button3.Text = "Sort";
            this.Sort_button3.UseVisualStyleBackColor = true;
            this.Sort_button3.Click += new System.EventHandler(this.Short_button3_Click);
            // 
            // Remove_Specificitems_button4
            // 
            this.Remove_Specificitems_button4.Location = new System.Drawing.Point(621, 194);
            this.Remove_Specificitems_button4.Name = "Remove_Specificitems_button4";
            this.Remove_Specificitems_button4.Size = new System.Drawing.Size(146, 26);
            this.Remove_Specificitems_button4.TabIndex = 6;
            this.Remove_Specificitems_button4.Text = "Remove Specific  items";
            this.Remove_Specificitems_button4.UseVisualStyleBackColor = true;
            this.Remove_Specificitems_button4.Click += new System.EventHandler(this.Remove_Specificitems_button4_Click);
            // 
            // clear_button1
            // 
            this.clear_button1.Location = new System.Drawing.Point(643, 91);
            this.clear_button1.Name = "clear_button1";
            this.clear_button1.Size = new System.Drawing.Size(75, 23);
            this.clear_button1.TabIndex = 7;
            this.clear_button1.Text = "Clear";
            this.clear_button1.UseVisualStyleBackColor = true;
            this.clear_button1.Click += new System.EventHandler(this.clear_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear_button1);
            this.Controls.Add(this.Remove_Specificitems_button4);
            this.Controls.Add(this.Sort_button3);
            this.Controls.Add(this.Count_items_button2);
            this.Controls.Add(this.Add_button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FruitslistBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My List Box Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FruitslistBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Add_button1;
        private System.Windows.Forms.Button Count_items_button2;
        private System.Windows.Forms.Button Sort_button3;
        private System.Windows.Forms.Button Remove_Specificitems_button4;
        private System.Windows.Forms.Button clear_button1;
    }
}


namespace Exercises_51_2017
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.labelPoint = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(183, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(417, 214);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(21, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(39, 15);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 23);
            this.textBox1.TabIndex = 2;
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(21, 66);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(36, 15);
            this.labelIndex.TabIndex = 3;
            this.labelIndex.Text = "Index";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(21, 84);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(89, 23);
            this.txtIndex.TabIndex = 4;
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Location = new System.Drawing.Point(21, 120);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(35, 15);
            this.labelPoint.TabIndex = 5;
            this.labelPoint.Text = "Point";
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(21, 138);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(89, 23);
            this.txtPoint.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Button button1;
    }
}


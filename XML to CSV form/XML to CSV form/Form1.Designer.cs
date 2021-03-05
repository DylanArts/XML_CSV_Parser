namespace XML_to_CSV_form
{
    partial class XMLtoCSVParser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XMLtoCSVParser));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ParseBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SaveCSVBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenBtn
            // 
            this.OpenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBtn.ForeColor = System.Drawing.Color.White;
            this.OpenBtn.Location = new System.Drawing.Point(12, 12);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(87, 23);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.Text = "Open XML File";
            this.OpenBtn.UseVisualStyleBackColor = false;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(105, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 13);
            this.textBox1.TabIndex = 2;
            // 
            // ParseBtn
            // 
            this.ParseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.ParseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParseBtn.ForeColor = System.Drawing.Color.White;
            this.ParseBtn.Location = new System.Drawing.Point(339, 12);
            this.ParseBtn.Name = "ParseBtn";
            this.ParseBtn.Size = new System.Drawing.Size(82, 23);
            this.ParseBtn.TabIndex = 3;
            this.ParseBtn.Text = "Parse to CSV";
            this.ParseBtn.UseVisualStyleBackColor = false;
            this.ParseBtn.Click += new System.EventHandler(this.ParseBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(19)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(409, 264);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // SaveCSVBtn
            // 
            this.SaveCSVBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.SaveCSVBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCSVBtn.ForeColor = System.Drawing.Color.White;
            this.SaveCSVBtn.Location = new System.Drawing.Point(174, 316);
            this.SaveCSVBtn.Name = "SaveCSVBtn";
            this.SaveCSVBtn.Size = new System.Drawing.Size(87, 23);
            this.SaveCSVBtn.TabIndex = 5;
            this.SaveCSVBtn.Text = "Save CSV file";
            this.SaveCSVBtn.UseVisualStyleBackColor = false;
            this.SaveCSVBtn.Visible = false;
            this.SaveCSVBtn.Click += new System.EventHandler(this.SaveCSVBtn_Click);
            // 
            // XMLtoCSVParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(433, 351);
            this.Controls.Add(this.SaveCSVBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ParseBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OpenBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 390);
            this.MinimumSize = new System.Drawing.Size(449, 390);
            this.Name = "XMLtoCSVParser";
            this.Text = "XML to CSV parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ParseBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SaveCSVBtn;
    }
}


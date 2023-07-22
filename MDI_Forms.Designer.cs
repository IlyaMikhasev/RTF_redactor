namespace RTF_redactor
{
    partial class MDI_Forms
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.b_open = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.b_font = new System.Windows.Forms.Button();
            this.b_color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 424);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // b_open
            // 
            this.b_open.Location = new System.Drawing.Point(701, 2);
            this.b_open.Name = "b_open";
            this.b_open.Size = new System.Drawing.Size(75, 23);
            this.b_open.TabIndex = 8;
            this.b_open.Text = "Open";
            this.b_open.UseVisualStyleBackColor = true;
            this.b_open.Click += new System.EventHandler(this.btnLoad_MouseClick);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(620, 2);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 7;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseClick);
            // 
            // b_font
            // 
            this.b_font.Location = new System.Drawing.Point(81, 2);
            this.b_font.Name = "b_font";
            this.b_font.Size = new System.Drawing.Size(75, 23);
            this.b_font.TabIndex = 6;
            this.b_font.Text = "Font";
            this.b_font.UseVisualStyleBackColor = true;
            this.b_font.Click += new System.EventHandler(this.b_font_Click);
            // 
            // b_color
            // 
            this.b_color.Location = new System.Drawing.Point(0, 2);
            this.b_color.Name = "b_color";
            this.b_color.Size = new System.Drawing.Size(75, 23);
            this.b_color.TabIndex = 5;
            this.b_color.Text = "Color";
            this.b_color.UseVisualStyleBackColor = true;
            this.b_color.Click += new System.EventHandler(this.b_color_Click);
            // 
            // MDI_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_open);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_font);
            this.Controls.Add(this.b_color);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MDI_Forms";
            this.Text = "MDI_Forms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button b_open;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_font;
        private System.Windows.Forms.Button b_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}
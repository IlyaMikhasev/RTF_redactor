namespace RTF_redactor
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_mdiForm = new System.Windows.Forms.RadioButton();
            this.rb_winForm = new System.Windows.Forms.RadioButton();
            this.b_create = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_create);
            this.panel1.Controls.Add(this.rb_winForm);
            this.panel1.Controls.Add(this.rb_mdiForm);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 23);
            this.panel1.TabIndex = 0;
            // 
            // rb_mdiForm
            // 
            this.rb_mdiForm.AutoSize = true;
            this.rb_mdiForm.Location = new System.Drawing.Point(4, 4);
            this.rb_mdiForm.Name = "rb_mdiForm";
            this.rb_mdiForm.Size = new System.Drawing.Size(71, 17);
            this.rb_mdiForm.TabIndex = 0;
            this.rb_mdiForm.TabStop = true;
            this.rb_mdiForm.Text = "MDI Form";
            this.rb_mdiForm.UseVisualStyleBackColor = true;
            // 
            // rb_winForm
            // 
            this.rb_winForm.AutoSize = true;
            this.rb_winForm.Location = new System.Drawing.Point(82, 4);
            this.rb_winForm.Name = "rb_winForm";
            this.rb_winForm.Size = new System.Drawing.Size(67, 17);
            this.rb_winForm.TabIndex = 1;
            this.rb_winForm.TabStop = true;
            this.rb_winForm.Text = "WinForm";
            this.rb_winForm.UseVisualStyleBackColor = true;
            // 
            // b_create
            // 
            this.b_create.Location = new System.Drawing.Point(155, 1);
            this.b_create.Name = "b_create";
            this.b_create.Size = new System.Drawing.Size(75, 23);
            this.b_create.TabIndex = 2;
            this.b_create.Text = "Create";
            this.toolTip1.SetToolTip(this.b_create, "Создание окна с указанными параметрами");
            this.b_create.UseVisualStyleBackColor = true;
            this.b_create.Click += new System.EventHandler(this.b_create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 475);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_winForm;
        private System.Windows.Forms.RadioButton rb_mdiForm;
        private System.Windows.Forms.Button b_create;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


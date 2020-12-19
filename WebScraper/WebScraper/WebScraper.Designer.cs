namespace WebScraper
{
    partial class Form1_WebScraper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_WebScraper));
            this.tb_main = new System.Windows.Forms.RichTextBox();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.label_url = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.tb_filepath = new System.Windows.Forms.TextBox();
            this.btn_fileExplorer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_main
            // 
            this.tb_main.Location = new System.Drawing.Point(12, 67);
            this.tb_main.Name = "tb_main";
            this.tb_main.Size = new System.Drawing.Size(959, 399);
            this.tb_main.TabIndex = 0;
            this.tb_main.Text = "";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(136, 40);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(693, 20);
            this.tb_url.TabIndex = 1;
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_url.ForeColor = System.Drawing.SystemColors.Control;
            this.label_url.Location = new System.Drawing.Point(69, 40);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(62, 21);
            this.label_url.TabIndex = 2;
            this.label_url.Text = "URL -";
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(878, 38);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 23);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(878, 480);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(67, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // tb_filepath
            // 
            this.tb_filepath.Location = new System.Drawing.Point(40, 482);
            this.tb_filepath.Name = "tb_filepath";
            this.tb_filepath.Size = new System.Drawing.Size(693, 20);
            this.tb_filepath.TabIndex = 5;
            // 
            // btn_fileExplorer
            // 
            this.btn_fileExplorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_fileExplorer.Location = new System.Drawing.Point(820, 478);
            this.btn_fileExplorer.Name = "btn_fileExplorer";
            this.btn_fileExplorer.Size = new System.Drawing.Size(37, 27);
            this.btn_fileExplorer.TabIndex = 6;
            this.btn_fileExplorer.Text = "...";
            this.btn_fileExplorer.UseVisualStyleBackColor = true;
            this.btn_fileExplorer.Click += new System.EventHandler(this.btn_fileExplorer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(739, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "(Choose File) ->";
            // 
            // Form1_WebScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1017, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fileExplorer);
            this.Controls.Add(this.tb_filepath);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label_url);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.tb_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1_WebScraper";
            this.Text = "WebScraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_main;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox tb_filepath;
        private System.Windows.Forms.Button btn_fileExplorer;
        private System.Windows.Forms.Label label1;
    }
}


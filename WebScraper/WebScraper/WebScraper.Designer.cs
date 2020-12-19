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
            this.tb_main = new System.Windows.Forms.RichTextBox();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.label_url = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_main
            // 
            this.tb_main.Location = new System.Drawing.Point(25, 84);
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
            // Form1_WebScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1017, 518);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label_url);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.tb_main);
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
    }
}


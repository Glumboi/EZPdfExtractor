namespace EZPdfTextExtractor
{
    partial class Form_extractor
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_extractor));
            this.button_start = new System.Windows.Forms.Button();
            this.button_extract = new System.Windows.Forms.Button();
            this.linkLabel_Github = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox_file = new System.Windows.Forms.TextBox();
            this.timer_OnTick = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.Location = new System.Drawing.Point(228, 34);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 39);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Open PDF";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_extract
            // 
            this.button_extract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_extract.Location = new System.Drawing.Point(228, 74);
            this.button_extract.Name = "button_extract";
            this.button_extract.Size = new System.Drawing.Size(75, 39);
            this.button_extract.TabIndex = 1;
            this.button_extract.Text = "Extract";
            this.button_extract.UseVisualStyleBackColor = true;
            this.button_extract.Click += new System.EventHandler(this.button_extract_Click);
            // 
            // linkLabel_Github
            // 
            this.linkLabel_Github.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_Github.AutoSize = true;
            this.linkLabel_Github.Location = new System.Drawing.Point(238, 18);
            this.linkLabel_Github.Name = "linkLabel_Github";
            this.linkLabel_Github.Size = new System.Drawing.Size(55, 13);
            this.linkLabel_Github.TabIndex = 2;
            this.linkLabel_Github.TabStop = true;
            this.linkLabel_Github.Text = "My Github";
            this.linkLabel_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Github_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 103);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Version 1.0.0.0";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox_file
            // 
            this.textBox_file.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_file.Location = new System.Drawing.Point(12, 53);
            this.textBox_file.Name = "textBox_file";
            this.textBox_file.ReadOnly = true;
            this.textBox_file.Size = new System.Drawing.Size(210, 20);
            this.textBox_file.TabIndex = 4;
            // 
            // timer_OnTick
            // 
            this.timer_OnTick.Enabled = true;
            this.timer_OnTick.Tick += new System.EventHandler(this.timer_OnTick_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "To extract text from a pdf you have to click the open button and then the extract" +
    " button...";
            // 
            // Form_extractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 125);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_file);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel_Github);
            this.Controls.Add(this.button_extract);
            this.Controls.Add(this.button_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_extractor";
            this.Text = "EZPdfextractor";
            this.Load += new System.EventHandler(this.Form_extractor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_extract;
        private System.Windows.Forms.LinkLabel linkLabel_Github;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox_file;
        private System.Windows.Forms.Timer timer_OnTick;
        private System.Windows.Forms.Label label1;
    }
}


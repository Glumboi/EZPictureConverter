namespace EZPicturteConverter
{
    partial class Form_converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_converter));
            this.button_open = new System.Windows.Forms.Button();
            this.button_convert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox_formats = new System.Windows.Forms.ComboBox();
            this.comboBox_resolution = new System.Windows.Forms.ComboBox();
            this.OnTick = new System.Windows.Forms.Timer(this.components);
            this.linkLabel_Github = new System.Windows.Forms.LinkLabel();
            this.linkLabel_version = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Resolution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_open.Location = new System.Drawing.Point(105, 91);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(160, 26);
            this.button_open.TabIndex = 1;
            this.button_open.Text = "Open picture";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_convert
            // 
            this.button_convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_convert.Location = new System.Drawing.Point(105, 117);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(160, 24);
            this.button_convert.TabIndex = 2;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "The selected image path will be displayed here...";
            // 
            // comboBox_formats
            // 
            this.comboBox_formats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_formats.FormattingEnabled = true;
            this.comboBox_formats.Items.AddRange(new object[] {
            "ICO",
            "PNG",
            "JPEG"});
            this.comboBox_formats.Location = new System.Drawing.Point(12, 51);
            this.comboBox_formats.Name = "comboBox_formats";
            this.comboBox_formats.Size = new System.Drawing.Size(253, 21);
            this.comboBox_formats.TabIndex = 4;
            this.comboBox_formats.SelectedIndexChanged += new System.EventHandler(this.comboBox_formats_SelectedIndexChanged);
            // 
            // comboBox_resolution
            // 
            this.comboBox_resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_resolution.FormattingEnabled = true;
            this.comboBox_resolution.Items.AddRange(new object[] {
            "64",
            "48",
            "32",
            "16"});
            this.comboBox_resolution.Location = new System.Drawing.Point(12, 91);
            this.comboBox_resolution.Name = "comboBox_resolution";
            this.comboBox_resolution.Size = new System.Drawing.Size(87, 21);
            this.comboBox_resolution.TabIndex = 5;
            this.comboBox_resolution.Visible = false;
            this.comboBox_resolution.SelectedIndexChanged += new System.EventHandler(this.comboBox_reselution_SelectedIndexChanged);
            // 
            // OnTick
            // 
            this.OnTick.Enabled = true;
            this.OnTick.Tick += new System.EventHandler(this.OnTick_Tick);
            // 
            // linkLabel_Github
            // 
            this.linkLabel_Github.AutoSize = true;
            this.linkLabel_Github.Location = new System.Drawing.Point(9, 115);
            this.linkLabel_Github.Name = "linkLabel_Github";
            this.linkLabel_Github.Size = new System.Drawing.Size(55, 13);
            this.linkLabel_Github.TabIndex = 6;
            this.linkLabel_Github.TabStop = true;
            this.linkLabel_Github.Text = "My Github";
            this.linkLabel_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Github_LinkClicked);
            // 
            // linkLabel_version
            // 
            this.linkLabel_version.AutoSize = true;
            this.linkLabel_version.Location = new System.Drawing.Point(9, 128);
            this.linkLabel_version.Name = "linkLabel_version";
            this.linkLabel_version.Size = new System.Drawing.Size(60, 13);
            this.linkLabel_version.TabIndex = 7;
            this.linkLabel_version.TabStop = true;
            this.linkLabel_version.Text = "Version 1.0";
            this.linkLabel_version.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_version_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select the format you want to convert to...";
            // 
            // label_Resolution
            // 
            this.label_Resolution.AutoSize = true;
            this.label_Resolution.Location = new System.Drawing.Point(9, 75);
            this.label_Resolution.Name = "label_Resolution";
            this.label_Resolution.Size = new System.Drawing.Size(221, 13);
            this.label_Resolution.TabIndex = 9;
            this.label_Resolution.Text = "Select the resolution that you want your ico in";
            this.label_Resolution.Visible = false;
            // 
            // Form_converter
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 147);
            this.Controls.Add(this.label_Resolution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel_version);
            this.Controls.Add(this.linkLabel_Github);
            this.Controls.Add(this.comboBox_resolution);
            this.Controls.Add(this.comboBox_formats);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.button_open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_converter";
            this.Text = "EZPictureConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox_formats;
        private System.Windows.Forms.ComboBox comboBox_resolution;
        private System.Windows.Forms.Timer OnTick;
        private System.Windows.Forms.LinkLabel linkLabel_Github;
        private System.Windows.Forms.LinkLabel linkLabel_version;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Resolution;
    }
}


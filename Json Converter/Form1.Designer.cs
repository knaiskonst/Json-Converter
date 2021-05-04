
namespace Json_Converter
{
    partial class JsonSelector
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
            this.btnJsonSelect = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJsonSelect
            // 
            this.btnJsonSelect.Location = new System.Drawing.Point(23, 33);
            this.btnJsonSelect.Name = "btnJsonSelect";
            this.btnJsonSelect.Size = new System.Drawing.Size(72, 40);
            this.btnJsonSelect.TabIndex = 0;
            this.btnJsonSelect.Text = "Select JSON";
            this.btnJsonSelect.UseVisualStyleBackColor = true;
            this.btnJsonSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(23, 15);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(67, 15);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Path To File";
            // 
            // txtShow
            // 
            this.txtShow.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtShow.Location = new System.Drawing.Point(448, 12);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShow.Size = new System.Drawing.Size(340, 426);
            this.txtShow.TabIndex = 2;
            this.txtShow.TextChanged += new System.EventHandler(this.txtShow_TextChanged);
            // 
            // JsonSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnJsonSelect);
            this.Name = "JsonSelector";
            this.Text = "JSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJsonSelect;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtShow;
    }
}


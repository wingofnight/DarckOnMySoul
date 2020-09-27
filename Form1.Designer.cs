namespace DarckOnMySoul
{
    partial class FormPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPicture));
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Button_Select = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_accept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.Image = global::DarckOnMySoul.Properties.Resources._12332133;
            this.Picture.Location = new System.Drawing.Point(12, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(207, 232);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // Button_Select
            // 
            this.Button_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Select.Location = new System.Drawing.Point(11, 250);
            this.Button_Select.Name = "Button_Select";
            this.Button_Select.Size = new System.Drawing.Size(208, 52);
            this.Button_Select.TabIndex = 1;
            this.Button_Select.Text = "Выбрать Фото";
            this.Button_Select.UseVisualStyleBackColor = true;
            this.Button_Select.Click += new System.EventHandler(this.Button_Select_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btn_accept
            // 
            this.btn_accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_accept.Location = new System.Drawing.Point(12, 314);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(208, 54);
            this.btn_accept.TabIndex = 4;
            this.btn_accept.Text = "Завастить";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Visible = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // FormPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DarckOnMySoul.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(231, 378);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.Button_Select);
            this.Controls.Add(this.Picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Завасть фото";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button Button_Select;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_accept;
    }
}


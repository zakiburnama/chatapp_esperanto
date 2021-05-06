
namespace chatapp.Chatitems
{
    partial class Incomming
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incomming));
            this.bunifuUserControl1 = new Bunifu.UI.WinForms.BunifuUserControl();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuUserControl1
            // 
            this.bunifuUserControl1.AllowAnimations = false;
            this.bunifuUserControl1.AllowBorderColorChanges = false;
            this.bunifuUserControl1.AllowMouseEffects = false;
            this.bunifuUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuUserControl1.AnimationSpeed = 200;
            this.bunifuUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuUserControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(238)))), ((int)(((byte)(183)))));
            this.bunifuUserControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(238)))), ((int)(((byte)(183)))));
            this.bunifuUserControl1.BorderRadius = 33;
            this.bunifuUserControl1.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.bunifuUserControl1.BorderThickness = 1;
            this.bunifuUserControl1.ColorContrastOnClick = 30;
            this.bunifuUserControl1.ColorContrastOnHover = 30;
            this.bunifuUserControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuUserControl1.Image = null;
            this.bunifuUserControl1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuUserControl1.Location = new System.Drawing.Point(47, 3);
            this.bunifuUserControl1.Name = "bunifuUserControl1";
            this.bunifuUserControl1.ShowBorders = true;
            this.bunifuUserControl1.Size = new System.Drawing.Size(559, 52);
            this.bunifuUserControl1.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.bunifuUserControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(238)))), ((int)(((byte)(183)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello World";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 19;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(4, -1);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(38, 38);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // Incomming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.bunifuUserControl1);
            this.Name = "Incomming";
            this.Size = new System.Drawing.Size(659, 58);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuUserControl bunifuUserControl1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}

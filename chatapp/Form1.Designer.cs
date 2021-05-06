
namespace chatapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSend = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txtPesan = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.TextBox();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(238)))), ((int)(((byte)(153)))));
            this.pnlHeader.Controls.Add(this.bunifuPictureBox1);
            this.pnlHeader.Controls.Add(this.lblStatus);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(500, 123);
            this.pnlHeader.TabIndex = 0;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 37;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(25, 25);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(75, 75);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(112, 65);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Online";
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 10;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(458, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 10;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trejnisto (trainer)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.txtPesan);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 725);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 75);
            this.panel2.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.ActiveImage = null;
            this.btnSend.AllowAnimations = true;
            this.btnSend.AllowBuffering = false;
            this.btnSend.AllowToggling = false;
            this.btnSend.AllowZooming = true;
            this.btnSend.AllowZoomingOnFocus = false;
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSend.ErrorImage")));
            this.btnSend.FadeWhenInactive = false;
            this.btnSend.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageActive = null;
            this.btnSend.ImageLocation = null;
            this.btnSend.ImageMargin = 10;
            this.btnSend.ImageSize = new System.Drawing.Size(31, 31);
            this.btnSend.ImageZoomSize = new System.Drawing.Size(41, 41);
            this.btnSend.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSend.InitialImage")));
            this.btnSend.Location = new System.Drawing.Point(447, 20);
            this.btnSend.Name = "btnSend";
            this.btnSend.Rotation = 0;
            this.btnSend.ShowActiveImage = true;
            this.btnSend.ShowCursorChanges = true;
            this.btnSend.ShowImageBorders = true;
            this.btnSend.ShowSizeMarkers = false;
            this.btnSend.Size = new System.Drawing.Size(41, 41);
            this.btnSend.TabIndex = 2;
            this.btnSend.ToolTipText = "";
            this.btnSend.WaitOnLoad = false;
            this.btnSend.Zoom = 10;
            this.btnSend.ZoomSpeed = 10;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtPesan
            // 
            this.txtPesan.AcceptsReturn = false;
            this.txtPesan.AcceptsTab = false;
            this.txtPesan.AnimationSpeed = 200;
            this.txtPesan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPesan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPesan.BackColor = System.Drawing.Color.Transparent;
            this.txtPesan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPesan.BackgroundImage")));
            this.txtPesan.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPesan.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPesan.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPesan.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPesan.BorderRadius = 1;
            this.txtPesan.BorderThickness = 1;
            this.txtPesan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPesan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesan.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPesan.DefaultText = "";
            this.txtPesan.FillColor = System.Drawing.Color.White;
            this.txtPesan.HideSelection = true;
            this.txtPesan.IconLeft = null;
            this.txtPesan.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesan.IconPadding = 10;
            this.txtPesan.IconRight = null;
            this.txtPesan.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesan.Lines = new string[0];
            this.txtPesan.Location = new System.Drawing.Point(12, 20);
            this.txtPesan.MaxLength = 32767;
            this.txtPesan.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPesan.Modified = false;
            this.txtPesan.Multiline = false;
            this.txtPesan.Name = "txtPesan";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPesan.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPesan.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPesan.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPesan.OnIdleState = stateProperties4;
            this.txtPesan.Padding = new System.Windows.Forms.Padding(3);
            this.txtPesan.PasswordChar = '\0';
            this.txtPesan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPesan.PlaceholderText = "Enter text";
            this.txtPesan.ReadOnly = false;
            this.txtPesan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesan.SelectedText = "";
            this.txtPesan.SelectionLength = 0;
            this.txtPesan.SelectionStart = 0;
            this.txtPesan.ShortcutsEnabled = true;
            this.txtPesan.Size = new System.Drawing.Size(429, 41);
            this.txtPesan.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPesan.TabIndex = 1;
            this.txtPesan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPesan.TextMarginBottom = 0;
            this.txtPesan.TextMarginLeft = 3;
            this.txtPesan.TextMarginTop = 0;
            this.txtPesan.TextPlaceholder = "Enter text";
            this.txtPesan.UseSystemPasswordChar = false;
            this.txtPesan.WordWrap = true;
            this.txtPesan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesan_KeyUp);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(500, 13);
            this.bunifuSeparator1.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Controls.Add(this.X);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 123);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(500, 602);
            this.pnlContainer.TabIndex = 2;
            this.pnlContainer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlContainer_Scroll);
            // 
            // X
            // 
            this.X.Enabled = false;
            this.X.Location = new System.Drawing.Point(35, -26);
            this.X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.X.Multiline = true;
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(442, 26);
            this.X.TabIndex = 1;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = false;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.pnlHeader;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlContainer;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuImageButton btnSend;
        private Bunifu.UI.WinForms.BunifuTextBox txtPesan;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox X;
    }
}


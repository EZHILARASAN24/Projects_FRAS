namespace AttendanceAPP
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            printDialog1 = new PrintDialog();
            pictureTitle = new PictureBox();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // pictureTitle
            // 
            pictureTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureTitle.BackColor = Color.Transparent;
            pictureTitle.BackgroundImageLayout = ImageLayout.Zoom;
            pictureTitle.Image = (Image)resources.GetObject("pictureTitle.Image");
            pictureTitle.Location = new Point(201, 0);
            pictureTitle.Name = "pictureTitle";
            pictureTitle.Size = new Size(829, 55);
            pictureTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureTitle.TabIndex = 1;
            pictureTitle.TabStop = false;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(850, 75);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(400, 400);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBox);
            Controls.Add(pictureTitle);
            Name = "Home";
            Size = new Size(1250, 565);
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PrintDialog printDialog1;
        private PictureBox pictureTitle;
        private PictureBox pictureBox;
    }
}

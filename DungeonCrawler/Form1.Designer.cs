namespace DungeonCrawler
{
    partial class Menu
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
            this.title = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.PictureBox();
            this.optionsButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Image = global::DungeonCrawler.Properties.Resources.splashTitle;
            this.title.Location = new System.Drawing.Point(12, 11);
            this.title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(764, 113);
            this.title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.title.TabIndex = 0;
            this.title.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Image = global::DungeonCrawler.Properties.Resources.playButton;
            this.playButton.Location = new System.Drawing.Point(300, 172);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(182, 70);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playButton.TabIndex = 1;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.playButton.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.Transparent;
            this.loadButton.Image = global::DungeonCrawler.Properties.Resources.loadButton;
            this.loadButton.Location = new System.Drawing.Point(300, 256);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(182, 70);
            this.loadButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadButton.TabIndex = 2;
            this.loadButton.TabStop = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            this.loadButton.MouseLeave += new System.EventHandler(this.loadButton_MouseLeave);
            this.loadButton.MouseHover += new System.EventHandler(this.loadButton_MouseHover);
            // 
            // optionsButton
            // 
            this.optionsButton.BackColor = System.Drawing.Color.Transparent;
            this.optionsButton.Image = global::DungeonCrawler.Properties.Resources.optionsButton;
            this.optionsButton.Location = new System.Drawing.Point(251, 342);
            this.optionsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(279, 70);
            this.optionsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.optionsButton.TabIndex = 3;
            this.optionsButton.TabStop = false;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            this.optionsButton.MouseLeave += new System.EventHandler(this.optionsButton_MouseLeave);
            this.optionsButton.MouseHover += new System.EventHandler(this.optionsButton_MouseHover);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = global::DungeonCrawler.Properties.Resources.exitButton;
            this.exitButton.Location = new System.Drawing.Point(300, 437);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 70);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 4;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            this.exitButton.MouseHover += new System.EventHandler(this.exitButton_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.optionsButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.loadButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 554);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DungeonCrawler.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(789, 554);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox title;
        private PictureBox playButton;
        private PictureBox loadButton;
        private PictureBox optionsButton;
        private PictureBox exitButton;
        private Panel panel1;
    }
}
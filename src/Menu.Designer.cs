namespace csharp_solitaire.src
{
    partial class Menu
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.play_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::csharp_solitaire.Properties.Resources.aces;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = global::csharp_solitaire.Properties.Resources.aces;
            this.pictureBox1.Location = new System.Drawing.Point(223, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 201);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.Gold;
            this.play_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.play_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.Location = new System.Drawing.Point(327, 268);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(150, 53);
            this.play_btn.TabIndex = 1;
            this.play_btn.Text = "Play";
            this.play_btn.UseVisualStyleBackColor = false;
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.Gold;
            this.help_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.help_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.Location = new System.Drawing.Point(327, 347);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(150, 53);
            this.help_btn.TabIndex = 1;
            this.help_btn.Text = "How To Play";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Solitaire";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button help_btn;
    }
}
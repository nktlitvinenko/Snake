namespace Snake
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Ticker = new System.Windows.Forms.Timer(this.components);
            this.pbGameField = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameField)).BeginInit();
            this.SuspendLayout();
            // 
            // Ticker
            // 
            this.Ticker.Interval = 150;
            this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
            // 
            // pbGameField
            // 
            this.pbGameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGameField.Location = new System.Drawing.Point(0, 0);
            this.pbGameField.Name = "pbGameField";
            this.pbGameField.Size = new System.Drawing.Size(858, 676);
            this.pbGameField.TabIndex = 0;
            this.pbGameField.TabStop = false;
            this.pbGameField.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGameField_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 676);
            this.Controls.Add(this.pbGameField);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score:";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Ticker;
        private System.Windows.Forms.PictureBox pbGameField;
    }
}


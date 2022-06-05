namespace RockPaperScissor
{
    partial class Form1
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
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UxRockbutton = new System.Windows.Forms.Button();
            this.UxPaperbutton = new System.Windows.Forms.Button();
            this.UxScissorsbutton = new System.Windows.Forms.Button();
            this.Playerbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerbox)).BeginInit();
            this.SuspendLayout();
            // 
            // picComputer
            // 
            this.picComputer.Location = new System.Drawing.Point(380, 87);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(170, 147);
            this.picComputer.TabIndex = 0;
            this.picComputer.TabStop = false;
            this.picComputer.Click += new System.EventHandler(this.picComputer_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Computer choice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(175, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose your tool";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UxRockbutton
            // 
            this.UxRockbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UxRockbutton.BackgroundImage = global::RockPaperScissor.Properties.Resources.rock;
            this.UxRockbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UxRockbutton.Location = new System.Drawing.Point(46, 270);
            this.UxRockbutton.Name = "UxRockbutton";
            this.UxRockbutton.Size = new System.Drawing.Size(108, 110);
            this.UxRockbutton.TabIndex = 3;
            this.UxRockbutton.Text = "Rock";
            this.UxRockbutton.UseVisualStyleBackColor = true;
            this.UxRockbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UxPaperbutton
            // 
            this.UxPaperbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UxPaperbutton.BackgroundImage = global::RockPaperScissor.Properties.Resources.paper;
            this.UxPaperbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UxPaperbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UxPaperbutton.Location = new System.Drawing.Point(281, 270);
            this.UxPaperbutton.Name = "UxPaperbutton";
            this.UxPaperbutton.Size = new System.Drawing.Size(97, 110);
            this.UxPaperbutton.TabIndex = 4;
            this.UxPaperbutton.Text = "Paper";
            this.UxPaperbutton.UseVisualStyleBackColor = true;
            // 
            // UxScissorsbutton
            // 
            this.UxScissorsbutton.BackgroundImage = global::RockPaperScissor.Properties.Resources.scissros;
            this.UxScissorsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UxScissorsbutton.Location = new System.Drawing.Point(504, 270);
            this.UxScissorsbutton.Name = "UxScissorsbutton";
            this.UxScissorsbutton.Size = new System.Drawing.Size(97, 110);
            this.UxScissorsbutton.TabIndex = 5;
            this.UxScissorsbutton.Text = "Scissors";
            this.UxScissorsbutton.UseVisualStyleBackColor = true;
            // 
            // Playerbox
            // 
            this.Playerbox.Location = new System.Drawing.Point(72, 87);
            this.Playerbox.Name = "Playerbox";
            this.Playerbox.Size = new System.Drawing.Size(170, 147);
            this.Playerbox.TabIndex = 6;
            this.Playerbox.TabStop = false;
            this.Playerbox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.Playerbox);
            this.Controls.Add(this.UxScissorsbutton);
            this.Controls.Add(this.UxPaperbutton);
            this.Controls.Add(this.UxRockbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picComputer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picComputer;
        private Label label1;
        private Label label2;
        private Button UxRockbutton;
        private Button UxPaperbutton;
        private Button UxScissorsbutton;
        private PictureBox Playerbox;
    }
}
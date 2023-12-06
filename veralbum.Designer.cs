
namespace ProyectoBebe
{
    partial class veralbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(veralbum));
            this.btnDer = new System.Windows.Forms.Button();
            this.btnIzq = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDer
            // 
            this.btnDer.BackColor = System.Drawing.Color.Transparent;
            this.btnDer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDer.FlatAppearance.BorderSize = 0;
            this.btnDer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDer.Location = new System.Drawing.Point(506, 137);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(40, 93);
            this.btnDer.TabIndex = 26;
            this.btnDer.UseVisualStyleBackColor = false;
            this.btnDer.Click += new System.EventHandler(this.btnDer_Click);
            // 
            // btnIzq
            // 
            this.btnIzq.BackColor = System.Drawing.Color.Transparent;
            this.btnIzq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzq.FlatAppearance.BorderSize = 0;
            this.btnIzq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIzq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzq.Location = new System.Drawing.Point(102, 137);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(40, 93);
            this.btnIzq.TabIndex = 28;
            this.btnIzq.UseVisualStyleBackColor = false;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(167, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 260);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(557, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 45);
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // veralbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 366);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIzq);
            this.Controls.Add(this.btnDer);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "veralbum";
            this.Text = "veralbum";
            this.Load += new System.EventHandler(this.veralbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDer;
        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
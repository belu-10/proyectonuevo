
namespace ProyectoBebe
{
    partial class forminsesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forminsesion));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttoninsesion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 30);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 119);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 27);
            this.textBox2.TabIndex = 1;
            // 
            // buttoninsesion
            // 
            this.buttoninsesion.BackColor = System.Drawing.Color.Transparent;
            this.buttoninsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoninsesion.FlatAppearance.BorderSize = 0;
            this.buttoninsesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttoninsesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttoninsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoninsesion.Location = new System.Drawing.Point(106, 176);
            this.buttoninsesion.Name = "buttoninsesion";
            this.buttoninsesion.Size = new System.Drawing.Size(374, 37);
            this.buttoninsesion.TabIndex = 17;
            this.buttoninsesion.UseVisualStyleBackColor = false;
            this.buttoninsesion.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(122, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 37);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // forminsesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttoninsesion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "forminsesion";
            this.Text = "forminsesion";
            this.Load += new System.EventHandler(this.forminsesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttoninsesion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
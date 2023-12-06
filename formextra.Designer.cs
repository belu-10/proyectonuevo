
namespace ProyectoBebe
{
    partial class formextra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formextra));
            this.panelvacunas = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.panelvacunas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelvacunas
            // 
            this.panelvacunas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelvacunas.BackgroundImage")));
            this.panelvacunas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelvacunas.Controls.Add(this.button15);
            this.panelvacunas.Controls.Add(this.button1);
            this.panelvacunas.Controls.Add(this.button16);
            this.panelvacunas.Location = new System.Drawing.Point(0, 0);
            this.panelvacunas.Name = "panelvacunas";
            this.panelvacunas.Size = new System.Drawing.Size(783, 406);
            this.panelvacunas.TabIndex = 0;
            this.panelvacunas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmedicamento_Paint);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(103, 365);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(591, 72);
            this.button16.TabIndex = 23;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(94, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(580, 72);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(13, 13);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(30, 19);
            this.button15.TabIndex = 24;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // formextra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.panelvacunas);
            this.Name = "formextra";
            this.Text = "formextra";
            this.panelvacunas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelvacunas;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button15;
    }
}
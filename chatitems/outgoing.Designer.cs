namespace Chatbot_HMS.chatitems
{
    partial class outgoing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(outgoing));
            this.paneluser2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picbox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.paneluser2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneluser2
            // 
            this.paneluser2.BackColor = System.Drawing.Color.White;
            this.paneluser2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(156)))), ((int)(((byte)(239)))));
            this.paneluser2.BorderRadius = 20;
            this.paneluser2.BorderThickness = 1;
            this.paneluser2.Controls.Add(this.label1);
            this.paneluser2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.paneluser2.Location = new System.Drawing.Point(16, 20);
            this.paneluser2.Name = "paneluser2";
            this.paneluser2.Size = new System.Drawing.Size(393, 84);
            this.paneluser2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello wolrd";
            // 
            // picbox1
            // 
            this.picbox1.Image = ((System.Drawing.Image)(resources.GetObject("picbox1.Image")));
            this.picbox1.ImageRotate = 0F;
            this.picbox1.Location = new System.Drawing.Point(430, 20);
            this.picbox1.Name = "picbox1";
            this.picbox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picbox1.Size = new System.Drawing.Size(52, 65);
            this.picbox1.TabIndex = 3;
            this.picbox1.TabStop = false;
            // 
            // outgoing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.paneluser2);
            this.Name = "outgoing";
            this.Size = new System.Drawing.Size(500, 117);
            this.Load += new System.EventHandler(this.outgoing_Load);
            this.DockChanged += new System.EventHandler(this.outgoing_DockChanged);
            this.paneluser2.ResumeLayout(false);
            this.paneluser2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel paneluser2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picbox1;
    }
}

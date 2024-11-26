namespace Chatbot_HMS.chatitems
{
    partial class incoming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(incoming));
            this.paneluser = new Guna.UI2.WinForms.Guna2Panel();
            this.picbox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paneluser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneluser
            // 
            this.paneluser.BackColor = System.Drawing.Color.White;
            this.paneluser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(83)))), ((int)(((byte)(219)))));
            this.paneluser.BorderRadius = 20;
            this.paneluser.BorderThickness = 1;
            this.paneluser.Controls.Add(this.label1);
            this.paneluser.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(83)))), ((int)(((byte)(219)))));
            this.paneluser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(156)))), ((int)(((byte)(239)))));
            this.paneluser.Location = new System.Drawing.Point(109, 14);
            this.paneluser.Name = "paneluser";
            this.paneluser.Size = new System.Drawing.Size(393, 61);
            this.paneluser.TabIndex = 0;
            // 
            // picbox1
            // 
            this.picbox1.Image = ((System.Drawing.Image)(resources.GetObject("picbox1.Image")));
            this.picbox1.ImageRotate = 0F;
            this.picbox1.Location = new System.Drawing.Point(14, 14);
            this.picbox1.Name = "picbox1";
            this.picbox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picbox1.Size = new System.Drawing.Size(65, 61);
            this.picbox1.TabIndex = 1;
            this.picbox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(156)))), ((int)(((byte)(239)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello wolrd";
            // 
            // incoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.paneluser);
            this.Name = "incoming";
            this.Size = new System.Drawing.Size(515, 87);
            this.Load += new System.EventHandler(this.incoming_Load);
            this.paneluser.ResumeLayout(false);
            this.paneluser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel paneluser;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picbox1;
        private System.Windows.Forms.Label label1;
    }
}

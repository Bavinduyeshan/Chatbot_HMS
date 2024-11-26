using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatbot_HMS.chatitems
{
    public partial class outgoing : UserControl
    {
        public outgoing()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Outgoing_Resize);
        }

        private void outgoing_Load(object sender, EventArgs e)
        {

        }

        public string Message
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
                AdjustHeight();
            }
        }

        void AdjustHeight()
        {
            label1.MaximumSize = new Size(420, 0); // Adjust maximum width
            label1.Height = utils.GetTextHeight(label1) + 4;
            paneluser2.Height = label1.Top + label1.Height + 10;
            this.Width = 440; // Set the width for oval shape and increase more to the edge
            this.Height = paneluser2.Bottom + 4;
        }

        private void Outgoing_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void outgoing_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}

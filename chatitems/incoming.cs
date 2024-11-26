using Bunifu.Framework.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chatbot_HMS.chatitems
{
    public partial class incoming : UserControl
    {
        public incoming()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Incoming_Resize);
        }

        private void incoming_Load(object sender, EventArgs e)
        {
            AdjustHeight(); // Ensure height adjusts on load
        }

        public string Message
        {
            get => label1.Text;
            set
            {
                label1.Text = value;
                AdjustHeight();
            }
        }

        /// <summary>
        /// Adjusts the height of the control dynamically based on the content.
        /// </summary>
        void AdjustHeight()
        {
            // Set the maximum width for the label to enable wrapping
            label1.MaximumSize = new Size(420, 0);
            label1.AutoSize = true;

            // Calculate label height dynamically
            int calculatedHeight = label1.PreferredHeight;

            // Update label height and reposition other elements
            label1.Height = calculatedHeight;
            picbox1.Location = new Point(4, 3);

            // Update panel size to fit the text
            paneluser.Height = label1.Top + label1.Height + 10;

            // Update this UserControl's height
            this.Width = 440; // Fixed width for consistency
            this.Height = paneluser.Bottom + 4;
        }

        public Image Avatar
        {
            get => picbox1.Image;
            set => picbox1.Image = value;
        }

        private void Incoming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}

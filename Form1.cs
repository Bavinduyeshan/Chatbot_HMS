using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Chatbot_HMS
{
    public partial class Form1 : Form
    {
        // Dictionary to store predefined responses
        private Dictionary<string, string> responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "hello", "Hi there! How can I assist you today?" },
            { "how are you", "I'm just a program, but I'm here to help you!" },
            { "what is your name", "I'm your HMS chatbot. You can call me ChatMed!" },
            { "thank you", "You're welcome! 😊" },
            { "bye", "Goodbye! Have a great day!" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you you need to close this", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.OK) 
            {
                this.Close();
            }
            
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            Send();
        }

        void Send()
        {
            string userMessage = txtmessage.Text.Trim();

            if (userMessage.Length == 0) return;

            // Display user's message
            AddOutgoing(userMessage);

            // Clear the input box
            txtmessage.Text = string.Empty;

            // Get chatbot response
            string reply = GetResponse(userMessage);

            // Display chatbot's reply
            AddIncoming(reply);
        }

        /// <summary>
        /// Generates a chatbot response based on user input.
        /// </summary>
        /// <param name="message">User's input message.</param>
        /// <returns>Response from the chatbot.</returns>
        string GetResponse(string message)
        {
            // Check for an exact match in the predefined responses
            if (responses.TryGetValue(message.ToLower(), out string response))
            {
                return response;
            }

            // Default response for unrecognized inputs
            return "I'm sorry, I don't understand that. Can you rephrase?";
        }

        void AddIncoming(string message)
        {
            var bubble = new chatitems.incoming();
            pnlContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }

        void AddOutgoing(string message)
        {
            var bubble = new chatitems.outgoing();
            pnlContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }

        private void txtmessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Send();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            AddIncoming("Hello " + "Bavindu"+ ", ask me anything :).");
        }
    }
}

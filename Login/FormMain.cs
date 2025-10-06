using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private string username;
        public FormMain(string user) 
        {
            InitializeComponent();
            username = user; 
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            label1.Text = "Xin chào, " + username + "!";
        }
    }
}

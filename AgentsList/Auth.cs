using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentsList
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            AgentsList aglist = new AgentsList();

            for (int i = 0; i < 3; i++)
            {
                aglist.AddToList(new Agent(
                    @"D:\Repos\AgentsList\AgentsList\picture.png",
                    "type",
                    "name",
                    "20",
                    "8940495050445",
                    "max",
                    "20%"
                    ));
            }
            aglist.FillCollection();
            Controls.Add(aglist);
            

        }
    }
}

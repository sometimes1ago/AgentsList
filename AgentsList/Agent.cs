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
    public partial class Agent : UserControl
    {
        public Agent(
            string AgentImgPath, 
            string AgentType,
            string AgentName,
            string SellsPerYear,
            string AgentPhone,
            string AgentPriority,
            string AgentSale
            )
        {
            InitializeComponent();
            AgentImage.ImageLocation = AgentImgPath;
            Agent Agent = this;
            Agent.AgentType.Text = AgentType;
            Agent.AgentName.Text = AgentName;
            Agent.SellsPerYear.Text += SellsPerYear;
            Agent.AgentPhone.Text = AgentPhone;
            Agent.AgentPriority.Text += AgentPriority;
            Agent.AgentSale.Text = AgentSale;
        }

    }
}

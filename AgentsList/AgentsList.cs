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
    public partial class AgentsList : UserControl
    {
        private List<Agent> AgentsCollection = new List<Agent>();
        
        public AgentsList()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Метод, добавляющий элементы коллекции на форму как элементы управления
        /// </summary>
        public void FillCollection()
        {
            int CurrentY = 0;
            int YOffset = 10;
            for (int i = 0; i < AgentsCollection.Count; i++)
            {
                AgentsCollection[i].Location = new Point(0, CurrentY);
                CurrentY += AgentsCollection[i].Height + YOffset;
                Controls.Add(AgentsCollection[i]);
            }
        }

        /// <summary>
        /// Метод, добавляющий Агента в коллекцию Агентов
        /// </summary>
        /// <param name="Item">Экземпляр Агента</param>
        public void AddToList(Agent Item)
        {
            AgentsCollection.Add(Item);
        }
    }
}

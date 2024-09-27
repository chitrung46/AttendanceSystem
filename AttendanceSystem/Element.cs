using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Element : Form
    {
        List<Food> listItem;
        public Element()
        {
            InitializeComponent();

            listItem = new List<Food>()
            {
                new Food(){Name = "Mực một nắng nướng sa tế", Price = 2000},
                new Food(){Name = "Ghẹ hấp bia", Price = 11000},
                new Food(){Name = "Ếch xào xả ớt", Price = 5000}
            };
            customComboBox1.DataSource = listItem;
            customComboBox1.DisplayMember = "Name";

            AddBinding();

        }

        void AddBinding()
        {
            textBox1.DataBindings.Add(new Binding("Text", customComboBox1.DataSource, "Price"));
        }
    }

    public class Food
    {
        public string Name { get; set; }
        public float Price { get; set; }
    }
}

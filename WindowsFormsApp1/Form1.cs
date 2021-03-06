using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int XXX { get; set; }
        public Form1()
        {
            InitializeComponent();
            Binding binding = new Binding("Text", textBox1, "Text", true, DataSourceUpdateMode.OnPropertyChanged);

     
            this.DataBindings.Add("Text",textBox1,"Name");

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Text = XXX.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parent
{
    public partial class Parent : Form
    {
        Child child = null;
        public Parent()
        {
            InitializeComponent();
            child = new Child(this);
            child.Location = new Point(309, 309);
            child.Show();
        }
        public String Info
        {
            set
            {
                textBox1.Text = value;
            }
            get
            {
                return textBox1.Text;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            child.Info = textBox1.Text;
        }
    }
}
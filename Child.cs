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
    public partial class Child : Form
    {
        Parent parent = null;
        public Child()
        {
            InitializeComponent();
        }
        public Child(Parent parent)
        {
            InitializeComponent();
            this.parent = parent;
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
            parent.Info = textBox1.Text;
        }
    }
}
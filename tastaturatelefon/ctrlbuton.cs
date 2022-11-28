using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tastaturatelefon
{
    public partial class ctrlbuton : UserControl
    {
        public ctrlbuton()
        {
            InitializeComponent();
        }

        public Form1 frm;

        public int x = -1;

        public void setctrlbuton(int i)
        {
            x = i;
        }

      

        public void setLabel1( string s)
        {
           label1.Text += s;

        }

        public string getLabel1()
        {
            return label1.Text;

        }

        public void setLabel2(string s)
        {
            label2.Text += s;

        }

        public string getLabel2()
        {
            return label2.Text;

        }

        private void ctrlbuton_Load(object sender, EventArgs e)
        {
            try
            {
                frm = (Form1)this.ParentForm;
            }
            catch { }
        }

        private void ctrlbuton_MouseDown(object sender, MouseEventArgs e)
        {
            frm.pressedbuton(x);
        }
    }
}

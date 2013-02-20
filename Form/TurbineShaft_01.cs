using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RDTextParser;
using RotorDynamics.Source;

namespace RotorDynamics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //
        }
   

        private void Save_Click(object sender, EventArgs e)
        {
            Source.RotorDynamics RDObject = new Source.RotorDynamics();
            foreach (Control textBox in splitContainer1.Panel2.Controls)
            {
                RDObject.AddToTurbineShaft01(((TextBox)textBox).Name, ((TextBox)textBox).Text);
                ((TextBox)textBox).ResetText();
            }
            RDObject.SaveTurbineShaft01();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Source.RotorDynamics RDObject = new Source.RotorDynamics();
            foreach (Control textBox in splitContainer1.Panel2.Controls)
            {
                ((TextBox)textBox).ResetText();
                ((TextBox)textBox).Text = RDObject.GetTurbineShaft01(((TextBox)textBox).Name);
            }
        }
    }
}

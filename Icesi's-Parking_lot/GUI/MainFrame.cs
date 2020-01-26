using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainFrame : Form
    {

        private LinkedListNode<Data> current;

        public MainFrame()
        {
            InitializeComponent();
            Program.read();
            current = Program.registers.First;
            set();
        }

        public void set()
        {
            txtName.Text = current.Value.getName();
            txtLastName.Text = current.Value.getLastName();
            txtLicense.Text = current.Value.getLicense();
            txtBrand.Text = current.Value.getBrand();
            txtModel.Text = current.Value.getModel();
            txtColor.Text = current.Value.getColor();
            txtCareer.Text = current.Value.getCareer();
        }

        public void clean()
        {
            txtName.Text = "";
            txtLastName.Text = "";
            txtLicense.Text = "";
            txtBrand.Text = "";
            txtModel.Text = "";
            txtColor.Text = "";
            txtCareer.Text = "";
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            if(current.Next != null)
            {
            current = current.Next;
            set();
            } else
            {
                current = Program.registers.First;
                set();
            }

        }

        private void butLast_Click(object sender, EventArgs e)
        {
            if(current.Previous != null)
            {
            current = current.Previous;
            set();
            } else
            {
                current = Program.registers.Last;
                set();
            }

        }

        private void butNew_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            // new element
            Data nE = new Data(txtName.Text, txtLastName.Text, txtLicense.Text, txtBrand.Text, txtModel.Text, txtColor.Text, txtCareer.Text);
            Program.registers.AddLast(nE);
            Program.Write();
            current = Program.registers.Last;
        }
    }
}

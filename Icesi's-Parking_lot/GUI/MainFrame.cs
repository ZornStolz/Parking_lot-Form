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

        private void butSearch_Click(object sender, EventArgs e)
        {
        
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            current = current.Next;
            set();
        }

        private void butLast_Click(object sender, EventArgs e)
        {
            current = current.Previous;
            set();
        }
    }
}

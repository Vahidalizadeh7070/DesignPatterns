using PrototypeDesignPattern.Prototype;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeDesignPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Nested instantiate an object 
        Employee emp = new Employee() { EmpAddress = new Address() };

        // Copy of Employee Class
        Employee empCopied;

        // Instantiate an object of StringBuilder
        StringBuilder sb = new StringBuilder();

        // Shallow Copy click event handler
        private void btnShallow_Click(object sender, EventArgs e)
        {
            // Invoke ShallowCopy method 
            empCopied = (Employee)this.emp.ShallowCopy();

            // Invoke Refresh method
            Refresh();
        }

        // Deep Copy click event handler
        private void btnDeep_Click(object sender, EventArgs e)
        {
             // Invoke DeepCopy method
            empCopied = (Employee)this.emp.DeepCopy();

            // Invoke Refresh method
            Refresh();
        }

        // Save click event handler
        // When we click on save button, we set all text box values to the emp object that is belonged to the Employee class
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblResult.ResetText();
            emp.ID = txtId.Text;
            emp.Name = txtName.Text;
            emp.EmpAddress.Country = txtCountry.Text;
            emp.EmpAddress.DoorNumber = int.Parse(txtDoor.Text);
            emp.EmpAddress.StreetNumber = int.Parse(txtStreet.Text);
            emp.EmpAddress.Zipcode = int.Parse(txtZip.Text);
            MessageBox.Show("Updated");
        }

        // Refresh click event handler
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        // Refresh method
        // It will append some texts and empCopied to the result textbox
        private void Refresh()
        {
            sb.Clear();
            sb.AppendLine("---------------------------------");
            sb.AppendLine(string.Format("Main Employee : {0} ",
                this.emp.ToString()));
            sb.AppendLine();
            sb.AppendLine(string.Format("Copied Employee : {0} ",
                empCopied.ToString()));
            sb.AppendLine("-----------------------------------");
            sb.AppendLine(txtResult.Text);

            txtResult.Text = sb.ToString();
        }


        // It clears result from result textbox
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

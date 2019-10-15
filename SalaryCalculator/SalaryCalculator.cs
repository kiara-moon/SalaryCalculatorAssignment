using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class SalaryCalculator : Form
    {
        public SalaryCalculator()
        {
            InitializeComponent();
        }

        Salary salary = new Salary();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void salaryButton_Click(object sender, EventArgs e)
        {
            salary.Name = nameTextBox.Text;
            salary.Amount = Convert.ToDouble(amountTextBox.Text);
            salary.Rent= Convert.ToDouble(houseRentTextBox.Text);
            salary.Allowance = Convert.ToDouble(allowanceTextBox.Text);

            double totalSalary = salary.CalculateSalary();

            MessageBox.Show(salary.Name + ", Your salary is " + totalSalary);
        }
    }
}

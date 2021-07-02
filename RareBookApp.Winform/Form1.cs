using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RareBookApp.Data;
using System.Windows.Forms;
using RareBookApp.Service.Customer.Concrete;

namespace RareBookApp.Winform
{
    public partial class Form1 : Form
    {
        private static readonly RareBookAppContext _context = new RareBookAppContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void customerServiceBtn_Click(object sender, EventArgs e)
        {
            var customerService = new CustomerService(_context);

            // STOP HERE!!

        }

      
    }
}

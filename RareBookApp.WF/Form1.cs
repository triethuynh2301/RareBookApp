using RareBookApp.Data;
using RareBookApp.Service.SaleService;
using RareBookApp.Service.SaleService.Concrete;
using RareBookApp.Service.SaleService.QueryObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RareBookApp.WF
{
    public partial class Form1 : Form
    {
        private static readonly RareBookAppContext _context = new RareBookAppContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void displaySalesDataBtn_Click(object sender, EventArgs e)
        {
            var filterValue = filterValueTextBox.Text;
            var saleServices = new SaleService(_context);
            var filterSortOptions = new SaleSortFilterPageOptions();

            filterSortOptions.filterOptions = (SalesFilterOptions)filterSalesByComboBox.SelectedIndex;
            filterSortOptions.sortOptions = (SalesSortOptions)sortSalesByComboBox.SelectedIndex;

            var salesQuery = saleServices.SalesSortFilter(filterSortOptions, filterValue).ToList();

            try
            {
                salesDataGridView.DataSource = salesQuery;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}

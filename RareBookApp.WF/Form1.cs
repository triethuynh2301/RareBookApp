using FastMember;
using RareBookApp.Data;
using RareBookApp.Domain;
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
        private readonly RareBookAppContext _context = new RareBookAppContext();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void displaySalesDataBtn_Click(object sender, EventArgs e)
        {
            string filterValue = filterValueComboBox.Text;
            List<Sale> salesQuery = new List<Sale>();
            var saleServices = new SaleService(_context);
            var filterSortOptions = new SortFilterPageOptions();

            filterSortOptions.filterOptions = (FilterOptions)filterSalesByComboBox.SelectedIndex;
            filterSortOptions.sortOptions = (SalesSortOptions)sortSalesByComboBox.SelectedIndex;

            salesQuery = saleServices.SalesSortFilter(filterSortOptions, filterValue).ToList();
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



        private void Form1_Load(object sender, EventArgs e)
        {
            using var db = new RareBookAppContext();

            var salesData = _context.Sales.Select(i => i).ToList();
            //var salesTable = new DataTable();
            //using (var reader = ObjectReader.Create(salesData))
            //{
            //    salesTable.Load(reader);
            //}

            if (salesData != null)
            {
                if (salesData.Count() > 0)
                {
                    salesDataGridView.DataSource = salesData;
                }
                else
                {
                    MessageBox.Show("No records found.", "Sale Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    salesDataGridView.DataSource = null;
                }
            }

        }

        private void salesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (salesDataGridView.Columns[e.ColumnIndex].Name == "SaleDate")
            {

            }
        }
    }
}

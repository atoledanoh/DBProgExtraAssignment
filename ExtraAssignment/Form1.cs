using System;
using System.Windows.Forms;

namespace ExtraAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindRepo northwindRepo;
        int employeeId = 0;

        public void init()
        {
            northwindRepo = NorthwindFactory.CreateRepo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
            LoadEmployees();
            LoadOrders();
        }

        private void LoadEmployees()
        {
            try
            {
                var employeeNames = northwindRepo.GetEmployees();
                Utilities.BindComboBox(comboBox1, employeeNames, "LastName", "EmployeeId");
            }
            catch (Exception e)
            {
            }
        }

        private void LoadOrders()
        {
            employeeId = comboBox1.SelectedIndex;
            try
            {
                var orders = northwindRepo.GetOrders(employeeId);

                dataGridView1.DataSource = orders;
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoResizeColumns();

            }
            catch (Exception e)
            {
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}

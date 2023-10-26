using System.Windows.Forms;

namespace EmployeeDBApp
{
    public partial class Form1 : Form
    {
        BindingSource departmanetBindingSource = new BindingSource();
        BindingSource employeeBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            /*DepartmentDAO departmentDAO = new DepartmentDAO();
            Department d1 = new Department
            {
                ID = 1,
                DepartmentTitle = "Accounting",
                EmployeeCount = 5,
                ImgURL = "WWW.GOOGLE.COM",
                DepartmentDiscription = "Responsible for financial record keeping."
            };
            Department d2 = new Department
            {
                ID = 2,
                DepartmentTitle = "Analytics",
                EmployeeCount = 5,
                ImgURL = "WWW.GOOGLE.COM",
                DepartmentDiscription = "Analyzing and interpreting data for decision-making."
            };
            departmentDAO.departments.Add(d1);
            departmentDAO.departments.Add(d2);*/
            // connect the list to the grid source 
            DepartmentDAO departmenDAO = new DepartmentDAO();
            departmanetBindingSource.DataSource = departmenDAO.getAllGdepartments();
            dataGridView1.DataSource = departmanetBindingSource;

            //    pictureBox1.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsY46gfKO_upkW5ZsSQwLVG0d5nWvojZqqjg&usqp=CAU");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // search for specific  departments 
            DepartmentDAO departmenDAO = new DepartmentDAO();
            departmanetBindingSource.DataSource = departmenDAO.searchTitles(tb_search.Text);
            dataGridView1.DataSource = departmanetBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // get row number clicked
            int rowClicked = dataGridView.CurrentRow.Index;

            String imgURL = dataGridView.Rows[rowClicked].Cells[3].Value.ToString();
            // MessageBox.Show("clicked" + rowClicked +"//" + imgURL);
            pictureBox1.Load(imgURL);

            DepartmentDAO departmentDAO = new DepartmentDAO();
            employeeBindingSource.DataSource = departmentDAO.getEmployeeUsingJoin((int)dataGridView.Rows[rowClicked].Cells[0].Value);
            dataGridView2.DataSource = employeeBindingSource;

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // add a new item to the database
            Department department = new Department
            {
                DepartmentTitle = txt_AddTitle.Text,
                EmployeeCount = Int32.Parse(txt_AddNumEm.Text),
                ImgURL = txt_AddIMGURL.Text,
                DepartmentDiscription = txt_Adddisc.Text

            };

            DepartmentDAO departmentDAO = new DepartmentDAO();
            int result = departmentDAO.addoneDeparrtment(department);
            MessageBox.Show(result + "new row(s) inserted ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dataGridView = (DataGridView)sender;

            // get row number clicked
            int rowClicked = dataGridView.CurrentRow.Index;

            String photo = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();
            // MessageBox.Show("clicked" + rowClicked +"//" + photo);
            pictureBox2.Load(photo);




        }


    }
}
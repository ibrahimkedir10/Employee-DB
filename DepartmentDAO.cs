using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDBApp
{
    public class DepartmentDAO
    {
        // connect to database
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=employee";

        public List<Department> getAllGdepartments()
        {
            //start with an empty list
            List<Department> returnThese = new List<Department>();

            // create connection to musql server 
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // create new instance of an object 
            MySqlCommand command = new MySqlCommand("SELECT ID,Title,Employees_Num,Image_Name,Description FROM departments", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Department department1 = new Department
                    {
                        ID = reader.GetInt32(0),
                        DepartmentTitle = reader.GetString(1),
                        EmployeeCount = reader.GetInt32(2),
                        ImgURL = reader.GetString(3),
                        DepartmentDiscription = reader.GetString(4)

                    };
                    returnThese.Add(department1);
                }
            }
            connection.Close();
            return returnThese;
        }

        public List<Department> searchTitles(String seachTerm)
        {
            //start with an empty list
            List<Department> returnThese = new List<Department>();

            // create connection to musql server 
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            String searchWildPhrase = "%" + seachTerm + "%";
            // create new instance of an object 
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID,Title,Employees_Num,Image_Name,Description FROM departments WHERE Title LIKE @search";

            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Department department1 = new Department
                    {
                        ID = reader.GetInt32(0),
                        DepartmentTitle = reader.GetString(1),
                        EmployeeCount = reader.GetInt32(2),
                        ImgURL = reader.GetString(3),
                        DepartmentDiscription = reader.GetString(4)

                    };
                    returnThese.Add(department1);
                }
            }
            connection.Close();
            return returnThese;
        }

        public List<Employee> getEmployee(int departmentID)
        {
            //start with an empty list
            List<Employee> returnThese = new List<Employee>();

            // create connection to musql server 
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            
            // create new instance of an object 
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM employees WHERE departments_ID = @departmentid";

            command.Parameters.AddWithValue("@departmentid", departmentID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employee employee1 = new Employee
                    {
                        ID = reader.GetInt32(0),
                        firstName = reader.GetString(1),
                        lastName = reader.GetString(2),
                        photo = reader.GetString(3),
                       

                    };
                    returnThese.Add(employee1);
                }
            }
            connection.Close();
            return returnThese;
        }

        public List<JObject> getEmployeeUsingJoin(int departmentID)
        {
            //start with an empty list
            List<JObject> returnThese = new List<JObject>();

            // create connection to musql server 
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();


            // create new instance of an object 
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT departments.ID as department_ID, employees.ID as Employee_ID, `employee_firstName`, `employee_lastName`, `photo` FROM `employees` JOIN departments ON departments_ID = departments.ID WHERE departments_ID = @departmentid";

            command.Parameters.AddWithValue("@departmentid", departmentID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                
                while (reader.Read())
                {
                    JObject newEmployee = new JObject();

                    for (int i = 0; i < reader.FieldCount; i++) 
                    {
                        newEmployee.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }
                    returnThese.Add(newEmployee);
                }
            }
            connection.Close();
            return returnThese;
        }

        internal int addoneDeparrtment(Department department)
        {
            //start with an empty list
            List<Department> returnThese = new List<Department>();

            // create connection to musql server 
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `departments`(`Title`, `Employees_Num`, `Image_Name`, `Description`) VALUES (@title,@employee_count,@imgURL,@description)", connection);

            command.Parameters.AddWithValue("@title", department.DepartmentTitle);
            command.Parameters.AddWithValue("@employee_count", department.EmployeeCount);
            command.Parameters.AddWithValue("@imgURL", department.ImgURL);
            command.Parameters.AddWithValue("@description", department.DepartmentDiscription);
            int newRow = command.ExecuteNonQuery();
            connection.Close();
            return newRow;
        }

        
    }


}

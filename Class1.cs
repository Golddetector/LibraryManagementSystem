using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.Design;
using System.Xml;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Mangment_System
{
    public class Book
    {
        public DateTime issued_date { get; set; }
        public DateTime returned_date { get; set; }
        public DateTime due_date { get; set; }
        public int book_id { get; set; }
        public string name { get; private set; }
        public string author_name { get; private set; }
        public DateTime publication { get; private set; }
        public DateTime purchase_date { get; private set; }
        public double price { get; private set; }
        public int quanitity { get; private set; }
        // constructur
        public Book(string name, string author_name, DateTime publication, DateTime purchase_date, double price, int quanitity=0, int book_id = 0, DateTime issued_date = default(DateTime), DateTime due_date = default(DateTime), DateTime returned_date = default(DateTime))
        {
            this.returned_date = returned_date;
            this.due_date = due_date;
            this.issued_date = issued_date;
            this.book_id = book_id;
            this.name = name;
            this.author_name = author_name;
            this.publication = publication;
            this.purchase_date = purchase_date;
            this.price = price;
            this.quanitity = quanitity;
        }
        public Book(int book_id, DateTime issued_date, DateTime due_date)
        {
            this.book_id=book_id;
            this.issued_date=issued_date;
            this.due_date=due_date;
        }
        public Book(int book_id, DateTime returned_date)
        {
            this.book_id=book_id;
            this.returned_date=returned_date;
        }
        public Book()
        {

        }
        // add book to the database
        public void add_to_database()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            databaseHelper.add_book(name, author_name, publication, purchase_date, price, quanitity);
        }
        // update book
        public void update_book()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            databaseHelper.update_book(book_id, name, author_name, publication, purchase_date, price);
        }
        // delete book
        public void delete_book()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            databaseHelper.delete_book(book_id);
        }
        public void issuee_book(int student_id)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            databaseHelper.issue_book(student_id, book_id, issued_date, due_date);
        }
        public void return_book(int student_id)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            databaseHelper.return_book(student_id, book_id, returned_date);
        }
    }

    public class Student { 
        public string name { get; private set; }
        public  int id {  get; private set; }
        public string department {  get; private set; }
        public string phone_number { get; private set; }
        public string email { get; private set; }

        public Student(string name,  int id, string department, string phone_number, string email)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.phone_number = phone_number;
            this.email = email;
        }
        public Student()
        {

        }
        public void add_to_database()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            databaseHelper.add_student(id,name,department,phone_number,email);
        }
        public void update_student()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();  
            databaseHelper.update_student(id,name,department,phone_number,email);
        }
        public void delete_student()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            dbHelper.delete_student(id);
        }
    }
    public class Staff {
        public int id;
        public string fname;
        public string lname;
        public string email;
        public double salary;
        public DateTime date_of_birth;
        public bool admin;
        public string username;
        public string password;
        public Staff(int id, string fname, string lname, string email, double salary, DateTime date_of_birth, string username,string password, bool admin)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.salary = salary;
            this.date_of_birth = date_of_birth;
            this.username = username;
            this.password = password;
            this.admin = admin;
        }
        public Staff()
        {

        }
    }

    public class DatabaseHelper
    {
        private SqlConnection connection;

        public DatabaseHelper()
            
        {
            
            string connectionString = "Server=Adugna_Dereje\\SQLEXPRESS;Database=library_managment;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
        }
        public bool OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                return connection.State == ConnectionState.Open;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection with Database failed");
                Console.WriteLine($"Connection error: {ex.Message}");
                Application.Exit();
                return false;
            }
        }
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void add_book(string book_name, string author, DateTime publication, DateTime purchase_date, double price, int quanitity)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("add_book", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@book_name", book_name));
                    cmd.Parameters.Add(new SqlParameter("@author", author));
                    cmd.Parameters.Add(new SqlParameter("@publication", publication));
                    cmd.Parameters.Add(new SqlParameter("@purchase_date", purchase_date));
                    cmd.Parameters.Add(new SqlParameter("@price", price));
                    cmd.Parameters.Add(new SqlParameter("@quantity", quanitity));

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
        }
        public void update_book(int book_id, string book_name, string author, DateTime publication, DateTime purchase_date, double price)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("update_book", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@book_id", book_id));
                    cmd.Parameters.Add(new SqlParameter("@book_name", book_name));
                    cmd.Parameters.Add(new SqlParameter("@author", author));
                    cmd.Parameters.Add(new SqlParameter("@publication", publication));
                    cmd.Parameters.Add(new SqlParameter("@purchase_date", purchase_date));
                    cmd.Parameters.Add(new SqlParameter("@price", price));

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
        }
        public void delete_book(int book_id)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("delete_book", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@book_id", book_id));

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }

        }
        public void issue_book(int student_id, int book_id, DateTime issue_date, DateTime due_date)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("issue_book", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@student_id", student_id));
                    cmd.Parameters.Add(new SqlParameter("@book_id", book_id));
                    cmd.Parameters.Add(new SqlParameter("@issue_date", issue_date));
                    cmd.Parameters.Add(new SqlParameter("@due_date", due_date));

                    cmd.ExecuteNonQuery();
                }
            }

            finally
            {
                CloseConnection();
            }
        }
        public void return_book(int student_id, int book_id, DateTime return_date)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("return_book", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@student_id", student_id));
                    cmd.Parameters.Add(new SqlParameter("@book_id", book_id));
                    cmd.Parameters.Add(new SqlParameter("@return_date", return_date));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
        }
        public void add_student(int student_id, string name, string department, string phone_number, string email)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("add_student", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@student_id", student_id));
                    cmd.Parameters.Add(new SqlParameter("@student_name", name));
                    cmd.Parameters.Add(new SqlParameter("@department", department));
                    cmd.Parameters.Add(new SqlParameter("@phone_number", phone_number));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
        }
        public void update_student(int student_id, string name, string department, string phone_number, string email)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("update_student", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@student_id", student_id));
                    cmd.Parameters.Add(new SqlParameter("@student_name", name));
                    cmd.Parameters.Add(new SqlParameter("@department", department));
                    cmd.Parameters.Add(new SqlParameter("@phone_number", phone_number));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
        }
        public void delete_student(int student_id)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("delete_student", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@student_id", student_id));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
        }
        public Book search_book(int book_id)
        {
            Book book = new Book();
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("search_book", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@book_id", book_id));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            book = new Book(reader["book_name"].ToString(), reader["author"].ToString(), Convert.ToDateTime(reader["publication"]), Convert.ToDateTime(reader["purchase_date"]), Convert.ToDouble(reader["price"]));
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
            return book;
        }
        public Student search_student(int student_id)
        {
            Student student = new Student();
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("search_student", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@student_id", student_id));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            student = new Student(reader["name"].ToString(), Convert.ToInt32(reader["student_id"]), (reader["department"]).ToString(), (reader["phone_number"]).ToString(), (reader["email"]).ToString());
                        }
                        if (string.IsNullOrEmpty(student.name))
                        {
                            MessageBox.Show("Id not found");
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return student;
        }
        public DataTable display_issued_table()
        {
            DataTable datatable = new DataTable();
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("display_issued_book", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
            return datatable;
        }
        public DataTable display_returned_table()
        {
            DataTable datatable = new DataTable();
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("returned_book_table", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
            return datatable;
        }
        public DataTable display_book_table(int book_id)
        {
            DataTable datatable = new DataTable();
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("display_book_table", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@book_id", book_id));
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
            return datatable;
        }
        public DataTable display_student_table(int student_id)
        {
            DataTable datatable = new DataTable();
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("display_student_table", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@student_id", student_id));
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
            return datatable;
        }
        public int check_user(string username, string password)
        {
            int i = 0;
            try
            {
                OpenConnection();
                    using (SqlCommand cmd = new SqlCommand("check_user", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@username", username));
                        cmd.Parameters.Add(new SqlParameter("@password", password));

                        SqlParameter returnValue = new SqlParameter();
                        returnValue.Direction = ParameterDirection.ReturnValue;
                        returnValue.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(returnValue);
                        cmd.ExecuteNonQuery();
                        i = (int)returnValue.Value;
                    }
            }
            finally
            {
                CloseConnection();
            }
            return i;
        }
        public void add_staff(string fname, string lname, string email, int salary, DateTime date_of_birth, bool admin)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("add_staff", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@fname", fname));
                    cmd.Parameters.Add(new SqlParameter("@lname", lname));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@salary", salary));
                    cmd.Parameters.Add(new SqlParameter("@date_of_birth", date_of_birth));
                    cmd.Parameters.Add(new SqlParameter("@admin", admin ? 1 : 0));

                    cmd.ExecuteNonQuery();
                }
            }
            finally { CloseConnection(); }

        }
        public void update_staff(int id,string fname, string lname, string email, int salary, DateTime date_of_birth, bool admin)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("update_staff", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@fname", fname));
                    cmd.Parameters.Add(new SqlParameter("@lname", lname));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@salary", salary));
                    cmd.Parameters.Add(new SqlParameter("@date_of_birth", date_of_birth));
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.Parameters.Add(new SqlParameter("@admin", admin ? 1 : 0));


                    cmd.ExecuteNonQuery();
                }
            }
            finally { CloseConnection(); }

        }
        public void delete_staff(int id)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("remove_staff", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    cmd.ExecuteNonQuery();
                }
            }
            finally { CloseConnection(); }

        }
        public void check_if_staff_is_empty()
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("dbo.SeedDefaultStaff", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }
            finally { CloseConnection(); }

        }

        public DataTable display_staff_table(int id)
        {
            DataTable datatable = new DataTable();
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("display_staff", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id",id));
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
            return datatable;
        }

        public void log_out()
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("log_out", connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
        }

        public Staff search_staff(int staff_id)
        {
            Staff staff = new Staff();
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("search_staff", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id", staff_id));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            staff = new Staff(Convert.ToInt32(reader["staff_id"]), (reader["staff_fname"]).ToString(), (reader["staff_lname"]).ToString(), (reader["staff_email"]).ToString(), Convert.ToDouble(reader["salary"]), Convert.ToDateTime(reader["date_of_birth"]), (reader["username"]).ToString(), (reader["password"]).ToString(), Convert.ToBoolean(reader["admin"]));
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }

            return staff;
        }

        public int currently_logged()
        {
            int i = 0;
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("currently_logged_staff_id", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(returnValue);
                    cmd.ExecuteNonQuery();
                    i = (int)returnValue.Value;
                }
            }
            catch(Exception ex) 
            {
                    MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return i;
        }

        public void change_password(int id, string password)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand("change_password", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@staff_id", id));
                    cmd.Parameters.Add(new SqlParameter("@password", password));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
        }



    }

}

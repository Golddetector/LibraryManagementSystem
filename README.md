- Update Connection String

Before running the application, you must update the SQL Server connection string
Open Class1.cs and DatabaseHelper.cs.
Locate the connection string variable.

Replace the placeholders with your server name, database name, username, and password.
EX.
string connectionString = "Server=YOUR_SERVER_NAME;Database=library_managment;Trusted_Connection=True;";

- Username and Password
When you first open the application:
A default staff account is automatically created if no staff exists.

Default Staff
  First Name:	Alex
  Last Name: Hunter
  Date of Birth: 21/02/2000
  Email: alexhunter@gmail.com

-Username: first character of first name + full last name + 1
If multiple staff have the same first and last name, the number increments (2, 3, …) for uniqueness.
Ex,
Username: AHunter1


-Password: first 2 characters of first name + first 2 characters of last name + day of birth (DD)
Ex,
Password: AlHu21

## Update the Connection String

Before running the application, you must update the SQL Server connection string.

1. Open both `Class1.cs` and `DatabaseHelper.cs`.
2. Locate the connection string variable.
3. Replace the placeholder values with your SQL Server name, database name, username, and password as needed.

Example using Windows Authentication:

```csharp
string connectionString = "Server=YOUR_SERVER_NAME;Database=library_managment;Trusted_Connection=True;";
```

Make sure `YOUR_SERVER_NAME` is replaced with the name of your SQL Server instance.

## Default Username and Password

When the application is opened for the first time, a default staff account will automatically be created if no staff accounts already exist in the database.

**Default Staff Account**

* First Name: Alex
* Last Name: Hunter
* Date of Birth: 21/02/2000
* Email: [alexhunter@gmail.com](mailto:alexhunter@gmail.com)

### Username Format

The username is created using:

**First letter of the first name + full last name + number**

If multiple staff members have the same first and last name, the number will increase to keep each username unique.

Example:

**Username:** `AHunter1`

If `AHunter1` already exists, the next username would be `AHunter2`, then `AHunter3`, and so on.

### Password Format

The password is created using:

**First 2 letters of the first name + first 2 letters of the last name + day of birth (DD)**

For Alex Hunter, born on 21/02/2000:

**Password:** `AlHu21`

Therefore, the default login credentials are:

**Username:** `AHunter1`
**Password:** `AlHu21`

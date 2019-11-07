## Intro to Database

- Intro to ADO.NET
- Connection with `sqlserver` database
- use of `DataTable` - Used to create the data table to reflect the changes
- use of `DataSet` - 
- use of `DataReader`
- use of `DataAdaptor`
- use of `SqlCommand`

### CRUD operations

CRUD stands for

- Create()
- Read()
- Update()
- Delete()

### Example Connection String

> String connection = "Data Source=(local);Initial Catalog=MySchool;Integrated Security=True;Asynchronous Processing=true;";

### Example Snippet -1

The following code creates a `SqlCommand` and a `SqlConnection`. The SqlConnection is opened and set as the `Connection` for the SqlCommand. The code then calls `ExecuteNonQuery`. To accomplish this, the ExecuteNonQuery is passed a connection string and a query string that is a Transact-SQL INSERT statement. The connection is closed automatically when the code exits the using block.

```C#
    private static void CreateCommand(string queryString, string connectionString)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
        } // after this block connection will automatically close and dispose
    }
```

### Example Snippet -2

The following example creates a `SqlConnection`, a SqlCommand, and a SqlDataReader. The example reads through the data, writing it to the console. Finally, the example closes the `SqlDataReader` and then the SqlConnection as it exits the Using code blocks

```C#

    private static void ReadOrderData(string connectionString)
    {
        string queryString = "SELECT OrderID, CustomerID FROM dbo.Orders;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);

            connection.Open();

            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}, {1}",reader[0], reader[1]));
                }
            }
        }
    }
```

### Example Snippet-3

```C#

static void HasRows(SqlConnection connection)
{
    using (connection)
    {
        string query = "SELECT CategoryID, CategoryName FROM Categories;"

        SqlCommand command = new SqlCommand(query, connection);
        connection.Open();

        SqlDataReader reader = command.ExecuteReader(); // ExecuteReader is a valid data reader
        // check data has rows or not
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                    reader.GetString(1));
            }
        }
        else
        {
            Console.WriteLine("No rows found.");
        }
        reader.Close(); // must close the connection after DataReader
    }
}

```

### DataTable and Dataset Usage

```C#

private void MakeTable()
   {
       // Create a new DataTable.
       System.Data.DataTable table = new DataTable("Table");
       // Declare variables for DataColumn and DataRow objects.
       DataColumn column;
       DataRow row;

       // Create new DataColumn, set DataType, 
       // ColumnName and add to DataTable.    
       column = new DataColumn();
       column.DataType = System.Type.GetType("System.Int32");
       column.ColumnName = "id";
       column.ReadOnly = true;
       column.Unique = true;
       // Add the Column to the DataColumnCollection.
       table.Columns.Add(column);

       // Make the ID column the primary key column.
       DataColumn[] PrimaryKeyColumns = new DataColumn[1];
       PrimaryKeyColumns[0] = table.Columns["id"];
       table.PrimaryKey = PrimaryKeyColumns;

       // Instantiate the DataSet variable.
       dataSet = new DataSet();
       // Add the new DataTable to the DataSet.
       dataSet.Tables.Add(table);

       // Create three new DataRow objects and add 
       // them to the DataTable
       for (int i = 0; i<= 2; i++)
       {
           row = table.NewRow();
           row["id"] = i;
           row["ParentItem"] = "ParentItem " + i;
           table.Rows.Add(row);
       }
   }

```

**Note**: Follow link for `CRUD` operations [CRUD-OPERATIONS](https://www.c-sharpcorner.com/blogs/crud-operation-in-c-sharp-application)
using Microsoft.Data.Sqlite;
string connectionString = "Data Source=Tienda.db;";

// Crear conexión a la base de datos
using (SqliteConnection connection = new SqliteConnection(connectionString))
{
    connection.Open();
    // Crear tabla si no existe
    // por lo general este tipo de consultas no se implementa en un porgrama real
    // la aplicamos para poder crear nuestra base de datos desde cero
    /*  string createTableQuery = "CREATE TABLE IF NOT EXISTS productos (id INTEGER PRIMARY KEY, nombre TEXT, precio REAL)";
      using (SqliteCommand createTableCmd = new SqliteCommand(createTableQuery, connection))
      {
          createTableCmd.ExecuteNonQuery();
          Console.WriteLine("Tabla 'productos' creada o ya existe.");
      }

      // Insertar datos
      string insertQuery = "INSERT INTO productos (nombre, precio) VALUES ('Manzana', 0.50), ('Banana', 0.30)";
              using (SqliteCommand insertCmd = new SqliteCommand(insertQuery, connection))
              {
                  insertCmd.ExecuteNonQuery();
                  Console.WriteLine("Datos insertados en la tabla 'productos'.");
              }*/


    //Agregar un producto
   /* string insertQuery = "INSERT INTO Productos (Descripcion, Precio) VALUES ('Teclado Aitech', 7000)";
    using (SqliteCommand insertCmd = new SqliteCommand(insertQuery, connection))
    {
        insertCmd.ExecuteNonQuery();
        Console.WriteLine("Dato insertado en la tabla Productos");
    }
    // Leer datos
    string selectQuery = "SELECT * FROM Productos";
    using (SqliteCommand selectCmd = new SqliteCommand(selectQuery, connection))
    using (SqliteDataReader reader = selectCmd.ExecuteReader())
    {
        Console.WriteLine("Datos en la tabla 'productos':");
        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader["idProducto"]}, Descripcion: {reader["Descripcion"]}, Precio: {reader["Precio"]}");
        }
    }*/

  /*  string insertQuery = "INSERT INTO Presupuestos (NombreDestinatario, FechaCreacion) VALUES ('Juan Perez', '2024-10-24')";
    using (SqliteCommand insertCmd = new SqliteCommand(insertQuery, connection))
    {
        insertCmd.ExecuteNonQuery();
        Console.WriteLine("Dato insertado en la tabla Presupuestos");
    }
    // Leer datos
    string selectQuery = "SELECT * FROM Presupuestos";
    using (SqliteCommand selectCmd = new SqliteCommand(selectQuery, connection))
    using (SqliteDataReader reader = selectCmd.ExecuteReader())
    {
        Console.WriteLine("Datos en la tabla 'presupuestos':");
        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader["idPresupuesto"]}, Destinatario: {reader["NombreDestinatario"]}, Fecha : {reader["FechaCreacion"]}");
        }
    }*/

    string updateQuery = "UPDATE Productos SET Precio = 80000 WHERE idProducto = 1";
    using (SqliteCommand updateCmd = new SqliteCommand(updateQuery, connection))
    {
        updateCmd.ExecuteNonQuery();
        Console.WriteLine("Dato modificado en la tabla Productos");
        int filasAfectadas = updateCmd.ExecuteNonQuery();
        Console.WriteLine($"Filas modificadas: {filasAfectadas}");
    }


    connection.Close();
}


/*
Nota: En caso que no te reconozca los comando relacionados a SQLite ejecuta para
que te agregue la librería al proyecto
● dotnet add package Microsoft.Data.SQLite
*/
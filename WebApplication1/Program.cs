using Npgsql;
using System;

public class DatabaseCreator
{
    private static string connectionString = "Host=your_host_name;Username=your_username;Password=your_password;";

    public static void CreateDatabaseAndTable(string database, string User)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            string createDatabaseQuery = $"CREATE DATABASE \"{database}\"";
            using (NpgsqlCommand command = new NpgsqlCommand(createDatabaseQuery, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine($"Database '{database}' created successfully.");
            }

            connection.ConnectionString = $"{connectionString}Database={database};";

            string createTableQuery = $"CREATE TABLE \"{User}\" (" +
                                      "id SERIAL PRIMARY KEY," +
                                      "first_name TEXT NOT NULL," +
                                      "last_name TEXT NOT NULL," +
                                      "created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP," +
                                      "updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP)";
            using (NpgsqlCommand command = new NpgsqlCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine($"Table '{User}' created successfully.");
            }
        }
    }
}
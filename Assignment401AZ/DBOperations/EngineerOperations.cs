using Assignment401AZ.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment401AZ.DBOperations
{
    internal class EngineerOperations
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public void AddEngineers(Engineers engineer)
        {
            string query = "CALL AddEngineers(p_firstname, @p_lastname, @p_dateofbirth, @p_tel, @p_addressid)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_firstname", engineer.FirstName);
            command.Parameters.AddWithValue("@p_lastname", engineer.LastName);
            command.Parameters.AddWithValue("@p_dateofbirth", engineer.Dateofbirth.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@p_tel", engineer.Tel);
            command.Parameters.AddWithValue("@p_email", engineer.AddressID);

            dataAccess.ExecuteNonQuery(command);
        }

        public DataTable GetEngineerss()
        {
            string query = "CALL GetEngineerss()";
            return dataAccess.ExecuteQuery(query);
        }

        public void UpdateEngineers(Engineers engineer)
        {
            string query = "CALL UpdateEngineers(@p_id, @p_firstname, @p_lastname, @p_email, @p_dateofbirth)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_id", engineer.EngineerID);
            command.Parameters.AddWithValue("@p_firstname", engineer.FirstName);
            command.Parameters.AddWithValue("@p_lastname", engineer.LastName);
            command.Parameters.AddWithValue("@p_dateofbirth", engineer.Dateofbirth.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@p_tel", engineer.Tel);
            command.Parameters.AddWithValue("@p_email", engineer.AddressID);


            dataAccess.ExecuteNonQuery(command);
        }

        public void DeleteEngineers(int engineerId)
        {
            string query = "CALL DeleteEngineers(@p_id)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_id", engineerId);

            dataAccess.ExecuteNonQuery(command);
        }

    }

}

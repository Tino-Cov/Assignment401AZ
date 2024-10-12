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
    internal class ProjectManagerOperations
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public void AddProjectManager(ProjectManager projectManager)
        {
            string query = "CALL AddProjectManager(@p_first, @p_lastname, @p_dateofbirth, @p_tel, @p_emailaddress)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_firstname", projectManager.FirstName);
            command.Parameters.AddWithValue("@p_lastname", projectManager.LastName);
            command.Parameters.AddWithValue("@p_dateofbirth", projectManager.Dateofbirth.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@p_tel", projectManager.Tel);
            command.Parameters.AddWithValue("@p_email", projectManager.EmailAddress);


            dataAccess.ExecuteNonQuery(command);
        }

        public DataTable GetProjectManagers()
        {
            string query = "CALL GetProjectManagers()";
            return dataAccess.ExecuteQuery(query);
        }

        public void UpdateProjectManager(ProjectManager projectManager)
        {
            string query = "CALL UpdateProjectManager(@p_id, @p_firstname, @p_lastname, @p_email, @p_dateofbirth)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_id", projectManager.ManagerID);
            command.Parameters.AddWithValue("@p_firstname", projectManager.FirstName);
            command.Parameters.AddWithValue("@p_lastname", projectManager.LastName);
            command.Parameters.AddWithValue("@p_dateofbirth", projectManager.Dateofbirth.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@p_tel", projectManager.Tel);
            command.Parameters.AddWithValue("@p_email", projectManager.EmailAddress);

            dataAccess.ExecuteNonQuery(command);
        }

        public void DeleteProjectManager(int projectManagerID)
        {
            string query = "CALL DeleteProjectManager(@p_id)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_id", projectManagerID);

            dataAccess.ExecuteNonQuery(command);
        }

    }

}


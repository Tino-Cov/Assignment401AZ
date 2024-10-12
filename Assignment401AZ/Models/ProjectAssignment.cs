using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Assignment401AZ.Models
{
    public class ProjectAssignment : ProjectManager , ProjectFiles
    {

       public int ProjectName { get; set; }

       public int ProjectId { get; set; }

       public string ProjectAddress { get; set; }

       public int ManagerID { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace Assignment401AZ.Models
{
    public class ProjectManager 
    {
        private int ManagerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dateofbirth { get; set; }
        public int Tel { get; set; }
        public string EmailAddress { get; set; }

        
    }
}

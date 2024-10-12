﻿using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Assignment401AZ.Models
{
    public class ProjectFiles : ProjectManager , Engineers
    {
        public int ProjectID { get; set; }

        public string ProjectName { get; set; } 

        public DateTime ProjectStart {  get; set; }

        public DateTime ProjectEnd { get; set; }

        public string ProjectAddress { get; set; }

        public int EngineerID { get; set; }

        public int ManagerID { get; set; }

    }
}

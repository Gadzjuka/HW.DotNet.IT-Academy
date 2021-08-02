using System;
using System.Collections.Generic;
using System.Text;

namespace HW08.Task3.Interface
{    
    interface IEngineer
    {
        public static int baseSalary = 500;

        public Guid Identifier { get ; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Experience { get; set; }
        public List<string> Responsibilities { get; set; }
        public List<string> Technologies { get; set; }
        public string GitAccount { get; set; }
        public string Company { get; set; }
        public string Title { get; }
        public short TitleImportance { get; }

        public int GetSalary();
        public string GetResponsibilities();
        public void ShowInformation();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP_Object_Approach
{
    public sealed class Teacher:Students,IRole
    {
        public int ID { get; set; }
        public  Designation Designations { get; set; }
        public DateTime JoinDate { get; set; }

        List<string> _roles = new List<string>();
        public void AddRole(string Role)
        {
            _roles.Add(Role);
        }

        public string RolePlays()
        {
           return string.Join(",",_roles.ToArray());
        }
    }
}

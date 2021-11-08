using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentApi.Entities
{
    public enum Gender
    {
        female = 0,
        male = 1,
        other = 2
    }
    public class Account
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string avatar { get; set; }
        public Gender gender { get; set; }
        public string email { get; set; }
        public DateTime birthday { get; set; }
    }
}

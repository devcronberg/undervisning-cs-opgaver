using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNuGetPackage
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Height { get; set; }
        public bool IsHealthy { get; set; }
        public int CountryId { get; set; }
        public Gender Gender { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNuGetPackage
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Captial { get; set; }



        public Country Clone()
        {
            return this.MemberwiseClone() as Country;
        }
    }
}

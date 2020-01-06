using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DM.GraphQlDemo.Entities
{
    public class Column : ObjectInstance
    {
        public bool IsCalculated { get; set; }
        public Property PropertyRef { get; set; }
        public string Expression { get; set; }
        public string Criteria { get; set; }
        public string DisplayFormat { get; set; }
        public Metadata[] Metadata { get; set; }
    }
}

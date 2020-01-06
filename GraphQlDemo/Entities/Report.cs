using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DM.GraphQlDemo.Entities
{
    public class Report : ObjectInstance
    {
        public Column[] Columns { get; set; }
    }
}

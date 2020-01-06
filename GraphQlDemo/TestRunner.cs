using DM.GraphQlDemo.Queries.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DM.GraphQlDemo
{
    public class TestRunner
    {
        public static void Main()
        {
            Activator.CreateInstance(typeof(PropertyType));
            Activator.CreateInstance(typeof(ColumnType));
        }
    }
}

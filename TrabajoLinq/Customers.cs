using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoLinq
{
    public partial class Customers
    {
        public string NombresCompletos()
        {
            return ContactName + "   " + ContactTitle;

        }
    }
}
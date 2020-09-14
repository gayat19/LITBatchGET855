using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntriFrameworkExampleProject.Models
{
    public class OrderSortWithShipCity : IComparer<Order>
    {
        public int Compare(Order x, Order y)
        {
            return x.ShipCity.CompareTo(y.ShipCity);
        }
    }
}
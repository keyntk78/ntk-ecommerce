using System;
using System.Collections.Generic;
using System.Text;

namespace NTKEcommerce.Orders
{
    public enum OrderStatus
    {
        New,
        Confirmed,
        Processing,
        Shipping,
        Finished,
        Canceled
    }
}

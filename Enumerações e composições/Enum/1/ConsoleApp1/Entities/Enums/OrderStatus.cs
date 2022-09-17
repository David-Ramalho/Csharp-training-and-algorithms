using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Sipped = 2,
        Delivered = 3
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NTKEcommerce.Orders
{
    public enum TransactionType
    {
        ConfirmOrder,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}

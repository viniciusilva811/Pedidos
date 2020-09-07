using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos.Entidades.Enumerados
{
    
        enum StatusPedido : int
        {
            PendingPayment = 0,
            Processing = 1,
            Shipped = 2,
            Delivered = 3
        }
    }



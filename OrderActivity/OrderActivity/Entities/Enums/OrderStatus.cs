namespace OrderActivity.Entities.Enums
{
    enum OrderStatus : int
        //enumeração status do pedido
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}

namespace Provider.Data
{
    public  enum CreditType
    {
        SalesReturn,
        PostSaleDiscount,
        CorrectionInInvoice,
        Other

    }
    public enum PaymentType
    {
        Cash,
        Bank,
        Cheque,
        CashMemo,
        CreditCard,
        PaySlip,
        Other
    }
    public enum CashFlow
    {
        Inflow,
        Outflow
    }
    public enum Measure
    {
        Kg,
        Piece,
        Box,
        Inche,
        Ton,
        Meter,
        Litre,
        Gram,
        CentiMeter

    }
}
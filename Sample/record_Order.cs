//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample
{
    using System;
    using System.Collections.Generic;
    
    public partial class record_Order
    {
        public long ID { get; set; }
        public string OrderNo { get; set; }
        public string GoodsName { get; set; }
        public int TotalFee { get; set; }
        public decimal CanCashOutFee { get; set; }
        public short PayWayID { get; set; }
        public byte Status { get; set; }
        public string PaidAccount { get; set; }
        public string Mark { get; set; }
        public System.DateTime AddedTime { get; set; }
        public Nullable<System.DateTime> PayTime { get; set; }
        public string TradeNo { get; set; }
        public long AreaID { get; set; }
        public string GameAccount { get; set; }
        public string BuyerQQ { get; set; }
        public string BuyerEmail { get; set; }
        public string BuyerMobile { get; set; }
    }
}
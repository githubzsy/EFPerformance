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
    
    public partial class record_CashOutOrder
    {
        public string OrderNo { get; set; }
        public string BatchNo { get; set; }
        public string ReceiverEmail { get; set; }
        public string ReceiverName { get; set; }
        public decimal Amount { get; set; }
        public string SuccessTag { get; set; }
        public string SuccessMsg { get; set; }
        public string FailTag { get; set; }
        public string FailMsg { get; set; }
        public string UserName { get; set; }
        public string Mark { get; set; }
        public string TradeNo { get; set; }
        public Nullable<System.DateTime> CompleteTime { get; set; }
        public string AlipayAccount { get; set; }
        public string AlipayRealName { get; set; }
    }
}

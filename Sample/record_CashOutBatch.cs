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
    
    public partial class record_CashOutBatch
    {
        public string BatchNo { get; set; }
        public short BatchNum { get; set; }
        public decimal BatchFee { get; set; }
        public System.DateTime AddedTime { get; set; }
        public bool IsAuto { get; set; }
        public string AppliedUserName { get; set; }
        public Nullable<System.DateTime> SubmitedTime { get; set; }
        public byte StatusId { get; set; }
        public byte TargetTypeId { get; set; }
        public string Mark { get; set; }
    }
}
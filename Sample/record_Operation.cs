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
    
    public partial class record_Operation
    {
        public long ID { get; set; }
        public int GroupNum { get; set; }
        public byte OperationTypeId { get; set; }
        public byte OperationWayId { get; set; }
        public string ClientIp { get; set; }
        public string SourceLink { get; set; }
        public Nullable<int> ForeignKeyId { get; set; }
        public string Mark { get; set; }
        public System.DateTime AddedTime { get; set; }
    }
}

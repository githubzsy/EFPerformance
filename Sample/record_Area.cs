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
    
    public partial class record_Area
    {
        public long ID { get; set; }
        public long AreaNum { get; set; }
        public string AreaKey { get; set; }
        public int GroupID { get; set; }
        public string Name { get; set; }
        public string ClientIp { get; set; }
        public string ClientMobile { get; set; }
        public string GameDir { get; set; }
        public string RechargeDir { get; set; }
        public System.DateTime AddedTime { get; set; }
        public int AddedBy { get; set; }
        public bool IsValid { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int Sort { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime OpenTime { get; set; }
        public byte EngineID { get; set; }
        public string AfterYuanbaoScript { get; set; }
        public string AttachBonus { get; set; }
        public string ScoreBonus { get; set; }
    }
}
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
    
    public partial class sys_User
    {
        public int ID { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public string SPassword { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string RealName { get; set; }
        public string AlipayAccount { get; set; }
        public byte Status { get; set; }
        public System.DateTime AddedTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public bool IsAdmin { get; set; }
        public string UserKey { get; set; }
        public Nullable<short> BankCodeId { get; set; }
        public string BankAccount { get; set; }
        public string BankAccountName { get; set; }
        public string BankCertId { get; set; }
        public byte ManageThemeId { get; set; }
        public byte RechargeThemeId { get; set; }
        public string BackGroundImgUrl { get; set; }
        public byte PageSize { get; set; }
        public byte RequireQQ { get; set; }
        public byte RequireEmail { get; set; }
        public byte RequireMobile { get; set; }
        public bool ShowMsgBoard { get; set; }
        public bool ShowServiceQQ { get; set; }
        public string ServiceQQ { get; set; }
        public string RechargeMsg { get; set; }
        public int MinRechargeAmount { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public partial class P1_User_Detail
    {
        public int id { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string sex { get; set; }
        public string tel { get; set; }
        public string address { get; set; }
        public string Ssn { get; set; }
        public System.DateTime bdate { get; set; }

        [JsonIgnore]
        public virtual P1_User_Account P1_User_Account { get; set; }
    }
}
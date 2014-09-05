//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIS.AutoEnt.DataContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrgUser
    {
        public OrgUser()
        {
            this.OrgGroups = new HashSet<OrgGroup>();
            this.OrgRoles = new HashSet<OrgRole>();
            this.SysAuths = new HashSet<SysAuth>();
        }
    
        public System.Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Tag { get; set; }
        public System.Guid MetadataId { get; set; }
        public string LoginName { get; set; }
    
        public virtual ICollection<OrgGroup> OrgGroups { get; set; }
        public virtual ICollection<OrgRole> OrgRoles { get; set; }
        public virtual ICollection<SysAuth> SysAuths { get; set; }
    }
}

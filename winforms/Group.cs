//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace winforms
{
    using System;
    using System.Collections.Generic;
    
    public partial class Group
    {
        public Group()
        {
            this.Students = new HashSet<Student>();
        }
    
        public string Name { get; set; }
        public string Specialisation { get; set; }
    
        public virtual ICollection<Student> Students { get; set; }
    }
}
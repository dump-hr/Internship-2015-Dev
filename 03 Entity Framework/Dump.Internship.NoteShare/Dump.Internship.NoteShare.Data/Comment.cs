//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dump.Internship.NoteShare.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int NoteId { get; set; }
        public int UserId { get; set; }
    
        public virtual Note Note { get; set; }
        public virtual User User { get; set; }
    }
}

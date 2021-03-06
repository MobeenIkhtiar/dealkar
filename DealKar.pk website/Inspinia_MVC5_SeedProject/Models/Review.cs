
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Inspinia_MVC5_SeedProject.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Review
{

    public Review()
    {

        this.ReviewReplies = new HashSet<ReviewReply>();

        this.ReviewVotes = new HashSet<ReviewVote>();

    }


    public int Id { get; set; }

    public int companyId { get; set; }

    public string reviewedBy { get; set; }

    public int rating { get; set; }

    public string description { get; set; }

    public System.DateTime time { get; set; }



    public virtual ICollection<ReviewReply> ReviewReplies { get; set; }

    public virtual ICollection<ReviewVote> ReviewVotes { get; set; }

    public virtual AspNetUser AspNetUser { get; set; }

    public virtual Company Company { get; set; }

}

}

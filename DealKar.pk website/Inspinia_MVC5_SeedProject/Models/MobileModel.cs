
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
    
public partial class MobileModel
{

    public MobileModel()
    {

        this.MobileAds = new HashSet<MobileAd>();

    }


    public int Id { get; set; }

    public int brandId { get; set; }

    public string model { get; set; }

    public System.DateTime time { get; set; }

    public string addedBy { get; set; }

    public string status { get; set; }



    public virtual Mobile Mobile { get; set; }

    public virtual ICollection<MobileAd> MobileAds { get; set; }

    public virtual AspNetUser AspNetUser { get; set; }

}

}

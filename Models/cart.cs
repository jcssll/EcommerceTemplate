using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace AcitoEcommerce.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }//created an Id property
        // a so called auto property Get and Set are accessors - they're able to access data and info in private fields
        //get can only read information from that private field and return it
        //set can only write information in that private field- uses an implicit variable 
        //by having both get and set we are using both functions at the same damn time

        public string CartId { get; set; }

        public int ProductId { get; set; }

        public int Count { get; set; }
        [Column(TypeName = "datetime2")]
        //

        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}
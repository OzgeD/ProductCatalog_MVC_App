using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductCatalog.Entity
{
    public class Category
    {
        public int Id { get; set; }

        //Data Annotations
        [DisplayName("Category Name")]
        [StringLength(20, ErrorMessage = "You can enter up to 20 characters.")]
        public string Name { get; set; }

        [DisplayName("Category Description")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
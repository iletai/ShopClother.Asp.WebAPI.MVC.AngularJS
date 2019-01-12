﻿using Flower.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flower.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        public int ID { set; get; }

        public string Name { set; get; }
        public string Alias { set; get; }
        public string Description { set; get; }
        public int ParentID { set; get; }
        public int DisplayOrder { set; get; }
        public string Image { set; get; }
        public bool Status { set; get; }
        public bool? HomeFlag { set; get; }
    }
}
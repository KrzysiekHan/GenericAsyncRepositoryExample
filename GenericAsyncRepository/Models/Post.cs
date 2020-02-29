using GenericAsyncRepository.Abstraction;
using GenericAsyncRepository.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GenericAsyncRepository.Models
{
    public class Post : IAuditable
    {
        [Key]
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime TimeStamp { get; set; }
        public Blog Blog { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

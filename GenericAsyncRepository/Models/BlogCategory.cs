using GenericAsyncRepository.Abstraction;
using GenericAsyncRepository.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GenericAsyncRepository.Models
{
    public class BlogCategory : IAuditable
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Blog> Blogs { get; set; } = new HashSet<Blog>();

        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

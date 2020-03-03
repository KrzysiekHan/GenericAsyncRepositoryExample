using GenericAsyncRepository.Abstraction;
using GenericAsyncRepository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace GenericAsyncRepository.EntityFramework
{
    public class Blog : IAuditable
    {
        [Key]
        public int BlogId { get; set; }
        public string Title { get; set; }
        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();
        public ICollection<BlogCategory> Blogs { get; set; } = new HashSet<BlogCategory>();

        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

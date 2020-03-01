using System;
using System.ComponentModel.DataAnnotations;

namespace GenericAsyncRepository.Models
{
    public class BlogDetail
    {
        [Key]
        public int BlogId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Url { get; set; }
    }
}

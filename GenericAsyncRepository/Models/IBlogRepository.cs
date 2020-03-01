using GenericAsyncRepository.Abstraction;
using GenericAsyncRepository.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAsyncRepository.Models
{
    public interface IBlogRepository : IGenericRepository<Blog>
    {
        Blog Get(int blogId);
    }
}

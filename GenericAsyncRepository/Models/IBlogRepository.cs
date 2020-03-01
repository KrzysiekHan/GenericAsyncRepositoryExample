using GenericAsyncRepository.Abstraction;
using GenericAsyncRepository.EntityFramework;

namespace GenericAsyncRepository.Models
{
    public interface IBlogRepository : IGenericRepository<Blog>
    {
        new Blog Get(int blogId);
    }
}

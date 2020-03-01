using GenericAsyncRepository.Abstraction;
using GenericAsyncRepository.EntityFramework;
using System.Linq;
using System.Threading.Tasks;

namespace GenericAsyncRepository.Models
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        public BlogRepository(DataContext context) : base(context) { }

        public new Blog Get(int blogId)
        {
            var query = GetAll().FirstOrDefault(b => b.BlogId == blogId);
            return query;
        }
        public async Task<Blog> GetSingleAsync(int blogId)
        {
            return await _context.Set<Blog>().FindAsync(blogId);
        }
        public override Blog Update(Blog t, object key)
        {
            Blog exist = _context.Set<Blog>().Find(key);
            if (exist != null)
            {
                t.CreatedBy = exist.CreatedBy;
                t.CreatedOn = exist.CreatedOn;
            }
            return base.Update(t, key);
        }

        public async override Task<Blog> UpdateAsync(Blog t, object key)
        {
            Blog exist = await _context.Set<Blog>().FindAsync(key);
            if (exist != null)
            {
                t.CreatedBy = exist.CreatedBy;
                t.CreatedOn = exist.CreatedOn;
            }
            return await base.UpdateAsync(t, key);
        }
    }

}

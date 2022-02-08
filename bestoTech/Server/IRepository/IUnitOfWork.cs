using bestoTech.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace bestoTech.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Brand> Brands { get; }
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<AStore> AStores { get; }
        IGenericRepository<ALink> ALinks { get; }
}
}
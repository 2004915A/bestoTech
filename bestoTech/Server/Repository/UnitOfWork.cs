using bestoTech.Server.Data;
using bestoTech.Server.IRepository;
using bestoTech.Server.Models;
using bestoTech.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace bestoTech.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Product> _products;
        private IGenericRepository<ProductCategory> _productcategories;
        private IGenericRepository<BrandCategory> _brandcategories;
        private IGenericRepository<Category> _categories;
        private IGenericRepository<Brand> _brands;
        private IGenericRepository<AStore> _astores;
        private IGenericRepository<ALink> _alinks;
        private IGenericRepository<Review> _reviews;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Product> Products
            => _products ??= new GenericRepository<Product>(_context);
        public IGenericRepository<ProductCategory> ProductCategories
            => _productcategories ??= new GenericRepository<ProductCategory>(_context);
        public IGenericRepository<BrandCategory> BrandCategories
            => _brandcategories ??= new GenericRepository<BrandCategory>(_context);
        public IGenericRepository<Category> Categories
            => _categories ??= new GenericRepository<Category>(_context);
        public IGenericRepository<Brand> Brands
            => _brands ??= new GenericRepository<Brand>(_context);
        public IGenericRepository<AStore> AStores
            => _astores ??= new GenericRepository<AStore>(_context);
        public IGenericRepository<ALink> ALinks
            => _alinks ??= new GenericRepository<ALink>(_context);
        public IGenericRepository<Review> Reviews
            => _reviews ??= new GenericRepository<Review>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            await _context.SaveChangesAsync();
        }
    }
}
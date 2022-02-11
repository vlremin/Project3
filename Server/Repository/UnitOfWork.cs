
//using Project3.Server.Data;
//using Project3.Server.IRepository;
//using Project3.Server.Models;
//using Project3.Shared.Domain;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Threading.Tasks;

//namespace Project3.Server.Repository
//{
//    public class UnitOfWork : IUnitOfWork
//    {
//        private readonly ApplicationDbContext _context;
//        private IGenericRepository<Route> _routes;
//        private IGenericRepository<Trip> _trips;
//        private IGenericRepository<Staff> _staffs;
//        private IGenericRepository<Traveller> _travellers;
//        private UserManager<ApplicationUser> _userManager;

//        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
//        {
//            _context = context;
//            _userManager = userManager;
//        }

//        public IGenericRepository<Route> Routes
//            => _routes ??= new GenericRepository<Route>(_context);
//        public IGenericRepository<Trip> Trips
//            => _trips ??= new GenericRepository<Trip>(_context);
//        public IGenericRepository<Staff> Staffs
//            => _staffs ??= new GenericRepository<Staff>(_context);
//        public IGenericRepository<Traveller> Travellers
//           => _travellers ??= new GenericRepository<Traveller>(_context);
        

  

//        public void Dispose()
//        {
//            _context.Dispose();
//            GC.SuppressFinalize(this);
//        }

//        public async Task Save(HttpContext httpContext)
//        {
//            //To be implemented
//            //string user = "System";
//            var userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
//            var user = await _userManager.FindByIdAsync(userId);

//            var entries = _context.ChangeTracker.Entries()
//                .Where(q => q.State == EntityState.Modified ||
//                    q.State == EntityState.Added);

//            foreach (var entry in entries)
//            {
//                ((BaseDomainModel)entry.Entity).DateUpdate = DateTime.Now;
//                ((BaseDomainModel)entry.Entity).UpdateBy = user;
//                if (entry.State == EntityState.Added)
//                {
//                    ((BaseDomainModel)entry.Entity).DateCreate = DateTime.Now;
//                    ((BaseDomainModel)entry.Entity).CreateBy = user;
//                }
//            }

//            await _context.SaveChangesAsync();
//        }
//    }
//}
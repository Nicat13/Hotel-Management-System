using Hotel.entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.entity.DAL
{
    public partial class HotelDB : DbContext
    {
        public HotelDB() : base("hotelmanagementdb") { }
        public DbSet<AdditionalServices> AdditionalServices { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AppUsers> AppUsers { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerServices> CustomerServices { get; set; }
        public DbSet<PaymentTypes> PaymentTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomTypes> RoomTypes { get; set; }
        public DbSet<RoomStatus> RoomStatuses { get; set; }

        public DbSet<Satisfaction> Satisfactions { get; set; }
        public DbSet<Transactions> Transactions { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasMany(t => t.Reservations).WithRequired(a => a.Customer).WillCascadeOnDelete(false);
        }
    }
}

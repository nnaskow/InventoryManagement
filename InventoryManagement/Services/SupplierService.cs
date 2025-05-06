using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services
{
    public class SupplierService
    {
        private readonly InventoryManagementContext _context;

        public SupplierService()
        {
            _context = new InventoryManagementContext();
        }

        public void AddSupplier(string name, string contactName, string phone, string email)
        {
            var supplier = new Supplier
            {
                Name = name,
                ContactName = contactName,
                Phone = phone,
                Email = email
            };

            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void ListSuppliers()
        {
            var suppliers = _context.Suppliers.ToList();

            foreach (var supplier in suppliers)
            {
                Console.WriteLine($"ID: {supplier.SupplierId}, Име: {supplier.Name}, Контакт: {supplier.ContactName}, Телефон: {supplier.Phone}, Email: {supplier.Email}");
            }
        }

        public Supplier GetSupplierById(int id)
        {
            return _context.Suppliers.FirstOrDefault(s => s.SupplierId == id);
        }

        public void EditSupplier(int id, string name, string contactName, string phone, string email)
        {
            var supplier = _context.Suppliers.FirstOrDefault(s => s.SupplierId == id);

            if (supplier == null)
            {
                Console.WriteLine("Доставчикът не е намерен.");
                return;
            }

            supplier.Name = name;
            supplier.ContactName = contactName;
            supplier.Phone = phone;
            supplier.Email = email;

            _context.SaveChanges();
        }

        public void DeleteSupplier(int id)
        {
            var supplier = _context.Suppliers.FirstOrDefault(s => s.SupplierId == id);

            if (supplier == null)
            {
                Console.WriteLine("Доставчикът не е намерен.");
                return;
            }

            _context.Suppliers.Remove(supplier);
            _context.SaveChanges();
        }
        public List<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }
    }
}

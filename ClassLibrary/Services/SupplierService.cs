using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services
{
    /// <summary>
    /// Услуга за управление на доставчици в системата за инвентаризация.
    /// </summary>
    public class SupplierService
    {
        /// <summary>
        /// Добавя нов доставчик в базата данни.
        /// </summary>
        /// <param name="name">Име на фирмата доставчик.</param>
        /// <param name="contactName">Име на контактното лице.</param>
        /// <param name="phone">Телефонен номер.</param>
        /// <param name="email">Имейл адрес.</param>
        public void AddSupplier(string name, string contactName, string phone, string email)
        {
            var supplier = new Supplier
            {
                Name = name,
                ContactName = contactName,
                Phone = phone,
                Email = email
            };

            using (var _context = new InventoryManagementContext())
            {
                _context.Suppliers.Add(supplier);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Извежда в конзолата списък с всички доставчици.
        /// </summary>
        public void ListSuppliers()
        {
            using (var _context = new InventoryManagementContext())
            {
                var suppliers = _context.Suppliers.ToList();

                foreach (var supplier in suppliers)
                {
                    Console.WriteLine($"ID: {supplier.SupplierId}, Име: {supplier.Name}, Контакт: {supplier.ContactName}, Телефон: {supplier.Phone}, Email: {supplier.Email}");
                }
            }
        }

        /// <summary>
        /// Връща доставчик по зададен идентификатор.
        /// </summary>
        /// <param name="id">ID на доставчика.</param>
        /// <returns>Обект Supplier или null, ако не е намерен.</returns>
        public Supplier GetSupplierById(int id)
        {
            using (var _context = new InventoryManagementContext())
            {
                return _context.Suppliers.FirstOrDefault(s => s.SupplierId == id);
            }
        }

        /// <summary>
        /// Редактира съществуващ доставчик по зададено ID.
        /// </summary>
        /// <param name="id">ID на доставчика.</param>
        /// <param name="name">Ново име на фирмата.</param>
        /// <param name="contactName">Ново контактно лице.</param>
        /// <param name="phone">Нов телефон.</param>
        /// <param name="email">Нов имейл.</param>
        public void EditSupplier(int id, string name, string contactName, string phone, string email)
        {
            using (var _context = new InventoryManagementContext())
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
        }

        /// <summary>
        /// Изтрива доставчик по зададено ID.
        /// </summary>
        /// <param name="id">ID на доставчика.</param>
        public void DeleteSupplier(int id)
        {
            using (var _context = new InventoryManagementContext())
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
        }

        /// <summary>
        /// Връща списък с всички доставчици.
        /// </summary>
        /// <returns>Списък от обекти Supplier.</returns>
        public List<Supplier> GetAllSuppliers()
        {
            using (var _context = new InventoryManagementContext())
            {
                return _context.Suppliers.ToList();
            }
        }
    }
}

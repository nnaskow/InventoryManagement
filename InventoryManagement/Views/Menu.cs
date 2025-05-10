using InventoryManagement.Models;
using InventoryManagement.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace InventoryManagement.Views
{
    public class Menu
    {
        private static SupplierService _supplierService = new SupplierService();
        private static ProductService _productService = new ProductService();
        private static CategoryService _categoryService = new CategoryService();
        private static TransactionService _transactionService = new TransactionService();

        string a = "/";
        string b = "\\";
        string c = "__";
        string d = "|";

        public Menu()
        {
/*            LoadingAnimation();
            Thread.Sleep(1000);*/
            MenuDesign();
        }
        public static void MenuDesign()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("         ИНВЕНТАРНА СИСТЕМА");
                Console.WriteLine("=======================================");
                Console.WriteLine("| [1] Продуктов мениджмънт           |");
                Console.WriteLine("| [2] Управление на категории        |");
                Console.WriteLine("| [3] Транзакции                     |");
                Console.WriteLine("| [4] Доставчици                     |");
                Console.WriteLine("| [5] Отчети                         |");
                Console.WriteLine("|------------------------------------|");
                Console.WriteLine("| [x] Изход от системата             |");
                Console.WriteLine("=======================================");
                Console.Write("Изберете опция: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ProductMenu();
                        break;
                    case "2":
                        CategoryMenu();
                        break;
                    case "3":
                        TransactionMenu();
                        break;
                    case "4":
                        SupplierMenu();
                        break;
                    case "5":
                        ReportMenu();
                        break;
                    case "x":
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Невалиден избор. Натиснете клавиш за продължение...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        //Функционалности на менюто с продукти
        private static void AddProduct()
        {
            Console.Clear();

            var categories = _categoryService.GetAllCategories();
            var suppliers = _supplierService.GetAllSuppliers();
         
            Console.WriteLine("\n--- Добави продукт ---");

            Console.Write("Име на продукта: ");
            var name = Console.ReadLine();
            Console.Clear();
            if (categories.Count == 0)
            {
                Console.WriteLine("Няма категории.");
            }
            else
            {
                Console.WriteLine("---Списък с категории---");
                foreach (var c in categories)
                {
                    Console.WriteLine($"ID: {c.CategoryId}, Име: {c.Name}");
                }
            }
            Console.WriteLine("\n--- Добави продукт ---");
            Console.WriteLine($"Име на продукта: {name}");
            Console.Write("Категория (въведете ID): ");
            var categoryId = int.Parse(Console.ReadLine());

            Console.Clear();
            if(suppliers.Count == 0)
            {
                Console.WriteLine("Няма доставчици.");
            }
            else
            {
                Console.WriteLine("---Списък с доставчици---");
                foreach (var s in suppliers)
                {
                    Console.WriteLine($"ID: {s.SupplierId}, Име: {s.Name}");
                }
            }
            Console.WriteLine("\n--- Добави продукт ---");
            Console.WriteLine($"Име на продукта: {name}");
            Console.WriteLine($"Категория (въведете ID): {categoryId}");
            Console.Write("Доставчик (въведете ID): ");
            var supplierId = int.Parse(Console.ReadLine());

            Console.Write("Количество: ");
            var quantity = int.Parse(Console.ReadLine());

            Console.Write("Цена: ");
            var price = decimal.Parse(Console.ReadLine());
           
            Console.Write("Последна актуализация: ");
            DateOnly lastUpdated = DateOnly.Parse(Console.ReadLine());

            _productService.AddProduct(name, categoryId, supplierId, quantity, price, lastUpdated);

            var productId = _productService.GetLastInsertedProductId();

            _transactionService.AddTransaction(productId, "IN", quantity, DateOnly.FromDateTime(DateTime.Now));

            Console.WriteLine("Продуктът беше добавен и транзакцията беше записана!");
            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за продукти: [b]");
            var input = Console.ReadLine();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    ProductMenu();
                    break;
            }
        }
        private static void ListProducts()
        {
            Console.Clear();
            Console.WriteLine("=== Лист с продукти ===");

            var products = _productService.GetAllProducts();

            if (products.Count == 0)
            {
                Console.WriteLine("Няма налични продукти.");
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"ID: {product.ProductId} | Име: {product.Name} | Категория: {product.Category.Name} | Доставчик: {product.Supplier.Name} | Цена: {product.Price}");
                }
            }
            Console.WriteLine("===============================");
            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за продукти: [b]");
            var input = Console.ReadLine();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    ProductMenu();
                    break;
            }
        }
        private static void EditProduct()
        {
            Console.Clear();
            var products = _productService.GetAllProduct();
            var categories = _categoryService.GetAllCategories();
            var suppliers = _supplierService.GetAllSuppliers();
            if (products.Count == 0)
            {
                Console.WriteLine("Няма продукти.");
            }
            else
            {
                Console.WriteLine("---Списък с продукти---");
                foreach (var p in products)
                {
                    Console.WriteLine($"ID: {p.ProductId}, Име: {p.Name}");
                }
            }
         
            Console.WriteLine("\n--- Редактиране на продукт ---");

            Console.Write("Въведи ID на продукта за редактиране: ");
            var productId = int.Parse(Console.ReadLine());

            var product = _productService.GetProductById(productId);

            if (product != null)
            {
                Console.Write("Новото име на продукта: ");
                var newName = Console.ReadLine();
                
                Console.Clear();
                if (categories.Count == 0)
                {
                    Console.WriteLine("Няма категории.");
                }
                else
                {
                    Console.WriteLine("---Списък с категории---");
                    foreach (var c in categories)
                    {
                        Console.WriteLine($"ID: {c.CategoryId}, Име: {c.Name}");
                    }
                }
                Console.WriteLine("\n--- Редактиране на продукт ---");
                Console.WriteLine($"Въведи ID на продукта за редактиране: {productId}");
                Console.WriteLine($"Новото име на продукта: {newName}");

                Console.Write("Нова категория (въведете ID): ");
                var newCategoryId = int.Parse(Console.ReadLine());

                Console.Clear();
                if (suppliers.Count == 0)
                {
                    Console.WriteLine("Няма доставчици.");
                }
                else
                {
                    Console.WriteLine("---Списък с доставчици---");
                    foreach (var s in suppliers)
                    {
                        Console.WriteLine($"ID: {s.SupplierId}, Име: {s.Name}");
                    }
                }
                Console.WriteLine("\n--- Редактиране на продукт ---");
                Console.WriteLine($"Въведи ID на продукта за редактиране: {productId}");
                Console.WriteLine($"Новото име на продукта: {newName}");
                Console.WriteLine($"Нова категория (въведете ID): {newCategoryId}");
                Console.Write("Нов доставчик (въведете ID): ");
                var newSupplierId = int.Parse(Console.ReadLine());

                Console.Write("Ново количество: ");
                var newQuantity = int.Parse(Console.ReadLine());

                Console.Write("Нова цена: ");
                var newPrice = decimal.Parse(Console.ReadLine());

                Console.Write("Нова дата на последна актуализация (YYYY-MM-DD): ");
                var newLastUpdated = DateOnly.Parse(Console.ReadLine());

                _productService.EditProduct(productId, newName, newCategoryId, newSupplierId, newQuantity, newPrice, newLastUpdated);

                Console.WriteLine("Продуктът беше редактиран!");
            }
            else
            {
                Console.WriteLine("Продуктът с такова ID не съществува.");
            }

            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за продукти: [b]");
            var input = Console.ReadLine();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    ProductMenu();
                    break;
            }
        }
        private static void DeleteProduct()
        {
            Console.Clear();
            var products = _productService.GetAllProducts();

            if (products.Count == 0)
            {
                Console.WriteLine("Няма продукти.");
            }
            else
            {
                Console.WriteLine("---Списък с продукти---");
                foreach (var p in products)
                {
                    Console.WriteLine($"ID: {p.ProductId}, Име: {p.Name}");
                }
            }

            Console.WriteLine("--- Изтриване на продукт ---");
            Console.Write("\nВъведи ID на продукта за изтриване: ");
            var productId = int.Parse(Console.ReadLine());

            _productService.DeleteProduct(productId);

            Console.WriteLine("Продуктът беше изтрит!");
            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за продукти: [b]");
            var input = Console.ReadLine();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    ProductMenu();
                    break;
            }
        }

        //Функционалности на менюто с категории
        private static void AddCategory()
        {
            Console.Clear();
            Console.WriteLine("--- Добавяне на категория ---\n");

            Console.Write("Име на категорията: ");
            var name = Console.ReadLine();

            _categoryService.AddCategory(name);

            Console.WriteLine("\nКатегорията беше добавена успешно!");
            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за категории: [b]");
            var input = Console.ReadLine();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    CategoryMenu();
                    break;
                default:
                    MenuDesign();
                    break;
            }
        }
        private static void ListCategories()
        {
            Console.Clear();
            Console.WriteLine("--- Списък с категории ---\n");

            var categories = _categoryService.GetAllCategories();

            if (categories.Count == 0)
            {
                Console.WriteLine("Няма въведени категории.");
            }
            else
            {
                foreach (var category in categories)
                {
                    Console.WriteLine($"ID: {category.CategoryId}, Име: {category.Name}");
                }
            }

            Console.WriteLine("\nВръщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за категории: [b]");
            var input = Console.ReadLine();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    CategoryMenu();
                    break;
                default:
                    MenuDesign();
                    break;
            }
        }
        private static void EditCategory()
        {
            Console.Clear();
            Console.WriteLine("--- Редактиране на категория ---\n");

            var categories = _categoryService.GetAllCategories();
            if (categories.Count == 0)
            {
                Console.WriteLine("Няма категории.");
                Console.WriteLine("Връщане към началното меню: [r]");
                Console.WriteLine("Връщане към менюто за категории: [b]");
                var inputEmpty = Console.ReadLine();
                switch (inputEmpty)
                {
                    case "r":
                        MenuDesign();
                        return;
                    case "b":
                        CategoryMenu();
                        return;
                    default:
                        MenuDesign();
                        return;
                }
            }

            foreach (var category in categories)
            {
                Console.WriteLine($"ID: {category.CategoryId}, Име: {category.Name}");
            }

            Console.Write("\nВъведи ID на категорията за редактиране: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Ново име на категорията: ");
            var newName = Console.ReadLine();

            _categoryService.EditCategory(id, newName);

            Console.WriteLine("\nКатегорията беше редактирана успешно!");
            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за категории: [b]");
            var input = Console.ReadLine();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    CategoryMenu();
                    break;
                default:
                    MenuDesign();
                    break;
            }
        }
        private static void DeleteCategory()
        {
            Console.Clear();
            Console.WriteLine("--- Изтриване на категория ---\n");

            var categories = _categoryService.GetAllCategories();
            if (categories.Count == 0)
            {
                Console.WriteLine("Няма категории.");
                Console.WriteLine("Връщане към началното меню: [r]");
                Console.WriteLine("Връщане към менюто за категории: [b]");
                var inputEmpty = Console.ReadLine();
                switch (inputEmpty)
                {
                    case "r":
                        MenuDesign();
                        return;
                    case "b":
                        CategoryMenu();
                        return;
                    default:
                        MenuDesign();
                        return;
                }
            }

            foreach (var category in categories)
            {
                Console.WriteLine($"ID: {category.CategoryId}, Име: {category.Name}");
            }

            Console.Write("\nВъведи ID на категорията за изтриване: ");
            var id = int.Parse(Console.ReadLine());

            _categoryService.DeleteCategory(id);

            Console.WriteLine("\nКатегорията беше изтрита успешно!");
            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за категории: [b]");
            var input = Console.ReadLine();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    CategoryMenu();
                    break;
                default:
                    MenuDesign();
                    break;
            }
        }

        //Функционалности на менюто с транзакции
        private static void AddTransaction()
        {
            int maxDots = 3;
            Console.Clear();
            Console.WriteLine("Продукти:");
            var products = _productService.GetAllProduct();

            if (products == null || products.Count == 0)
            {
                Console.WriteLine("Няма налични продукти.");
                return;
            }

            foreach (var p in products)
            {
                Console.WriteLine($"ID: {p.ProductId}, Име: {p.Name}");
            }

            Console.WriteLine("--- Добави транзакция ---");

            Console.Write("Продукт (въведете ID): ");
            if (!int.TryParse(Console.ReadLine(), out int productId))
            {
                ReturnToMenuAnimation("Невалидно ID на продукт.",maxDots);
                return;
            }

            Console.Write("Тип на транзакцията (например 'покупка', 'продажба'): ");
            var transactionType = Console.ReadLine();

            if (transactionType == "покупка")
            {
                transactionType = "IN";
            }
            else if (transactionType == "продажба")
            {
                transactionType = "OUT";
            }
            else
            {
                ReturnToMenuAnimation("Грешно въведени данни.",maxDots);
                return;
            }

            Console.Write("Количество: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity))
            {
                ReturnToMenuAnimation("Невалидно количество.",maxDots);
                return;
            }

            var product = _productService.GetProductById(productId);
            if (product == null)
            {
                ReturnToMenuAnimation("Несъществуващ продукт.",maxDots);
                return;
            }

            if (transactionType == "OUT" && quantity > product.Quantity)
            {
                ReturnToMenuAnimation("Недостатъчно количество",maxDots);
                return;
            }

            Console.Write("Дата на транзакцията (YYYY-MM-DD): ");
            if (!DateOnly.TryParse(Console.ReadLine(), out DateOnly transactionDate))
            {
                ReturnToMenuAnimation("Невалиден формат на датата.",maxDots);
                return;
            }

            _transactionService.AddTransaction(productId, transactionType, quantity, transactionDate);

            Console.WriteLine("Транзакцията беше добавена!");
            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за транзакции: [b]");
            var input = Console.ReadLine();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    TransactionMenu();
                    break;
            }
        }
        private static void ViewTransactions()
        {
            var transactions = _transactionService.GetAllTransactions();

            Console.Clear();
            Console.WriteLine("Желате ли да разпределите транзакциите в две различни таблици ( IN, OUT )?: *ДА/НЕ*");
            var inp = Console.ReadLine().ToUpper();
            if(inp =="ДА")
            {
                Console.Clear();
                Console.WriteLine("--- Преглед на транзакции ---");
                if (transactions.Count == 0)
                {
                    Console.WriteLine("Няма транзакции.");
                }
                else
                {
                    Console.WriteLine("----IN----");
                    foreach (var transaction in transactions)
                    {
                        var productName = transaction.Product != null ? transaction.Product.Name : "неизвестен продукт";
                        if (transaction.TransactionType == "IN")
                        {
                            Console.WriteLine($"ID: {transaction.TransactionId}, Продукт: {productName}, Добавено количество: {transaction.Quantity}, Тип на транзакцията: {transaction.TransactionType}, Дата: {transaction.TransactionDate}");
                        }                       
                    }
                    Console.WriteLine("----OUT----");
                    foreach (var transaction in transactions)
                    {
                        var productName = transaction.Product != null ? transaction.Product.Name : "неизвестен продукт";
                        if (transaction.TransactionType == "OUT")
                        {
                            Console.WriteLine($"ID: {transaction.TransactionId}, Продукт: {productName}, Премахнато количество: {transaction.Quantity}, Тип на транзакцията: {transaction.TransactionType}, Дата: {transaction.TransactionDate}");
                        }
                    }
                }
            }
            else if(inp =="НЕ")
            {
                Console.Clear();
              Console.WriteLine("--- Преглед на транзакции ---");
                     
              if (transactions.Count == 0)
              {
                 Console.WriteLine("Няма транзакции.");
              }
              else
              {
                foreach (var transaction in transactions)
                {
                    var productName = transaction.Product != null ? transaction.Product.Name : "неизвестен продукт";
                    if(transaction.TransactionType =="IN")
                    {
                       Console.WriteLine($"ID: {transaction.TransactionId}, Продукт: {productName}, Добавено количество: {transaction.Quantity}, Тип на транзакцията: {transaction.TransactionType}, Дата: {transaction.TransactionDate}");
                    }
                    else if(transaction.TransactionType == "OUT")
                    {
                        Console.WriteLine($"ID: {transaction.TransactionId}, Продукт: {productName}, Премахнато количество: {transaction.Quantity}, Тип на транзакцията: {transaction.TransactionType}, Дата: {transaction.TransactionDate}");
                    }
                }
            }
            }

            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за транзакции: [b]");
            var input = Console.ReadLine();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    TransactionMenu();
                    break;
            }
        }

        //Функционалности на менюто с доставчици
        private static void AddSupplier()
        {
            Console.Clear();
            Console.WriteLine("--- Добави доставчик ---");
            Console.Write("Име: ");
            var name = Console.ReadLine();
            Console.Write("Контактно лице: ");
            var contactName = Console.ReadLine();
            Console.Write("Телефон: ");
            var phone = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();

            _supplierService.AddSupplier(name, contactName, phone, email);
            Console.WriteLine("Доставчикът беше добавен!");
            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за доставчици: [b]");
            var input = Console.ReadLine();
            switch(input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    SupplierMenu();
                    break;
            }
        }

        private static void ViewSuppliers()
        {
            Console.Clear();
            Console.WriteLine("--- Списък с доставчици ---");
            _supplierService.ListSuppliers();
            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за доставчици: [b]");
            var input = Console.ReadLine();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    SupplierMenu();
                    break;
            }
        }

        private static void EditSupplier()
        {
            Console.Clear();
            var suppliers = _supplierService.GetAllSuppliers();

            if (suppliers.Count == 0)
            {
                Console.WriteLine("Няма доставчици.");
            }
            else
            {
                Console.WriteLine("---Списък с доставчици---");
                foreach (var supplier in suppliers)
                {
                    Console.WriteLine($"ID: {supplier.SupplierId}, Име: {supplier.Name}");
                }
            }
            Console.Write("\nВъведи ID на доставчика: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var supplier = _supplierService.GetSupplierById(id);
                if (supplier == null)
                {
                    Console.WriteLine("Не е намерен такъв доставчик.");
                }
                else
                {
                    Console.Write("Ново име: ");
                    var name = Console.ReadLine();
                    Console.Write("Ново контактно лице: ");
                    var contactName = Console.ReadLine();
                    Console.Write("Нов телефон: ");
                    var phone = Console.ReadLine();
                    Console.Write("Нов Email: ");
                    var email = Console.ReadLine();

                    _supplierService.EditSupplier(id, name, contactName, phone, email);
                    Console.WriteLine("Успешно редактиран.");
                }
            }
            else
            {
                Console.WriteLine("Невалидно ID.");
            }
            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за доставчици: [b]");
            var input = Console.ReadLine();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    SupplierMenu();
                    break;
            }
        }

        private static void DeleteSupplier()
        {
            Console.Clear();
            var suppliers = _supplierService.GetAllSuppliers();

            if (suppliers.Count == 0)
            {
                Console.WriteLine("Няма доставчици.");
            }
            else
            {
                Console.WriteLine("---Списък с доставчици---");
                foreach (var supplier in suppliers)
                {
                    Console.WriteLine($"ID: {supplier.SupplierId}, Име: {supplier.Name}");
                }
            }
            Console.Write("\nВъведи ID на доставчика за изтриване: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                _supplierService.DeleteSupplier(id);
                Console.WriteLine("Доставчикът беше изтрит.");
            }
            else
            {
                Console.WriteLine("Невалидно ID.");
            }
            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за доставчици: [b]");
            var input = Console.ReadLine();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    SupplierMenu();
                    break;
            }
        }

        //Функционалности на менюто с отчети
        private static void FullInventoryReport()
        {
            Console.Clear();
            Console.WriteLine("--- Пълен инвентар ---");

            var products = _productService.GetAllProducts();
            if (products.Count == 0)
            {
                Console.WriteLine("Няма продукти в инвентара.");
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"ID: {product.ProductId}, Име: {product.Name}, Категория: {product.Category.Name}, Цена: {product.Price}, Наличност: {product.Quantity}");
                }
            }

            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за отчети: [b]");
            var input = Console.ReadLine();

            if (input == "r")
            {
                MenuDesign();
            }
            else if (input == "b")
            {
                ReportMenu();
            }
            else
            {
                MenuDesign();
            }
        }

        private static void CategoryReport()
        {
            Console.Clear();
            Console.WriteLine("--- Отчет по категория ---");
            var allProducts = _productService.GetAllProducts();
            var allCatIds = allProducts.Select(p => p.CategoryId).Distinct().ToList();

            Console.Write("Въведете ID на категорията: ");
            Console.WriteLine("*Използвани ID-та: " + string.Join(", ", allCatIds));
            var categoryId = int.Parse(Console.ReadLine());

            var products = _productService.GetAllProducts().Where(p => p.CategoryId == categoryId).ToList();

            if (products.Count == 0)
            {
                Console.WriteLine("Няма продукти в тази категория.");
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"ID: {product.ProductId}, Име: {product.Name}, Цена: {product.Price}, Наличност: {product.Quantity}");
                }
            }

            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за отчети: [b]");
            var input = Console.ReadLine();

            if (input == "r")
            {
                MenuDesign();
            }
            else if (input == "b")
            {
                ReportMenu();
            }
            else
            {
                MenuDesign();
            }
        }

        private static void LowStockReport()
        {
            Console.Clear();
            Console.WriteLine("--- Ниски наличности (<5) ---");

            var lowStockProducts = _productService.GetAllProducts().Where(p => p.Quantity < 5).ToList();

            if (lowStockProducts.Count == 0)
            {
                Console.WriteLine("Няма продукти с ниски наличности.");
            }
            else
            {
                foreach (var product in lowStockProducts)
                {
                    Console.WriteLine($"ID: {product.ProductId}, Име: {product.Name}, Категория: {product.Category.Name}, Цена: {product.Price}, Наличност: {product.Quantity}");
                }
            }

            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine("Връщане към менюто за отчети: [b]");
            var input = Console.ReadLine();

            if (input == "r")
            {
                MenuDesign();
            }
            else if (input == "b")
            {
                ReportMenu();
            }
            else
            {
                MenuDesign();
            }
        }

        //Менюта
        private static void ProductMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine("   --- Управление на продукти ---    ");
                Console.WriteLine("=====================================");
                Console.WriteLine("| [1] Добави продукт                |");
                Console.WriteLine("| [2] Прегледай всички продукти     |");
                Console.WriteLine("| [3] Редактирай продукт            |");
                Console.WriteLine("| [4] Изтрий продукт                |");
                Console.WriteLine("|-----------------------------------|");
                Console.WriteLine("| [r] Назад                         |");
                Console.WriteLine("=====================================");
                Console.Write("Изберете опция: ");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        ListProducts();
                        break;
                    case "3":
                        EditProduct();
                        break;
                    case "4":
                        DeleteProduct();
                        break;
                    case "r":
                        return;
                    default:
                        Console.WriteLine("Невалиден избор. Натиснете клавиш за продължение...");
                        Console.ReadKey();
                        break;
                }
            }

        }
        private static void CategoryMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine("  --- Управление на категории ---    ");
                Console.WriteLine("=====================================");
                Console.WriteLine("| [1] Добави категория              |");
                Console.WriteLine("| [2] Прегледай всички категории    |");
                Console.WriteLine("| [3] Редактирай категория          |");
                Console.WriteLine("| [4] Изтрий категория              |");
                Console.WriteLine("|-----------------------------------|");
                Console.WriteLine("| [r] Назад                         |");
                Console.WriteLine("=====================================");
                Console.Write("Изберете опция: ");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddCategory();
                        break;
                    case "2":
                        ListCategories();
                        break;
                    case "3":
                        EditCategory();
                        break;
                    case "4":
                        DeleteCategory();
                        break;
                    case "r":
                        return;
                    default:
                        Console.WriteLine("Невалиден избор. Натиснете клавиш за продължение...");
                        Console.ReadKey();
                        break;
                }
            }

        }
        private static void SupplierMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("      --- Управление на доставчици ---     ");
                Console.WriteLine("===========================================");
                Console.WriteLine("| [1] Добави нов доставчик                |");
                Console.WriteLine("| [2] Прегледай всички доставчици         |");
                Console.WriteLine("| [3] Редактирай доставчик                |");
                Console.WriteLine("| [4] Изтрий доставчик                    |");
                Console.WriteLine("|-----------------------------------------|");
                Console.WriteLine("| [r] Назад                               |");
                Console.WriteLine("===========================================");
                Console.Write("Изберете опция: ");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddSupplier();
                        break;
                    case "2":
                        ViewSuppliers();
                        break;
                    case "3":
                        EditSupplier();
                        break;
                    case "4":
                        DeleteSupplier();
                        break;
                    case "r":
                        return;
                    default:
                        Console.WriteLine("Невалиден избор. Натиснете клавиш за продължение...");
                        Console.ReadKey();
                        break;
                }
            }

        }
        private static void TransactionMenu()
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("            --- Транзакции ---             ");
            Console.WriteLine("===========================================");
            Console.WriteLine("| [1] Добави нова транзакция              |");
            Console.WriteLine("| [2] Преглед на всички транзакции        |"); 
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("| [r] Назад                               |");
            Console.WriteLine("===========================================");
            Console.Write("Изберете опция: ");

            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddTransaction();
                    break;
                case "2":
                    ViewTransactions();
                    break;
                case "r":
                    MenuDesign();
                    break;
                default:
                    Console.WriteLine("Невалиден избор.");
                    Console.ReadKey();
                    break;
            }
        }
        private static void ReportMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("        --- Генериране на отчети ---       ");
                Console.WriteLine("===========================================");
                Console.WriteLine("| [1] Пълен инвентар                      |");
                Console.WriteLine("| [2] Отчет по категория                  |");
                Console.WriteLine("| [3] Ниски наличности                    |");
                Console.WriteLine("|-----------------------------------------|");
                Console.WriteLine("| [r] Назад                               |");
                Console.WriteLine("===========================================");
                Console.Write("Изберете опция: ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        FullInventoryReport();
                        break;
                    case "2":
                        CategoryReport();
                        break;
                    case "3":
                        LowStockReport();
                        break;
                    case "r":
                        return;
                    default:
                        Console.WriteLine("Невалиден избор.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        //Анимации
        private static void ReturnToMenuAnimation(string text,int maxDots)
        {
            for (int i = 1; i <= maxDots; i++)
            {
                Console.Clear();
                Console.WriteLine($"--------\n{text}\n--------\nВръщане към началното меню{DotsAnimation(i)}");
                Thread.Sleep(500);
            }

            for (int i = maxDots; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"--------\n{text}\n--------\nВръщане към началното меню{DotsAnimation(i)}");
                Thread.Sleep(500);
            }
        }
        public void LoadingAnimation()
        {
            Console.WriteLine("Зареждане....");
            double num = 0.3;

            while (num > 0)
            {
                for (int i = 1; i <= 2; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Зареждане{DotsAnimation(i)}");
                    Console.WriteLine(d);
                    Thread.Sleep(500);

                    Console.Clear();
                    Console.WriteLine($"Зареждане{DotsAnimation(i)}");
                    Console.WriteLine(a);
                    Thread.Sleep(500);

                    Console.Clear();
                    Console.WriteLine($"Зареждане{DotsAnimation(i)}");
                    Console.WriteLine(c);
                    Thread.Sleep(500);

                    Console.Clear();
                    Console.WriteLine($"Зареждане{DotsAnimation(i)}");
                    Console.WriteLine(b);
                    Thread.Sleep(500);
                    Console.Clear();
                }
                num = -num;
            }
        }

        public static string DotsAnimation(int count)
        {
            return new string('.', count);
        }
    }
}

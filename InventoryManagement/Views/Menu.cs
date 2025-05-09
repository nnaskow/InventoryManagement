using InventoryManagement.Models;
using InventoryManagement.Services;
using Microsoft.EntityFrameworkCore;
using System;
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
                Console.WriteLine("=== ИНВЕНТАРНА СИСТЕМА ===");
                Console.WriteLine("[1] Управление на продукти");
                Console.WriteLine("[2] Управление на категории");
                Console.WriteLine("[3] Управление на транзакции");
                Console.WriteLine("[4] Управление на доставчици");
                Console.WriteLine("[5] Генериране на отчети");
                Console.WriteLine("[x] Изход");
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
                        Console.WriteLine("Невалиден избор.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        //ProductFunctionality
        private static void AddProduct()
        {
            Console.Clear();
            var productIds = _productService.GetAllProductIds();
            var categories = _categoryService.GetAllCategories();
            var suppliers = _supplierService.GetAllSuppliers();

            int maxLength = Math.Max(categories.Count, suppliers.Count);

            Console.WriteLine("{0,-3} | {1,-25} | {2,-25}", "ID", "Category", "Supplier");
            Console.WriteLine(new string('-', 60));

            for (int i = 0; i < maxLength; i++)
            {
                string categoryName = i < categories.Count ? categories[i].Name : "";
                string supplierName = i < suppliers.Count ? suppliers[i].Name : "";

                Console.WriteLine("{0,-3} | {1,-25} | {2,-25}", i+1, categoryName, supplierName);
            }

            Console.WriteLine("\n--- Добави продукт ---");

            Console.Write("Име на продукта: ");
            var name = Console.ReadLine();

            Console.Write("Категория (въведете ID): ");
            var categoryId = int.Parse(Console.ReadLine());

            Console.Write("Доставчик (въведете ID): ");
            var supplierId = int.Parse(Console.ReadLine());

            Console.Write("Количество: ");
            var quantity = int.Parse(Console.ReadLine());

            Console.Write("Цена: ");
            var price = decimal.Parse(Console.ReadLine());

            _productService.AddProduct(name, categoryId, supplierId, quantity, price);

            Console.WriteLine("Продуктът беше добавен!");
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
            Console.WriteLine("--- Преглед на продукти ---");

            var products = _productService.GetAllProducts();

            if (products.Count == 0)
            {
                Console.WriteLine("Няма налични продукти.");
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"ID: {product.ProductId}, Име: {product.Name}, Категория: {product.Category.Name}, Цена: {product.Price}");
                }
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
        private static void EditProduct()
        {
            Console.Clear();
            var products = _productService.GetAllProduct();
            if (products.Count == 0)
            {
                Console.WriteLine("Няма продукти.");
            }
            else
            {
                Console.WriteLine("---Списък с продукти---");
                foreach (var p in products)
                {
                    Console.WriteLine($"ID: {p.SupplierId}, Име: {p.Name}");
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

                Console.Write("Нова категория (въведете ID): ");
                var newCategoryId = int.Parse(Console.ReadLine());

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
            var products = _productService.GetAllProduct();
            if (products.Count == 0)
            {
                Console.WriteLine("Няма продукти.");
            }
            else
            {
                Console.WriteLine("---Списък с продукти---");
                foreach (var p in products)
                {
                    Console.WriteLine($"ID: {p.SupplierId}, Име: {p.Name}");
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

        //CategoryFuncionality
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

        //TransactionFunctionality
        private static void AddTransaction()
        {
            Console.Clear();
            Console.WriteLine("--- Добави транзакция ---");

            Console.Write("Продукт (въведете ID): ");
            var productId = int.Parse(Console.ReadLine());

            Console.Write("Тип на транзакцията (например 'покупка', 'продажба'): ");
            var transactionType = Console.ReadLine();

            Console.Write("Количество: ");
            var quantity = int.Parse(Console.ReadLine());

            Console.Write("Дата на транзакцията (YYYY-MM-DD): ");
            var transactionDate = DateOnly.Parse(Console.ReadLine());

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
            Console.Clear();
            Console.WriteLine("--- Преглед на транзакции ---");

            var transactions = _transactionService.GetAllTransactions();

            if (transactions.Count == 0)
            {
                Console.WriteLine("Няма транзакции.");
            }
            else
            {
                foreach (var transaction in transactions)
                {
                    Console.WriteLine($"ID: {transaction.TransactionId}, Продукт: {transaction.Product.Name}, Променено количество: {transaction.Quantity}, Тип на транзакцията: {transaction.TransactionType}, Дата: {transaction.TransactionDate}");
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

        //SupplierFunctionality
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

        //ReportFunctionality
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

        //Menus
        private static void ProductMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Управление на продукти ---");
                Console.WriteLine("[1] Добави продукт");
                Console.WriteLine("[2] Прегледай продукти");
                Console.WriteLine("[3] Редактирай продукт");
                Console.WriteLine("[4] Изтрий продукт");
                Console.WriteLine("[r] Назад");
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
                        Console.WriteLine("Невалиден избор.");
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
                Console.WriteLine("--- Управление на категории ---");
                Console.WriteLine("[1] Добави категория");
                Console.WriteLine("[2] Прегледай категории");
                Console.WriteLine("[3] Редактирай категория");
                Console.WriteLine("[4] Изтрий категория");
                Console.WriteLine("[r] Назад");
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
                        Console.WriteLine("Невалиден избор.");
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
                Console.WriteLine("--- Управление на доставчици ---");
                Console.WriteLine("[1] Добави доставчик");
                Console.WriteLine("[2] Прегледай доставчици");
                Console.WriteLine("[3] Редактирай доставчик");
                Console.WriteLine("[4] Изтрий доставчик");
                Console.WriteLine("[r] Назад");
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
                        Console.WriteLine("Невалиден избор.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private static void ReportMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Отчети ---");
                Console.WriteLine("[1] Пълен инвентар");
                Console.WriteLine("[2] Отчет по категория");
                Console.WriteLine("[3] Ниски наличности");
                Console.WriteLine("[r] Назад");
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
        private static void TransactionMenu()
        {
            Console.Clear();
            Console.WriteLine("--- Меню за транзакции ---");
            Console.WriteLine("[1] Добави транзакция");
            Console.WriteLine("[2] Преглед на транзакции");
            Console.WriteLine("[r] Назад");
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

        //Animations
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

        public string DotsAnimation(int count)
        {
            return new string('.', count);
        }
    }
}

using InventoryManagement.Models;
using InventoryManagement.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace InventoryManagement.Views
{
    public class Menu
    {
        private static SupplierService _supplierService;
        private static ProductService _productService;
        private static CategoryService _categoryService;
        private static TransactionService _transactionService;

        static int maxDots = 3;
        string a = "/";
        string b = "\\";
        string c = "__";
        string d = "|";

        public Menu()
        {
            _transactionService = new TransactionService();
            _categoryService = new CategoryService();
            _productService = new ProductService();
            _supplierService = new SupplierService();
            LoadingAnimation();
            Thread.Sleep(1000);
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
                Console.WriteLine("| [4] Търсене и филтриране           |");
                Console.WriteLine("| [5] Доставчици                     |");
                Console.WriteLine("| [6] Отчети                         |");
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
                        SearchNFilterMenu();
                        break;
                    case "5":
                        SupplierMenu();
                        break;
                    case "6":
                        ReportMenu();
                        break;
                    case "x":
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Невалиден избор. Натиснете клавиш за да продължите...");
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

            Console.WriteLine("\n=== Добави продукт ===");

            Console.Write("Име на продукта: ");
            var name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Името на продукта не може да бъде празно.");
                ReturnToMenus("Менюто за продукти", ProductMenu);
                return;
            }
            Console.Clear();

            if (categories.Count == 0)
            {
                Console.WriteLine("Няма категории.");
                ReturnToMenus("Менюто за продукти", ProductMenu);
                return;
            }
            else
            {
                Console.WriteLine("=== Списък с категории ===");
                foreach (var c in categories)
                {
                    Console.WriteLine($"ID: {c.CategoryId}, Име: {c.Name}");
                }
            }

            Console.WriteLine("\n=== Добави продукт === ");
            Console.WriteLine($"Име на продукта: {name}");
            Console.Write("Категория (въведете ID): ");

            if (!int.TryParse(Console.ReadLine(), out int categoryId) || !categories.Any(c => c.CategoryId == categoryId))
            {
                Console.WriteLine("Невалиден или несъществуващ ID за категория.");
                ReturnToMenus("Менюто за продукти", ProductMenu);
                return;
            }

            Console.Clear();

            if (suppliers.Count == 0)
            {
                Console.WriteLine("Няма доставчици.");
                ReturnToMenus("Менюто за продукти", ProductMenu);
                return;
            }
            else
            {
                Console.WriteLine("=== Списък с доставчици ===");
                foreach (var s in suppliers)
                {
                    Console.WriteLine($"ID: {s.SupplierId}, Име: {s.Name}");
                }
            }

            Console.WriteLine("\n=== Добави продукт ===");
            Console.WriteLine($"Име на продукта: {name}");
            Console.WriteLine($"Категория (въведете ID): {categoryId}");
            Console.Write("Доставчик (въведете ID): ");

            if (!int.TryParse(Console.ReadLine(), out int supplierId) || !suppliers.Any(s => s.SupplierId == supplierId))
            {
                Console.WriteLine("Невалиден или несъществуващ ID за доставчик.");
                ReturnToMenus("Менюто за продукти", ProductMenu);
                return;
            }

            Console.Write("Количество: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 0)
            {
                Console.WriteLine("Невалидно количество.");
                ReturnToMenus("Менюто за продукти", ProductMenu);
                return;
            }

            Console.Write("Цена: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal price) || price < 0)
            {
                Console.WriteLine("Невалидна цена.");
                ReturnToMenus("Менюто за продукти", ProductMenu);
                return;
            }

            Console.WriteLine("Желаете ли да използвате днешна дата за въвеждане на поле *ПОСЛЕДНА АКТУАЛИЗАЦИЯ*?: *ДА/НЕ*");
            var inputYN = Console.ReadLine().ToUpper();

            DateOnly lastUpdt;

            if (inputYN == "ДА")
            {
                lastUpdt = DateOnly.FromDateTime(DateTime.Now);
            }
            else if (inputYN == "НЕ")
            {
                Console.Write("Данни на последна актуализация (YYYY-MM-DD): ");
                var inputDate = Console.ReadLine();
                if (!DateOnly.TryParse(inputDate, out lastUpdt))
                {
                    Console.WriteLine("Невалиден формат на датата.");
                    ReturnToMenus("Менюто за продукти", ProductMenu);
                    return;
                }
            }
            else
            {
                Console.WriteLine("Невалиден отговор. Моля, въведете ДА или НЕ.");
                ReturnToMenus("Менюто за продукти", ProductMenu);
                return;
            }

            _productService.AddProduct(name, categoryId, supplierId, quantity, price, lastUpdt);

            var productId = _productService.GetLastInsertedProductId();

            _transactionService.AddTransactionForINEntriesOnly(productId, "IN", quantity, DateOnly.FromDateTime(DateTime.Now));

            Console.WriteLine("Продуктът беше добавен и транзакцията беше записана!");
            Console.WriteLine("=============================");
            ReturnToMenus("Менюто за продукти", ProductMenu);
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
            Console.WriteLine("============================");
            ReturnToMenus("Менюто за продукти", ProductMenu);
        }
        private static void EditProduct()
        {
            Console.Clear();
            var products = _productService.GetAllProducts();
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

            int productId;
            while (true)
            {
                Console.Write("Въведи ID на продукта за редактиране: ");
                if (int.TryParse(Console.ReadLine(), out productId))
                    break;
                Console.WriteLine("Невалидно ID. Опитайте отново.");
            }

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

                int newCategoryId;
                while (true)
                {
                    Console.Write("Нова категория (въведете ID): ");
                    if (int.TryParse(Console.ReadLine(), out newCategoryId) &&
                        categories.Any(c => c.CategoryId == newCategoryId))
                        break;
                    Console.WriteLine("Невалидно ID на категория. Опитайте отново.");
                }

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

                int newSupplierId;
                while (true)
                {
                    Console.Write("Нов доставчик (въведете ID): ");
                    if (int.TryParse(Console.ReadLine(), out newSupplierId) &&
                        suppliers.Any(s => s.SupplierId == newSupplierId))
                        break;
                    Console.WriteLine("Невалидно ID на доставчик. Опитайте отново.");
                }

                int newQuantity;
                while (true)
                {
                    Console.Write("Ново количество: ");
                    if (int.TryParse(Console.ReadLine(), out newQuantity) && newQuantity >= 0)
                        break;
                    Console.WriteLine("Невалидно количество. Въведете положително цяло число.");
                }

                decimal newPrice;
                while (true)
                {
                    Console.Write("Нова цена: ");
                    if (decimal.TryParse(Console.ReadLine(), out newPrice) && newPrice >= 0)
                        break;
                    Console.WriteLine("Невалидна цена. Въведете положително десетично число.");
                }

                DateOnly newLastUpdated;
                while (true)
                {
                    Console.Write("Нова дата на последна актуализация (YYYY-MM-DD): ");
                    if (DateOnly.TryParse(Console.ReadLine(), out newLastUpdated))
                        break;
                    Console.WriteLine("Невалиден формат на дата. Опитайте отново.");
                }

                _productService.EditProduct(productId, newName, newCategoryId, newSupplierId, newQuantity, newPrice, newLastUpdated);

                Console.WriteLine("Продуктът беше редактиран!");
            }
            else
            {
                Console.WriteLine("Продуктът с такова ID не съществува.");
            }

            Console.WriteLine("=============================");
            ReturnToMenus("Менюто за продукти", ProductMenu);
        }
        private static void DeleteProduct()
        {
            Console.Clear();
            var products = _productService.GetAllProducts();

            if (products.Count == 0)
            {
                Console.WriteLine("Няма продукти.");
                ReturnToMenus("Менюто за продукти", ProductMenu);
                return;
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

            int productId;
            while (true)
            {
                Console.Write("\nВъведи ID на продукта за изтриване: ");
                var input = Console.ReadLine();
                if (!int.TryParse(input, out productId))
                {
                    Console.WriteLine("Невалидно ID. Моля, въведете число.");
                    continue;
                }
                if (!products.Any(p => p.ProductId == productId))
                {
                    Console.WriteLine("Продукт с такова ID не съществува. Опитайте пак.");
                    continue;
                }
                break;
            }

            _productService.DeleteProduct(productId);

            Console.WriteLine("Продуктът беше изтрит успешно.");
            Console.WriteLine("=============================");
            ReturnToMenus("Менюто за продукти", ProductMenu);
        }


        //Функционалности на менюто с категории
        private static void AddCategory()
        {
            Console.Clear();
            Console.WriteLine("--- Добавяне на категория ---\n");

            Console.Write("Име на категорията: ");
            var name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Името на категорията не може да бъде празно.");
                ReturnToMenus("Менюто за Категории", CategoryMenu);
                return;
            }

            _categoryService.AddCategory(name);

            Console.WriteLine("\nКатегорията беше добавена успешно!");
            Console.WriteLine("=============================");
            ReturnToMenus("Менюто за Категории", CategoryMenu);
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
            Console.WriteLine("=============================");
            ReturnToMenus("Менюто за Категории", CategoryMenu);
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

            int id;
            while (true)
            {
                Console.Write("\nВъведи ID на категорията за редактиране: ");
                var inputId = Console.ReadLine();

                if (!int.TryParse(inputId, out id))
                {
                    Console.WriteLine("Невалиден формат на ID. Моля, въведете число.");
                    continue;
                }

                if (!categories.Any(c => c.CategoryId == id))
                {
                    Console.WriteLine("Категория с такова ID не съществува. Опитайте отново.");
                    continue;
                }
                break;
            }

            string newName;
            while (true)
            {
                Console.Write("Ново име на категорията: ");
                newName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(newName))
                {
                    Console.WriteLine("Името не може да бъде празно. Опитайте отново.");
                    continue;
                }
                break;
            }

            _categoryService.EditCategory(id, newName);

            Console.WriteLine("\nКатегорията беше редактирана успешно!");
            Console.WriteLine("=============================");
            ReturnToMenus("Менюто за Категории", CategoryMenu);
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

            int id;
            while (true)
            {
                Console.Write("\nВъведи ID на категорията за изтриване: ");
                var input = Console.ReadLine();
                if (!int.TryParse(input, out id))
                {
                    Console.WriteLine("Невалидно ID. Моля, въведете число.");
                    continue;
                }
                if (!categories.Any(c => c.CategoryId == id))
                {
                    Console.WriteLine("Категория с такова ID не съществува. Опитайте отново.");
                    continue;
                }
                break;
            }

            Console.Write($"Сигурни ли сте, че искате да изтриете категорията с ID {id}? (да/не): ");
            var confirm = Console.ReadLine()?.Trim().ToLower();
            if (confirm == "да" || confirm == "д" || confirm == "yes" || confirm == "y")
            {
                _categoryService.DeleteCategory(id);
                Console.WriteLine("\nКатегорията беше изтрита успешно!");
            }
            else
            {
                Console.WriteLine("\nИзтриването беше отказано.");
            }

            Console.WriteLine("=============================");
            ReturnToMenus("Менюто за Категории", CategoryMenu);
        }

        //Функционалности на менюто с транзакции

        private static void AddTransaction()
        {
            Console.Clear();
            Console.WriteLine("Продукти:");
            var products = _productService.GetAllProducts();

            if (products == null || products.Count == 0)
            {
                Console.WriteLine("Няма налични продукти.");
                ReturnToMenus("Менюто за транзакции", TransactionMenu);
                return;
            }

            foreach (var p in products)
            {
                Console.WriteLine($"ID: {p.ProductId}, Име: {p.Name}");
            }

            Console.WriteLine("=== Добави транзакция ===");

            int productId;
            while (true)
            {
                Console.Write("Продукт (въведете ID): ");
                if (int.TryParse(Console.ReadLine(), out productId) && products.Any(p => p.ProductId == productId))
                    break;
                Console.WriteLine("Невалидно или несъществуващо ID на продукт. Опитайте отново.");
            }

            string transactionType;
            while (true)
            {
                Console.Write("Тип на транзакцията (покупка/продажба): ");
                var inputType = Console.ReadLine()?.Trim().ToLower();

                if (inputType == "покупка")
                {
                    transactionType = "IN";
                    break;
                }
                else if (inputType == "продажба")
                {
                    transactionType = "OUT";
                    break;
                }
                else
                {
                    Console.WriteLine("Грешен тип на транзакция. Въведете 'покупка' или 'продажба'.");
                }
            }

            int quantity;
            while (true)
            {
                Console.Write("Количество: ");
                if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                    break;
                Console.WriteLine("Невалидно количество. Въведете положително цяло число.");
            }

            var product = _productService.GetProductById(productId);
            if (product == null)
            {
                Console.WriteLine("Несъществуващ продукт.");
                ReturnToMenus("Менюто за транзакции", TransactionMenu);
                return;
            }

            if (transactionType == "OUT" && quantity > product.Quantity)
            {
                Console.WriteLine("Недостатъчно количество на склад за тази продажба.");
                ReturnToMenus("Менюто за транзакции", TransactionMenu);
                return;
            }

            DateOnly transactionDate;
            while (true)
            {
                Console.WriteLine("Желаете ли да използвате днешна дата за транзакцията? (ДА/НЕ)");
                var inputYN = Console.ReadLine()?.Trim().ToUpper();

                if (inputYN == "ДА")
                {
                    transactionDate = DateOnly.FromDateTime(DateTime.Now);
                    break;
                }
                else if (inputYN == "НЕ")
                {
                    Console.Write("Дата на транзакцията (YYYY-MM-DD): ");
                    var inputDate = Console.ReadLine();
                    if (DateOnly.TryParse(inputDate, out transactionDate))
                        break;
                    else
                        Console.WriteLine("Невалиден формат на датата. Опитайте отново.");
                }
                else
                {
                    Console.WriteLine("Моля, въведете 'ДА' или 'НЕ'.");
                }
            }

            _transactionService.AddTransaction(productId, transactionType, quantity, transactionDate);

            Console.WriteLine("Транзакцията беше добавена!");
            Console.WriteLine("======================");
            ReturnToMenus("Менюто за транзакции", TransactionMenu);
        }

        private static void ViewTransactions()
        {
            var transactions = _transactionService.GetAllTransactions();

            Console.Clear();
            Console.WriteLine("Желате ли да разпределите транзакциите в две различни таблици ( ВХОДЯЩИ, ИЗХОДЯЩИ )?: *ДА/НЕ*");
            var inp = Console.ReadLine().ToUpper();
            if(inp =="ДА")
            {
                Console.Clear();
                Console.WriteLine("=== Преглед на транзакции ===");
                if (transactions.Count == 0)
                {
                    Console.WriteLine("Няма транзакции.");
                }
                else
                {
                    Console.WriteLine("<<< IN >>>");
                    foreach (var transaction in transactions)
                    {
                        if (transaction.TransactionType == "IN")
                        {
                            Console.WriteLine($"ID: {transaction.TransactionId}, Продукт: {transaction.Product.Name}, Добавено количество: {transaction.Quantity}, Тип на транзакцията: {transaction.TransactionType}, Дата: {transaction.TransactionDate}");
                        }                       
                    }
                    Console.WriteLine("<<< OUT >>>");
                    foreach (var transaction in transactions)
                    {
                        if (transaction.TransactionType == "OUT")
                        {
                            Console.WriteLine($"ID: {transaction.TransactionId}, Продукт: {transaction.Product.Name}, Премахнато количество: {transaction.Quantity}, Тип на транзакцията: {transaction.TransactionType}, Дата: {transaction.TransactionDate}");
                        }
                    }
                }
            }
            else if(inp =="НЕ")
            {
                Console.Clear();
              Console.WriteLine("=== Преглед на транзакции ===");
                     
              if (transactions.Count == 0)
              {
                 Console.WriteLine("Няма транзакции.");
              }
              else
              {
                foreach (var transaction in transactions)
                {
                    if(transaction.TransactionType =="IN")
                    {
                       Console.WriteLine($"ID: {transaction.TransactionId}, Продукт: {transaction.Product.Name}, Добавено количество: {transaction.Quantity}, Тип на транзакцията: {transaction.TransactionType}, Дата: {transaction.TransactionDate}");
                    }
                    else if(transaction.TransactionType == "OUT")
                    {
                        Console.WriteLine($"ID: {transaction.TransactionId}, Продукт: {transaction.Product.Name}, Премахнато количество: {transaction.Quantity}, Тип на транзакцията: {transaction.TransactionType}, Дата: {transaction.TransactionDate}");
                    }
                }
            }
            }
            Console.WriteLine("========================");
            ReturnToMenus("Менюто за транзакции", TransactionMenu);
        }

        //Функционалности на менюто с филтриране
        private static void FilterByCategory()
        {
            var categories = _categoryService.GetAllCategories();
            var products = _productService.GetAllProducts();

            Console.Clear();

            if (categories.Count == 0)
            {
                Console.WriteLine("Няма налични категории.");
            }
            else
            {
                Console.WriteLine("=== Категории ===");
                foreach (var c in categories)
                {
                    Console.WriteLine($"ID: {c.CategoryId} Име: {c.Name}");
                }

                Console.WriteLine("==== Филтриране на продукти по категория ====");
                Console.Write("Въведете ID на категория, по която искате да филтрирате: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int categoryId))
                {
                    if (!categories.Any(c => c.CategoryId == categoryId))
                    {
                        Console.WriteLine("Няма такава категория.");
                    }
                    else
                    {
                        var filteredProducts = products
                            .Where(p => p.CategoryId == categoryId)
                            .ToList();

                        if (filteredProducts.Count == 0)
                        {
                            Console.WriteLine("Няма намерени продукти за тази категория.");
                        }
                        else
                        {
                            Console.WriteLine("=== Продукти в избраната категория ===");
                            foreach (var product in filteredProducts)
                            {
                                Console.WriteLine($"ID: {product.ProductId} | Име: {product.Name} | Цена: {product.Price} лв | Количество: {product.Quantity}");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Невалиден вход. Моля, въведете правилно ID.");
                }
            }
            Console.WriteLine("==================");
            ReturnToMenus("Менюто за търсене и филтриране", SearchNFilterMenu);
        }

        private static void FilterBySuppliers()
        {
            var suppliers = _supplierService.GetAllSuppliers();
            var products = _productService.GetAllProducts();
            Console.Clear();

            if (suppliers.Count == 0)
            {
                Console.WriteLine("Няма доставчици.");
            }
            else
            {
                Console.WriteLine("=== Доставчици ===");
                foreach (var s in suppliers)
                {
                    Console.WriteLine($"ID: {s.SupplierId} | Име: {s.Name} | Контактно лице: {s.ContactName} => {s.Email} | {s.Phone}");
                }

                Console.WriteLine("==== Филтриране на продукти по доставчик ====");
                Console.Write("Въведете ID на доставчик, по който искате да филтрирате: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int supplierId))
                {
                    if (!suppliers.Any(s => s.SupplierId == supplierId))
                    {
                        Console.WriteLine("Няма такъв доставчик.");
                    }
                    else
                    {
                        var filteredProducts = products
                            .Where(p => p.SupplierId == supplierId)
                            .ToList();

                        if (filteredProducts.Count == 0)
                        {
                            Console.WriteLine("Няма намерени продукти от този доставчик.");
                        }
                        else
                        {
                            Console.WriteLine("=== Продукти от избрания доставчик ===");
                            foreach (var product in filteredProducts)
                            {
                                Console.WriteLine($"ID: {product.ProductId} | Име: {product.Name} | Цена: {product.Price} лв | Количество: {product.Quantity}");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Невалиден вход. Моля, въведете правилно ID.");
                }
            }
            Console.WriteLine("==================");
            ReturnToMenus("Менюто за търсене и филтриране", SearchNFilterMenu);
        }

        //Функционалности на менюто с доставчици
        private static void AddSupplier()
        {
            Console.Clear();
            Console.WriteLine("=== Добави доставчик ===");

            string name = "";
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Име: ");
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                    Console.WriteLine("Името не може да е празно.");
            }

            string contactName = "";
            while (string.IsNullOrWhiteSpace(contactName))
            {
                Console.Write("Контактно лице: ");
                contactName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(contactName))
                    Console.WriteLine("Контактното лице не може да е празно.");
            }

            string phone = "";
            while (string.IsNullOrWhiteSpace(phone))
            {
                Console.Write("Телефон: ");
                phone = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(phone))
                    Console.WriteLine("Телефонът не може да е празен.");
            }

            string email = "";
            while (string.IsNullOrWhiteSpace(email))
            {
                Console.Write("Email: ");
                email = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(email))
                    Console.WriteLine("Email-ът не може да е празен.");
            }

            _supplierService.AddSupplier(name, contactName, phone, email);

            Console.WriteLine("Доставчикът беше добавен!");
            Console.WriteLine("===========================");
            ReturnToMenus("Менюто за доставчици", SupplierMenu);
        }


        private static void ViewSuppliers()
        {
            Console.Clear();
            Console.WriteLine("=== Списък с доставчици ===");
            _supplierService.ListSuppliers();
            Console.WriteLine("===========================");
            ReturnToMenus("Менюто за доставчици", SupplierMenu);

        }

        private static void EditSupplier()
        {
            Console.Clear();
            var suppliers = _supplierService.GetAllSuppliers();

            if (suppliers.Count == 0)
            {
                Console.WriteLine("Няма доставчици.");
                Console.WriteLine("==========================");
                ReturnToMenus("Менюто за доставчици", SupplierMenu);
                return;
            }

            Console.WriteLine("=== Списък с доставчици ===");
            foreach (var supplier in suppliers)
            {
                Console.WriteLine($"ID: {supplier.SupplierId}, Име: {supplier.Name}");
            }

            Console.Write("\nВъведи ID на доставчика: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Невалидно ID.");
                Console.WriteLine("==========================");
                ReturnToMenus("Менюто за доставчици", SupplierMenu);
                return;
            }

            var supplierToEdit = _supplierService.GetSupplierById(id);
            if (supplierToEdit == null)
            {
                Console.WriteLine("Не е намерен такъв доставчик.");
                Console.WriteLine("==========================");
                ReturnToMenus("Менюто за доставчици", SupplierMenu);
                return;
            }

            string name = "";
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Ново име: ");
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                    Console.WriteLine("Името не може да е празно.");
            }

            string contactName = "";
            while (string.IsNullOrWhiteSpace(contactName))
            {
                Console.Write("Ново контактно лице: ");
                contactName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(contactName))
                    Console.WriteLine("Контактното лице не може да е празно.");
            }

            string phone = "";
            while (string.IsNullOrWhiteSpace(phone))
            {
                Console.Write("Нов телефон: ");
                phone = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(phone))
                    Console.WriteLine("Телефонът не може да е празен.");
            }

            string email = "";
            while (string.IsNullOrWhiteSpace(email))
            {
                Console.Write("Нов Email: ");
                email = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(email))
                    Console.WriteLine("Email-ът не може да е празен.");
            }

            _supplierService.EditSupplier(id, name, contactName, phone, email);
            Console.WriteLine("Успешно редактиран.");
            Console.WriteLine("==========================");
            ReturnToMenus("Менюто за доставчици", SupplierMenu);
        }


        private static void DeleteSupplier()
        {
            Console.Clear();
            var suppliers = _supplierService.GetAllSuppliers();

            if (suppliers.Count == 0)
            {
                Console.WriteLine("Няма доставчици.");
                Console.WriteLine("=============================");
                ReturnToMenus("Менюто за доставчици", SupplierMenu);
                return;
            }

            Console.WriteLine("=== Списък с доставчици ===");
            foreach (var supplier in suppliers)
            {
                Console.WriteLine($"ID: {supplier.SupplierId}, Име: {supplier.Name}");
            }

            Console.Write("\nВъведи ID на доставчика за изтриване: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var supplier = _supplierService.GetSupplierById(id);
                if (supplier == null)
                {
                    Console.WriteLine("Доставчик с такова ID не съществува.");
                }
                else
                {
                    _supplierService.DeleteSupplier(id);
                    Console.WriteLine("Доставчикът беше изтрит.");
                }
            }
            else
            {
                Console.WriteLine("Невалидно ID.");
            }
            Console.WriteLine("=============================");
            ReturnToMenus("Менюто за доставчици", SupplierMenu);
        }


        //Функционалности на менюто с отчети
        private static void FullInventoryReport()
        {
            Console.Clear();
            Console.WriteLine("=== Пълен инвентар ===");

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
            Console.WriteLine("======================");
            ReturnToMenus("Менюто за отчети", ReportMenu);

        }

        private static void CategoryReport()
        {
            Console.Clear();
            var categories = _categoryService.GetAllCategories();
            var allProducts = _productService.GetAllProducts();

            if (categories.Count == 0)
            {
                Console.WriteLine("Няма налични категории.");
                ReturnToMenus("Менюто за отчети", ReportMenu);
                return;
            }

            Console.WriteLine("===========================");
            foreach (var c in categories)
            {
                Console.WriteLine($"ID: {c.CategoryId} Име: {c.Name}");
            }
            Console.WriteLine("=== Отчет по категория ====");
            Console.Write("Въведете ID на категорията: ");

            if (!int.TryParse(Console.ReadLine(), out int categoryId))
            {
                Console.WriteLine("Невалиден вход. Моля, въведете валидно число.");
                ReturnToMenus("Менюто за отчети", ReportMenu);
                return;
            }

            if (!categories.Any(c => c.CategoryId == categoryId))
            {
                Console.WriteLine("Категория с това ID не съществува.");
                ReturnToMenus("Менюто за отчети", ReportMenu);
                return;
            }

            var products = allProducts.Where(p => p.CategoryId == categoryId).ToList();

            if (products.Count == 0)
            {
                Console.WriteLine("Няма продукти в тази категория.");
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"ID: {product.ProductId}, Име: {product.Name}, Цена: {product.Price} лв, Наличност: {product.Quantity}");
                }
            }

            Console.WriteLine("======================");
            ReturnToMenus("Менюто за отчети", ReportMenu);
        }

        private static void LowStockReport()

        {
            Console.Clear();
            Console.WriteLine("=== Ниски наличности (<5) ===");

            var lowStockProducts = _productService.GetAllProducts().Where(p => p.Quantity < 5).ToList();

            if (lowStockProducts.Count == 0)
            {
                Console.WriteLine("Няма продукти с ниски наличности.");
            }
            else
            {
                foreach (var product in lowStockProducts)
                {
                    Console.WriteLine($"ID: {product.ProductId}, Име: {product.Name}, Категория: {product.Category.Name}, Цена: {product.Price}, Наличност: {product.Quantity}, Доставчик: {product.Supplier.Name}, Контактно лице: {product.Supplier.ContactName}");
                }
            }
            Console.WriteLine("======================");
            ReturnToMenus("Менюто за отчети", ReportMenu);
        }

        //Менюта
        private static void ProductMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine("|  --- Управление на продукти ---   |");
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
                        Console.WriteLine("Невалиден избор. Натиснете произволен клавиш, за да продължите...");
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
                Console.WriteLine("| --- Управление на категории ---   |");
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
                        Console.WriteLine("Невалиден избор. Натиснете произволен клавиш, за да продължите...");
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
                Console.WriteLine("|     --- Управление на доставчици ---    |");
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
                        Console.WriteLine("Невалиден избор. Натиснете произволен клавиш, за да продължите...");
                        Console.ReadKey();
                        break;
                }
            }

        }
        private static void SearchNFilterMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("|      --- Търсене и филтриране ---       |");
                Console.WriteLine("|-----------------------------------------|");
                Console.WriteLine("| [1] Филтриране по категория             |");
                Console.WriteLine("| [2] Филтриране по доставчици            |");
                Console.WriteLine("|-----------------------------------------|");
                Console.WriteLine("| [r] Назад                               |");
                Console.WriteLine("===========================================");

                Console.Write("Вашият избор: ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        FilterByCategory();
                        break;
                    case "2":
                        FilterBySuppliers();
                        break;
                    case "r":
                        return;
                    default:
                        Console.WriteLine("Невалиден избор. Натиснете произволен клавиш, за да продължите...");
                        Console.ReadKey();
                        break;
                }
            }            
        }
        private static void TransactionMenu()
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("|           --- Транзакции ---            |");
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
                    Console.WriteLine("Невалиден избор. Натиснете произволен клавиш, за да продължите...");
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
                Console.WriteLine("|       --- Генериране на отчети ---      |");
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
                        Console.WriteLine("Невалиден избор. Натиснете произволен клавиш, за да продължите...");
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

        //Връщане към менюта
        private static void ReturnToMenus(string txt,Action backMenu)
        {
            Console.WriteLine("Връщане към началното меню: [r]");
            Console.WriteLine($"Връщане към {txt.ToLower()}: [b]");
            var input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "r":
                    MenuDesign();
                    break;
                case "b":
                    backMenu();
                    break;
            }
        }
    }
}

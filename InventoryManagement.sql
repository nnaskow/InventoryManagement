CREATE DATABASE InventoryManagement;
USE InventoryManagement;

CREATE TABLE categories (
    category_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(50),
    description TEXT
);

INSERT INTO categories (name, description) VALUES
('Electronics', 'Devices and gadgets'),
('Furniture', 'Office and home furniture'),
('Stationery', 'Office supplies and paper products'),
('Clothing', 'Apparel and accessories'),
('Groceries', 'Food and daily essentials');

CREATE TABLE suppliers (
    supplier_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100),
    contact_name VARCHAR(100),
    phone VARCHAR(20),
    email VARCHAR(100)
);

INSERT INTO suppliers (name, contact_name, phone, email) VALUES
('ElectroMax', 'John Doe', '123-456-7890', 'john@electromax.com'),
('FurniCraft', 'Jane Smith', '234-567-8901', 'jane@furnicraft.com'),
('PaperHouse', 'Lisa White', '345-678-9012', 'lisa@paperhouse.com'),
('WearZone', 'Mike Brown', '456-789-0123', 'mike@wearzone.com'),
('FreshMart', 'Anna Green', '567-890-1234', 'anna@freshmart.com');

CREATE TABLE products (
    product_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100),
    category_id INT,
    supplier_id INT,
    quantity INT,
    last_updated DATE,
    price DECIMAL(10,2),
    FOREIGN KEY (category_id) REFERENCES categories(category_id),
    FOREIGN KEY (supplier_id) REFERENCES suppliers(supplier_id)
);

INSERT INTO products (name, category_id, supplier_id, quantity, price, last_updated) VALUES
('Smartphone X', 1, 1, 50, 599.99, '2025-04-01'),
('Office Chair', 2, 2, 30, 149.99, '2025-04-02'),
('A4 Paper Pack', 3, 3, 200, 5.99, '2025-04-03'),
('Men T-Shirt', 4, 4, 80, 12.49, '2025-04-04'),
('Organic Milk', 5, 5, 120, 2.99, '2025-04-05');

CREATE TABLE transactions (
    transaction_id INT IDENTITY(1,1) PRIMARY KEY,
    product_id INT,
    transaction_type VARCHAR(10),
    quantity INT,
    transaction_date DATE,
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);

INSERT INTO transactions (product_id, transaction_type, quantity, transaction_date) VALUES
(1, 'OUT', 5, '2025-04-03'),
(2, 'IN', 10, '2025-04-03'),
(3, 'OUT', 20, '2025-04-04'),
(4, 'OUT', 10, '2025-04-05'),
(5, 'IN', 50, '2025-04-05');

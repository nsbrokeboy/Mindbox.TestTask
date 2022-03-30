/*
 Создание таблицы "Продукты"
 */

CREATE TABLE [Products]
(
    [ProductID] int IDENTITY NOT NULL,
    [ProductName] TEXT NOT NULL,

    CONSTRAINT [PK_ProductID] PRIMARY KEY (ProductID)
);

/*
 Создание таблицы "Категории"
 */

CREATE TABLE [Categories]
(
    [CategoryID] int IDENTITY NOT NULL,
    [CategoryName] TEXT NOT NULL,

    CONSTRAINT [PK_CategoryID] PRIMARY KEY (CategoryID)
);

/*
 Создание таблицы-посредника для реализации связи многие-ко-многим между таблицами Продукты и Категории
 */

CREATE TABLE [ProductsCategories]
(
    [ProductID] int FOREIGN KEY REFERENCES Products(ProductID),
    [CategoryID] int FOREIGN KEY REFERENCES Categories(CategoryID),

    CONSTRAINT [FK_ProductsCategories] PRIMARY KEY (ProductID, CategoryID)
);

/*
 Вставка значений в таблицу "Продукты"
 */

INSERT INTO Products (ProductName)
VALUES
    ('Pizza'),
    ('Pasta'),
    ('Shampoo'),
    ('Apple'),
    ('Pancake'),
    ('Banana'),
    ('Toy Soldier');

/*
 Вставка значений в таблицу "Категории"
 */

INSERT INTO Categories (CategoryName)
VALUES
    ('Fruits'),
    ('Food'),
    ('Household chemicals');

/*
 Вставка значений в таблицу-посредник
 */

INSERT INTO ProductsCategories (ProductID, CategoryID)
VALUES
    (1, 2),
    (2, 2),
    (3, 3),
    (4, 1),
    (5, 2),
    (6, 1);

/*
 Запрос для выбора всех пар "Имя продукта – Имя категории"
  */

SELECT P.ProductName, C.CategoryName
FROM Products P
LEFT JOIN ProductsCategories PC
    ON P.ProductID = PC.ProductID
LEFT JOIN Categories C
    ON PC.CategoryID = C.CategoryID;
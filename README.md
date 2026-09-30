# BookStoreApp - Информационная система книжного магазина

Десктопное приложение для автоматизации учёта товаров, продаж и клиентов в розничном книжном магазине.

## Стек технологий

- C# (.NET Framework 4.7.2)
- Windows Forms
- Microsoft SQL Server
- ADO.NET
- EPPlus (экспорт отчётов в Excel)

## Функционал

- Авторизация с разграничением прав доступа (администратор, продавец, бухгалтер)
- Ведение справочников: книги, авторы, издательства, клиенты, поставщики, сотрудники
- Учёт поступлений товара от поставщиков
- Оформление продаж с автоматическим списанием остатков
- Отмена заказов с возвратом остатков на склад
- Поиск книг по названию, автору, ISBN
- Формирование отчётов: остатки книг, продажи по дням, статистика клиентов
- Экспорт отчётов в Excel и печать
- Журналирование входа пользователей (аудит)

## Структура проекта

BookStore/
 AddBookForm.cs — добавление книги
 AddOrderForm.cs — оформление заказа
 ClientForm.cs — управление клиентами
 ConfirmSupplyForm.cs — подтверждение поставок
 DatabaseHelper.cs — работа с базой данных
 EditBookForm.cs — редактирование книги
 EmailHelper.cs — отправка email
 ExportHelper.cs — экспорт в Excel
 Form1.cs — авторизация
 MainForm.cs — главное окно
 ReportsForm.cs — отчёты
 SupplierForm.cs — управление поставщиками
 SupplyForm.cs — приход товара
 App.config — конфигурация

## Как запустить

1. Требования

Windows 7/10/11
.NET Framework 4.7.2
Microsoft SQL Server Express или выше
Visual Studio 2022 для сборки

2. Восстановление базы данных

1. Откройте SQL Server Management Studio (SSMS)
2. Создайте базу данных "BookStore"
3. Выполните скрипт "BookStore_Database.sql" (прилагается в репозитории).

3. Настройка подключения

Откротей файл "App.config" и проверьте строку подключения:

```xml
<connectionStrings>
    <add name="BookStoreDB" 
         connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True" />
</connectionStrings>

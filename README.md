# Tax Management System | سیستم مدیریت امور مالیاتی

[English](#english) | [فارسی](#persian)

---

## <a name="english"></a>English

## 📋 Overview

Tax Management System is a .NET 8 Web API application designed for managing tax invoices and related documents. The system is built using Clean Architecture principles with CQRS pattern implementation using MediatR.

## 🏗️ Architecture

The solution follows **Clean Architecture** with the following layers:

### 📁 Project Structure

```
Tax/
├── Domain/                 # Core business logic and entities
│   └── Tax.Domain/
│       ├── Entities/      # Domain entities
│       ├── Events/        # Domain events
│       ├── Aggregates/    # Aggregate roots
│       └── ValueObjects/  # Value objects
├── Application/           # Application business rules
│   └── Tax.Application/
│       ├── Commands/      # CQRS commands
│       ├── Queries/       # CQRS queries
│       └── Dto/           # Data transfer objects
├── Infrastructure/        # External concerns
│   └── Tax.Infrastructure/
│       ├── Data/          # Database context
│       ├── Handlers/      # Command and Query handlers
│       └── Migrations/    # EF Core migrations
└── Presentation/          # API layer
    └── Tax.Api/
        └── Tax.Api/
            └── Controllers/  # API controllers
```

### 🔧 Technologies Used

- **.NET 8.0** - Latest LTS version of .NET
- **Entity Framework Core 9.0.3** - ORM for database operations
- **SQL Server** - Database provider
- **MediatR 12.5.0** - Mediator pattern implementation for CQRS
- **Swagger/OpenAPI** - API documentation
- **Clean Architecture** - Architectural pattern

## 📦 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server/) (LocalDB, Express, or Full version)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone <repository-url>
cd Tax
```

### 2. Configure Database Connection

Update the connection string in `Presentation/Tax.Api/Tax.Api/appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TaxDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

### 3. Apply Database Migrations

```bash
cd Infrastructure/Tax.Infrastructure
dotnet ef database update
```

### 4. Build the Solution

```bash
dotnet build
```

### 5. Run the Application

```bash
cd Presentation/Tax.Api/Tax.Api
dotnet run
```

The API will be available at:
- `http://localhost:5000` (HTTP)
- `https://localhost:5001` (HTTPS)

### 6. Access Swagger Documentation

Navigate to `https://localhost:5001/swagger` to view the API documentation.

## 📡 API Endpoints

### Tax Items Controller

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/taxitems` | Get paginated tax items |
| POST | `/api/taxitems/{id}/confirm` | Confirm a tax item |

### Request Examples

#### Get Tax Items
```http
GET /api/taxitems?pageNumber=1&pageSize=10
```

#### Confirm Tax Item
```http
POST /api/taxitems/123/confirm
```

## 🏛️ Domain Entities

### InvoiceHeader
Represents the header information for tax invoices with the following properties:
- `Indatim` - Invoice date/time
- `Inty` - Invoice type
- `IrtaxId` - Tax ID
- `Tins` - Taxpayer identification number
- And more...

### TaxInvoiceItem
Represents individual items in a tax invoice (currently commented out for refactoring).

## 🔌 CQRS Pattern

The application implements CQRS using MediatR:

- **Commands**: Modify the state (e.g., `ConfirmTaxItemCommand`)
- **Queries**: Read data without side effects (e.g., `GetTaxItemsQuery`)
- **Handlers**: Process commands and queries in the Infrastructure layer

## 🗃️ Database Migrations

To add a new migration:

```bash
cd Infrastructure/Tax.Infrastructure
dotnet ef migrations add <MigrationName> --startup-project ../../Presentation/Tax.Api/Tax.Api
```

## 🧪 Development

### Project Dependencies

- **Tax.Domain**: No external dependencies (pure domain logic)
- **Tax.Application**: References Tax.Domain
- **Tax.Infrastructure**: References Tax.Domain and Tax.Application
- **Tax.Api**: References Tax.Application and Tax.Infrastructure

---

## <a name="persian"></a>فارسی

## 📋 معرفی پروژه

سیستم مدیریت امور مالیاتی یک برنامه Web API با .NET 8 است که برای مدیریت صورتحساب‌های مالیاتی و اسناد مرتبط طراحی شده است. این سیستم با استفاده از اصول Clean Architecture و الگوی CQRS با استفاده از MediatR پیاده‌سازی شده است.

## 🏗️ معماری

این راه‌حل از **Clean Architecture** با لایه‌های زیر پیروی می‌کند:

### 📁 ساختار پروژه

```
Tax/
├── Domain/                 # منطق تجاری و موجودیت‌ها
│   └── Tax.Domain/
│       ├── Entities/      # موجودیت‌های دامنه
│       ├── Events/        # رویدادهای دامنه
│       ├── Aggregates/    # ریشه‌های تجمیعی
│       └── ValueObjects/  # اشیاء ارزش
├── Application/           # قوانین کسب و کار
│   └── Tax.Application/
│       ├── Commands/      # دستورات CQRS
│       ├── Queries/       # پرس‌وجوهای CQRS
│       └── Dto/           # اشیاء انتقال داده
├── Infrastructure/        # نگرانی‌های خارجی
│   └── Tax.Infrastructure/
│       ├── Data/          # کانتکست دیتابیس
│       ├── Handlers/      # هندلرهای Command و Query
│       └── Migrations/    # مایگریشن‌های EF Core
└── Presentation/          # لایه API
    └── Tax.Api/
        └── Tax.Api/
            └── Controllers/  # کنترلرهای API
```

### 🔧 تکنولوژی‌های استفاده شده

- **.NET 8.0** - آخرین نسخه LTS دات‌نت
- **Entity Framework Core 9.0.3** - ORM برای عملیات دیتابیس
- **SQL Server** - پایگاه داده
- **MediatR 12.5.0** - پیاده‌سازی الگوی Mediator برای CQRS
- **Swagger/OpenAPI** - مستندسازی API
- **Clean Architecture** - الگوی معماری

## 📦 پیش‌نیازها

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server/) (LocalDB، Express یا نسخه کامل)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) یا [Visual Studio Code](https://code.visualstudio.com/)

## 🚀 شروع کار

### 1. کلون کردن مخزن

```bash
git clone <repository-url>
cd Tax
```

### 2. پیکربندی اتصال به دیتابیس

رشته اتصال را در `Presentation/Tax.Api/Tax.Api/appsettings.json` به‌روزرسانی کنید:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TaxDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

### 3. اعمال مایگریشن‌های دیتابیس

```bash
cd Infrastructure/Tax.Infrastructure
dotnet ef database update
```

### 4. ساخت پروژه

```bash
dotnet build
```

### 5. اجرای برنامه

```bash
cd Presentation/Tax.Api/Tax.Api
dotnet run
```

API در آدرس‌های زیر در دسترس خواهد بود:
- `http://localhost:5000` (HTTP)
- `https://localhost:5001` (HTTPS)

### 6. دسترسی به مستندات Swagger

به آدرس `https://localhost:5001/swagger` بروید تا مستندات API را مشاهده کنید.

## 📡 Endpoint های API

### کنترلر Tax Items

| متد | آدرس | توضیحات |
|-----|------|---------|
| GET | `/api/taxitems` | دریافت آیتم‌های مالیاتی صفحه‌بندی شده |
| POST | `/api/taxitems/{id}/confirm` | تأیید یک آیتم مالیاتی |

### نمونه درخواست‌ها

#### دریافت آیتم‌های مالیاتی
```http
GET /api/taxitems?pageNumber=1&pageSize=10
```

#### تأیید آیتم مالیاتی
```http
POST /api/taxitems/123/confirm
```

## 🏛️ موجودیت‌های دامنه

### InvoiceHeader
نمایش اطلاعات سرفصل فاکتورهای مالیاتی با ویژگی‌های زیر:
- `Indatim` - تاریخ/زمان فاکتور
- `Inty` - نوع فاکتور
- `IrtaxId` - شناسه مالیاتی
- `Tins` - شماره شناسایی مؤدی مالیاتی
- و موارد دیگر...

### TaxInvoiceItem
نمایش آیتم‌های فردی در فاکتور مالیاتی (در حال حاضر برای بازنویسی کامنت شده است).

## 🔌 الگوی CQRS

برنامه CQRS را با استفاده از MediatR پیاده‌سازی می‌کند:

- **Commands**: تغییر وضعیت (مثلاً `ConfirmTaxItemCommand`)
- **Queries**: خواندن داده بدون عوارض جانبی (مثلاً `GetTaxItemsQuery`)
- **Handlers**: پردازش دستورات و پرس‌وجوها در لایه Infrastructure

## 🗃️ مایگریشن‌های دیتابیس

برای اضافه کردن مایگریشن جدید:

```bash
cd Infrastructure/Tax.Infrastructure
dotnet ef migrations add <MigrationName> --startup-project ../../Presentation/Tax.Api/Tax.Api
```

## 🧪 توسعه

### وابستگی‌های پروژه

- **Tax.Domain**: بدون وابستگی خارجی (منطق دامنه خالص)
- **Tax.Application**: مرجع به Tax.Domain
- **Tax.Infrastructure**: مرجع به Tax.Domain و Tax.Application
- **Tax.Api**: مرجع به Tax.Application و Tax.Infrastructure

## 📝 License | مجوز

This project is licensed under the MIT License.
این پروژه تحت مجوز MIT منتشر شده است.

## 🤝 Contributing | مشارکت

Contributions are welcome! Please feel free to submit a Pull Request.
مشارکت‌ها پذیرفته می‌شوند! لطفاً Pull Request ارسال کنید.

## 📧 Contact | تماس

For questions and support, please open an issue in the repository.
برای سوالات و پشتیبانی، لطفاً یک issue در مخزن ایجاد کنید.


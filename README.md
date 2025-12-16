# Tax Management System | سیستم مدیریت امور مالیاتی

[English](#english) | [فارسی](#persian)

---

## <a name="english"></a>English

### 📋 Overview
Tax Management System is a .NET 8 Web API that manages tax invoices and related documents. It follows Clean Architecture with CQRS (MediatR) and Entity Framework Core for data access.

### 🏗️ Architecture at a Glance
- **Domain**: Entities, events, aggregates, value objects.
- **Application**: CQRS commands/queries and DTOs.
- **Infrastructure**: EF Core DbContext, handlers, migrations.
- **Presentation**: ASP.NET Core API controllers and startup.

### 📁 Project Structure
```
Tax/
├── Domain/Tax.Domain/          # Core domain model
├── Application/Tax.Application/# Use-cases (CQRS)
├── Infrastructure/Tax.Infrastructure/ # Data + handlers
└── Presentation/Tax.Api/Tax.Api/      # API host/controllers
```

### 🔧 Tech Stack
- .NET 8.0
- Entity Framework Core 9.0.3 (SQL Server)
- MediatR 12.5.0 (CQRS)
- Swagger / OpenAPI

### 📦 Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server/) (LocalDB/Express/full)
- IDE: Visual Studio 2022 or VS Code

### 🚀 Quick Start
1) Clone
```bash
git clone <repository-url>
cd Tax
```
2) Configure DB connection in `Presentation/Tax.Api/Tax.Api/appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TaxDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```
3) Apply migrations
```bash
cd Infrastructure/Tax.Infrastructure
dotnet ef database update
```
4) Build
```bash
dotnet build
```
5) Run
```bash
cd Presentation/Tax.Api/Tax.Api
dotnet run
```
Swagger is available at `https://localhost:5001/swagger`.

### 📡 API (current)
| Method | Endpoint | Description |
| ------ | -------- | ----------- |
| GET    | `/api/taxitems` | Get paginated tax items |
| POST   | `/api/taxitems/{id}/confirm` | Confirm a tax item |

Example:
```http
GET /api/taxitems?pageNumber=1&pageSize=10
```

### 🧪 Development Notes
- Add migration:
```bash
cd Infrastructure/Tax.Infrastructure
dotnet ef migrations add <MigrationName> --startup-project ../../Presentation/Tax.Api/Tax.Api
```
- Project references:
  - Tax.Application → Tax.Domain
  - Tax.Infrastructure → Tax.Domain, Tax.Application
  - Tax.Api → Tax.Application, Tax.Infrastructure

### 📝 License | 🤝 Contributing | 📧 Contact
- MIT License.
- Contributions welcome via PR.
- For questions/support, open an issue.

---

## <a name="persian"></a>فارسی

### 📋 معرفی
سیستم مدیریت امور مالیاتی یک Web API بر پایه .NET 8 است که صورتحساب‌های مالیاتی و اسناد مرتبط را مدیریت می‌کند. ساختار پروژه بر مبنای Clean Architecture و الگوی CQRS (با MediatR) و دسترسی به داده‌ها با Entity Framework Core است.

### 🏗️ معماری به‌اختصار
- **Domain**: موجودیت‌ها، رویدادها، Aggregateها، Value Objectها
- **Application**: دستورات/پرس‌وجوهای CQRS و DTOها
- **Infrastructure**: DbContext، هندلرها و مایگریشن‌ها
- **Presentation**: کنترلرهای ASP.NET Core و پیکربندی اجرا

### 📁 ساختار پروژه
```
Tax/
├── Domain/Tax.Domain/             # مدل دامنه
├── Application/Tax.Application/   # موارد استفاده (CQRS)
├── Infrastructure/Tax.Infrastructure/ # داده و هندلرها
└── Presentation/Tax.Api/Tax.Api/  # میزبان API / کنترلرها
```

### 🔧 تکنولوژی‌ها
- .NET 8.0
- Entity Framework Core 9.0.3 (SQL Server)
- MediatR 12.5.0 (CQRS)
- Swagger / OpenAPI

### 📦 پیش‌نیازها
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server/) (LocalDB/Express/نسخه کامل)
- محیط توسعه: Visual Studio 2022 یا VS Code

### 🚀 شروع سریع
1) کلون
```bash
git clone <repository-url>
cd Tax
```
2) تنظیم اتصال دیتابیس در `Presentation/Tax.Api/Tax.Api/appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TaxDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```
3) اجرای مایگریشن
```bash
cd Infrastructure/Tax.Infrastructure
dotnet ef database update
```
4) بیلد
```bash
dotnet build
```
5) اجرا
```bash
cd Presentation/Tax.Api/Tax.Api
dotnet run
```
Swagger در `https://localhost:5001/swagger` در دسترس است.

### 📡 API فعلی
| متد | مسیر | توضیح |
| --- | ---- | ----- |
| GET | `/api/taxitems` | دریافت آیتم‌های مالیاتی صفحه‌بندی‌شده |
| POST | `/api/taxitems/{id}/confirm` | تأیید یک آیتم مالیاتی |

نمونه:
```http
GET /api/taxitems?pageNumber=1&pageSize=10
```

### 🧪 نکات توسعه
- افزودن مایگریشن:
```bash
cd Infrastructure/Tax.Infrastructure
dotnet ef migrations add <MigrationName> --startup-project ../../Presentation/Tax.Api/Tax.Api
```
- وابستگی پروژه‌ها:
  - Tax.Application → Tax.Domain
  - Tax.Infrastructure → Tax.Domain، Tax.Application
  - Tax.Api → Tax.Application، Tax.Infrastructure

### 📝 مجوز | 🤝 مشارکت | 📧 تماس
- مجوز MIT.
- مشارکت از طریق Pull Request پذیرفته می‌شود.
- برای سوال یا پشتیبانی، لطفاً یک Issue ثبت کنید.


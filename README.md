# 📱 GadgetHub

**GadgetHub** is a multi-module **gadget management and e-commerce platform** developed using **ASP.NET Core and .NET technologies**.
The system supports different user roles such as **Administrators, Customers, and Distributors**, allowing them to manage gadgets, orders, and system operations through dedicated portals.

---

# 🚀 Project Overview

The **GadgetHub System** provides a centralized platform to manage electronic gadgets, users, and distribution operations.

It consists of multiple applications:

* 🛠 **Admin Panel** – Manage products, users, and system data
* 🛒 **Customer Portal** – Customers can browse and purchase gadgets
* 📦 **Distributor Portal** – Distributors can manage supply and inventory
* 🔗 **REST API** – Backend services connecting all modules
* 🧩 **Models Library** – Shared data models used across the system

---

# 🏗 System Architecture

The solution follows a **multi-project architecture**:

```
GadgetHub
│
├── GadgetHub.API                # Backend REST API
├── GadgetHub.AdminPanel         # Administrator Web Application
├── GadgetHub.CustomerPortal     # Customer Web Portal
├── GadgetHub.DistributorPortal  # Distributor Web Portal
└── GadgetHub.Models             # Shared Data Models
```

This structure ensures **code reusability, scalability, and maintainability**.

---

# ✨ Features

### 👨‍💼 Admin Panel

* Manage gadgets and categories
* Manage customers and distributors
* View system records
* Control platform operations

### 🛒 Customer Portal

* Browse gadgets
* View product details
* Place orders
* Manage customer accounts

### 📦 Distributor Portal

* Manage product distribution
* Track supply
* Update inventory information

### 🔗 API

* RESTful API services
* Central communication layer between portals
* Handles business logic and data operations

---

# 🛠 Technologies Used

### Backend

* **ASP.NET Core**
* **C#**
* **REST API**

### Frontend

* **ASP.NET MVC / Razor Pages**
* **HTML**
* **CSS**
* **JavaScript**

### Database

* **SQL Server**

### Development Tools

* **Visual Studio**
* **.NET SDK**
* **Git & GitHub**

---

# ⚙️ Installation Guide

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/your-username/GadgetHub.git
```

---

### 2️⃣ Open the Solution

Open the project using **Visual Studio**

```
GadgetHub.sln
```

---

### 3️⃣ Configure Database

Update the **connection string** in:

```
appsettings.json
```

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=GadgetHubDB;Trusted_Connection=True;"
}
```

---

### 4️⃣ Run the Application

1. Set **GadgetHub.API** as the startup project
2. Run the solution in **Visual Studio**
3. Launch the portals

---

# 📂 Project Structure

```
GadgetHub
│
├── GadgetHub.API
│   ├── Controllers
│   ├── Services
│   └── Configuration
│
├── GadgetHub.AdminPanel
│
├── GadgetHub.CustomerPortal
│
├── GadgetHub.DistributorPortal
│
└── GadgetHub.Models
```

---

# 🔐 User Roles

The system supports multiple roles:

* **Administrator**
* **Customer**
* **Distributor**

Each role has **separate permissions and interfaces**.

---

# 🔮 Future Improvements

* Payment gateway integration
* Product reviews and ratings
* Advanced analytics dashboard
* Mobile application
* Notification system

---

# 👩‍💻 Author

Developed as part of a **software development project**.

---


# Hospital Patient Report Management System 🏥

A robust, dynamic, and secure **Desktop Application** designed for hospitals to manage medical test reports and provide patients with a secure self-service portal to track and download their lab reports. Built using **C# (WinForms)** and **SQL Server**.

## 🚀 Key Features

### 👤 Admin Dashboard
- **Patient Registration:** Register new patients seamlessly using advanced input validation controls like `DateTimePicker` for DOB.
- **Automated Account Generation:** Instantly creates unique patient login credentials upon registration with a default password (`1234`), mapping them directly to the centralized authentication table.
- **Dynamic Test Assignment:** Multi-select interface to assign laboratory tests (CBC, X-Ray, Ultrasound, etc.) with individual cost tracking.

### 🧪 Patient Portal (PatientPanel)
- **Role-Based Authentication:** Directs patients to their customized portal after verifying unique credentials, separating patient views from admin data.
- **Itemized Billing Tracking:** Instead of a generic total fee, patients can see an item-wise cost breakdown for each assigned test along with its current processing status (Pending/Completed).
- **Secure Document Download:** Utilizes `SaveFileDialog` to allow patients to safely copy and download their official lab reports in PDF format directly to any local directory.

### 🔒 Security Enhancements
- **SQL Injection Prevention:** All database operations are secured using **Parameterized Queries** (`SqlCommand.Parameters`).
- **Brute Force Protection:** Temporarily locks down the authentication interface after 3 consecutive failed login attempts.

---

## 🛠️ Tech Stack & Architecture Concepts

- **Language:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Database:** Microsoft SQL Server (Transact-SQL)
- **Core Concepts:** Object-Oriented Programming (OOP), Session State Management, Database Normalization & Multi-Table `JOIN` Queries.

---

## ⚙️ How to Run Locally

1. **Clone the Repository:**
   ```bash
   git clone [https://github.com/sahariar77/Hospital_management_system.git](https://github.com/sahariar77/Hospital_management_system.git)
2. **Database Setup:** 
  Import the provided SQL scripts `(SQLQuery1.sql to SQLQuery4.sql)` into your local SQL Server Express.
  Ensure the connection string in the backend matches your local server environment:
   `Data Source=localhost\\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;`

3.**Run the Project:**
  Open the `Hospital_management_system`.sln file in Visual Studio.
  Press F5 to clean, build, and run the application.
  Developed as a part of the Computer Science & Engineering curriculum at AIUB.

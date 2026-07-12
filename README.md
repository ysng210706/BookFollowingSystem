# Book Following System

A lightweight, console-based Library Management System built with C# that demonstrates the core principles of Object-Oriented Programming (OOP), Encapsulation, and Interface Segregation.

## 🚀 Features

- **Robust OOP Architecture:** Built using clean domain models and proper class hierarchies.
- **Interface Segregation:** Implements a dynamic `ILoanable` interface to separate assets that can be borrowed (like books) from those that are restricted (like magazines).
- **State & Encapsulation Management:** Utilizes C# properties (`get; set;`) to securely manage and validate data states (e.g., tracking item availability and handling borrower names dynamically).
- **Interactive UI:** A continuous, user-friendly console menu to handle day-to-day library operations in real-time.

---

## 🛠️ How It Works (Core Operations)

1. **Add Book:** Registers new books into the runtime library inventory.
2. **List All Items:** Displays the complete inventory with real-time status attributes (ID, Title, and Availability).
3. **Borrow Book:** Validates item availability, assigns the borrower's name, and sets a 14-day due date automatically.
4. **Return Book:** Resets the asset status back to the library inventory upon return.

---

## 🔮 Future Roadmap (SQL Integration)

> 📌 **Next Milestone:** This project currently manages data using in-memory collections (`List<T>`). Upon completing my comprehensive SQL training database course, I will evolve this architecture. 
> 
> The next version will seamlessly substitute runtime lists with a permanent relational database (MS SQL Server / PostgreSQL) using standard SQL queries (`INSERT`, `SELECT`, `UPDATE`) to ensure data persistence and scalability.

---

## 💻 Tech Stack

- **Language:** C# (.NET Core)
- **Paradigm:** Object-Oriented Programming (OOP)

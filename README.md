# 🧑‍🌾 Web Nông Sản Xanh

A full-featured web application for managing clean agricultural products, developed as part of academic projects using **ASP.NET Core MVC** and **SQL Server**.

![MIT License](https://img.shields.io/badge/License-MIT-green.svg)

---

## 📌 Overview

**Web Nông Sản Xanh** is an agricultural e-commerce platform that allows users to explore, purchase products, become agents, publish articles, and manage agricultural listings.  
The platform also aims to expand connections between agents and suppliers — primarily local farmers — enabling them to contact and visit each other directly.  
This creates opportunities for collaboration and supports the development of Vietnam’s agricultural industry.  
The system includes **role-based access**, article/blog publishing, and a product ordering workflow – ideal for learning and applying backend development skills.

---

## 🚀 Technologies Used

- 💻 **Backend**: C#, ASP.NET Core MVC
- 🗃️ **Database**: SQL Server, Entity Framework Core
- 🌐 **Frontend**: HTML, CSS, Bootstrap, JavaScript
- ⚙️ **Tools**: Visual Studio, SQL Server Management Studio (SSMS), Postman
- 🧪 **Testing**: Manual testing via Postman
- 🛠️ **Other**: Role-based authentication, Razor views

---

## 👥 User Roles

The system supports **4 types of users**, each with dedicated permissions:

| Role             | Description                                                                                                                       |
|------------------|-----------------------------------------------------------------------------------------------------------------------------------|
| 🧑‍🌾 User          | Can browse and purchase agricultural products. Users also have the ability to apply for an agency role directly from their account. |
| 🛠️ Admin          | Has full control over the system: manage users, products, categories, view revenue statistics, approve agency requests, and review agency product listings before they go live on the homepage. |
| 🏪 Agency         | Can perform full CRUD operations on their own product listings. Agencies can also view the farm page of Content Writers to discover products posted there. |
| ✍️ Content Writer | Can create, read, update, and delete their own agricultural news articles. They are allowed to view articles posted by others, but cannot modify them. |

---

## 📚 Main Features

- ✅ User registration & login with secure password hashing
- ✅ CRUD operations for products, articles, and categories
- ✅ Product ordering and order history
- ✅ Admin dashboard for global management
- ✅ Blog/news publishing and editing
- ✅ Responsive design for desktop and mobile

---

## 📷 Project Structure

![image](https://github.com/user-attachments/assets/4b510302-6d91-4a1a-9f1e-b7dda3ba1102)

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

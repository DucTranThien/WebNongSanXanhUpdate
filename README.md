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
- ✅ Forgot password functionality with reset link sent via email  
- ✅ Users can apply to become Agencies directly from their profile  
- ✅ CRUD operations for products, articles, and categories  
- ✅ Product ordering and order history management  
- ✅ Multiple payment methods supported: **Cash on Delivery (COD)** and **VNPAY integration**  
- ✅ Default shipping address management in user profile  
- ✅ Admin dashboard for managing users, products, categories, and analytics  
- ✅ Blog/news publishing and editing by Content Writers  
- ✅ Responsive design optimized for both desktop and mobile devices  

---

### 🏠 1. Homepage – Web Nông Sản Xanh
This is the landing page for users to explore organic agricultural products, including vegetables, fruits, and more. The page emphasizes clean food and encourages users to start shopping.

![Homepage](https://github.com/user-attachments/assets/your-image-path-1.png)

---

### 👤 2. User Profile Page
Users can manage their personal information, update profile pictures, phone numbers, and especially set a **default delivery address** used during checkout.

![User Profile](https://github.com/user-attachments/assets/your-image-path-2.png)

---

### 📝 3. Apply to Become an Agency
Users can go through a step-by-step form to apply to become a **Product Agency**. After submitting, the request is placed into a "Pending Approval" state awaiting Admin review.

![Agency Registration Pending](https://github.com/user-attachments/assets/your-image-path-3.png)

---

### 🏪 4. Agency Homepage
Once approved, the user becomes an agency and gains access to their storefront. They can view other content writers' farm pages and explore available products.

![Agency Homepage](https://github.com/user-attachments/assets/your-image-path-4.png)

---

### 📊 5. Agency Dashboard
Agencies can manage their own product listings, track revenue, and see monthly statistics about their product sales. Features include filters, bar/line charts, and real-time numbers.

![Agency Dashboard](https://github.com/user-attachments/assets/your-image-path-5.png)

---

### 🛠️ 6. Admin Dashboard
The Admin has full control over the system: managing categories, certifications, users, and traffic statistics. Graphs show user visit counts throughout the year.

![Admin Dashboard](https://github.com/user-attachments/assets/your-image-path-6.png)

---

### ✅ 7. Approve New Agency
Admin reviews and approves new agency applications. Only approved accounts can post products for sale.

![Approve Agency](https://github.com/user-attachments/assets/your-image-path-7.png)

---

### 🛒 8. Approve Agency Products
Admin can review each new product submitted by agencies. Only after approval will the products appear on the homepage for users to purchase.

![Approve Products](https://github.com/user-attachments/assets/your-image-path-8.png)

---

### ✍️ 9. Agricultural Post Management (Content Writer)
Content Writers can manage and publish agricultural news and product-related articles. The system uses a **Classic Editor** for creating, updating, and organizing posts efficiently.  
Writers can update their own posts and view articles created by others.

![Post Management](https://github.com/user-attachments/assets/your-image-path-9.png)

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

# 🏠 Orphanage Management System

![Status](https://img.shields.io/badge/Status-Completed-brightgreen)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/Framework-.NET%20Windows%20Forms-lightgrey)
![Database](https://img.shields.io/badge/Database-SQL%20Server-orange)
![License](https://img.shields.io/badge/License-Academic-lightblue)

---

## 📘 Project Description

Our Helping Hands Project aims to develop a user-friendly software system that enables orphanages to manage their day-to-day activities more efficiently. This initiative aims to
simplify tasks like keeping track of resident information, managing staff details, and overseeing daily operations. By incorporating features such as admissions, attendance tracking, and resource management, our goal is to streamline the administrative aspects, fostering a transparent and caring environment for the children. With the Helping Hands Project, we're striving to enhance the overall well-being of those under the care of orphanages, allowing caretakers to focus on providing the best support and nurturing atmosphere.

---

## ⚙️ Tech Stack / Tools Used

| Category | Technology |
|-----------|-------------|
| **Programming Language** | C# |
| **IDE** | Visual Studio |
| **Database Server** | Microsoft SQL Server Management Studio (SSMS) |
| **UI Technology** | Windows Forms |
| **Documentation** | Microsoft Word, PDF Report |
| **Version Control** | Git / GitHub |

---

## ✨ Features

| Feature | Description |
|----------|-------------|
| ![Feature](https://img.shields.io/badge/Feature-User%20Registration-success) | New users such as supervisors, caretakers, and accountants can register with unique credentials. |
| ![Feature](https://img.shields.io/badge/Feature-Profile%20Management-blue) | Users can view or edit their profiles based on assigned roles. |
| ![Feature](https://img.shields.io/badge/Feature-Employee%20Management-teal) | Supervisors can manage employee data (add, update, remove) and assign roles. |
| ![Feature](https://img.shields.io/badge/Feature-Orphan%20Management-purple) | Supervisors can add, edit, or remove orphan records with full details. |
| ![Feature](https://img.shields.io/badge/Feature-Financial%20Management-orange) | Accountants can record expenses, track donations, and manage overall budgets. |
| ![Feature](https://img.shields.io/badge/Feature-Role%20Control-yellow) | Supervisors can modify employee roles dynamically. |
| ![Feature](https://img.shields.io/badge/Feature-Authentication-red) | Role-based login and authentication system for secure access. |

---

## 🧮 Database Schema

### **1. Login Table**
| Column | Type | Length | Nullable | Description |
|---------|------|---------|-----------|--------------|
| Username | nvarchar | max | NO | System login username |
| Password | nvarchar | max | NO | Encrypted password |
| Role | nvarchar | max | NO | User role (Supervisor, Employee, etc.) |

### **2. Register Table**
| Column | Type | Length | Nullable |
|---------|------|---------|-----------|
| ID (Primary Key) | int | 10 | NO |
| Name | nvarchar | max | NO |
| Address | nvarchar | max | NO |
| Email | nvarchar | max | NO |
| Number | nvarchar | max | NO |
| Role | nvarchar | max | NO |
| Age | int | 10 | NO |
| BloodGroup | nvarchar | max | NO |
| PreferableTime | nvarchar | max | NO |

### **3. Employee Table**
| Column | Type | Length | Nullable |
|---------|------|---------|-----------|
| ID (Primary Key) | int | 10 | NO |
| Name | nvarchar | max | NO |
| Email | nvarchar | max | NO |
| Role | nvarchar | max | NO |
| PreferableTime | nvarchar | max | NO |
| MobileNumber | nvarchar | max | NO |

### **4. Donor Table**
| Column | Type | Length | Nullable |
|---------|------|---------|-----------|
| donorID (Primary Key) | int | 10 | NO |
| donorName | nvarchar | max | NO |
| donorAddress | nvarchar | max | NO |
| donorEmail | nvarchar | max | NO |
| donationAmount | nvarchar | max | NO |

### **5. Expense Table**
| Column | Type | Length | Nullable |
|---------|------|---------|-----------|
| product | int | 10 | NO |
| description | nvarchar | max | NO |
| amount | nvarchar | max | NO |
| rate | nvarchar | max | NO |
| total | nvarchar | max | NO |

### **6. Orphan Table**
| Column | Type | Length | Nullable |
|---------|------|---------|-----------|
| orphanID (Primary Key) | int | 10 | NO |
| name | nvarchar | max | NO |
| age | int | 10 | NO |
| orphanGender | nvarchar | max | NO |
| bloodGroup | nvarchar | max | NO |
| orphanCustodianName | nvarchar | max | NO |
| number | nvarchar | max | NO |
| address | nvarchar | max | NO |
| email | nvarchar | max | NO |

---

## UI
<img width="1056" height="635" alt="image" src="https://github.com/user-attachments/assets/eee20314-22b1-452b-a8bb-8f41a17d5a48" />
<img width="1064" height="629" alt="image" src="https://github.com/user-attachments/assets/e53ddca8-d59c-4bcd-b642-726997c8b8f5" />
<img width="1056" height="634" alt="image" src="https://github.com/user-attachments/assets/78bb3809-4601-426a-b382-47edf259b623" />
<img width="1056" height="637" alt="image" src="https://github.com/user-attachments/assets/aca41e84-49be-4538-a38a-cfafc16bd783" />
<img width="1056" height="628" alt="image" src="https://github.com/user-attachments/assets/e6a195b5-292c-4227-939e-467623ece0df" />
<img width="1056" height="628" alt="image" src="https://github.com/user-attachments/assets/5d55b43a-8ac0-4213-9e59-0e557b8b3f9f" />
<img width="1056" height="636" alt="image" src="https://github.com/user-attachments/assets/5d05d195-caf1-42c3-af22-6c72f63e9bd1" />
<img width="1056" height="639" alt="image" src="https://github.com/user-attachments/assets/f5fc8655-f096-4ed0-8c6f-b821563ef877" />
<img width="1056" height="637" alt="image" src="https://github.com/user-attachments/assets/0d8f25ad-9dbd-4eaa-8035-4ecf2edec924" />
<img width="1056" height="637" alt="image" src="https://github.com/user-attachments/assets/821bed6b-ef81-499d-90d4-def60fbcdd27" />
<img width="1056" height="633" alt="image" src="https://github.com/user-attachments/assets/194576dc-5204-440a-b05c-ae11a86333e7" />
<img width="1056" height="633" alt="image" src="https://github.com/user-attachments/assets/29d6e711-b1f9-457d-b5cf-655300f061b5" />
<img width="1056" height="628" alt="image" src="https://github.com/user-attachments/assets/ff0a431c-be0e-493f-b9c8-97c31fc90a7d" />





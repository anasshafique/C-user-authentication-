# CET137 Assessment 1 – C# Console User Authentication System

This project is a **First Year – First Semester University Assessment** for the CET137 module.  
It is a console-based **User Authentication System** developed in **C#**, demonstrating core programming concepts such as file handling, validation, object-oriented programming, and user interaction.

---

## 🎯 Project Purpose

The purpose of this project was to apply fundamental C# concepts learned during the first semester, including:

- Classes and Objects  
- Methods and Control Structures  
- File Input/Output  
- Arrays and String Handling  
- Basic Security Validation  
- Console-Based User Interface

---

## 🚀 Features

- User Registration with username and password  
- Username validation to prevent duplicate accounts  
- Password validation with:
  - Minimum 10-character requirement  
  - Check against common passwords stored in `Password.txt`  
- Secure login system verifying:
  - Username existence  
  - Correct password matching  
- Menu-driven console application  
- Account data stored in individual text files

---

## 🛠 Technologies Used

- **C# (.NET Console Application)**
- `System.IO` for file handling  
- Object-Oriented Programming (OOP)  
- Exception-safe input validation

---

## 📂 Project Structure

- `Program.cs` – Controls menu system and program flow  
- `Account.cs` – Handles all authentication logic:
  - Registration  
  - Username Validation  
  - Password Validation  
  - Login Verification  
- `Password.txt` – List of common passwords for security check  
- `[username].TXT` – Stores individual user credentials

---

## ▶ How to Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/anasshafique/C-user-authentication-.git

# 📚 Examination System

A full-stack web application for managing online courses, exams, and student evaluations. Built using **Blazor Server** and **Entity Framework Core**, the system allows instructors to create and manage exams, while students can enroll in courses, take exams, and view their grades.

## 🛠️ Features

### 👨‍🏫 Instructor Features
- Create and manage courses
- Create exams and add questions (MCQ with correct answer)
- Assign exams to courses
- View enrolled students and their results

### 👨‍🎓 Student Features
- View available courses and enroll
- View enrolled courses and associated exams
- Take exams with real-time answer selection
- View exam grades after submission

### 🔐 Authentication & Authorization
- Role-based access (Instructor / Student)
- Secure exam access (students can take an exam only once)

### 📊 Admin or Instructor Dashboard
- Statistics on course enrollments and exam results

## 🧱 Tech Stack

- **Blazor Server** (ASP.NET Core)
- **Entity Framework Core**
- **SQL Server** (or SQLite for testing)
- **MudBlazor** (UI component library)
- **ASP.NET Identity** (Authentication & Role Management)

## 🧪 Database Schema Overview

- `Student` ←→ `Course` (Many-to-Many through `StdCrs`)
- `Course` ←→ `Exam` (One-to-One)
- `Exam` ←→ `Question` ←→ `Answer` (Hierarchical)
- Each `Student` has grades stored in `StdCrs.Grade`

# Thanks for your time!
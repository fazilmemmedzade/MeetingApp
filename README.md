# 📅 MeetingApp

**MeetingApp** is a simple meeting registration web application built with **ASP.NET Core MVC and .NET 8**.

The application allows users to submit their information and attendance status for a meeting, while providing a separate page where submitted participants can be viewed and their details inspected.

## ✨ Features

### 📝 Meeting Registration

Users can apply to participate in a meeting by providing:

* Full name
* Phone number
* Email address
* Attendance status

The registration form includes validation and allows users to indicate whether they will attend the meeting.

### ✅ Attendance Status

Each participant has an attendance status:

* **Will Attend**
* **Will Not Attend**

The application uses the attendance status to distinguish participants in the participant list.

### 👥 Participant List

The participant list displays all registered users and their attendance status.

Participants who are attending and those who are not attending are visually distinguished, making the list easy to understand.

The page also calculates and displays the total number of participants who will attend the meeting.

### 🔎 Participant Details

Each participant has a dedicated details page.

The details page provides additional information about the selected registration and clearly displays the participant's attendance status.

### 🎉 Registration Confirmation

After successfully submitting the registration form, the user is redirected to a confirmation page.

The application also calculates the current number of participants who have confirmed that they will attend.

## 🏗️ Architecture

MeetingApp follows the **ASP.NET Core MVC** architectural pattern.

The project is organized into:

* **Controllers** — Handle HTTP requests and application flow
* **Models** — Represent application data
* **Views** — Provide the user interface
* **wwwroot** — Contains static files such as CSS and JavaScript

The main meeting functionality is handled by `MeetingController`, while participant data and repository operations are implemented in the `Models` folder.

## 🛠️ Technologies

The project is built using:

* **C#**
* **ASP.NET Core MVC**
* **.NET 8**
* **Razor Views**
* **HTML**
* **CSS**
* **Bootstrap**

The project targets:

```text
net8.0
```

and uses the ASP.NET Core Web SDK.

## 📖 Usage

### 1. Register for the Meeting

Navigate to the meeting application and open the registration form.

Enter your:

```text
Name
Phone
Email
Attendance Status
```

Then submit the form.

### 2. View Participants

The participant list displays all submitted registrations.

Each participant is shown with their name and attendance status.

### 3. View Details

Select **Details** for a participant to view their registration information and attendance status.

## 📁 Project Structure

```text
MeetingApp/
│
├── Controllers/
│   ├── HomeController.cs
│   └── MeetingController.cs
│
├── Models/
│   ├── MeetingInfo.cs
│   ├── Repository.cs
│   └── UserInfo.cs
│
├── Views/
│   ├── Home/
│   ├── Meeting/
│   └── Shared/
│
├── wwwroot/
│
├── Properties/
│
├── Program.cs
├── appsettings.json
├── appsettings.Development.json
├── MeetingApp.csproj
├── MeetingApp.sln
└── README.md
```

## 🎯 Project Purpose

MeetingApp was created as a practical **ASP.NET Core MVC** project for managing a simple meeting registration workflow.

The project demonstrates the fundamental concepts of MVC web application development, including:

* Controllers and actions
* Razor Views
* Model binding
* Form submission
* Validation
* Passing data between controllers and views
* In-memory data management
* Dynamic participant lists
* Detail pages

The application focuses on keeping the workflow simple:

**Register → Submit → Confirmation → View Participants → View Details**

## 🚀 Getting Started

### Requirements

To build and run MeetingApp, you need:

* Windows, Linux, or macOS
* .NET 8 SDK
* Visual Studio 2022 or newer, or another compatible .NET IDE

### Clone the Repository

```bash
git clone https://github.com/fazilmemmedzade/MeetingApp.git
```

Navigate to the project directory:

```bash
cd MeetingApp
```

Run the application:

```bash
dotnet run
```

Alternatively, open `MeetingApp.sln` in Visual Studio and run the project.

## 👨‍💻 Author

**Fazil Məmmədzadə**

<a href="https://github.com/fazilmemmedzade">Github</a>
<a href="https://fazilmemmedzade.github.io/Portfolio">Portfolio</a>

---

## 📸 Screenshots

| Meeting - Home | Meeting - Apply |
|:--------------:|:---------------:|
| <img width="460" alt="Meeting 1" src="https://github.com/fazilmmmdzad/My-Files/blob/main/Meeting1.png" /> | <img width="460" alt="Meeting 2" src="https://github.com/fazilmmmdzad/My-Files/blob/main/Meeting2.png" /> |

| Meeting - List | Meeting - Details |
|:--------------:|:-----------------:|
| <img width="460" alt="Meeting 3" src="https://github.com/fazilmmmdzad/My-Files/blob/main/Meeting3.png" /> | <img width="460" alt="Meeting 4" src="https://github.com/fazilmmmdzad/My-Files/blob/main/Meeting4.png" /> |

| Meeting - Thanks |
|:----------------:|
| <img width="920" alt="Meeting 5" src="https://github.com/fazilmmmdzad/My-Files/blob/main/Meeting5.png" /> |

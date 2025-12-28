🎓 Examination Management System
A robust, console-based C# Examination System built using Object-Oriented Programming (OOP) principles. This system allows instructors to design different types of exams (Final and Practical) with diverse question formats, including MCQ and True/False.

📝 Description
This project demonstrates the core pillars of OOP: Inheritance, Encapsulation, Abstraction, and Polymorphism. It provides a complete workflow for creating a subject, defining an exam's structure, adding questions with specific marks, and simulating the student's examination experience with real-time grading.

🚀 Use Case: Academic Assessment
The system is designed for educational environments where two distinct testing modes are required:

Final Exams:

Goal: Comprehensive evaluation of student knowledge.

Features: Supports both MCQ and True/False questions. Displays the total grade and maximum possible score upon completion.

Practical Exams:

Goal: Testing specific technical choices or scenarios.

Features: Restricted to MCQ questions only. Upon completion, it reveals the model answers for immediate review.

🛠️ Key Features
Subject Management: Every exam is linked to a specific academic subject.

Dynamic Question Creation: Support for multiple choice and boolean (True/False) logic.

Input Validation: Robust error handling for user inputs (duration, indices, and data types).

Grading Engine: Automatically calculates scores based on assigned question marks.

Abstraction: Utilizes Base_Exam and Base_Question classes to allow for easy future extensions.

💻 Tech Stack
Language: C#

Framework: .NET 6.0 / 8.0

Paradigm: Object-Oriented Programming (OOP)

📊 Sample Output
1. Configuration Phase
Plaintext

Enter Subject Name:
C# Advanced
Please enter a valid exam type (1 for Final, 2 for Practical):
1
Enter Exam Duration in minutes (30-180):
60
Please enter Number of Questions:
2
2. Examination Phase
Plaintext

Question 1:
The Body of the Question = Is C# a functional language?
The Choices are:
1. True
2. False
The Grade of the Question = 5
Enter answer (true/false only): false
Correct Answer
==================================
Final Grade: 5/5
🏗️ Project Architecture
Subject: Orchestrates the relationship between the course and the exam.

Base_Exam: Abstract class defining the lifecycle of an exam (ShowExam, StartExam).

Final: Implementation that calculates grades.

Practical: Implementation that shows correct answers at the end.

Base_Question: Abstract class for question properties.

Mcq_Class: Handles questions with multiple options.

True_OR_False: Handles boolean questions.

📥 How to Run
Clone the repository:

Bash

git clone https://github.com/YourUsername/ExaminationSystem.git
Navigate to the directory:

Bash

cd ExaminationSystem
Build and Run:

Bash

dotnet run

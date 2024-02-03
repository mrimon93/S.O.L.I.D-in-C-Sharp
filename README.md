# SOLID Principles in C# Geometric Shapes

## Overview

This C# project is an implementation of geometric shapes that adheres to the SOLID principles. SOLID is an acronym representing a set of five design principles for creating maintainable and scalable software. The project focuses on five key SOLID principles: Single Responsibility Principle (SRP), Open/Closed Principle (OCP), Liskov Substitution Principle (LSP), Interface Segregation Principle (ISP), and Dependency Inversion Principle (DIP).

## Features

### 1. Single Responsibility Principle (SRP)

Each class within the project has a single responsibility. The `Shape`, `Circle`, `Rectangle`, `AreaCalculator`, and `ConsoleLogger` classes are designed with a clear and distinct purpose, promoting maintainability and readability.

### 2. Open/Closed Principle (OCP)

The `AreaCalculator` class is open for extension but closed for modification. It can easily accommodate new shapes without altering existing code, demonstrating adherence to the Open/Closed Principle.

### 3. Liskov Substitution Principle (LSP)

The Liskov Substitution Principle is exemplified through the `Bird` and `Penguin` classes. Objects of a superclass (`Bird`) can be replaced with objects of a subclass (`Penguin`) without affecting the correctness of the program.

### 4. Interface Segregation Principle (ISP)

The Interface Segregation Principle is showcased through the `IDocument`, `IPhotoCopier`, `BasicDocument`, and `AdvancedDocument` interfaces and classes. Each class implements only the interfaces it needs, preventing the implementation of unnecessary methods.

### 5. Dependency Inversion Principle (DIP)

The project employs dependency inversion by introducing the `ILogger` interface and the `ConsoleLogger` class. This allows high-level modules (e.g., `AreaCalculator`) to depend on abstractions (`ILogger`), not on concrete implementations, fostering flexibility and testability.

## How to Use

1. Clone the repository to your local machine.
2. Build and run the project using a C# IDE or command-line tools.
3. Explore the `Shape`, `Circle`, `Rectangle`, `AreaCalculator`, `ConsoleLogger`, `Bird`, `Penguin`, `IDocument`, `IPhotoCopier`, `BasicDocument`, and `AdvancedDocument` classes to understand how SOLID principles are applied.
4. Modify or extend the project to experiment with new geometric shapes while adhering to SOLID principles.

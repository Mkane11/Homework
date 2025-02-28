// Written by Mamoutou Kane
// Date: 02/27/2025

using System;

// 1. Vehicles and Cars
class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Year} {Make} {Model}";
    }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }
    public override string ToString()
    {
        return base.ToString() + $" with {NumberOfDoors} doors";
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
    public Motorcycle(string make, string model, int year, bool hasSidecar) : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }
    public override string ToString()
    {
        return base.ToString() + $" (Has Sidecar: {HasSidecar})";
    }
}

// 2. Employees and Specializations
class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Employee: {Name}, Salary: ${Salary}";
    }
}

class Manager : Employee
{
    public int NumberOfEmployeesManaged { get; set; }
    public Manager(string name, double salary, int numEmployees) : base(name, salary)
    {
        NumberOfEmployeesManaged = numEmployees;
    }
    public override string ToString()
    {
        return base.ToString() + $", Manages {NumberOfEmployeesManaged} employees";
    }
}

class Engineer : Employee
{
    public string Specialization { get; set; }
    public Engineer(string name, double salary, string specialization) : base(name, salary)
    {
        Specialization = specialization;
    }
    public override string ToString()
    {
        return base.ToString() + $", Specialization: {Specialization}";
    }
}

// 3. Shapes and Areas
abstract class Shape
{
    public string Color { get; set; }
    public Shape(string color)
    {
        Color = color;
    }
    public abstract double GetArea();
    public override string ToString()
    {
        return $"{Color} Shape";
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(string color, double width, double height) : base(color)
    {
        Width = width;
        Height = height;
    }
    public override double GetArea()
    {
        return Width * Height;
    }
    public override string ToString()
    {
        return base.ToString() + $", Width: {Width}, Height: {Height}, Area: {GetArea()}";
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
    public override string ToString()
    {
        return base.ToString() + $", Radius: {Radius}, Area: {GetArea()}";
    }
}

// 4. Animals and Sounds
class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public virtual string MakeSound()
    {
        return "Some generic animal sound";
    }
    public override string ToString()
    {
        return $"Animal: {Name}, Sound: {MakeSound()}";
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public override string MakeSound()
    {
        return "Bark";
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }
    public override string MakeSound()
    {
        return "Meow";
    }
}

// 5. Library System
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearPublished { get; set; }
    public Book(string title, string author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
    }
    public override string ToString()
    {
        return $"{Title} by {Author} ({YearPublished})";
    }
}

class EBook : Book
{
    public double FileSizeMB { get; set; }
    public EBook(string title, string author, int yearPublished, double fileSize) : base(title, author, yearPublished)
    {
        FileSizeMB = fileSize;
    }
    public override string ToString()
    {
        return base.ToString() + $", File Size: {FileSizeMB}MB";
    }
}

class PrintedBook : Book
{
    public int PageCount { get; set; }
    public PrintedBook(string title, string author, int yearPublished, int pageCount) : base(title, author, yearPublished)
    {
        PageCount = pageCount;
    }
    public override string ToString()
    {
        return base.ToString() + $", Pages: {PageCount}";
    }
}


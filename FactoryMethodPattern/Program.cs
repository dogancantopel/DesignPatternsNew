using FactoryMethodPattern.Concretes;
using FactoryMethodPattern.Contracts;

DocumentCreator creator;

// Creating a Resume
creator = new ResumeCreator();
creator.PrintDocument(); 

// Creating a Report
creator = new ReportCreator();
creator.PrintDocument(); 

Console.ReadLine();
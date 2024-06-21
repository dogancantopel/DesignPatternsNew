// See https://aka.ms/new-console-template for more information
using AbstractFactory.Contracts;
using AbstractFactory.Factories;

new EngineManager(new BmwFactory()).RunAllEngines();

new EngineManager(new MercedesFactory()).RunAllEngines();

Console.ReadLine();
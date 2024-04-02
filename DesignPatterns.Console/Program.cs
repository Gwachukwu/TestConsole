﻿using DesignPatterns.Factory;

Console.WriteLine("Please type a command: (read,write)");
string? command = Console.ReadLine();

var operation = FileOperationFactory.CreateOperation(command ?? "");

Console.WriteLine("Please enter a file path");
string? filePath = Console.ReadLine();

operation.Execute(filePath ?? "");
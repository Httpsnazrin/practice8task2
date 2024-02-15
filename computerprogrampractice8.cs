using practice8task2;

Computer computer = new Computer(1, "XPS 15", "Dell", 2000, "Windows", "Intel", 16);

Console.WriteLine($"Price with tax: {computer.CalcPriceWithTax()}");
computer.DisplayInfo();
computer.GetUsefulOrNot();


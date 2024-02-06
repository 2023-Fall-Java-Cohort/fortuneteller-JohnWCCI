// See https://aka.ms/new-console-template for more information

using FortuneTeller;

ConsoleDisplay display = new ConsoleDisplay("Fortune Teller");
ProcessUsers process = new ProcessUsers(display);
process.StartProcess(); 




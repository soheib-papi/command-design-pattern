
using command_design_pattern.command;
using command_design_pattern.command.fx;

var service = new CustomerService();
var command = new AddCustomerCommand(service);

var button = new Button(command);

button.Click();

Console.ReadLine();
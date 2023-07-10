
using command_design_pattern.command.fx;

namespace command_design_pattern.command;
public class AddCustomerCommand : ICommand
{
    private readonly CustomerService customerService;

    public AddCustomerCommand(CustomerService customerService)
    {
        this.customerService = customerService;
    }

    public void Execute()
    {
        customerService.AddCustomer();
    }
}
namespace command_design_pattern.command.fx;
public class Button
{
    private string label;
    private readonly ICommand command;

    public Button(ICommand command)
    {
        this.command = command;
    }

    public string Label { get => label; set => label = value; }

    public void Click()
    {
        command.Execute();
    }
}
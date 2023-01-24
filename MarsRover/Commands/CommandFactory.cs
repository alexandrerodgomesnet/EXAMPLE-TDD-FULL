namespace MarsRover.Commands;

public class CommandFactory
{
    public static ICommand CreateFrom(char command) => command switch
    {
        'M' => new MoveForwardCommand(),
        'R' => new TurnRightCommand(),
        'L' => new TurnLeftCommand(),
        _ => throw new NotSupportedException($"Command {command} not supported.")
    };    
}
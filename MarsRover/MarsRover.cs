using MarsRover.Commands;
using MarsRover.Rovers;

namespace MarsRover;

public class MarsRover
{
    private Rover _rover;
    public MarsRover(string initialState)
    {
        _rover = RoverFactory.CreateFrom(initialState);
    }
    
    public string Execute(string stringCommands)
    {        
        var commands = stringCommands.ToCharArray()
            .Select(CommandFactory.CreateFrom)
            .ToList();
        
        commands.ForEach(command => _rover = _rover.Apply(command));

        return _rover.PrintState();
    }    
}
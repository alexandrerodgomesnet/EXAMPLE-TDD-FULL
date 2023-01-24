using MarsRover.Commands;
using MarsRover.Directions;

namespace MarsRover.Rovers;

public class Rover
{
    private readonly IDirection _direction;
    private readonly Position _position;
    public Rover(Position position, IDirection direction)
    {
        _position = position;
        _direction = direction;
    }

    public Rover Apply(ICommand command) => ApplyCommand((dynamic) command);
    private Rover ApplyCommand(TurnRightCommand c) => new Rover(_position, _direction.ToRight());
    private Rover ApplyCommand(TurnLeftCommand c) => new Rover(_position, _direction.ToLeft());
    private Rover ApplyCommand(MoveForwardCommand c) => new Rover(_direction.MoveForward(_position), _direction);
    public string PrintState() => $"{_position.X}:{_position.Y}:{_direction.AsStringCommand()}";
}
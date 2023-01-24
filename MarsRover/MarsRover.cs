using MarsRover.Directions;

namespace MarsRover;

public class MarsRover
{
    private readonly string _initialState;
    private IDirection _direction;
    private Position _position;
    public MarsRover(string initialState)
    {
        _initialState = initialState;
        _position = new Position();
    }

    public string Execute(string commands)
    {
        var states = _initialState.Split(":");
        _position.X = int.Parse(states[0]);
        _position.Y = int.Parse(states[1]);
        var directionStringCommand = states[2];

        if (commands == "M")
        {
            _direction = DirectionFactory.CreateFrom(directionStringCommand);
            _position = _direction.MoveForward(_position);
        }

        return $"{_position.X}:{_position.Y}:{directionStringCommand}";
    }
}

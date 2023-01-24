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
            _direction = CreateDirectionFrom(directionStringCommand);
            _position = _direction.MoveForward(_position);
        }

        return $"{_position.X}:{_position.Y}:{directionStringCommand}";
    }

    private IDirection CreateDirectionFrom(string direction)
    {
        switch (direction)
        {
            case "N":
                return new North();
            case "W":
                return new West();
            case "E":
                return new East();
            default:
                throw new NotSupportedException($"Direction {direction} is not supported.");
        }
    }
}

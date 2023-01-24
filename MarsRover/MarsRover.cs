namespace MarsRover;

public class MarsRover
{
    private readonly string _initialState;
    private readonly Position _position;
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
        var direction = states[2];

        if (commands == "M")
        {
            switch (direction)
            {
                case "N":
                    _position.Y++;
                    break;
                case "W":
                    _position.X--;
                    break;
                case "E":
                    _position.X++;
                    break;
            }
        }

        return $"{_position.X}:{_position.Y}:{direction}";
    }
}

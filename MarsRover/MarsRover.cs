namespace MarsRover;

public class MarsRover
{
    private readonly string _initialState;

    public MarsRover(string initialState)
    {
        _initialState = initialState;
    }

    public string Execute(string commands)
    {
        var states = _initialState.Split(":");
        var positionX = int.Parse(states[0]);
        var positionY = int.Parse(states[1]);
        var direction = states[2];

        if(commands == "M")
        {
            if(direction == "N")
                return $"{positionX}:{positionY + 1}:{direction}";
            else
                return $"{positionX - 1}:{positionY}:{direction}";
        }

        return _initialState;
    }
}
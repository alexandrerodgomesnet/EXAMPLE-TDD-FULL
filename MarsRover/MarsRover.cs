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
            switch (direction)
            {
                case "N":
                    positionY++;
                    break;
                case "W":
                    positionX--;
                    break;
                case "E":
                    positionX++;
                    break;
            }
        }

        return $"{positionX}:{positionY}:{direction}";
    }
}
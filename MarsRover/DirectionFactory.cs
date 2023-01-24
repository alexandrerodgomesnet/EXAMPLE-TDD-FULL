namespace MarsRover;

public class DirectionFactory
{
    public static IDirection CreateFrom(string direction)
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

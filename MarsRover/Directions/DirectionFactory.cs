namespace MarsRover.Directions;

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
            case "S":
                return new South();
            default:
                throw new NotSupportedException($"Direction {direction} is not supported.");
        }
    }
}

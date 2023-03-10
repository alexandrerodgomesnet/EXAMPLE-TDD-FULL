namespace MarsRover.Directions;

public class DirectionFactory
{
    public static IDirection CreateFrom(string direction) => direction switch
    {
        "N" => new North(),
        "W" => new West(),
        "E" => new East(),
        "S" => new South(),
        _ => throw new NotSupportedException($"Direction {direction} is not supported.")
    };
}

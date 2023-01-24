namespace MarsRover;

public class North : IDirection
{
    public static Position MoveForward(Position position)
    {
        position.Y++;
        return position;
    }
}

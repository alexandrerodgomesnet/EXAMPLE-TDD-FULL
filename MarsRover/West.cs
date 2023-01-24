namespace MarsRover;

public class West : IDirection
{
    public static Position MoveForward(Position position)
    {
        position.X--;
        return position;
    }
}

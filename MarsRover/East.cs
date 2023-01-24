namespace MarsRover;

public class East : IDirection
{
    public static Position MoveForward(Position position)
    {
        position.X++;
        return position;
    }
}
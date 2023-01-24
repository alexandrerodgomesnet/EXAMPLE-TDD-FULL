namespace MarsRover;

public class East
{
    public static Position MoveForward(Position position)
    {
        position.X++;
        return position;
    }
}
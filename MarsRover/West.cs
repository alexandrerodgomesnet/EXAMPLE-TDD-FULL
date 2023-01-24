namespace MarsRover;

public class West
{
    public static Position MoveForward(Position position)
    {
        position.X--;
        return position;
    }
}

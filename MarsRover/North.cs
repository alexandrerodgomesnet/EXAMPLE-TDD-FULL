namespace MarsRover;

public class North
{
    public static Position MoveForward(Position position)
    {
        position.Y++;
        return position;
    }
}

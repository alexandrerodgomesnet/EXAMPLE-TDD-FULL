namespace MarsRover;

public class East : IDirection
{
    public Position MoveForward(Position position)
    {
        position.X++;
        return position;
    }
}
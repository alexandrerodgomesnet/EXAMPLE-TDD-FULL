namespace MarsRover.Directions;

public class West : IDirection
{
    public Position MoveForward(Position position)
    {
        position.X--;
        return position;
    }
}

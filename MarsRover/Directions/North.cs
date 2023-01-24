namespace MarsRover.Directions;

public class North : IDirection
{
    public Position MoveForward(Position position)
    {
        position.Y++;
        return position;
    }
}

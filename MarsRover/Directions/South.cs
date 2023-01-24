namespace MarsRover.Directions;
public class South: IDirection
{
    public Position MoveForward(Position position)
    {
        position.Y--;
        return position;
    }
}
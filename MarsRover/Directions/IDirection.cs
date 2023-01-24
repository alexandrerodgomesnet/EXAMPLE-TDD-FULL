namespace MarsRover.Directions;
public interface IDirection
{
    string AsStringCommand();
    Position MoveForward(Position position);
    IDirection ToRight();
}

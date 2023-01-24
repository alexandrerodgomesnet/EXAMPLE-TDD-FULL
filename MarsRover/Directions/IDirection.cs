using MarsRover.Rovers;

namespace MarsRover.Directions;

public interface IDirection
{
    string AsStringCommand();
    Position MoveForward(Position position);
    IDirection ToLeft();
    IDirection ToRight();
}

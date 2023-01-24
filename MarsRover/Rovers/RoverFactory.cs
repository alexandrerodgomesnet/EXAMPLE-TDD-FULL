using MarsRover.Directions;

namespace MarsRover.Rovers;

public class RoverFactory
{
    public static Rover CreateFrom(string initialState)
    {
        var states = initialState.Split(":");
        var x = int.Parse(states[0]);
        var y = int.Parse(states[1]);
        var directionStringCommand = states[2];

        var position = new Position(x, y);
        var direction = DirectionFactory.CreateFrom(directionStringCommand);
        return new Rover(position, direction);
    }
}
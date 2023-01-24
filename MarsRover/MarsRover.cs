using MarsRover.Directions;

namespace MarsRover;

public class MarsRover
{
    private readonly string _initialState;
    private IDirection _direction;
    private Position _position;
    public MarsRover(string initialState)
    {
        _initialState = initialState;
    }

    public string Execute(string commands)
    {
        var states = _initialState.Split(":");
        var x = int.Parse(states[0]);
        var y = int.Parse(states[1]);
        _position = new Position(x, y);
        var directionStringCommand = states[2];

        _direction = DirectionFactory.CreateFrom(directionStringCommand);
        
        if (commands == "M")
            _position = _direction.MoveForward(_position);
        

        if (commands == "R")       
            _direction = _direction.ToRight();

        if (commands == "L")       
            _direction = _direction.ToLeft();
        

        return $"{_position.X}:{_position.Y}:{_direction.AsStringCommand()}";
    }
}

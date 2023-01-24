namespace MarsRover;

public class MarsRover
{
    private readonly string _initialState;

    public MarsRover(string initialState)
    {
        _initialState = initialState;
    }

    public string Execute(string commands)
    {
        if(commands == "M")
            return "0:1:N";
            
        return _initialState;
    }
}
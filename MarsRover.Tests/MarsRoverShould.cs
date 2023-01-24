using FluentAssertions;

namespace MarsRover.Tests;

public class MarsRoverShould
{
    [Theory]
    [InlineData("0:0:N")]
    [InlineData("2:1:W")]
    public void PrintInitialState(string initialState)
    {        
        var marsRover = new MarsRover(initialState);

        var result = marsRover.Execute("");

        result.Should().Be(initialState);
    }
}
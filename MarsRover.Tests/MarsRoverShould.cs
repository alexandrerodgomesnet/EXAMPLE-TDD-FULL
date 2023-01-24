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

    [Fact]
    public void MoveForward()
    {
        var marsRover = new MarsRover("0:0:N");

        var result = marsRover.Execute("M");

        result.Should().Be("0:1:N");
    }
}
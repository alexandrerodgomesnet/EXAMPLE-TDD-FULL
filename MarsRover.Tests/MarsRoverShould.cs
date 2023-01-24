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

    [Theory]
    [InlineData("0:0:N", "0:1:N")]
    [InlineData("1:1:N", "1:2:N")]
    [InlineData("1:1:W", "0:1:W")]
    [InlineData("1:1:E", "2:1:E")]
    public void MoveForward(string initialState, string expectedFinalState)
    {
        var marsRover = new MarsRover(initialState);

        var result = marsRover.Execute("M");

        result.Should().Be(expectedFinalState);
    }
}
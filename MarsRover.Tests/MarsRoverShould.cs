using FluentAssertions;

namespace MarsRover.Tests;

public class MarsRoverShould
{
    [Theory]
    [InlineData("0:0:N", "", "0:0:N")]
    [InlineData("2:1:W", "", "2:1:W")]
    [InlineData("0:0:N", "M", "0:1:N")]
    [InlineData("1:1:N", "M", "1:2:N")]
    [InlineData("1:1:W", "M", "0:1:W")]
    [InlineData("1:1:E", "M", "2:1:E")]
    [InlineData("1:1:S", "M", "1:0:S")]
    public void ExecuteCommands(string initialState, string command, string expectedFinalState)
    {
        var marsRover = new MarsRover(initialState);

        var result = marsRover.Execute(command);

        result.Should().Be(expectedFinalState);
    }
}
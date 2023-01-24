using FluentAssertions;

namespace MarsRover.Tests;

public class MarsRoverShould
{
    [Fact]
    public void PrintInitialState()
    {        
        var marsRover = new MarsRover("0:0:N");

        var result = marsRover.Execute("");

        result.Should().Be("0:0:N");
    }
}
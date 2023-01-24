using FluentAssertions;

namespace MarsRover.Tests;

public class MarsRoverShould
{
    [Fact]
    public void PrintInitialStateFromOnePosition()
    {        
        var marsRover = new MarsRover("0:0:N");

        var result = marsRover.Execute("");

        result.Should().Be("0:0:N");
    }

    [Fact]
    public void PrintInitialStateFromAnotherPosition()
    {        
        var marsRover = new MarsRover("2:1:W");

        var result = marsRover.Execute("");

        result.Should().Be("2:1:W");
    }
}
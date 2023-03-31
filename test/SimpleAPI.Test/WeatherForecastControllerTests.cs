using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class WeatherForecastControllerTests
{
    WeatherForecastController Sut = new WeatherForecastController(logger: null);

    [Fact]
    public void GetWeatherForecastReturnsValues()
    {
        // Arrange

        // Act
        var actual = Sut.Get();

        // Assert
        Assert.NotNull(actual);
        Assert.NotEmpty(actual);
    }
}

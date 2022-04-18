using ChoiceHelper.Core.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ChoiceHelper.Core.Tests.Domain.Entities;

public class PossibilityTests
{
    [Fact]
    public void Constructor_Creation_SetsName()
    {
        // Given
        string name = "Test Possiblity Name";

        // When
        var possibility = new Possibility(name);

        // Then
        possibility.Name.Should().Be(name);
    }
    [Fact]
    public void Constructor_Creation_InitPosibilityList()
    {
        // When
        var possibility = new Possibility("Test Choice Name");

        // Then
        possibility.Labels.Should().BeEmpty();
    }

    [Fact]
    public void Score_PositiveAndNegatives1_ReturnsSumOfLabelScores()
    {
        // When
        var possibility = new Possibility("Chocolate") { Labels = new List<PossibilityLabel> { new PossibilityLabel("Fat", -3), new PossibilityLabel("Sweet", -2), new PossibilityLabel("Delicious", 2) } };


        // Then
        possibility.Score.Should().Be(-3);
    }

    [Fact]
    public void Score_PositiveAndNegatives2_ReturnsSumOfLabelScores()
    {
        // When
        var possibility = new Possibility("Soup") { Labels = new List<PossibilityLabel> { new PossibilityLabel("Very Healthy", 3), new PossibilityLabel("Bad taste", -2) } };


        // Then
        possibility.Score.Should().Be(1);
    }


    
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void Name_NoInvalidValue(string invalidValue)
    {
        // Given
        var possibility = new Possibility("Test Possiblity Name");

        // When
        Action act = () => possibility.Name = invalidValue;

        // Then
        act.Should().Throw<ArgumentException>();
    }
}

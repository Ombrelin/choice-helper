using System;
using System.Collections.Generic;
using ChoiceHelper.Core.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace ChoiceHelper.Core.Tests.Domain.Entities;

public class ChoiceTests
{
    [Fact]
    public void Constructor_Creation_SetsName()
    {
        // Given
        string name = "Test Choice Name";
        
        // When
        var choice = new Choice(name);
        
        // Then
        choice.Name.Should().Be(name);
    }
    
    [Fact]
    public void Constructor_Creation_InitPosibilityList()
    {
        // When
        var choice = new Choice("Test Choice Name");
        
        // Then
        choice.Possibilities.Should().BeEmpty();
    }

    
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void Name_NoInvalidValue(string invalidValue)
    {
        // Given
        var choice = new Choice("Test Choice Name");

        // When
        Action act = () => choice.Name = invalidValue;
        
        // Then
        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void RankedPossibilities_OrdersPossibilitiesByLabelScoreSum()
    {
        // Given
        var choice = new Choice("What to eat ? ")
        {
            Possibilities = new List<Possibility>
            {
                new Possibility("Apple") { Labels = new List<PossibilityLabel> { new PossibilityLabel("Healthy", 2) }}, // 2
                new Possibility("Pear") { Labels = new List<PossibilityLabel> { new PossibilityLabel("Healthy", 2), new PossibilityLabel("Yummy", 1) }}, // 3
                new Possibility("Cheese"){ Labels = new List<PossibilityLabel> { new PossibilityLabel("Fat", -2), new PossibilityLabel("Delicious", 2) }}, // 0
                new Possibility("Soup"){ Labels = new List<PossibilityLabel> { new PossibilityLabel("Very Healthy", 3), new PossibilityLabel("Bad taste", -2) }}, // 1
                new Possibility("Chocolate"){ Labels = new List<PossibilityLabel> { new PossibilityLabel("Fat", -3),new PossibilityLabel("Sweet", -2), new PossibilityLabel("Delicious", 2) }}, // -3
            }
        };

        // When
        List<Possibility> result = choice.RankedPossibilities;

        // Then
        result[0].Name.Should().Be("Pear");
        result[1].Name.Should().Be("Apple");
        result[2].Name.Should().Be("Soup");
        result[3].Name.Should().Be("Cheese");
        result[4].Name.Should().Be("Chocolate");
    }
}
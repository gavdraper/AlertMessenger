using System;
using Xunit;

namespace AlertMessenger.Test
{
    public class CardBuilderTests
    {
        [Fact]
        public void CreateReturnsNewCardBuilder()
        {
            var builder = CardBuilder.Create();
            Assert.True(builder is CardBuilder);
        }

        [Fact]
        public void CreateSetsTitle()
        {
            var card = CardBuilder
                .Create("Hello World")
                .Build();
            Assert.Equal("Hello World" , card.Title);
        }

        [Fact]
        public void CreateSetsBody()
        {
            var card = CardBuilder
                .Create("Title", "Hello World Body")
                .Build();
            Assert.Equal("Hello World Body",card.Body); 
        }

        [Fact]
        public void BuildReturnsCard()
        {
            var card = 
                CardBuilder
                    .Create()
                    .Build();
            Assert.True(card is Card);
        }
    }
}

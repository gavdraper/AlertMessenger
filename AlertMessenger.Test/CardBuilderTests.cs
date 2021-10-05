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
        public void BuildReturnsCard()
        {
            var builder = 
                CardBuilder.Create()
                .Build();
            Assert.True(builder is Card);
        }
    }
}

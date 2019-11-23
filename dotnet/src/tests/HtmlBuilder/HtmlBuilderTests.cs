using System;
using PucSp.DesignPatterns.HtmlBuilder;
using Xunit;

namespace PucSp.DesignPatterns.Tests
{
    public class HtmlBuilderTests
    {
        [Fact]
        public void BoldElement_New_Instance_Should_Produce_Correct_Tag()
        {
            //Arrange
            const string Tag = "strong";

            var element = new BoldElement("Here I am. This is me.");

            //Act
            string tag = element.Tag;

            //Assert
            Assert.NotNull(element);
            Assert.Equal(Tag, element.Tag);
        }

        [Fact]
        public void DivisionElement_New_Instance_Should_Produce_Correct_Tag()
        {
            //Arrange
            const string Tag = "div";

            var element = new DivisionElement("Here I am. This is me.");

            //Act
            string tag = element.Tag;

            //Assert
            Assert.NotNull(element);
            Assert.Equal(Tag, element.Tag);
        }

        [Fact]
        public void EmphasisElement_New_Instance_Should_Produce_Correct_Tag()
        {
            //Arrange
            const string Tag = "em";

            var element = new EmphasisElement("Here I am. This is me.");

            //Act
            string tag = element.Tag;

            //Assert
            Assert.NotNull(element);
            Assert.Equal(Tag, element.Tag);
        }

        [Fact]
        public void ItalicElement_New_Instance_Should_Produce_Correct_Tag()
        {
            //Arrange
            const string Tag = "i";

            var element = new ItalicElement("Here I am. This is me.");

            //Act
            string tag = element.Tag;

            //Assert
            Assert.NotNull(element);
            Assert.Equal(Tag, element.Tag);
        }

        [Fact]
        public void ListItemElement_New_Instance_Should_Produce_Correct_Tag()
        {
            //Arrange
            const string Tag = "li";

            var element = new ListItemElement("Here I am. This is me.");

            //Act
            string tag = element.Tag;

            //Assert
            Assert.NotNull(element);
            Assert.Equal(Tag, element.Tag);
        }

        [Fact]
        public void SpanElement_New_Instance_Should_Produce_Correct_Tag()
        {
            //Arrange
            const string Tag = "span";

            var element = new SpanElement("Here I am. This is me.");

            //Act
            string tag = element.Tag;

            //Assert
            Assert.NotNull(element);
            Assert.Equal(Tag, element.Tag);
        }

        [Fact]
        public void UnorderedListElement_New_Instance_Should_Produce_Correct_Tag()
        {
            //Arrange
            const string Tag = "ul";

            var element = new UnorderedListElement("Here I am. This is me.");

            //Act
            string tag = element.Tag;

            //Assert
            Assert.NotNull(element);
            Assert.Equal(Tag, element.Tag);
        }
    }
}

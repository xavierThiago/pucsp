using System;
using PucSp.DesignPatterns.HtmlBuilder.Core;
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

        [Theory]
        [InlineData(typeof(BoldElement))]
        [InlineData(typeof(DivisionElement))]
        [InlineData(typeof(EmphasisElement))]
        [InlineData(typeof(ItalicElement))]
        [InlineData(typeof(ListItemElement))]
        [InlineData(typeof(SpanElement))]
        [InlineData(typeof(UnorderedListElement))]
        public void Validate_Node_Elements_Should_Create_Attributes_Successfully(Type @class)
        {
            //Arrange
            var instance = Activator.CreateInstance(@class, "This is a dummy text.") as IHtmlElement;
            var node = instance as Node;
            string name = "class";
            string value = "col-12";
            var attribute = new HtmlAttribute(name, value);

            //Act
            instance.AddAttribute(attribute);

            //Assert
            Assert.NotNull(instance);
            Assert.NotNull(node.Attributes);
            Assert.NotEmpty(node.Attributes);
            Assert.Contains(node.Attributes, x => x.Name == name && x.Value == value);
        }

        [Theory]
        [InlineData(typeof(BoldElement))]
        [InlineData(typeof(DivisionElement))]
        [InlineData(typeof(EmphasisElement))]
        [InlineData(typeof(ItalicElement))]
        [InlineData(typeof(ListItemElement))]
        [InlineData(typeof(SpanElement))]
        [InlineData(typeof(UnorderedListElement))]
        public void Validate_Node_Elements_Should_Not_Create_Duplicate_Attribute(Type @class)
        {
            //Arrange
            var instance = Activator.CreateInstance(@class, "This is a dummy text.") as IHtmlElement;
            var node = instance as Node;
            string name = "class";
            string value = "col-12";
            var attribute = new HtmlAttribute(name, value);

            //Act
            instance.AddAttribute(attribute);
            instance.AddAttribute(attribute);
            instance.AddAttribute(attribute);

            //Assert
            Assert.NotNull(instance);
            Assert.NotNull(node.Attributes);
            Assert.NotEmpty(node.Attributes);
            Assert.Contains(node.Attributes, x => x.Name == name && x.Value == value);
            Assert.True(node.Attributes.Count == 1);
        }
    }
}

using System;
using System.Text;

namespace PucSp.DesignPatterns.HtmlBuilder.Core
{
    public class EmphasisElement : Node, IHtmlElement
    {
        private readonly string _text;

        public override string Tag => "em";

        public EmphasisElement(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            this._text = text;
        }

        public override string ToHtml()
        {
            var result = new StringBuilder();

            result.Append($"<{this.Tag}>{this._text}");

            foreach (var item in base.nodes)
            {
                result.Append(item.ToHtml());
            }

            result.Append($"</{this.Tag}>");

            return result.ToString();
        }

        protected override string AsTagString() => $"<{this.Tag}>{this._text}</{this.Tag}>";
    }
}

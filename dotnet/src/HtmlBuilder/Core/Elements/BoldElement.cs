using System;
using System.Collections.Generic;
using System.Text;

namespace PucSp.DesignPatterns.HtmlBuilder.Core
{
    public class BoldElement : Node, IHtmlElement
    {
        private readonly string _text;

        public override string Tag => "strong";

        public BoldElement(string text)
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

            foreach (var item in base.nodes)
            {
                result.Append(item.Tag);
            }

            return result.ToString();
        }

        protected override string AsTagString() => $"<{this.Tag}>{this._text}</{this.Tag}>";
    }
}

using System;

namespace PucSp.DesignPatterns.HtmlBuilder.Core
{
    public class HtmlAttribute : IEquatable<HtmlAttribute>
    {
        public string Name { get; private set; }

        public string Value { get; private set; }

        public HtmlAttribute(string name, string value)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            this.Name = name;
            this.Value = value;
        }

        public override bool Equals(object obj) => obj is HtmlAttribute converted && this.Equals(converted);

        public override int GetHashCode() => HashCode.Combine(this.Name);

        public bool Equals(HtmlAttribute other) => this.Name == other.Name;
    }
}

using System;
using System.Diagnostics.CodeAnalysis;

namespace ByteBee.Core.DotNetWrapper.Impl
{
    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "RedundantOverriddenMember")]
    public sealed class EmptyGuidWrapper : AbstractGuidWrapper
    {
        /// <inheritdoc />
        public override Guid Empty => base.Empty;

        /// <inheritdoc />
        public override Guid NewGuid => base.NewGuid;

        /// <inheritdoc />
        public override Guid Parse(string input)
        {
            return base.Parse(input);
        }

        /// <inheritdoc />
        public override Guid Parse(string input, string format)
        {
            return base.Parse(input, format);
        }

        /// <inheritdoc />
        public override bool TryParse(string input, out Guid result)
        {
            return base.TryParse(input, out result);
        }

        /// <inheritdoc />
        public override bool TryParse(string input, string format, out Guid result)
        {
            return base.TryParse(input, format, out result);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
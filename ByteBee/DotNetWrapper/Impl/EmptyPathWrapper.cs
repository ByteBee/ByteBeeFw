using System.Diagnostics.CodeAnalysis;

namespace ByteBee.DotNetWrapper.Impl
{
    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "RedundantOverriddenMember")]
    internal sealed class EmptyPathWrapper : AbstractPathWrapper
    {
        /// <inheritdoc />
        public override string ChangeExtension(string path, string extension)
        {
            return base.ChangeExtension(path, extension);
        }

        /// <inheritdoc />
        public override string Combine(string path1, string path2)
        {
            return base.Combine(path1, path2);
        }

        /// <inheritdoc />
        public override string Combine(string path1, string path2, string path3)
        {
            return base.Combine(path1, path2, path3);
        }

        /// <inheritdoc />
        public override string Combine(string path1, string path2, string path3, string path4)
        {
            return base.Combine(path1, path2, path3, path4);
        }

        /// <inheritdoc />
        public override string Combine(params string[] paths)
        {
            return base.Combine(paths);
        }

        /// <inheritdoc />
        public override string GetDirectoryName(string path)
        {
            return base.GetDirectoryName(path);
        }

        /// <inheritdoc />
        public override string GetExtension(string path)
        {
            return base.GetExtension(path);
        }

        /// <inheritdoc />
        public override string GetFileName(string path)
        {
            return base.GetFileName(path);
        }

        /// <inheritdoc />
        public override string GetFileNameWithoutExtension(string path)
        {
            return base.GetFileNameWithoutExtension(path);
        }

        /// <inheritdoc />
        public override string GetFullPath(string path)
        {
            return base.GetFullPath(path);
        }

        /// <inheritdoc />
        public override char[] GetInvalidFileNameChars()
        {
            return base.GetInvalidFileNameChars();
        }

        /// <inheritdoc />
        public override char[] GetInvalidPathChars()
        {
            return base.GetInvalidPathChars();
        }

        /// <inheritdoc />
        public override string GetPathRoot(string path)
        {
            return base.GetPathRoot(path);
        }

        /// <inheritdoc />
        public override string GetRandomFileName()
        {
            return base.GetRandomFileName();
        }

        /// <inheritdoc />
        public override string GetTempFileName()
        {
            return base.GetTempFileName();
        }

        /// <inheritdoc />
        public override string GetTempPath()
        {
            return base.GetTempPath();
        }

        /// <inheritdoc />
        public override bool HasExtension(string path)
        {
            return base.HasExtension(path);
        }

        /// <inheritdoc />
        public override bool IsPathRooted(string path)
        {
            return base.IsPathRooted(path);
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
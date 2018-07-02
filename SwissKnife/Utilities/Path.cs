using System.IO;

namespace SwissKnife.Utilities
{
    public interface IPath
    {
        string ChangeExtension(string path, string extension);
        string Combine(string path1, string path2);
        string Combine(string path1, string path2, string path3);
        string Combine(string path1, string path2, string path3, string path4);
        string Combine(params string[] paths);
        string GetDirectoryName(string path);
        string GetExtension(string path);
        string GetFileName(string path);
        string GetFileNameWithoutExtension(string path);
        string GetFullPath(string path);
        char[] GetInvalidFileNameChars();
        char[] GetInvalidPathChars();
        string GetPathRoot(string path);
        string GetRandomFileName();
        string GetTempFileName();
        string GetTempPath();
        bool HasExtension(string path);
        bool IsPathRooted(string path);
    }

    public abstract class PathAdapter : IPath
    {
        /// <inheritdoc />
        public virtual string ChangeExtension(string path, string extension) => Path.ChangeExtension(path, extension);
        /// <inheritdoc />
        public virtual string Combine(string path1, string path2) => Path.Combine(path1, path2);
        /// <inheritdoc />
        public virtual string Combine(string path1, string path2, string path3) => Path.Combine(path1, path2, path3);
        /// <inheritdoc />
        public virtual string Combine(string path1, string path2, string path3, string path4) => Path.Combine(path1, path2, path3, path4);
        /// <inheritdoc />
        public virtual string Combine(params string[] paths) => Path.Combine(paths);
        /// <inheritdoc />
        public virtual string GetDirectoryName(string path) => Path.GetDirectoryName(path);
        /// <inheritdoc />
        public virtual string GetExtension(string path) => Path.GetExtension(path);
        /// <inheritdoc />
        public virtual string GetFileName(string path) => Path.GetFileName(path);
        /// <inheritdoc />
        public virtual string GetFileNameWithoutExtension(string path) => Path.GetFileNameWithoutExtension(path);
        /// <inheritdoc />
        public virtual string GetFullPath(string path) => Path.GetFullPath(path);
        /// <inheritdoc />
        public virtual char[] GetInvalidFileNameChars() => Path.GetInvalidFileNameChars();
        /// <inheritdoc />
        public virtual char[] GetInvalidPathChars() => Path.GetInvalidPathChars();
        /// <inheritdoc />
        public virtual string GetPathRoot(string path) => Path.GetPathRoot(path);
        /// <inheritdoc />
        public virtual string GetRandomFileName() => Path.GetRandomFileName();
        /// <inheritdoc />
        public virtual string GetTempFileName() => Path.GetTempFileName();
        /// <inheritdoc />
        public virtual string GetTempPath() => Path.GetTempPath();
        /// <inheritdoc />
        public virtual bool HasExtension(string path) => Path.HasExtension(path);
        /// <inheritdoc />
        public virtual bool IsPathRooted(string path) => Path.IsPathRooted(path);
    }

    internal class PathImpl : PathAdapter { }
}
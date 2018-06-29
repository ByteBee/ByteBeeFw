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

    public abstract class StandardPath : IPath
    {
        public string ChangeExtension(string path, string extension) => Path.ChangeExtension(path, extension);
        public string Combine(string path1, string path2) => Path.Combine(path1, path2);
        public string Combine(string path1, string path2, string path3) => Path.Combine(path1, path2, path3);
        public string Combine(string path1, string path2, string path3, string path4) => Path.Combine(path1, path2, path3, path4);
        public string Combine(params string[] paths) => Path.Combine(paths);
        public string GetDirectoryName(string path) => Path.GetDirectoryName(path);
        public string GetExtension(string path) => Path.GetExtension(path);
        public string GetFileName(string path) => Path.GetFileName(path);
        public string GetFileNameWithoutExtension(string path) => Path.GetFileNameWithoutExtension(path);
        public string GetFullPath(string path) => Path.GetFullPath(path);
        public char[] GetInvalidFileNameChars() => Path.GetInvalidFileNameChars();
        public char[] GetInvalidPathChars() => Path.GetInvalidPathChars();
        public string GetPathRoot(string path) => Path.GetPathRoot(path);
        public string GetRandomFileName() => Path.GetRandomFileName();
        public string GetTempFileName() => Path.GetTempFileName();
        public string GetTempPath() => Path.GetTempPath();
        public bool HasExtension(string path) => Path.HasExtension(path);
        public bool IsPathRooted(string path) => Path.IsPathRooted(path);
    }

    internal class PathImpl : StandardPath { }
}
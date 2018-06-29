namespace KukSoft.ToolKit.Utilities
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

    internal class PathImpl : IPath
    {
        public string ChangeExtension(string path, string extension) => System.IO.Path.ChangeExtension(path, extension);
        public string Combine(string path1, string path2) => System.IO.Path.Combine(path1, path2);
        public string Combine(string path1, string path2, string path3) => System.IO.Path.Combine(path1, path2, path3);
        public string Combine(string path1, string path2, string path3, string path4) => System.IO.Path.Combine(path1, path2, path3, path4);
        public string Combine(params string[] paths) => System.IO.Path.Combine(paths);
        public string GetDirectoryName(string path) => System.IO.Path.GetDirectoryName(path);
        public string GetExtension(string path) => System.IO.Path.GetExtension(path);
        public string GetFileName(string path) => System.IO.Path.GetFileName(path);
        public string GetFileNameWithoutExtension(string path) => System.IO.Path.GetFileNameWithoutExtension(path);
        public string GetFullPath(string path) => System.IO.Path.GetFullPath(path);
        public char[] GetInvalidFileNameChars() => System.IO.Path.GetInvalidFileNameChars();
        public char[] GetInvalidPathChars() => System.IO.Path.GetInvalidPathChars();
        public string GetPathRoot(string path) => System.IO.Path.GetPathRoot(path);
        public string GetRandomFileName() => System.IO.Path.GetRandomFileName();
        public string GetTempFileName() => System.IO.Path.GetTempFileName();
        public string GetTempPath() => System.IO.Path.GetTempPath();
        public bool HasExtension(string path) => System.IO.Path.HasExtension(path);
        public bool IsPathRooted(string path) => System.IO.Path.IsPathRooted(path);
    }
}
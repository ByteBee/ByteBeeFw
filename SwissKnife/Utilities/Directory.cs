using System;
using System.Collections.Generic;
using System.IO;

#if !NETSTANDARD2_0
using System.Security.AccessControl;
#endif

namespace SwissKnife.Utilities
{
    public interface IDirectory
    {
        DirectoryInfo GetParent(string path);
        DirectoryInfo Create(string path);
        bool Exists(string path);
        void SetCreationTime(string path, DateTime creationTime);
        void SetCreationTimeUtc(string path, DateTime creationTimeUtc);
        DateTime GetCreationTime(string path);
        DateTime GetCreationTimeUtc(string path);
        void SetLastWriteTime(string path, DateTime lastWriteTime);
        void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);
        DateTime GetLastWriteTime(string path);
        DateTime GetLastWriteTimeUtc(string path);
        void SetLastAccessTime(string path, DateTime lastAccessTime);
        void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);
        DateTime GetLastAccessTime(string path);
        DateTime GetLastAccessTimeUtc(string path);
        string[] GetFiles(string path);
        string[] GetFiles(string path, string searchPattern);
        string[] GetFiles(string path, string searchPattern, SearchOption searchOption);
        string[] GetDirectories(string path);
        string[] GetDirectories(string path, string searchPattern);
        string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);
        string[] GetFileSystemEntries(string path);
        string[] GetFileSystemEntries(string path, string searchPattern);
        string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption);
        IEnumerable<string> EnumerateDirectories(string path);
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern);
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption);
        IEnumerable<string> EnumerateFiles(string path);
        IEnumerable<string> EnumerateFiles(string path, string searchPattern);
        IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption);
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern);
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption);
        string[] GetLogicalDrives();
        string GetDirectoryRoot(string path);
        string GetCurrentDirectory();
        void SetCurrentDirectory(string path);
        void Move(string sourceDirName, string destDirName);
        void Delete(string path);
        void Delete(string path, bool recursive);
#if !NETSTANDARD2_0
        DirectoryInfo Create(string path, DirectorySecurity directorySecurity);
        DirectorySecurity GetAccessControl(string path);
        DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections);
        void SetAccessControl(string path, DirectorySecurity directorySecurity);
        DirectoryInfo Info(string path);
#endif
    }

    public abstract class DirectoryAdapter : IDirectory
    {
        public virtual DirectoryInfo GetParent(string path) => Directory.GetParent(path);
        public virtual DirectoryInfo Create(string path) => Directory.CreateDirectory(path);
        public virtual bool Exists(string path) => Directory.Exists(path);

        public virtual void SetCreationTime(string path, DateTime creationTime)
            => Directory.SetCreationTime(path, creationTime);

        public virtual void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
            => Directory.SetCreationTimeUtc(path, creationTimeUtc);

        public virtual DateTime GetCreationTime(string path) => Directory.GetCreationTime(path);

        public virtual DateTime GetCreationTimeUtc(string path) => Directory.GetCreationTimeUtc(path);

        public virtual void SetLastWriteTime(string path, DateTime lastWriteTime)
            => Directory.SetLastWriteTime(path, lastWriteTime);

        public virtual void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
            => Directory.SetLastWriteTimeUtc(path, lastWriteTimeUtc);

        public virtual DateTime GetLastWriteTime(string path) => Directory.GetLastWriteTime(path);

        public virtual DateTime GetLastWriteTimeUtc(string path) => Directory.GetLastWriteTimeUtc(path);

        public virtual void SetLastAccessTime(string path, DateTime lastAccessTime)
            => Directory.SetLastAccessTime(path, lastAccessTime);

        public virtual void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
            => Directory.SetLastAccessTimeUtc(path, lastAccessTimeUtc);

        public virtual DateTime GetLastAccessTime(string path) => Directory.GetLastAccessTime(path);

        public virtual DateTime GetLastAccessTimeUtc(string path) => Directory.GetLastAccessTimeUtc(path);


        public virtual DirectoryInfo Info(string path) => new DirectoryInfo(path);

        public virtual string[] GetFiles(string path) => Directory.GetFiles(path);

        public virtual string[] GetFiles(string path, string searchPattern)
            => Directory.GetFiles(path, searchPattern);

        public virtual string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
            => Directory.GetFiles(path, searchPattern, searchOption);

        public virtual string[] GetDirectories(string path)
            => Directory.GetDirectories(path);

        public virtual string[] GetDirectories(string path, string searchPattern)
            => Directory.GetDirectories(path, searchPattern);

        public virtual string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
            => Directory.GetDirectories(path, searchPattern, searchOption);

        public virtual string[] GetFileSystemEntries(string path) => Directory.GetFileSystemEntries(path);

        public virtual string[] GetFileSystemEntries(string path, string searchPattern)
            => Directory.GetFileSystemEntries(path, searchPattern);

        public virtual string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
            => Directory.GetFileSystemEntries(path, searchPattern, searchOption);

        public virtual IEnumerable<string> EnumerateDirectories(string path)
            => Directory.EnumerateDirectories(path);

        public virtual IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
            => Directory.EnumerateDirectories(path, searchPattern);

        public virtual IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
            => Directory.EnumerateDirectories(path, searchPattern, searchOption);

        public virtual IEnumerable<string> EnumerateFiles(string path)
            => Directory.EnumerateFiles(path);

        public virtual IEnumerable<string> EnumerateFiles(string path, string searchPattern)
            => Directory.EnumerateFiles(path, searchPattern);

        public virtual IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
            => Directory.EnumerateFiles(path, searchPattern, searchOption);

        public virtual IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
            => Directory.EnumerateFileSystemEntries(path, searchPattern);

        public virtual IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
            => Directory.EnumerateFileSystemEntries(path, searchPattern, searchOption);

        public virtual string[] GetLogicalDrives() => Directory.GetLogicalDrives();

        public virtual string GetDirectoryRoot(string path) => Directory.GetDirectoryRoot(path);

        public virtual string GetCurrentDirectory() => Directory.GetCurrentDirectory();

        public virtual void SetCurrentDirectory(string path) => Directory.SetCurrentDirectory(path);

        public virtual void Move(string sourceDirName, string destDirName)
            => Directory.Move(sourceDirName, destDirName);

        public virtual void Delete(string path) => Directory.Delete(path);

        public virtual void Delete(string path, bool recursive) => Directory.Delete(path, recursive);
#if !NETSTANDARD2_0
        public virtual DirectoryInfo Create(string path, DirectorySecurity directorySecurity)
            => Directory.CreateDirectory(path, directorySecurity);

        public virtual DirectorySecurity GetAccessControl(string path)
            => Directory.GetAccessControl(path);

        public virtual DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections)
            => Directory.GetAccessControl(path, includeSections);

        public virtual void SetAccessControl(string path, DirectorySecurity directorySecurity)
            => Directory.SetAccessControl(path, directorySecurity);
#endif
    }
    internal class DirectoryImpl : DirectoryAdapter { }
}
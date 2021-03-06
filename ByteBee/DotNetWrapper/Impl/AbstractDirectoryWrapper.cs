﻿using System;
using System.Collections.Generic;
using System.IO;

#if !NETSTANDARD2_0
using System.Security.AccessControl;
#endif

namespace ByteBee.DotNetWrapper.Impl
{
    internal abstract class AbstractDirectoryWrapper : IDirectoryWrapper
    {
        /// <inheritdoc />
        public virtual DirectoryInfo GetParent(string path) => Directory.GetParent(path);
        /// <inheritdoc />
        public virtual DirectoryInfo Create(string path) => Directory.CreateDirectory(path);
        /// <inheritdoc />
        public virtual bool Exists(string path) => Directory.Exists(path);
        /// <inheritdoc />
        public virtual void SetCreationTime(string path, DateTime creationTime)
            => Directory.SetCreationTime(path, creationTime);
        /// <inheritdoc />
        public virtual void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
            => Directory.SetCreationTimeUtc(path, creationTimeUtc);
        /// <inheritdoc />
        public virtual DateTime GetCreationTime(string path) => Directory.GetCreationTime(path);
        /// <inheritdoc />
        public virtual DateTime GetCreationTimeUtc(string path) => Directory.GetCreationTimeUtc(path);
        /// <inheritdoc />
        public virtual void SetLastWriteTime(string path, DateTime lastWriteTime)
            => Directory.SetLastWriteTime(path, lastWriteTime);
        /// <inheritdoc />
        public virtual void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
            => Directory.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        /// <inheritdoc />
        public virtual DateTime GetLastWriteTime(string path) => Directory.GetLastWriteTime(path);
        /// <inheritdoc />
        public virtual DateTime GetLastWriteTimeUtc(string path) => Directory.GetLastWriteTimeUtc(path);
        /// <inheritdoc />
        public virtual void SetLastAccessTime(string path, DateTime lastAccessTime)
            => Directory.SetLastAccessTime(path, lastAccessTime);
        /// <inheritdoc />
        public virtual void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
            => Directory.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        /// <inheritdoc />
        public virtual DateTime GetLastAccessTime(string path) => Directory.GetLastAccessTime(path);
        /// <inheritdoc />
        public virtual DateTime GetLastAccessTimeUtc(string path) => Directory.GetLastAccessTimeUtc(path);
        /// <inheritdoc />
        public virtual DirectoryInfo Info(string path) => new DirectoryInfo(path);
        /// <inheritdoc />
        public virtual string[] GetFiles(string path) => Directory.GetFiles(path);
        /// <inheritdoc />
        public virtual string[] GetFiles(string path, string searchPattern)
            => Directory.GetFiles(path, searchPattern);
        /// <inheritdoc />
        public virtual string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
            => Directory.GetFiles(path, searchPattern, searchOption);
        /// <inheritdoc />
        public virtual string[] GetDirectories(string path)
            => Directory.GetDirectories(path);
        /// <inheritdoc />
        public virtual string[] GetDirectories(string path, string searchPattern)
            => Directory.GetDirectories(path, searchPattern);
        /// <inheritdoc />
        public virtual string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
            => Directory.GetDirectories(path, searchPattern, searchOption);
        /// <inheritdoc />
        public virtual string[] GetFileSystemEntries(string path) => Directory.GetFileSystemEntries(path);
        /// <inheritdoc />
        public virtual string[] GetFileSystemEntries(string path, string searchPattern)
            => Directory.GetFileSystemEntries(path, searchPattern);
        /// <inheritdoc />
        public virtual string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
            => Directory.GetFileSystemEntries(path, searchPattern, searchOption);
        /// <inheritdoc />
        public virtual IEnumerable<string> EnumerateDirectories(string path)
            => Directory.EnumerateDirectories(path);
        /// <inheritdoc />
        public virtual IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
            => Directory.EnumerateDirectories(path, searchPattern);
        /// <inheritdoc />
        public virtual IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
            => Directory.EnumerateDirectories(path, searchPattern, searchOption);
        /// <inheritdoc />
        public virtual IEnumerable<string> EnumerateFiles(string path)
            => Directory.EnumerateFiles(path);
        /// <inheritdoc />
        public virtual IEnumerable<string> EnumerateFiles(string path, string searchPattern)
            => Directory.EnumerateFiles(path, searchPattern);
        /// <inheritdoc />
        public virtual IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
            => Directory.EnumerateFiles(path, searchPattern, searchOption);
        /// <inheritdoc />
        public virtual IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
            => Directory.EnumerateFileSystemEntries(path, searchPattern);
        /// <inheritdoc />
        public virtual IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
            => Directory.EnumerateFileSystemEntries(path, searchPattern, searchOption);
        /// <inheritdoc />
        public virtual string[] GetLogicalDrives() => Directory.GetLogicalDrives();
        /// <inheritdoc />
        public virtual string GetDirectoryRoot(string path) => Directory.GetDirectoryRoot(path);
        /// <inheritdoc />
        public virtual string GetCurrentDirectory() => Directory.GetCurrentDirectory();
        /// <inheritdoc />
        public virtual void SetCurrentDirectory(string path) => Directory.SetCurrentDirectory(path);
        /// <inheritdoc />
        public virtual void Move(string sourceDirName, string destDirName)
            => Directory.Move(sourceDirName, destDirName);
        /// <inheritdoc />
        public virtual void Delete(string path) => Directory.Delete(path);
        /// <inheritdoc />
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
}
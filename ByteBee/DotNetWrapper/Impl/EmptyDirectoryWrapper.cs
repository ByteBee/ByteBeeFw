using System;
using System.Collections.Generic;
using System.IO;

namespace ByteBee.DotNetWrapper.Impl
{
    public sealed class EmptyDirectoryWrapper : AbstractDirectoryWrapper {
        /// <inheritdoc />
        public override DirectoryInfo GetParent(string path)
        {
            return base.GetParent(path);
        }

        /// <inheritdoc />
        public override DirectoryInfo Create(string path)
        {
            return base.Create(path);
        }

        /// <inheritdoc />
        public override bool Exists(string path)
        {
            return base.Exists(path);
        }

        /// <inheritdoc />
        public override void SetCreationTime(string path, DateTime creationTime)
        {
            base.SetCreationTime(path, creationTime);
        }

        /// <inheritdoc />
        public override void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            base.SetCreationTimeUtc(path, creationTimeUtc);
        }

        /// <inheritdoc />
        public override DateTime GetCreationTime(string path)
        {
            return base.GetCreationTime(path);
        }

        /// <inheritdoc />
        public override DateTime GetCreationTimeUtc(string path)
        {
            return base.GetCreationTimeUtc(path);
        }

        /// <inheritdoc />
        public override void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            base.SetLastWriteTime(path, lastWriteTime);
        }

        /// <inheritdoc />
        public override void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            base.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }

        /// <inheritdoc />
        public override DateTime GetLastWriteTime(string path)
        {
            return base.GetLastWriteTime(path);
        }

        /// <inheritdoc />
        public override DateTime GetLastWriteTimeUtc(string path)
        {
            return base.GetLastWriteTimeUtc(path);
        }

        /// <inheritdoc />
        public override void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            base.SetLastAccessTime(path, lastAccessTime);
        }

        /// <inheritdoc />
        public override void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            base.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        }

        /// <inheritdoc />
        public override DateTime GetLastAccessTime(string path)
        {
            return base.GetLastAccessTime(path);
        }

        /// <inheritdoc />
        public override DateTime GetLastAccessTimeUtc(string path)
        {
            return base.GetLastAccessTimeUtc(path);
        }

        /// <inheritdoc />
        public override string[] GetFiles(string path)
        {
            return base.GetFiles(path);
        }

        /// <inheritdoc />
        public override string[] GetFiles(string path, string searchPattern)
        {
            return base.GetFiles(path, searchPattern);
        }

        /// <inheritdoc />
        public override string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return base.GetFiles(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public override string[] GetDirectories(string path)
        {
            return base.GetDirectories(path);
        }

        /// <inheritdoc />
        public override string[] GetDirectories(string path, string searchPattern)
        {
            return base.GetDirectories(path, searchPattern);
        }

        /// <inheritdoc />
        public override string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return base.GetDirectories(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public override string[] GetFileSystemEntries(string path)
        {
            return base.GetFileSystemEntries(path);
        }

        /// <inheritdoc />
        public override string[] GetFileSystemEntries(string path, string searchPattern)
        {
            return base.GetFileSystemEntries(path, searchPattern);
        }

        /// <inheritdoc />
        public override string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            return base.GetFileSystemEntries(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public override IEnumerable<string> EnumerateDirectories(string path)
        {
            return base.EnumerateDirectories(path);
        }

        /// <inheritdoc />
        public override IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
        {
            return base.EnumerateDirectories(path, searchPattern);
        }

        /// <inheritdoc />
        public override IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return base.EnumerateDirectories(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public override IEnumerable<string> EnumerateFiles(string path)
        {
            return base.EnumerateFiles(path);
        }

        /// <inheritdoc />
        public override IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        {
            return base.EnumerateFiles(path, searchPattern);
        }

        /// <inheritdoc />
        public override IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return base.EnumerateFiles(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public override IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
        {
            return base.EnumerateFileSystemEntries(path, searchPattern);
        }

        /// <inheritdoc />
        public override IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            return base.EnumerateFileSystemEntries(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public override string[] GetLogicalDrives()
        {
            return base.GetLogicalDrives();
        }

        /// <inheritdoc />
        public override string GetDirectoryRoot(string path)
        {
            return base.GetDirectoryRoot(path);
        }

        /// <inheritdoc />
        public override string GetCurrentDirectory()
        {
            return base.GetCurrentDirectory();
        }

        /// <inheritdoc />
        public override void SetCurrentDirectory(string path)
        {
            base.SetCurrentDirectory(path);
        }

        /// <inheritdoc />
        public override void Move(string sourceDirName, string destDirName)
        {
            base.Move(sourceDirName, destDirName);
        }

        /// <inheritdoc />
        public override void Delete(string path)
        {
            base.Delete(path);
        }

        /// <inheritdoc />
        public override void Delete(string path, bool recursive)
        {
            base.Delete(path, recursive);
        }

        /// <inheritdoc />
        public override DirectoryInfo Info(string path)
        {
            return base.Info(path);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;

namespace ByteBee.DotNetWrapper.Impl
{
    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "RedundantOverriddenMember")]
    public sealed class EmptyFileWrapper : AbstractFileWrapper
    {
        /// <inheritdoc />
        public override void AppendAllLines(string path, IEnumerable<string> contents)
        {
            base.AppendAllLines(path, contents);
        }

        /// <inheritdoc />
        public override void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            base.AppendAllLines(path, contents, encoding);
        }

        /// <inheritdoc />
        public override void AppendAllText(string path, string contents)
        {
            base.AppendAllText(path, contents);
        }

        /// <inheritdoc />
        public override void AppendAllText(string path, string contents, Encoding encoding)
        {
            base.AppendAllText(path, contents, encoding);
        }

        /// <inheritdoc />
        public override StreamWriter AppendText(string path)
        {
            return base.AppendText(path);
        }

        /// <inheritdoc />
        public override void Copy(string sourceFileName, string destFileName)
        {
            base.Copy(sourceFileName, destFileName);
        }

        /// <inheritdoc />
        public override void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            base.Copy(sourceFileName, destFileName, overwrite);
        }

        /// <inheritdoc />
        public override FileStream Create(string path)
        {
            return base.Create(path);
        }

        /// <inheritdoc />
        public override FileStream Create(string path, int bufferSize)
        {
            return base.Create(path, bufferSize);
        }

        /// <inheritdoc />
        public override FileStream Create(string path, int bufferSize, FileOptions options)
        {
            return base.Create(path, bufferSize, options);
        }

        /// <inheritdoc />
        public override StreamWriter CreateText(string path)
        {
            return base.CreateText(path);
        }

        /// <inheritdoc />
        public override void Decrypt(string path)
        {
            base.Decrypt(path);
        }

        /// <inheritdoc />
        public override void Delete(string path)
        {
            base.Delete(path);
        }

        /// <inheritdoc />
        public override void Encrypt(string path)
        {
            base.Encrypt(path);
        }

        /// <inheritdoc />
        public override bool Exists(string path)
        {
            return base.Exists(path);
        }

        /// <inheritdoc />
        public override FileAttributes GetAttributes(string path)
        {
            return base.GetAttributes(path);
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
        public override void Move(string sourceFileName, string destFileName)
        {
            base.Move(sourceFileName, destFileName);
        }

        /// <inheritdoc />
        public override FileStream Open(string path, FileMode mode)
        {
            return base.Open(path, mode);
        }

        /// <inheritdoc />
        public override FileStream Open(string path, FileMode mode, FileAccess access)
        {
            return base.Open(path, mode, access);
        }

        /// <inheritdoc />
        public override FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return base.Open(path, mode, access, share);
        }

        /// <inheritdoc />
        public override FileStream OpenRead(string path)
        {
            return base.OpenRead(path);
        }

        /// <inheritdoc />
        public override StreamReader OpenText(string path)
        {
            return base.OpenText(path);
        }

        /// <inheritdoc />
        public override FileStream OpenWrite(string path)
        {
            return base.OpenWrite(path);
        }

        /// <inheritdoc />
        public override byte[] ReadAllBytes(string path)
        {
            return base.ReadAllBytes(path);
        }

        /// <inheritdoc />
        public override string[] ReadAllLines(string path)
        {
            return base.ReadAllLines(path);
        }

        /// <inheritdoc />
        public override string[] ReadAllLines(string path, Encoding encoding)
        {
            return base.ReadAllLines(path, encoding);
        }

        /// <inheritdoc />
        public override string ReadAllText(string path)
        {
            return base.ReadAllText(path);
        }

        /// <inheritdoc />
        public override string ReadAllText(string path, Encoding encoding)
        {
            return base.ReadAllText(path, encoding);
        }

        /// <inheritdoc />
        public override IEnumerable<string> ReadLines(string path)
        {
            return base.ReadLines(path);
        }

        /// <inheritdoc />
        public override IEnumerable<string> ReadLines(string path, Encoding encoding)
        {
            return base.ReadLines(path, encoding);
        }

        /// <inheritdoc />
        public override void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
        {
            base.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
        }

        /// <inheritdoc />
        public override void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName,
            bool ignoreMetadataErrors)
        {
            base.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
        }

        /// <inheritdoc />
        public override void SetAttributes(string path, FileAttributes fileAttributes)
        {
            base.SetAttributes(path, fileAttributes);
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
        public override void WriteAllBytes(string path, byte[] bytes)
        {
            base.WriteAllBytes(path, bytes);
        }

        /// <inheritdoc />
        public override void WriteAllLines(string path, IEnumerable<string> contents)
        {
            base.WriteAllLines(path, contents);
        }

        /// <inheritdoc />
        public override void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            base.WriteAllLines(path, contents, encoding);
        }

        /// <inheritdoc />
        public override void WriteAllLines(string path, string[] contents)
        {
            base.WriteAllLines(path, contents);
        }

        /// <inheritdoc />
        public override void WriteAllLines(string path, string[] contents, Encoding encoding)
        {
            base.WriteAllLines(path, contents, encoding);
        }

        /// <inheritdoc />
        public override void WriteAllText(string path, string contents)
        {
            base.WriteAllText(path, contents);
        }

        /// <inheritdoc />
        public override void WriteAllText(string path, string contents, Encoding encoding)
        {
            base.WriteAllText(path, contents, encoding);
        }

        /// <inheritdoc />
        public override FileInfo Info(string filename)
        {
            return base.Info(filename);
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
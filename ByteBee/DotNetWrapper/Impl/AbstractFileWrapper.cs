using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#if !NETSTANDARD2_0
using System.Security.AccessControl;
#endif

namespace ByteBee.DotNetWrapper.Impl
{
    public abstract class AbstractFileWrapper : IFileWrapper
    {
        /// <inheritdoc />
        public virtual void AppendAllLines(string path, IEnumerable<string> contents) => File.AppendAllLines(path, contents);
        /// <inheritdoc />
        public virtual void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding) => File.AppendAllLines(path, contents, encoding);
        /// <inheritdoc />
        public virtual void AppendAllText(string path, string contents) => File.AppendAllText(path, contents);
        /// <inheritdoc />
        public virtual void AppendAllText(string path, string contents, Encoding encoding) => File.AppendAllText(path, contents, encoding);
        /// <inheritdoc />
        public virtual StreamWriter AppendText(string path) => File.AppendText(path);
        /// <inheritdoc />
        public virtual void Copy(string sourceFileName, string destFileName) => File.Copy(sourceFileName, destFileName);
        /// <inheritdoc />
        public virtual void Copy(string sourceFileName, string destFileName, bool overwrite) => File.Copy(sourceFileName, destFileName, overwrite);
        /// <inheritdoc />
        public virtual FileStream Create(string path) => File.Create(path);
        /// <inheritdoc />
        public virtual FileStream Create(string path, int bufferSize) => File.Create(path, bufferSize);
        /// <inheritdoc />
        public virtual FileStream Create(string path, int bufferSize, FileOptions options) => File.Create(path, bufferSize, options);
        /// <inheritdoc />
        public virtual StreamWriter CreateText(string path) => File.CreateText(path);
        /// <inheritdoc />
        public virtual void Decrypt(string path) => File.Decrypt(path);
        /// <inheritdoc />
        public virtual void Delete(string path) => File.Delete(path);
        /// <inheritdoc />
        public virtual void Encrypt(string path) => File.Encrypt(path);
        /// <inheritdoc />
        public virtual bool Exists(string path) => File.Exists(path);
        /// <inheritdoc />
        public virtual FileAttributes GetAttributes(string path) => File.GetAttributes(path);
        /// <inheritdoc />
        public virtual DateTime GetCreationTime(string path) => File.GetCreationTime(path);
        /// <inheritdoc />
        public virtual DateTime GetCreationTimeUtc(string path) => File.GetCreationTimeUtc(path);
        /// <inheritdoc />
        public virtual DateTime GetLastAccessTime(string path) => File.GetLastAccessTime(path);
        /// <inheritdoc />
        public virtual DateTime GetLastAccessTimeUtc(string path) => File.GetLastAccessTimeUtc(path);
        /// <inheritdoc />
        public virtual DateTime GetLastWriteTime(string path) => File.GetLastWriteTime(path);
        /// <inheritdoc />
        public virtual DateTime GetLastWriteTimeUtc(string path) => File.GetLastWriteTimeUtc(path);
        /// <inheritdoc />
        public virtual void Move(string sourceFileName, string destFileName) => File.Move(sourceFileName, destFileName);
        /// <inheritdoc />
        public virtual FileStream Open(string path, FileMode mode) => File.Open(path, mode);
        /// <inheritdoc />
        public virtual FileStream Open(string path, FileMode mode, FileAccess access) => File.Open(path, mode, access);
        /// <inheritdoc />
        public virtual FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) => File.Open(path, mode, access, share);
        /// <inheritdoc />
        public virtual FileStream OpenRead(string path) => File.OpenRead(path);
        /// <inheritdoc />
        public virtual StreamReader OpenText(string path) => File.OpenText(path);
        /// <inheritdoc />
        public virtual FileStream OpenWrite(string path) => File.OpenWrite(path);
        /// <inheritdoc />
        public virtual byte[] ReadAllBytes(string path) => File.ReadAllBytes(path);
        /// <inheritdoc />
        public virtual string[] ReadAllLines(string path) => File.ReadAllLines(path);
        /// <inheritdoc />
        public virtual string[] ReadAllLines(string path, Encoding encoding) => File.ReadAllLines(path, encoding);
        /// <inheritdoc />
        public virtual string ReadAllText(string path) => File.ReadAllText(path);
        /// <inheritdoc />
        public virtual string ReadAllText(string path, Encoding encoding) => File.ReadAllText(path, encoding);
        /// <inheritdoc />
        public virtual IEnumerable<string> ReadLines(string path) => File.ReadLines(path);
        /// <inheritdoc />
        public virtual IEnumerable<string> ReadLines(string path, Encoding encoding) => File.ReadLines(path, encoding);
        /// <inheritdoc />
        public virtual void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName) => File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
        /// <inheritdoc />
        public virtual void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors) => File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
        /// <inheritdoc />
        public virtual void SetAttributes(string path, FileAttributes fileAttributes) => File.SetAttributes(path, fileAttributes);
        /// <inheritdoc />
        public virtual void SetCreationTime(string path, DateTime creationTime) => File.SetCreationTime(path, creationTime);
        /// <inheritdoc />
        public virtual void SetCreationTimeUtc(string path, DateTime creationTimeUtc) => File.SetCreationTimeUtc(path, creationTimeUtc);
        /// <inheritdoc />
        public virtual void SetLastAccessTime(string path, DateTime lastAccessTime) => File.SetLastAccessTime(path, lastAccessTime);
        /// <inheritdoc />
        public virtual void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) => File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        /// <inheritdoc />
        public virtual void SetLastWriteTime(string path, DateTime lastWriteTime) => File.SetLastWriteTime(path, lastWriteTime);
        /// <inheritdoc />
        public virtual void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) => File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        /// <inheritdoc />
        public virtual void WriteAllBytes(string path, byte[] bytes) => File.WriteAllBytes(path, bytes);
        /// <inheritdoc />
        public virtual void WriteAllLines(string path, IEnumerable<string> contents) => File.WriteAllLines(path, contents);
        /// <inheritdoc />
        public virtual void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding) => File.WriteAllLines(path, contents, encoding);
        /// <inheritdoc />
        public virtual void WriteAllLines(string path, string[] contents) => File.WriteAllLines(path, contents);
        /// <inheritdoc />
        public virtual void WriteAllLines(string path, string[] contents, Encoding encoding) => File.WriteAllLines(path, contents, encoding);
        /// <inheritdoc />
        public virtual void WriteAllText(string path, string contents) => File.WriteAllText(path, contents);
        /// <inheritdoc />
        public virtual void WriteAllText(string path, string contents, Encoding encoding) => File.WriteAllText(path, contents, encoding);
        /// <inheritdoc />
        public virtual FileInfo Info(string filename) => new FileInfo(filename);

#if !NETSTANDARD2_0
        /// <inheritdoc />
        public virtual FileStream Create(string path, int bufferSize, FileOptions options, FileSecurity fileSecurity) => File.Create(path, bufferSize, options, fileSecurity);
        /// <inheritdoc />
        public virtual FileSecurity GetAccessControl(string path) => File.GetAccessControl(path);
        /// <inheritdoc />
        public virtual FileSecurity GetAccessControl(string path, AccessControlSections includeSections) => File.GetAccessControl(path, includeSections);
        /// <inheritdoc />
        public virtual void SetAccessControl(string path, FileSecurity fileSecurity) => File.SetAccessControl(path, fileSecurity);
#endif
    }
}
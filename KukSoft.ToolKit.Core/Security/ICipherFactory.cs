using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace KukSoft.ToolKit.Security
{
    public interface ICipherFactory
    {
        ICipher MD5 { get; }
    }
}

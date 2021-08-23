using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Wrappers
{
    public interface IDirectoryWrapper
    {
        bool Exists(string path);
        DirectoryInfo CreateDirectory(string path);
    }
}

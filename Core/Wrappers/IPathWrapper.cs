using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Wrappers
{
    public interface IPathWrapper
    {
        string GetFileNameWithoutExtension(string path);
        string GetExtension(string path);
        string Combine(params string[] paths);
    }
}

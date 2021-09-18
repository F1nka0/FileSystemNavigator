using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.IO;
namespace ConsoleApp8
{
    class DirectoryFileInfoHandler {

        private List<DirectoryFileInfo> _directoryFileInfoList = new List<DirectoryFileInfo>();
        public void AddNewNode(DirectoryFileInfo DFI)
        {
            _directoryFileInfoList.Add(DFI);
        }
    }
    class DirectoryFileInfo {
        public DirectoryFileInfo()
        {

        }
        public DirectoryFileInfo Up{
            get { return}
        }
        public DirectoryFileInfo(DirectoryInfo directoryInfos, IEnumerable<FileInfo> fileInfos)
        {

        }

        List<DirectoryInfo> Directories;
        List<FileInfo> Files;
    }
    class Program
    {
        public (IEnumerable<DirectoryInfo>,IEnumerable<FileInfo>) Get
        public static void Main(string[] args)
        {

        }
    }
}

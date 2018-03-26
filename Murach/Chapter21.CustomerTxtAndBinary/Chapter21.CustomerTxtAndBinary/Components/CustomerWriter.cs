using System;
using System.IO;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class CustomerWriter : IDisposable
    {
        private FileStream _fileStream;
        private int _filterIndex;

        public CustomerWriter(FileStream filestream, int filterIndex)
        {
            _fileStream = filestream;
            _filterIndex = filterIndex;


        }

        public void Dispose()
        {
            
        }

        public void Write(object[] datarow)
        {

        }
    }
}

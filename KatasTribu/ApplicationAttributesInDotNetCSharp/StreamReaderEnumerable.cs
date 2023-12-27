using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationAttributesInDotNetCSharp
{
    //a custom class that implements IEnumerable(T)
    //You must also implement IEnumerable and IEnumerable(T)
    class StreamReaderEnumerable //: IEnumerable<string>
    {
        private string _filePath;
        public StreamReaderEnumerable(string filePath)
        {
            this._filePath = filePath;
        }
        //Must implement GetEnumerator, which returns a new StreamReaderEnumerable
        //public IEnumerable<string> GetEnumerator()
        //{
        //    return (new StreamReaderEnumerable(_filePath));
        //}

        //Must also implement IEnumerable.GetEnumerator, but implement as a private method
        //private IEnumerable<string> GetEnumerator1()
        //{
        //    return (this.GetEnumerator());
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return (GetEnumerator1());
        //}
    }
}

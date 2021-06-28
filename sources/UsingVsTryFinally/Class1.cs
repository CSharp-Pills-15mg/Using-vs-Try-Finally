using System;
using System.IO;

namespace UsingVsTryFinally
{
    public class Class1
    {
        public void Method1()
        {
            StreamWriter streamWriter = new StreamWriter(@"file.txt");
            try
            {
                streamWriter.Write("some text");
            }
            finally
            {
                if (streamWriter != null)
                    ((IDisposable)streamWriter).Dispose();
            }
        }

        public void Method2()
        {
            using (StreamWriter streamWriter = new StreamWriter(@"file.txt"))
            {
                // Write file content
                streamWriter.Write("some text");
            }
        }

        public void Method3()
        {
            using StreamWriter streamWriter = new StreamWriter(@"file.txt");
            streamWriter.Write("some text");
        }
    }
}

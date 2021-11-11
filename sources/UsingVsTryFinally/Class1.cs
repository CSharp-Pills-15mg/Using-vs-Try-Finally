// C# Pills 15mg
// Copyright (C) 2021 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.IO;

namespace DustInTheWind.UsingVsTryFinally
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

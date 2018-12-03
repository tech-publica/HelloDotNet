using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace it.Finsa.HelloDotNetCore.Collections
{
    public class Aula : IEnumerable<string>
    {
  

        private string st1 = "ciccio";
        private string st2 = "pippo";
        private string st3 = "pluto";

        public IEnumerator<string> GetEnumerator()
        {
            return new AulaEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class AulaEnumerator : IEnumerator<string>
        {
            private string currentStudent;
            private Aula aula;
            private int pos;
            public string Current
            {
                get
                {
                    return currentStudent;
                }
            }

            object IEnumerator.Current => Current;

            public AulaEnumerator(Aula aula)
            {
                this.aula = aula;
            }


            public void Dispose()
            {
                currentStudent = null;
            }

            public bool MoveNext()
            {
                pos++;
                switch (pos)
                {
                    case 1:
                        currentStudent = aula.st1;
                        return true;
                    case 2:
                        currentStudent = aula.st2;
                        return true;
                    case 3:
                        currentStudent = aula.st3;
                        return true;
                    default:
                        currentStudent = null;
                        return false;
                }
            }

            public void Reset()
            {
                pos = 0;
            }
        }


    }
}

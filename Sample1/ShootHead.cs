using System;

namespace Sample1
{
    internal class Quit
    {
        public Quit()
        {
        }

        public int Quit { get; internal set; }

        internal object Yes()
        {
            throw new NotImplementedException();
        }
    }
}
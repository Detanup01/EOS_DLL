using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK._Data
{
    public interface IHandler
    {
        public IntPtr Create();
        public void Tick();
        public void Close();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_05
{
    class NativeWrapper: IDisposable
    {
        private dynamic _res;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // remove finalization flag from GC
        }

        public virtual void Dispose(bool disposing)
        {
            _res?.Free();
        }

        public void Start()
        {
            _res?.Operate();
        }

        ~NativeWrapper() // Finalizer
        {
            Dispose(false);
        }
    }
}

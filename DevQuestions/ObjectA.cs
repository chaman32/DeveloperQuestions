using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestions
{
    internal class ObjectA : IDisposable
    {
        private ObjectB _objectB;

        internal void DoSomething(ObjectB objectB)
        {
            _objectB = objectB;
        }

        #region stuff
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // secret question - what should go here
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);

        }
        #endregion
    }
}

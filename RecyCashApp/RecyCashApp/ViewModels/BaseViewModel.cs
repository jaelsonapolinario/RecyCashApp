using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RecyCashApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region IDispose Implementation

        /// <summary>
        /// <see cref="IDisposable"/> implementation.
        /// </summary>
        public void Dispose()
        {
            //finalize
            this.Dispose(true);

            //await the thread finalizers
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Destrutor
        /// </summary>
        ~BaseViewModel()
        {
            // Prevents the circular call to dispose.
            this.Dispose(false);
        }

        /// <summary>
        /// When override in derived classe, provides to GC 
        /// the mecanims to ends the memory utilization
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            //when false, don't dispose
            if (this._disposed) return;

            if (!this._disposed)
            {
                this._disposed = true;
            }
        }

        /// <summary>
        /// When true, indicates it is a dispose process
        /// </summary>
        private bool _disposed = false;

        #endregion
    }
}
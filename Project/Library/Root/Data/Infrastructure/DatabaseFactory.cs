using Root.Models;

namespace Root.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private SGVNInterviewDBContext _dataContext;

        public SGVNInterviewDBContext Get()
        {
            return _dataContext ?? (_dataContext = new SGVNInterviewDBContext());
        }

        protected override void DisposeCore()
        {
            if (_dataContext != null)
            {
                _dataContext.Dispose();
            }
        }
    }
}

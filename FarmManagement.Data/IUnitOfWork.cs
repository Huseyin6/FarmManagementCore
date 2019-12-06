using System;

namespace FarmManagement.Data
{
    public interface IUnitOfWork:IDisposable
    {
        int Commit();
    }
}
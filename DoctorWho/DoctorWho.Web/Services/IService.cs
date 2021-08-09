using System.Collections.Generic;

namespace DoctorWho.Web.Services
{
    public interface IService<TEntitiy> where TEntitiy : class
    {
        IEnumerable<TEntitiy> GetAll();
    }
}

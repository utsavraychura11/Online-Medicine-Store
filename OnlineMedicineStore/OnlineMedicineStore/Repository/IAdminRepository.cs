using OnlineMedicineStore.Models;
using System.Collections.Generic;

namespace OnlineMedicineStore.Repository
{
    public interface IAdminRepository
    {
        IEnumerable<ApplicationUser> GetAllUsers();
    }
}
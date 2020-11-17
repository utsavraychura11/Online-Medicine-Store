using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using OnlineMedicineStore.Data;
using OnlineMedicineStore.Models;

namespace OnlineMedicineStore.Repository
{
    public interface IAdminReposotory
    {



        Task<IdentityResult> AddmedicineAsync(Medicine medicine);

    }
}

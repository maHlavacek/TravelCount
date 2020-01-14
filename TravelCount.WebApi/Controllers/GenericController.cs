using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCount.WebApi.Controllers
{
    public abstract class GenericController<I, M> : ControllerBase
        where M : Transfer.TransferObject, I, Contracts.ICopyable<I>, new()
        where I : Contracts.IIdentifiable
    {
        protected Contracts.Client.IControllerAccess<I> CreateController()
        {
            return Logic.Factory.Create<I>();
        }

        protected async Task<int> CountAsync()
        {
            using var ctrl = CreateController();

            return await ctrl.CountAsync();
        }

        protected async Task<IEnumerable<I>> GetAllAsync()
        {
            using var ctrl = CreateController();

            return await ctrl.GetAllAsync();
        }
        
        protected async Task<I> GetByIdAsync(int id)
        {
            using var ctrl = CreateController();

            return await ctrl.GetByIdAsync(id);
        }
    }
}

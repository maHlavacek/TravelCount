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
    }
}

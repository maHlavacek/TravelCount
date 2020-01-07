using System;
using System.Collections.Generic;
using System.Text;
using TravelCount.Contracts;
using TravelCount.Logic.Entities;

namespace TravelCount.Logic.DataContext
{
    internal partial interface IContext : IDisposable
    {
        #region Sync-Methods
        int Count<I, E>()
            where I : IIdentifiable
            where E : IdentityObject, I;

        E Create<I, E>()
            where I : IIdentifiable
            where E : IdentityObject, ICopyable<I>, I, new();

        E Insert<I, E>(I entity)
            where I : IIdentifiable
            where E : IdentityObject, ICopyable<I>, I, new();

        E Update<I, E>(I entity)
            where I : IIdentifiable
            where E : IdentityObject, ICopyable<I>, I, new();

        E Delete<I, E>(int id)
            where I : IIdentifiable
            where E : IdentityObject, I;

        void Save();
        #endregion Sync-Methods
    }
}

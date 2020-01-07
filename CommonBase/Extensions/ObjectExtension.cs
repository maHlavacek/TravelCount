using System;
namespace CommonBase.Extensions
{
    public static class ObjectExtension
    {
        public static void CheckArgument(this object source, string name)
        {
            if(source == null)
            {
                throw new ArgumentNullExeption(name);
            }
        }
    }
}
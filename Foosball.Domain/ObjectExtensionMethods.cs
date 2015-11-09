using System.Linq;
using System.Reflection;

namespace Foosball.Domain
{
    public static class ObjectExtensionMethods
    {
        public static void MemberwiseCloneInto<T>(this T source, T destination) where T : class
        {
            if (source == null || destination == null)
                return;

            var destinationType = destination.GetType();
            var sourceType = source.GetType();

            sourceType.GetProperties().ToList().ForEach(
                delegate(PropertyInfo src)
                {
                    var dest = destinationType.GetProperty(src.Name);
                    dest.SetValue(destination, src.GetValue(source));
                });
        }
    }
}

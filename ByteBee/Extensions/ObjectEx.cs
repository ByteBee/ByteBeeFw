using System;
using System.ComponentModel;

namespace ByteBee.Core.Extensions
{
    public static class ObjectEx
    {
        public static bool IsAnyOf<T>(this T self, params T[] values) 
            => Array.IndexOf(values, self) != -1;
        
        public static bool IsNoneOf<T>(this T self, params T[] values) 
            => !self.IsAnyOf(values);

        public static TResult Convert<TResult>(this object self)
        {
            return self.Convert(default(TResult));
        }
        
        // todo: write some tests here
        public static TResult Convert<TResult>(this object self, TResult fallback)
        {
            if (self != null)
            {
                Type resultType = typeof(TResult);

                if (self.GetType() == resultType)
                {
                    return (TResult) self;
                }

                TypeConverter converter = TypeDescriptor.GetConverter(self);
                if (converter.CanConvertTo(resultType))
                {
                    return (TResult)converter.ConvertTo(self, resultType);
                }

                converter = TypeDescriptor.GetConverter(resultType);
                if (converter.CanConvertFrom(self.GetType()))
                {
                    return (TResult)converter.ConvertFrom(self);
                }
            }

            return fallback;
        }
    }
}
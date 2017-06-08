#region License
// 
// Hotcakes Commerce - https://hotcakes.org
// Copyright (c) 2017
// by Hotcakes Commerce, LLC
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion

using System;

// ReSharper disable once CheckNamespace
namespace DotNetNuke.Common
{
    public static class Arg
    {
        [Obsolete("Deprecated in Hotcakes Commerce 5.4.0. Replaced by Requires.IsTypeOf()")]
        public static void IsTypeOf<T>(string argName, object argValue)
        {
            Requires.IsTypeOf<T>(argName, argValue);
        }

        [Obsolete("Deprecated in Hotcakes Commerce 5.4.0. Replaced by Requires.NotNegative()")]
        public static void NotNegative(string argName, int argValue)
        {
            Requires.NotNegative(argName, argValue);
        }

        [Obsolete("Deprecated in Hotcakes Commerce 5.4.0. Replaced by Requires.PropertyNotNull()")]
        public static void NotNull(string argName, object argValue)
        {
            Requires.NotNull(argName, argValue);
        }

        [Obsolete("Deprecated in Hotcakes Commerce 5.4.0. Replaced by Requires.NotNullOrEmpty()")]
        public static void NotNullOrEmpty(string argName, string argValue)
        {
            Requires.NotNullOrEmpty(argName, argValue);
        }

        [Obsolete("Deprecated in Hotcakes Commerce 5.4.0. Replaced by Requires.PropertyNotNullOrEmpty()")]
        public static void PropertyNotNullOrEmpty(string argName, string argProperty, string propertyValue)
        {
            Requires.PropertyNotNullOrEmpty(argName, argProperty, propertyValue);
        }

        [Obsolete("Deprecated in Hotcakes Commerce 5.4.0. Replaced by Requires.PropertyNotNegative()")]
        public static void PropertyNotNegative(string argName, string argProperty, int propertyValue)
        {
            Requires.PropertyNotNegative(argName, argProperty, propertyValue);
        }

        [Obsolete("Deprecated in Hotcakes Commerce 5.4.0. Replaced by Requires.PropertyNotEqualTo()")]
        public static void PropertyNotEqualTo<TValue>(string argName, string argProperty, TValue propertyValue, TValue testValue) where TValue : IEquatable<TValue>
        {
            Requires.PropertyNotEqualTo(argName, argProperty, propertyValue, testValue);
        }
    }
}
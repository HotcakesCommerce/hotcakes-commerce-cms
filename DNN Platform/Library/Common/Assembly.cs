#region Copyright
// 
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2014
// by DotNetNuke Corporation
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
#region Usings

using System;

using Microsoft.VisualBasic.CompilerServices;

#endregion

namespace DotNetNuke.Common
{
    [Obsolete("Deprecated in Hotcakes Commerce 5.1. Use DotNetNukeContext.Current.Application properties.")]
    [StandardModule]
    public sealed class Assembly
    {
        #region Public Constants

        [Obsolete("Deprecated in Hotcakes Commerce 5.1. Use DotNetNukeContext.Current.Application properties.")]
        public const string glbAppType = "Framework";

        [Obsolete("Deprecated in Hotcakes Commerce 5.1. Use DotNetNukeContext.Current.Application properties.")]
        public const string glbAppVersion = "05.01.00";

        [Obsolete("Deprecated in Hotcakes Commerce 5.1. Use DotNetNukeContext.Current.Application properties.")]
        public const string glbAppName = "HCC";

        [Obsolete("Deprecated in Hotcakes Commerce 5.1. Use DotNetNukeContext.Current.Application properties.")]
        public const string glbAppTitle = "Hotcakes";

        [Obsolete("Deprecated in Hotcakes Commerce 5.1. Use DotNetNukeContext.Current.Application properties.")]
        public const string glbAppDescription = "Hotcakes Commerce";

        [Obsolete("Deprecated in Hotcakes Commerce 5.1. Use DotNetNukeContext.Current.Application properties.")]
        public const string glbAppCompany = "Hotcakes Commerce";

        [Obsolete("Deprecated in Hotcakes Commerce 5.1. Use DotNetNukeContext.Current.Application properties.")]
        public const string glbAppUrl = "https://hotcakes.org";

        [Obsolete("Deprecated in Hotcakes Commerce 5.1. Use DotNetNukeContext.Current.Application properties.")]
        public const string glbUpgradeUrl = "https://hotcakes.org/DesktopModules/HCC/UpdateService/";

        [Obsolete("Deprecated in Hotcakes Commerce 5.1. Use DotNetNukeContext.Current.Application properties.")]
        public const string glbLegalCopyright = "Hotcakes Commerce is copyright 2013-YYYY by Hotcakes Commerce, LLC";

        [Obsolete("Deprecated in Hotcakes Commerce 5.1. Use DotNetNukeContext.Current.Application properties.")]
        public const string glbTrademark = "Hotcakes Commerce,Hotcakes,HCC";

        [Obsolete("Deprecated in Hotcakes Commerce 5.1. Use DotNetNukeContext.Current.Application properties.")]
        public const string glbHelpUrl = "https://hotcakes.org";

        #endregion

        [Obsolete("Deprecated in Hotcakes Commerce 5.1. Use DotNetNukeContext.Current.Application properties.")]
        public static Version ApplicationVersion
        {
            get
            {
                return new Version("05.01.00");
            }
        }
    }
}
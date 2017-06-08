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
using DotNetNuke.Entities.Portals;

namespace DotNetNuke.Services.Log.EventLog
{
    /// <summary>
    /// Do not implement.  This interface is only implemented by the Hotcakes Commerce core framework. Outside 
    /// the framework it should used as a type and for unit test purposes only. There is no guarantee that this 
    /// interface will not change.
    /// </summary>
    public interface IEventLogController : ILogController
    {
        void AddLog(string propertyName, string propertyValue, EventLogController.EventLogType logType);

        void AddLog(string propertyName, string propertyValue, PortalSettings portalSettings, int userID, EventLogController.EventLogType logType);

        void AddLog(string propertyName, string propertyValue, PortalSettings portalSettings, int userID, string logType);

        void AddLog(PortalSettings portalSettings, int userID, EventLogController.EventLogType logType);

        void AddLog(LogProperties properties, PortalSettings portalSettings, int userID, string logTypeKey, bool bypassBuffering);

        void AddLog(object businessObject, PortalSettings portalSettings, int userID, string userName, EventLogController.EventLogType logType);

        void AddLog(object businessObject, PortalSettings portalSettings, int userID, string userName, string logType);
    }
}
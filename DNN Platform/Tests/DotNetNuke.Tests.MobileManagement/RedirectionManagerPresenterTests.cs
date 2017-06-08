#region Copyright
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2014
// by DotNetNuke Corporation
// All Rights Reserved
// 
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
using System.Collections.Generic;
using System.Web;
using System.Web.UI.WebControls;
using DotNetNuke.Entities.Portals;
using DotNetNuke.Modules.MobileManagement.Presenters;
using DotNetNuke.Modules.MobileManagement.ViewModels;
using DotNetNuke.Modules.MobileManagement.Views;
using DotNetNuke.Services.Mobile;
using DotNetNuke.Tests.MobileManagement.Mocks;
using DotNetNuke.UI.Modules;
using Moq;
using NUnit.Framework;

#endregion

namespace DotNetNuke.Tests.MobileManagement
{
	// ReSharper disable InconsistentNaming

	[TestFixture]
	public class RedirectionManagerPresenterTests
	{
		#region "Private Properties"

		private Mock<IRedirectionManagerView> _mockView;
		private Mock<IRedirectionController> _mockController;
		private RedirectionManagerPresenter _presenter;

		#endregion

		#region "Set Up"

		[SetUp]
		public void Setup()
		{
			_mockView = MockHelper.CreateNew<IRedirectionManagerView>();
			_mockView.Setup(v => v.Model).Returns(new RedirectionManagerViewModel());

			_mockController = MockHelper.CreateNew<IRedirectionController>();
			_mockController.Setup(c => c.GetRedirectionById(It.IsAny<int>(), It.IsAny<int>())).Returns<int, int>(GetRedirectionByIdCallback);
			_mockController.Setup(c => c.GetRedirectionsByPortal(It.IsAny<int>())).Returns<int>(GetRedirectionsByPortalCallback);
			_mockController.Setup(c => c.Save(It.IsAny<IRedirection>())).Callback<IRedirection>(SaveCallback);
			_mockController.Setup(c => c.Delete(It.IsAny<int>(), It.IsAny<int>())).Callback<int, int>(DeleteCallback);

			CreatePresenter();
		}

		#endregion

		#region "Test Methods"

		[Test]
		public void RedirectionManagerPresenter_RedirectionItemAction()
		{
			var eventArgs = new DataGridCommandEventArgs(null, null, new CommandEventArgs("delete", 1));

			_mockView.Raise(v => v.RedirectionItemAction += null, eventArgs);
		}

		[Test]
		public void RedirectionManagerPresenter_SortRedirections()
		{
			_presenter.SortRedirections(1, -1);
		}

		#endregion

		#region "Private Methods"

		private IRedirection GetRedirectionByIdCallback(int portalId, int id)
		{
			return new Redirection { Id = id, PortalId = portalId };
		}

		private IList<IRedirection> GetRedirectionsByPortalCallback(int portalId)
		{
			var profiles = new List<IRedirection>();
			profiles.Add(new Redirection{PortalId = portalId});

			return profiles;
		}

		private void SaveCallback(IRedirection profile)
		{
			
		}

		private void DeleteCallback(int portalId, int id)
		{
			
		}

		private void CreatePresenter()
		{
            var simulator = new Instance.Utilities.HttpSimulator.HttpSimulator("/", "c:\\");
            simulator.SimulateRequest(new Uri("http://localhost/hcc/Default.aspx"));

			HttpContext.Current.Items.Add("PortalSettings", new PortalSettings());

			_presenter = new RedirectionManagerPresenter(_mockView.Object, _mockController.Object)
			             	{
								ModuleContext = new ModuleInstanceContext()
			             	};
		}

		#endregion
	}
}

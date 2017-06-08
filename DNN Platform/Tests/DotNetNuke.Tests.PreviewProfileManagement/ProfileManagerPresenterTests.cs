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
using DotNetNuke.Entities.Portals;
using DotNetNuke.Modules.PreviewProfileManagement.Components;
using DotNetNuke.Modules.PreviewProfileManagement.Presenters;
using DotNetNuke.Modules.PreviewProfileManagement.ViewModels;
using DotNetNuke.Modules.PreviewProfileManagement.Views;
using DotNetNuke.Services.Mobile;
using DotNetNuke.Tests.PreviewProfileManagement.Mocks;
using DotNetNuke.Tests.Utilities;
using DotNetNuke.UI.Modules;
using Moq;
using NUnit.Framework;

#endregion

namespace DotNetNuke.Tests.PreviewProfileManagement
{
	// ReSharper disable InconsistentNaming

	[TestFixture]
	public class ProfileManagerPresenterTests : DnnUnitTest
	{
		#region Private Properties

		private Mock<IProfileManagerView> _mockView;
		private Mock<IPreviewProfileController> _mockController;
		private ProfileManagerPresenter _presenter;

		#endregion

        #region Set Up

        [SetUp]
		public void Setup()
		{
			_mockView = MockHelper.CreateNew<IProfileManagerView>();
			_mockView.Setup(v => v.Model).Returns(new ProfileManagerViewModel());

			_mockController = MockHelper.CreateNew<IPreviewProfileController>();
			_mockController.Setup(c => c.GetProfileById(It.IsAny<int>(), It.IsAny<int>())).Returns<int, int>(GetProfileByIdCallback);
			_mockController.Setup(c => c.GetProfilesByPortal(It.IsAny<int>())).Returns<int>(GetProfilesByPortalCallback);
			_mockController.Setup(c => c.Save(It.IsAny<IPreviewProfile>())).Callback<IPreviewProfile>(SaveCallback);
			_mockController.Setup(c => c.Delete(It.IsAny<int>(), It.IsAny<int>())).Callback<int, int>(DeleteCallback);

			CreatePresenter();
		}

		#endregion

		#region Test Methods

		[Test]
		public void ProfileManagerPresenter_GetEditProfile()
		{
			_mockView.Raise(v => v.GetEditProfile += null, new PrimaryKeyEventArgs(1));

			Assert.AreEqual(1, _mockView.Object.Model.EditProfile.Id);
		}

		[Test]
		public void ProfileManagerPresenter_GetProfiles()
		{
			_mockView.Raise(v => v.GetProfiles += null, EventArgs.Empty);

			Assert.AreEqual(1, _mockView.Object.Model.PreviewProfiles.Count);
		}

		[Test]
		public void ProfileManagerPresenter_GetHighlightProfiles()
		{
			_mockView.Raise(v => v.GetHighlightProfiles += null, EventArgs.Empty);

			Assert.AreEqual(10, _mockView.Object.Model.HighlightProfiles.Count);
		}

		[Test]
		public void ProfileManagerPresenter_SaveProfile()
		{
			_mockView.Raise(v => v.SaveProfile += null, new ProfileEventArgs(new PreviewProfile()));
		}

		[Test]
		public void ProfileManagerPresenter_DeleteProfile()
		{
			_mockView.Raise(v => v.DeleteProfile += null, new PrimaryKeyEventArgs(1));
		}

		#endregion

		#region Private Methods

		private IPreviewProfile GetProfileByIdCallback(int portalId, int id)
		{
			return new PreviewProfile { Id = id, PortalId = portalId };
		}

		private IList<IPreviewProfile> GetProfilesByPortalCallback(int portalId)
		{
			var profiles = new List<IPreviewProfile>();
			profiles.Add(new PreviewProfile());

			return profiles;
		}

		private void SaveCallback(IPreviewProfile profile)
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

			_presenter = new ProfileManagerPresenter(_mockView.Object, _mockController.Object)
			             	{
								ModuleContext = new ModuleInstanceContext(),
                                HighlightDataPath = HighlightDataPath
			             	};
		}

		#endregion
	}
}
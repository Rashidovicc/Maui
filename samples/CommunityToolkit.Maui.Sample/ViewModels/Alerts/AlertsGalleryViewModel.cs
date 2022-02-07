﻿using CommunityToolkit.Maui.Sample.Models;

namespace CommunityToolkit.Maui.Sample.ViewModels.Alerts;

public class AlertsGalleryViewModel : BaseGalleryViewModel
{
	public AlertsGalleryViewModel()
		: base(new[]
		{
			SectionModel.Create<SnackbarViewModel>("Snackbar", "Show Snackbar")
		})
	{
	}
}

public class SnackbarViewModel : BaseViewModel
{

}
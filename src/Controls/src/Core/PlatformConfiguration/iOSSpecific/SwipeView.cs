namespace Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific
{
	using FormsElement = Maui.Controls.SwipeView;

	public static class SwipeView
	{
		public static readonly BindableProperty SwipeTransitionModeProperty = BindableProperty.Create("SwipeTransitionMode", typeof(SwipeTransitionMode), typeof(SwipeView), SwipeTransitionMode.Reveal);

		public static SwipeTransitionMode GetSwipeTransitionMode(BindableObject element)
		{
			return (SwipeTransitionMode)element.GetValue(SwipeTransitionModeProperty);
		}

		public static void SetSwipeTransitionMode(BindableObject element, SwipeTransitionMode value)
		{
			element.SetValue(SwipeTransitionModeProperty, value);
		}

		public static SwipeTransitionMode GetSwipeTransitionMode(this IPlatformElementConfiguration<iOS, FormsElement> config)
		{
			return GetSwipeTransitionMode(config.Element);
		}

		public static IPlatformElementConfiguration<iOS, FormsElement> SetSwipeTransitionMode(this IPlatformElementConfiguration<iOS, FormsElement> config, SwipeTransitionMode value)
		{
			SetSwipeTransitionMode(config.Element, value);
			return config;
		}
	}
}
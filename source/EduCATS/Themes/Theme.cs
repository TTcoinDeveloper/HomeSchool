﻿using EduCATS.Themes.DependencyServices;
using EduCATS.Themes.Interfaces;
using EduCATS.Themes.Templates;

namespace EduCATS.Themes
{
	public static class Theme
	{
		public static ITheme Current { get; private set; }

		static Theme()
		{
			Current = new DefaultTheme();
		}

		public static void Set(ITheme iTheme)
		{
			Current = iTheme;
			ThemePlatformSpecific.SetColors(Current.AppStatusBarBackgroundColor);
		}
	}
}
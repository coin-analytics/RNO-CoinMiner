﻿using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace coinminner.Properties
{
	// Token: 0x02000007 RID: 7
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000051BC File Offset: 0x000033BC
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000043 RID: 67
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}

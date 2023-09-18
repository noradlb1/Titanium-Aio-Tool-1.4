using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Titanium_Aio_Tool_1._4.Properties
{
	// Token: 0x0200000A RID: 10
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000AFB4 File Offset: 0x000091B4
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0000AFCC File Offset: 0x000091CC
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0000AFF0 File Offset: 0x000091F0
		[DefaultSettingValue("0")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int UsageCount
		{
			get
			{
				return (int)this["UsageCount"];
			}
			set
			{
				this["UsageCount"] = value;
			}
		}

		// Token: 0x04000034 RID: 52
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}

using System;
using System.Configuration;

// Token: 0x02000106 RID: 262
internal sealed class Delegate187 : MulticastDelegate
{
	// Token: 0x060009E9 RID: 2537
	public extern SettingsBase Invoke(SettingsBase settingsBase_0);

	// Token: 0x060009EA RID: 2538 RVA: 0x00005BE1 File Offset: 0x00003DE1
	public static SettingsBase smethod_0(SettingsBase settingsBase_0, Delegate187 delegate187_1)
	{
		return delegate187_1(settingsBase_0);
	}

	// Token: 0x060009EB RID: 2539
	public extern Delegate187(object object_0, IntPtr intptr_0);

	// Token: 0x060009EC RID: 2540 RVA: 0x00005BEC File Offset: 0x00003DEC
	static Delegate187()
	{
		Class2.smethod_14(typeof(Delegate187).TypeHandle);
	}

	// Token: 0x04000208 RID: 520
	internal static Delegate187 delegate187_0;
}

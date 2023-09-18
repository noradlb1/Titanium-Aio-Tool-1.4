using System;
using System.Diagnostics;

// Token: 0x020000CD RID: 205
internal sealed class Delegate130 : MulticastDelegate
{
	// Token: 0x0600090A RID: 2314
	public extern Process Invoke(ProcessStartInfo processStartInfo_0);

	// Token: 0x0600090B RID: 2315 RVA: 0x000056A9 File Offset: 0x000038A9
	public static Process smethod_0(ProcessStartInfo processStartInfo_0, Delegate130 delegate130_1)
	{
		return delegate130_1(processStartInfo_0);
	}

	// Token: 0x0600090C RID: 2316
	public extern Delegate130(object object_0, IntPtr intptr_0);

	// Token: 0x0600090D RID: 2317 RVA: 0x000056B4 File Offset: 0x000038B4
	static Delegate130()
	{
		Class2.smethod_14(typeof(Delegate130).TypeHandle);
	}

	// Token: 0x040001CF RID: 463
	internal static Delegate130 delegate130_0;
}

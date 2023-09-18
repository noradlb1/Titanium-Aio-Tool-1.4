using System;
using System.Drawing;

// Token: 0x02000065 RID: 101
internal sealed class Delegate26 : MulticastDelegate
{
	// Token: 0x06000774 RID: 1908
	public extern void Invoke(object object_0, Region region_0);

	// Token: 0x06000775 RID: 1909 RVA: 0x00004D35 File Offset: 0x00002F35
	public static void smethod_0(object object_0, Region region_0, Delegate26 delegate26_1)
	{
		delegate26_1(object_0, region_0);
	}

	// Token: 0x06000776 RID: 1910
	public extern Delegate26(object object_0, IntPtr intptr_0);

	// Token: 0x06000777 RID: 1911 RVA: 0x00004D42 File Offset: 0x00002F42
	static Delegate26()
	{
		Class2.smethod_14(typeof(Delegate26).TypeHandle);
	}

	// Token: 0x04000167 RID: 359
	internal static Delegate26 delegate26_0;
}

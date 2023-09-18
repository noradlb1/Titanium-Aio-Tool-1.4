using System;

// Token: 0x0200005D RID: 93
internal sealed class Delegate18 : MulticastDelegate
{
	// Token: 0x06000754 RID: 1876
	public extern int Invoke(object object_0);

	// Token: 0x06000755 RID: 1877 RVA: 0x00004C71 File Offset: 0x00002E71
	public static int smethod_0(object object_0, Delegate18 delegate18_1)
	{
		return delegate18_1(object_0);
	}

	// Token: 0x06000756 RID: 1878
	public extern Delegate18(object object_0, IntPtr intptr_0);

	// Token: 0x06000757 RID: 1879 RVA: 0x00004C7C File Offset: 0x00002E7C
	static Delegate18()
	{
		Class2.smethod_14(typeof(Delegate18).TypeHandle);
	}

	// Token: 0x0400015F RID: 351
	internal static Delegate18 delegate18_0;
}

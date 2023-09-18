using System;

// Token: 0x02000127 RID: 295
internal sealed class Delegate220 : MulticastDelegate
{
	// Token: 0x06000A6D RID: 2669
	public extern long Invoke(object object_0);

	// Token: 0x06000A6E RID: 2670 RVA: 0x00005EEE File Offset: 0x000040EE
	public static long smethod_0(object object_0, Delegate220 delegate220_1)
	{
		return delegate220_1(object_0);
	}

	// Token: 0x06000A6F RID: 2671
	public extern Delegate220(object object_0, IntPtr intptr_0);

	// Token: 0x06000A70 RID: 2672 RVA: 0x00005EF9 File Offset: 0x000040F9
	static Delegate220()
	{
		Class2.smethod_14(typeof(Delegate220).TypeHandle);
	}

	// Token: 0x04000229 RID: 553
	internal static Delegate220 delegate220_0;
}

using System;

// Token: 0x02000123 RID: 291
internal sealed class Delegate216 : MulticastDelegate
{
	// Token: 0x06000A5D RID: 2653
	public extern byte[] Invoke(object object_0, int int_0);

	// Token: 0x06000A5E RID: 2654 RVA: 0x00005E90 File Offset: 0x00004090
	public static byte[] smethod_0(object object_0, int int_0, Delegate216 delegate216_1)
	{
		return delegate216_1(object_0, int_0);
	}

	// Token: 0x06000A5F RID: 2655
	public extern Delegate216(object object_0, IntPtr intptr_0);

	// Token: 0x06000A60 RID: 2656 RVA: 0x00005E9D File Offset: 0x0000409D
	static Delegate216()
	{
		Class2.smethod_14(typeof(Delegate216).TypeHandle);
	}

	// Token: 0x04000225 RID: 549
	internal static Delegate216 delegate216_0;
}

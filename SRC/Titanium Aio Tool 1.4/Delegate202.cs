using System;

// Token: 0x02000115 RID: 277
internal sealed class Delegate202 : MulticastDelegate
{
	// Token: 0x06000A25 RID: 2597
	public extern Type Invoke(object object_0);

	// Token: 0x06000A26 RID: 2598 RVA: 0x00005D48 File Offset: 0x00003F48
	public static Type smethod_0(object object_0, Delegate202 delegate202_1)
	{
		return delegate202_1(object_0);
	}

	// Token: 0x06000A27 RID: 2599
	public extern Delegate202(object object_0, IntPtr intptr_0);

	// Token: 0x06000A28 RID: 2600 RVA: 0x00005D53 File Offset: 0x00003F53
	static Delegate202()
	{
		Class2.smethod_14(typeof(Delegate202).TypeHandle);
	}

	// Token: 0x04000217 RID: 535
	internal static Delegate202 delegate202_0;
}

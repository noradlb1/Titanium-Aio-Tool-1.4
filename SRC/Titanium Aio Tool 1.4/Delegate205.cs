using System;

// Token: 0x02000118 RID: 280
internal sealed class Delegate205 : MulticastDelegate
{
	// Token: 0x06000A31 RID: 2609
	public extern long Invoke(object object_0);

	// Token: 0x06000A32 RID: 2610 RVA: 0x00005D8F File Offset: 0x00003F8F
	public static long smethod_0(object object_0, Delegate205 delegate205_1)
	{
		return delegate205_1(object_0);
	}

	// Token: 0x06000A33 RID: 2611
	public extern Delegate205(object object_0, IntPtr intptr_0);

	// Token: 0x06000A34 RID: 2612 RVA: 0x00005D9A File Offset: 0x00003F9A
	static Delegate205()
	{
		Class2.smethod_14(typeof(Delegate205).TypeHandle);
	}

	// Token: 0x0400021A RID: 538
	internal static Delegate205 delegate205_0;
}

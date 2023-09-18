using System;

// Token: 0x02000114 RID: 276
internal sealed class Delegate201 : MulticastDelegate
{
	// Token: 0x06000A21 RID: 2593
	public extern bool Invoke(object object_0);

	// Token: 0x06000A22 RID: 2594 RVA: 0x00005D31 File Offset: 0x00003F31
	public static bool smethod_0(object object_0, Delegate201 delegate201_1)
	{
		return delegate201_1(object_0);
	}

	// Token: 0x06000A23 RID: 2595
	public extern Delegate201(object object_0, IntPtr intptr_0);

	// Token: 0x06000A24 RID: 2596 RVA: 0x00005D3C File Offset: 0x00003F3C
	static Delegate201()
	{
		Class2.smethod_14(typeof(Delegate201).TypeHandle);
	}

	// Token: 0x04000216 RID: 534
	internal static Delegate201 delegate201_0;
}

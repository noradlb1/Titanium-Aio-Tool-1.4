using System;

// Token: 0x0200010C RID: 268
internal sealed class Delegate193 : MulticastDelegate
{
	// Token: 0x06000A01 RID: 2561
	public extern void Invoke(object object_0, object object_1, object object_2);

	// Token: 0x06000A02 RID: 2562 RVA: 0x00005C71 File Offset: 0x00003E71
	public static void smethod_0(object object_0, object object_1, object object_2, Delegate193 delegate193_1)
	{
		delegate193_1(object_0, object_1, object_2);
	}

	// Token: 0x06000A03 RID: 2563
	public extern Delegate193(object object_0, IntPtr intptr_0);

	// Token: 0x06000A04 RID: 2564 RVA: 0x00005C80 File Offset: 0x00003E80
	static Delegate193()
	{
		Class2.smethod_14(typeof(Delegate193).TypeHandle);
	}

	// Token: 0x0400020E RID: 526
	internal static Delegate193 delegate193_0;
}

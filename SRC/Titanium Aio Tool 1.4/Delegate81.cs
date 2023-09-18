using System;

// Token: 0x0200009C RID: 156
internal sealed class Delegate81 : MulticastDelegate
{
	// Token: 0x0600084E RID: 2126
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x0600084F RID: 2127 RVA: 0x00005258 File Offset: 0x00003458
	public static void smethod_0(object object_0, int int_0, Delegate81 delegate81_1)
	{
		delegate81_1(object_0, int_0);
	}

	// Token: 0x06000850 RID: 2128
	public extern Delegate81(object object_0, IntPtr intptr_0);

	// Token: 0x06000851 RID: 2129 RVA: 0x00005265 File Offset: 0x00003465
	static Delegate81()
	{
		Class2.smethod_14(typeof(Delegate81).TypeHandle);
	}

	// Token: 0x0400019E RID: 414
	internal static Delegate81 delegate81_0;
}

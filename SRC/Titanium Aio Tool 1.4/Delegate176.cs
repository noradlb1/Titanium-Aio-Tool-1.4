using System;

// Token: 0x020000FB RID: 251
internal sealed class Delegate176 : MulticastDelegate
{
	// Token: 0x060009BD RID: 2493
	public extern void Invoke(object object_0);

	// Token: 0x060009BE RID: 2494 RVA: 0x00005AD4 File Offset: 0x00003CD4
	public static void smethod_0(object object_0, Delegate176 delegate176_1)
	{
		delegate176_1(object_0);
	}

	// Token: 0x060009BF RID: 2495
	public extern Delegate176(object object_0, IntPtr intptr_0);

	// Token: 0x060009C0 RID: 2496 RVA: 0x00005ADF File Offset: 0x00003CDF
	static Delegate176()
	{
		Class2.smethod_14(typeof(Delegate176).TypeHandle);
	}

	// Token: 0x040001FD RID: 509
	internal static Delegate176 delegate176_0;
}

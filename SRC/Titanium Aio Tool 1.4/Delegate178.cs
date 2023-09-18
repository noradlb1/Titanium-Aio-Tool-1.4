using System;

// Token: 0x020000FD RID: 253
internal sealed class Delegate178 : MulticastDelegate
{
	// Token: 0x060009C5 RID: 2501
	public extern void Invoke();

	// Token: 0x060009C6 RID: 2502 RVA: 0x00005B02 File Offset: 0x00003D02
	public static void smethod_0(Delegate178 delegate178_1)
	{
		delegate178_1();
	}

	// Token: 0x060009C7 RID: 2503
	public extern Delegate178(object object_0, IntPtr intptr_0);

	// Token: 0x060009C8 RID: 2504 RVA: 0x00005B0B File Offset: 0x00003D0B
	static Delegate178()
	{
		Class2.smethod_14(typeof(Delegate178).TypeHandle);
	}

	// Token: 0x040001FF RID: 511
	internal static Delegate178 delegate178_0;
}

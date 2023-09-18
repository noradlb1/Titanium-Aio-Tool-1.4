using System;

// Token: 0x020000FC RID: 252
internal sealed class Delegate177 : MulticastDelegate
{
	// Token: 0x060009C1 RID: 2497
	public extern void Invoke(object object_0);

	// Token: 0x060009C2 RID: 2498 RVA: 0x00005AEB File Offset: 0x00003CEB
	public static void smethod_0(object object_0, Delegate177 delegate177_1)
	{
		delegate177_1(object_0);
	}

	// Token: 0x060009C3 RID: 2499
	public extern Delegate177(object object_0, IntPtr intptr_0);

	// Token: 0x060009C4 RID: 2500 RVA: 0x00005AF6 File Offset: 0x00003CF6
	static Delegate177()
	{
		Class2.smethod_14(typeof(Delegate177).TypeHandle);
	}

	// Token: 0x040001FE RID: 510
	internal static Delegate177 delegate177_0;
}

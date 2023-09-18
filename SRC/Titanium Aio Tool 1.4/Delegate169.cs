using System;

// Token: 0x020000F4 RID: 244
internal sealed class Delegate169 : MulticastDelegate
{
	// Token: 0x060009A2 RID: 2466
	public extern void Invoke(object object_0, object[] object_1);

	// Token: 0x060009A3 RID: 2467 RVA: 0x00005A32 File Offset: 0x00003C32
	public static void smethod_0(object object_0, object[] object_1, Delegate169 delegate169_0)
	{
		delegate169_0(object_0, object_1);
	}

	// Token: 0x060009A4 RID: 2468
	public extern Delegate169(object object_0, IntPtr intptr_0);

	// Token: 0x060009A5 RID: 2469 RVA: 0x00005A3F File Offset: 0x00003C3F
	static Delegate169()
	{
		Class2.smethod_14(typeof(Delegate169).TypeHandle);
	}

	// Token: 0x040001F6 RID: 502
	internal static Delegate169 VjcUoqMgRu;
}

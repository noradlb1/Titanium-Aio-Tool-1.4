using System;

// Token: 0x020000F5 RID: 245
internal sealed class Delegate170 : MulticastDelegate
{
	// Token: 0x060009A6 RID: 2470
	public extern void Invoke(object object_0, EventHandler eventHandler_0);

	// Token: 0x060009A7 RID: 2471 RVA: 0x00005A4B File Offset: 0x00003C4B
	public static void smethod_0(object object_0, EventHandler eventHandler_0, Delegate170 delegate170_1)
	{
		delegate170_1(object_0, eventHandler_0);
	}

	// Token: 0x060009A8 RID: 2472
	public extern Delegate170(object object_0, IntPtr intptr_0);

	// Token: 0x060009A9 RID: 2473 RVA: 0x00005A58 File Offset: 0x00003C58
	static Delegate170()
	{
		Class2.smethod_14(typeof(Delegate170).TypeHandle);
	}

	// Token: 0x040001F7 RID: 503
	internal static Delegate170 delegate170_0;
}

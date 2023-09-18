using System;

// Token: 0x0200007C RID: 124
internal sealed class Delegate49 : MulticastDelegate
{
	// Token: 0x060007D0 RID: 2000
	public extern void Invoke(object object_0, EventHandler eventHandler_0);

	// Token: 0x060007D1 RID: 2001 RVA: 0x00004F74 File Offset: 0x00003174
	public static void smethod_0(object object_0, EventHandler eventHandler_0, Delegate49 delegate49_1)
	{
		delegate49_1(object_0, eventHandler_0);
	}

	// Token: 0x060007D2 RID: 2002
	public extern Delegate49(object object_0, IntPtr intptr_0);

	// Token: 0x060007D3 RID: 2003 RVA: 0x00004F81 File Offset: 0x00003181
	static Delegate49()
	{
		Class2.smethod_14(typeof(Delegate49).TypeHandle);
	}

	// Token: 0x0400017E RID: 382
	internal static Delegate49 delegate49_0;
}

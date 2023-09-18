using System;

// Token: 0x0200010E RID: 270
internal sealed class Delegate195 : MulticastDelegate
{
	// Token: 0x06000A09 RID: 2569
	public extern void Invoke(object object_0, ref bool bool_0);

	// Token: 0x06000A0A RID: 2570 RVA: 0x00005CA3 File Offset: 0x00003EA3
	public static void smethod_0(object object_0, ref bool bool_0, Delegate195 delegate195_1)
	{
		delegate195_1(object_0, ref bool_0);
	}

	// Token: 0x06000A0B RID: 2571
	public extern Delegate195(object object_0, IntPtr intptr_0);

	// Token: 0x06000A0C RID: 2572 RVA: 0x00005CB0 File Offset: 0x00003EB0
	static Delegate195()
	{
		Class2.smethod_14(typeof(Delegate195).TypeHandle);
	}

	// Token: 0x04000210 RID: 528
	internal static Delegate195 delegate195_0;
}

using System;

// Token: 0x020000B0 RID: 176
internal sealed class Delegate101 : MulticastDelegate
{
	// Token: 0x0600089D RID: 2205
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x0600089E RID: 2206 RVA: 0x0000543B File Offset: 0x0000363B
	public static void smethod_0(object object_0, int int_0, Delegate101 delegate101_1)
	{
		delegate101_1(object_0, int_0);
	}

	// Token: 0x0600089F RID: 2207
	public extern Delegate101(object object_0, IntPtr intptr_0);

	// Token: 0x060008A0 RID: 2208 RVA: 0x00005448 File Offset: 0x00003648
	static Delegate101()
	{
		Class2.smethod_14(typeof(Delegate101).TypeHandle);
	}

	// Token: 0x040001B2 RID: 434
	internal static Delegate101 delegate101_0;
}

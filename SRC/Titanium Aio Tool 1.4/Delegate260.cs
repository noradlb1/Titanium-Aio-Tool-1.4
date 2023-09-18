using System;

// Token: 0x0200014F RID: 335
internal sealed class Delegate260 : MulticastDelegate
{
	// Token: 0x06000B0C RID: 2828
	public extern string Invoke(object object_0, int int_0);

	// Token: 0x06000B0D RID: 2829 RVA: 0x0000629F File Offset: 0x0000449F
	public static string smethod_0(object object_0, int int_0, Delegate260 delegate260_1)
	{
		return delegate260_1(object_0, int_0);
	}

	// Token: 0x06000B0E RID: 2830
	public extern Delegate260(object object_0, IntPtr intptr_0);

	// Token: 0x06000B0F RID: 2831 RVA: 0x000062AC File Offset: 0x000044AC
	static Delegate260()
	{
		Class2.smethod_14(typeof(Delegate260).TypeHandle);
	}

	// Token: 0x04000251 RID: 593
	internal static Delegate260 delegate260_0;
}

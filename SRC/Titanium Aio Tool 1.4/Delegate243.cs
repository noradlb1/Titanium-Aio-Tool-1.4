using System;

// Token: 0x0200013E RID: 318
internal sealed class Delegate243 : MulticastDelegate
{
	// Token: 0x06000AC8 RID: 2760
	public extern string Invoke(ref double double_0);

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00006104 File Offset: 0x00004304
	public static string smethod_0(ref double double_0, Delegate243 delegate243_1)
	{
		return delegate243_1(ref double_0);
	}

	// Token: 0x06000ACA RID: 2762
	public extern Delegate243(object object_0, IntPtr intptr_0);

	// Token: 0x06000ACB RID: 2763 RVA: 0x0000610F File Offset: 0x0000430F
	static Delegate243()
	{
		Class2.smethod_14(typeof(Delegate243).TypeHandle);
	}

	// Token: 0x04000240 RID: 576
	internal static Delegate243 delegate243_0;
}

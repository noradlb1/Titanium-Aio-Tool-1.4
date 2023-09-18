using System;

// Token: 0x02000146 RID: 326
internal sealed class Delegate251 : MulticastDelegate
{
	// Token: 0x06000AE8 RID: 2792
	public extern int Invoke(object object_0);

	// Token: 0x06000AE9 RID: 2793 RVA: 0x000061C8 File Offset: 0x000043C8
	public static int smethod_0(object object_0, Delegate251 delegate251_1)
	{
		return delegate251_1(object_0);
	}

	// Token: 0x06000AEA RID: 2794
	public extern Delegate251(object object_0, IntPtr intptr_0);

	// Token: 0x06000AEB RID: 2795 RVA: 0x000061D3 File Offset: 0x000043D3
	static Delegate251()
	{
		Class2.smethod_14(typeof(Delegate251).TypeHandle);
	}

	// Token: 0x04000248 RID: 584
	internal static Delegate251 delegate251_0;
}

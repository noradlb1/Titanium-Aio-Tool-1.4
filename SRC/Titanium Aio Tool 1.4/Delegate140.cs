using System;

// Token: 0x020000D7 RID: 215
internal sealed class Delegate140 : MulticastDelegate
{
	// Token: 0x06000932 RID: 2354
	public extern string Invoke(object object_0);

	// Token: 0x06000933 RID: 2355 RVA: 0x0000579D File Offset: 0x0000399D
	public static string smethod_0(object object_0, Delegate140 delegate140_1)
	{
		return delegate140_1(object_0);
	}

	// Token: 0x06000934 RID: 2356
	public extern Delegate140(object object_0, IntPtr intptr_0);

	// Token: 0x06000935 RID: 2357 RVA: 0x000057A8 File Offset: 0x000039A8
	static Delegate140()
	{
		Class2.smethod_14(typeof(Delegate140).TypeHandle);
	}

	// Token: 0x040001D9 RID: 473
	internal static Delegate140 delegate140_0;
}

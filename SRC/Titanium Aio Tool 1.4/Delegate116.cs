using System;

// Token: 0x020000BF RID: 191
internal sealed class Delegate116 : MulticastDelegate
{
	// Token: 0x060008D6 RID: 2262
	public extern int Invoke(object object_0);

	// Token: 0x060008D7 RID: 2263 RVA: 0x00005585 File Offset: 0x00003785
	public static int smethod_0(object object_0, Delegate116 delegate116_1)
	{
		return delegate116_1(object_0);
	}

	// Token: 0x060008D8 RID: 2264
	public extern Delegate116(object object_0, IntPtr intptr_0);

	// Token: 0x060008D9 RID: 2265 RVA: 0x00005590 File Offset: 0x00003790
	static Delegate116()
	{
		Class2.smethod_14(typeof(Delegate116).TypeHandle);
	}

	// Token: 0x040001C1 RID: 449
	internal static Delegate116 delegate116_0;
}

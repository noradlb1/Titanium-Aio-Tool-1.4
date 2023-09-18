using System;

// Token: 0x02000088 RID: 136
internal sealed class Delegate61 : MulticastDelegate
{
	// Token: 0x060007FE RID: 2046
	public extern string Invoke(object object_0);

	// Token: 0x060007FF RID: 2047 RVA: 0x00005078 File Offset: 0x00003278
	public static string smethod_0(object object_0, Delegate61 delegate61_1)
	{
		return delegate61_1(object_0);
	}

	// Token: 0x06000800 RID: 2048
	public extern Delegate61(object object_0, IntPtr intptr_0);

	// Token: 0x06000801 RID: 2049 RVA: 0x00005083 File Offset: 0x00003283
	static Delegate61()
	{
		Class2.smethod_14(typeof(Delegate61).TypeHandle);
	}

	// Token: 0x0400018A RID: 394
	internal static Delegate61 delegate61_0;
}

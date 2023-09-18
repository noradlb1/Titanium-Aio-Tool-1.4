using System;

// Token: 0x020000B9 RID: 185
internal sealed class Delegate110 : MulticastDelegate
{
	// Token: 0x060008BE RID: 2238
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060008BF RID: 2239 RVA: 0x000054F3 File Offset: 0x000036F3
	public static void smethod_0(object object_0, string string_0, Delegate110 delegate110_1)
	{
		delegate110_1(object_0, string_0);
	}

	// Token: 0x060008C0 RID: 2240
	public extern Delegate110(object object_0, IntPtr intptr_0);

	// Token: 0x060008C1 RID: 2241 RVA: 0x00005500 File Offset: 0x00003700
	static Delegate110()
	{
		Class2.smethod_14(typeof(Delegate110).TypeHandle);
	}

	// Token: 0x040001BB RID: 443
	internal static Delegate110 delegate110_0;
}

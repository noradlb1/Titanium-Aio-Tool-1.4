using System;

// Token: 0x02000075 RID: 117
internal sealed class Delegate42 : MulticastDelegate
{
	// Token: 0x060007B4 RID: 1972
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060007B5 RID: 1973 RVA: 0x00004EC5 File Offset: 0x000030C5
	public static void smethod_0(object object_0, string string_0, Delegate42 delegate42_1)
	{
		delegate42_1(object_0, string_0);
	}

	// Token: 0x060007B6 RID: 1974
	public extern Delegate42(object object_0, IntPtr intptr_0);

	// Token: 0x060007B7 RID: 1975 RVA: 0x00004ED2 File Offset: 0x000030D2
	static Delegate42()
	{
		Class2.smethod_14(typeof(Delegate42).TypeHandle);
	}

	// Token: 0x04000177 RID: 375
	internal static Delegate42 delegate42_0;
}

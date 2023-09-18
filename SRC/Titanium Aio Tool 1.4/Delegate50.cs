using System;

// Token: 0x0200007D RID: 125
internal sealed class Delegate50 : MulticastDelegate
{
	// Token: 0x060007D4 RID: 2004
	public extern void Invoke(object object_0);

	// Token: 0x060007D5 RID: 2005 RVA: 0x00004F8D File Offset: 0x0000318D
	public static void smethod_0(object object_0, Delegate50 delegate50_1)
	{
		delegate50_1(object_0);
	}

	// Token: 0x060007D6 RID: 2006
	public extern Delegate50(object object_0, IntPtr intptr_0);

	// Token: 0x060007D7 RID: 2007 RVA: 0x00004F98 File Offset: 0x00003198
	static Delegate50()
	{
		Class2.smethod_14(typeof(Delegate50).TypeHandle);
	}

	// Token: 0x0400017F RID: 383
	internal static Delegate50 delegate50_0;
}

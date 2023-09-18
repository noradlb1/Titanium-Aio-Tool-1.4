using System;

// Token: 0x0200013F RID: 319
internal sealed class Delegate244 : MulticastDelegate
{
	// Token: 0x06000ACC RID: 2764
	public extern string Invoke(ref char char_0);

	// Token: 0x06000ACD RID: 2765 RVA: 0x0000611B File Offset: 0x0000431B
	public static string smethod_0(ref char char_0, Delegate244 delegate244_1)
	{
		return delegate244_1(ref char_0);
	}

	// Token: 0x06000ACE RID: 2766
	public extern Delegate244(object object_0, IntPtr intptr_0);

	// Token: 0x06000ACF RID: 2767 RVA: 0x00006126 File Offset: 0x00004326
	static Delegate244()
	{
		Class2.smethod_14(typeof(Delegate244).TypeHandle);
	}

	// Token: 0x04000241 RID: 577
	internal static Delegate244 delegate244_0;
}

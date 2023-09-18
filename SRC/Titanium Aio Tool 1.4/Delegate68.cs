using System;
using System.Drawing;

// Token: 0x0200008F RID: 143
internal sealed class Delegate68 : MulticastDelegate
{
	// Token: 0x0600081A RID: 2074
	public extern Size Invoke(object object_0);

	// Token: 0x0600081B RID: 2075 RVA: 0x00005123 File Offset: 0x00003323
	public static Size smethod_0(object object_0, Delegate68 delegate68_1)
	{
		return delegate68_1(object_0);
	}

	// Token: 0x0600081C RID: 2076
	public extern Delegate68(object object_0, IntPtr intptr_0);

	// Token: 0x0600081D RID: 2077 RVA: 0x0000512E File Offset: 0x0000332E
	static Delegate68()
	{
		Class2.smethod_14(typeof(Delegate68).TypeHandle);
	}

	// Token: 0x04000191 RID: 401
	internal static Delegate68 delegate68_0;
}

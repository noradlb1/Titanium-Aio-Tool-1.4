using System;
using System.Drawing;

// Token: 0x020000A0 RID: 160
internal sealed class Delegate85 : MulticastDelegate
{
	// Token: 0x0600085E RID: 2142
	public extern void Invoke(object object_0, Size size_0);

	// Token: 0x0600085F RID: 2143 RVA: 0x000052BC File Offset: 0x000034BC
	public static void smethod_0(object object_0, Size size_0, Delegate85 delegate85_1)
	{
		delegate85_1(object_0, size_0);
	}

	// Token: 0x06000860 RID: 2144
	public extern Delegate85(object object_0, IntPtr intptr_0);

	// Token: 0x06000861 RID: 2145 RVA: 0x000052C9 File Offset: 0x000034C9
	static Delegate85()
	{
		Class2.smethod_14(typeof(Delegate85).TypeHandle);
	}

	// Token: 0x040001A2 RID: 418
	internal static Delegate85 delegate85_0;
}

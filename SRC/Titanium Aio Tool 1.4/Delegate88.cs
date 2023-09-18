using System;
using System.Windows.Forms;

// Token: 0x020000A3 RID: 163
internal sealed class Delegate88 : MulticastDelegate
{
	// Token: 0x06000869 RID: 2153
	public extern void Invoke(object object_0, Cursor cursor_0);

	// Token: 0x0600086A RID: 2154 RVA: 0x000052FA File Offset: 0x000034FA
	public static void smethod_0(object object_0, Cursor cursor_0, Delegate88 delegate88_1)
	{
		delegate88_1(object_0, cursor_0);
	}

	// Token: 0x0600086B RID: 2155
	public extern Delegate88(object object_0, IntPtr intptr_0);

	// Token: 0x0600086C RID: 2156 RVA: 0x00005307 File Offset: 0x00003507
	static Delegate88()
	{
		Class2.smethod_14(typeof(Delegate88).TypeHandle);
	}

	// Token: 0x040001A5 RID: 421
	internal static Delegate88 delegate88_0;
}

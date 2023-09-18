using System;
using System.Windows.Forms;

// Token: 0x020000F1 RID: 241
internal sealed class Delegate166 : MulticastDelegate
{
	// Token: 0x06000996 RID: 2454
	public extern void Invoke(object object_0, PaintEventHandler paintEventHandler_0);

	// Token: 0x06000997 RID: 2455 RVA: 0x000059E7 File Offset: 0x00003BE7
	public static void smethod_0(object object_0, PaintEventHandler paintEventHandler_0, Delegate166 delegate166_1)
	{
		delegate166_1(object_0, paintEventHandler_0);
	}

	// Token: 0x06000998 RID: 2456
	public extern Delegate166(object object_0, IntPtr intptr_0);

	// Token: 0x06000999 RID: 2457 RVA: 0x000059F4 File Offset: 0x00003BF4
	static Delegate166()
	{
		Class2.smethod_14(typeof(Delegate166).TypeHandle);
	}

	// Token: 0x040001F3 RID: 499
	internal static Delegate166 delegate166_0;
}

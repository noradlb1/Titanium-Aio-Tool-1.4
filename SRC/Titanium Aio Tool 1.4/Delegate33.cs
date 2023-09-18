using System;
using System.Windows.Forms;

// Token: 0x0200006C RID: 108
internal sealed class Delegate33 : MulticastDelegate
{
	// Token: 0x06000790 RID: 1936
	public extern void Invoke(object sender, PaintEventArgs e);

	// Token: 0x06000791 RID: 1937 RVA: 0x00004DE6 File Offset: 0x00002FE6
	public static void smethod_0(object object_0, PaintEventArgs paintEventArgs_0, Delegate33 delegate33_1)
	{
		delegate33_1(object_0, paintEventArgs_0);
	}

	// Token: 0x06000792 RID: 1938
	public extern Delegate33(object object_0, IntPtr intptr_0);

	// Token: 0x06000793 RID: 1939 RVA: 0x00004DF3 File Offset: 0x00002FF3
	static Delegate33()
	{
		Class2.smethod_14(typeof(Delegate33).TypeHandle);
	}

	// Token: 0x0400016E RID: 366
	internal static Delegate33 delegate33_0;
}

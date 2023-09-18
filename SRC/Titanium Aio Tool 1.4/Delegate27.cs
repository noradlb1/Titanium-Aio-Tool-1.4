using System;
using System.Windows.Forms;

// Token: 0x02000066 RID: 102
internal sealed class Delegate27 : MulticastDelegate
{
	// Token: 0x06000778 RID: 1912
	public extern void Invoke(object sender, PaintEventArgs e);

	// Token: 0x06000779 RID: 1913 RVA: 0x00004D4E File Offset: 0x00002F4E
	public static void smethod_0(object object_0, PaintEventArgs paintEventArgs_0, Delegate27 delegate27_1)
	{
		delegate27_1(object_0, paintEventArgs_0);
	}

	// Token: 0x0600077A RID: 1914
	public extern Delegate27(object object_0, IntPtr intptr_0);

	// Token: 0x0600077B RID: 1915 RVA: 0x00004D5B File Offset: 0x00002F5B
	static Delegate27()
	{
		Class2.smethod_14(typeof(Delegate27).TypeHandle);
	}

	// Token: 0x04000168 RID: 360
	internal static Delegate27 delegate27_0;
}

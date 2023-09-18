using System;
using System.Drawing;

// Token: 0x0200009B RID: 155
internal sealed class Delegate80 : MulticastDelegate
{
	// Token: 0x0600084A RID: 2122
	public extern void Invoke(object object_0, Size size_0);

	// Token: 0x0600084B RID: 2123 RVA: 0x0000523F File Offset: 0x0000343F
	public static void smethod_0(object object_0, Size size_0, Delegate80 delegate80_1)
	{
		delegate80_1(object_0, size_0);
	}

	// Token: 0x0600084C RID: 2124
	public extern Delegate80(object object_0, IntPtr intptr_0);

	// Token: 0x0600084D RID: 2125 RVA: 0x0000524C File Offset: 0x0000344C
	static Delegate80()
	{
		Class2.smethod_14(typeof(Delegate80).TypeHandle);
	}

	// Token: 0x0400019D RID: 413
	internal static Delegate80 delegate80_0;
}

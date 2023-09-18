using System;
using System.Windows.Forms;

// Token: 0x0200009F RID: 159
internal sealed class Delegate84 : MulticastDelegate
{
	// Token: 0x0600085A RID: 2138
	public extern void Invoke(object object_0, AutoScaleMode autoScaleMode_0);

	// Token: 0x0600085B RID: 2139 RVA: 0x000052A3 File Offset: 0x000034A3
	public static void smethod_0(object object_0, AutoScaleMode autoScaleMode_0, Delegate84 delegate84_1)
	{
		delegate84_1(object_0, autoScaleMode_0);
	}

	// Token: 0x0600085C RID: 2140
	public extern Delegate84(object object_0, IntPtr intptr_0);

	// Token: 0x0600085D RID: 2141 RVA: 0x000052B0 File Offset: 0x000034B0
	static Delegate84()
	{
		Class2.smethod_14(typeof(Delegate84).TypeHandle);
	}

	// Token: 0x040001A1 RID: 417
	internal static Delegate84 delegate84_0;
}

using System;
using System.Drawing;

// Token: 0x020000B6 RID: 182
internal sealed class Delegate107 : MulticastDelegate
{
	// Token: 0x060008B3 RID: 2227
	public extern void Invoke(object object_0, Color color_0);

	// Token: 0x060008B4 RID: 2228 RVA: 0x000054B5 File Offset: 0x000036B5
	public static void smethod_0(object object_0, Color color_0, Delegate107 delegate107_1)
	{
		delegate107_1(object_0, color_0);
	}

	// Token: 0x060008B5 RID: 2229
	public extern Delegate107(object object_0, IntPtr intptr_0);

	// Token: 0x060008B6 RID: 2230 RVA: 0x000054C2 File Offset: 0x000036C2
	static Delegate107()
	{
		Class2.smethod_14(typeof(Delegate107).TypeHandle);
	}

	// Token: 0x040001B8 RID: 440
	internal static Delegate107 delegate107_0;
}

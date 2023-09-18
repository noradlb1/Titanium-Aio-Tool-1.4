using System;
using System.Drawing;

// Token: 0x020000E3 RID: 227
internal sealed class Delegate152 : MulticastDelegate
{
	// Token: 0x06000961 RID: 2401
	public extern void Invoke(object object_0, Color color_0);

	// Token: 0x06000962 RID: 2402 RVA: 0x000058B2 File Offset: 0x00003AB2
	public static void smethod_0(object object_0, Color color_0, Delegate152 delegate152_1)
	{
		delegate152_1(object_0, color_0);
	}

	// Token: 0x06000963 RID: 2403
	public extern Delegate152(object object_0, IntPtr intptr_0);

	// Token: 0x06000964 RID: 2404 RVA: 0x000058BF File Offset: 0x00003ABF
	static Delegate152()
	{
		Class2.smethod_14(typeof(Delegate152).TypeHandle);
	}

	// Token: 0x040001E5 RID: 485
	internal static Delegate152 delegate152_0;
}

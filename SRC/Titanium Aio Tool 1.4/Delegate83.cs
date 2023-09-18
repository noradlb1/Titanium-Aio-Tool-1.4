using System;
using System.Drawing;

// Token: 0x0200009E RID: 158
internal sealed class Delegate83 : MulticastDelegate
{
	// Token: 0x06000856 RID: 2134
	public extern void Invoke(object object_0, SizeF sizeF_0);

	// Token: 0x06000857 RID: 2135 RVA: 0x0000528A File Offset: 0x0000348A
	public static void smethod_0(object object_0, SizeF sizeF_0, Delegate83 delegate83_1)
	{
		delegate83_1(object_0, sizeF_0);
	}

	// Token: 0x06000858 RID: 2136
	public extern Delegate83(object object_0, IntPtr intptr_0);

	// Token: 0x06000859 RID: 2137 RVA: 0x00005297 File Offset: 0x00003497
	static Delegate83()
	{
		Class2.smethod_14(typeof(Delegate83).TypeHandle);
	}

	// Token: 0x040001A0 RID: 416
	internal static Delegate83 delegate83_0;
}

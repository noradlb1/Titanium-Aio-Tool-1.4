using System;
using System.Drawing;

// Token: 0x020000F6 RID: 246
internal sealed class Delegate171 : MulticastDelegate
{
	// Token: 0x060009AA RID: 2474
	public extern void Invoke(object object_0, Image image_0);

	// Token: 0x060009AB RID: 2475 RVA: 0x00005A64 File Offset: 0x00003C64
	public static void smethod_0(object object_0, Image image_0, Delegate171 delegate171_1)
	{
		delegate171_1(object_0, image_0);
	}

	// Token: 0x060009AC RID: 2476
	public extern Delegate171(object object_0, IntPtr intptr_0);

	// Token: 0x060009AD RID: 2477 RVA: 0x00005A71 File Offset: 0x00003C71
	static Delegate171()
	{
		Class2.smethod_14(typeof(Delegate171).TypeHandle);
	}

	// Token: 0x040001F8 RID: 504
	internal static Delegate171 delegate171_0;
}

using System;
using System.Drawing;

// Token: 0x020000EB RID: 235
internal sealed class Delegate160 : MulticastDelegate
{
	// Token: 0x0600097F RID: 2431
	public extern void Invoke(object object_0, Image image_0);

	// Token: 0x06000980 RID: 2432 RVA: 0x00005960 File Offset: 0x00003B60
	public static void smethod_0(object object_0, Image image_0, Delegate160 delegate160_1)
	{
		delegate160_1(object_0, image_0);
	}

	// Token: 0x06000981 RID: 2433
	public extern Delegate160(object object_0, IntPtr intptr_0);

	// Token: 0x06000982 RID: 2434 RVA: 0x0000596D File Offset: 0x00003B6D
	static Delegate160()
	{
		Class2.smethod_14(typeof(Delegate160).TypeHandle);
	}

	// Token: 0x040001ED RID: 493
	internal static Delegate160 delegate160_0;
}

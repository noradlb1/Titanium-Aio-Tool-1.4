using System;
using System.Windows.Forms;

// Token: 0x020000EF RID: 239
internal sealed class Delegate164 : MulticastDelegate
{
	// Token: 0x0600098F RID: 2447
	public extern void Invoke(object object_0, FlatStyle flatStyle_0);

	// Token: 0x06000990 RID: 2448 RVA: 0x000059C2 File Offset: 0x00003BC2
	public static void smethod_0(object object_0, FlatStyle flatStyle_0, Delegate164 delegate164_1)
	{
		delegate164_1(object_0, flatStyle_0);
	}

	// Token: 0x06000991 RID: 2449
	public extern Delegate164(object object_0, IntPtr intptr_0);

	// Token: 0x06000992 RID: 2450 RVA: 0x000059CF File Offset: 0x00003BCF
	static Delegate164()
	{
		Class2.smethod_14(typeof(Delegate164).TypeHandle);
	}

	// Token: 0x040001F1 RID: 497
	internal static Delegate164 delegate164_0;
}

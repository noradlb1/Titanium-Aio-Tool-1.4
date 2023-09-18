using System;

// Token: 0x0200007B RID: 123
internal sealed class Delegate48 : MulticastDelegate
{
	// Token: 0x060007CC RID: 1996
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x060007CD RID: 1997 RVA: 0x00004F5B File Offset: 0x0000315B
	public static void smethod_0(object object_0, int int_0, Delegate48 delegate48_1)
	{
		delegate48_1(object_0, int_0);
	}

	// Token: 0x060007CE RID: 1998
	public extern Delegate48(object object_0, IntPtr intptr_0);

	// Token: 0x060007CF RID: 1999 RVA: 0x00004F68 File Offset: 0x00003168
	static Delegate48()
	{
		Class2.smethod_14(typeof(Delegate48).TypeHandle);
	}

	// Token: 0x0400017D RID: 381
	internal static Delegate48 delegate48_0;
}

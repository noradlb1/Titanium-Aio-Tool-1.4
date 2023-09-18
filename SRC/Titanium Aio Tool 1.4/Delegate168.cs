using System;

// Token: 0x020000F3 RID: 243
internal sealed class Delegate168 : MulticastDelegate
{
	// Token: 0x0600099E RID: 2462
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x0600099F RID: 2463 RVA: 0x00005A19 File Offset: 0x00003C19
	public static void smethod_0(object object_0, bool bool_0, Delegate168 delegate168_1)
	{
		delegate168_1(object_0, bool_0);
	}

	// Token: 0x060009A0 RID: 2464
	public extern Delegate168(object object_0, IntPtr intptr_0);

	// Token: 0x060009A1 RID: 2465 RVA: 0x00005A26 File Offset: 0x00003C26
	static Delegate168()
	{
		Class2.smethod_14(typeof(Delegate168).TypeHandle);
	}

	// Token: 0x040001F5 RID: 501
	internal static Delegate168 delegate168_0;
}

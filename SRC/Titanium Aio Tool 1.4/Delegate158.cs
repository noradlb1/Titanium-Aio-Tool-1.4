using System;

// Token: 0x020000E9 RID: 233
internal sealed class Delegate158 : MulticastDelegate
{
	// Token: 0x06000978 RID: 2424
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06000979 RID: 2425 RVA: 0x0000593B File Offset: 0x00003B3B
	public static void smethod_0(object object_0, bool bool_0, Delegate158 delegate158_1)
	{
		delegate158_1(object_0, bool_0);
	}

	// Token: 0x0600097A RID: 2426
	public extern Delegate158(object object_0, IntPtr intptr_0);

	// Token: 0x0600097B RID: 2427 RVA: 0x00005948 File Offset: 0x00003B48
	static Delegate158()
	{
		Class2.smethod_14(typeof(Delegate158).TypeHandle);
	}

	// Token: 0x040001EB RID: 491
	internal static Delegate158 delegate158_0;
}

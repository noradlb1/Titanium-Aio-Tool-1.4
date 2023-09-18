using System;

// Token: 0x02000079 RID: 121
internal sealed class Delegate46 : MulticastDelegate
{
	// Token: 0x060007C4 RID: 1988
	public extern string Invoke(string string_0, string string_1);

	// Token: 0x060007C5 RID: 1989 RVA: 0x00004F29 File Offset: 0x00003129
	public static string smethod_0(string string_0, string string_1, Delegate46 delegate46_1)
	{
		return delegate46_1(string_0, string_1);
	}

	// Token: 0x060007C6 RID: 1990
	public extern Delegate46(object object_0, IntPtr intptr_0);

	// Token: 0x060007C7 RID: 1991 RVA: 0x00004F36 File Offset: 0x00003136
	static Delegate46()
	{
		Class2.smethod_14(typeof(Delegate46).TypeHandle);
	}

	// Token: 0x0400017B RID: 379
	internal static Delegate46 delegate46_0;
}

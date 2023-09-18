using System;

// Token: 0x020000C7 RID: 199
internal sealed class Delegate124 : MulticastDelegate
{
	// Token: 0x060008F3 RID: 2291
	public extern byte[] Invoke(object object_0, string string_0);

	// Token: 0x060008F4 RID: 2292 RVA: 0x00005622 File Offset: 0x00003822
	public static byte[] smethod_0(object object_0, string string_0, Delegate124 delegate124_1)
	{
		return delegate124_1(object_0, string_0);
	}

	// Token: 0x060008F5 RID: 2293
	public extern Delegate124(object object_0, IntPtr intptr_0);

	// Token: 0x060008F6 RID: 2294 RVA: 0x0000562F File Offset: 0x0000382F
	static Delegate124()
	{
		Class2.smethod_14(typeof(Delegate124).TypeHandle);
	}

	// Token: 0x040001C9 RID: 457
	internal static Delegate124 delegate124_0;
}

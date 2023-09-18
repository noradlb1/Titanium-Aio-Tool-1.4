using System;

// Token: 0x02000135 RID: 309
internal sealed class Delegate234 : MulticastDelegate
{
	// Token: 0x06000AA4 RID: 2724
	public extern string Invoke(ref uint uint_0);

	// Token: 0x06000AA5 RID: 2725 RVA: 0x00006035 File Offset: 0x00004235
	public static string smethod_0(ref uint uint_0, Delegate234 delegate234_1)
	{
		return delegate234_1(ref uint_0);
	}

	// Token: 0x06000AA6 RID: 2726
	public extern Delegate234(object object_0, IntPtr intptr_0);

	// Token: 0x06000AA7 RID: 2727 RVA: 0x00006040 File Offset: 0x00004240
	static Delegate234()
	{
		Class2.smethod_14(typeof(Delegate234).TypeHandle);
	}

	// Token: 0x04000237 RID: 567
	internal static Delegate234 delegate234_0;
}

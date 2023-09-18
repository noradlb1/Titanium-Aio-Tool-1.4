using System;

// Token: 0x02000136 RID: 310
internal sealed class Delegate235 : MulticastDelegate
{
	// Token: 0x06000AA8 RID: 2728
	public extern string Invoke(ref long long_0);

	// Token: 0x06000AA9 RID: 2729 RVA: 0x0000604C File Offset: 0x0000424C
	public static string smethod_0(ref long long_0, Delegate235 delegate235_1)
	{
		return delegate235_1(ref long_0);
	}

	// Token: 0x06000AAA RID: 2730
	public extern Delegate235(object object_0, IntPtr intptr_0);

	// Token: 0x06000AAB RID: 2731 RVA: 0x00006057 File Offset: 0x00004257
	static Delegate235()
	{
		Class2.smethod_14(typeof(Delegate235).TypeHandle);
	}

	// Token: 0x04000238 RID: 568
	internal static Delegate235 delegate235_0;
}

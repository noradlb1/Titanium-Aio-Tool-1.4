using System;

// Token: 0x0200015E RID: 350
internal sealed class Delegate275 : MulticastDelegate
{
	// Token: 0x06000B48 RID: 2888
	public extern bool Invoke(object object_0);

	// Token: 0x06000B49 RID: 2889 RVA: 0x00006406 File Offset: 0x00004606
	public static bool smethod_0(object object_0, Delegate275 delegate275_1)
	{
		return delegate275_1(object_0);
	}

	// Token: 0x06000B4A RID: 2890
	public extern Delegate275(object object_0, IntPtr intptr_0);

	// Token: 0x06000B4B RID: 2891 RVA: 0x00006411 File Offset: 0x00004611
	static Delegate275()
	{
		Class2.smethod_14(typeof(Delegate275).TypeHandle);
	}

	// Token: 0x04000260 RID: 608
	internal static Delegate275 delegate275_0;
}

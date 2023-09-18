using System;

// Token: 0x02000157 RID: 343
internal sealed class Delegate268 : MulticastDelegate
{
	// Token: 0x06000B2C RID: 2860
	public extern Type Invoke(object object_0);

	// Token: 0x06000B2D RID: 2861 RVA: 0x0000635B File Offset: 0x0000455B
	public static Type smethod_0(object object_0, Delegate268 delegate268_1)
	{
		return delegate268_1(object_0);
	}

	// Token: 0x06000B2E RID: 2862
	public extern Delegate268(object object_0, IntPtr intptr_0);

	// Token: 0x06000B2F RID: 2863 RVA: 0x00006366 File Offset: 0x00004566
	static Delegate268()
	{
		Class2.smethod_14(typeof(Delegate268).TypeHandle);
	}

	// Token: 0x04000259 RID: 601
	internal static Delegate268 delegate268_0;
}

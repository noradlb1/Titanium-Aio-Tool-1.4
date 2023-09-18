using System;

// Token: 0x02000167 RID: 359
internal sealed class Delegate284 : MulticastDelegate
{
	// Token: 0x06000B6C RID: 2924
	public extern Type Invoke(object object_0);

	// Token: 0x06000B6D RID: 2925 RVA: 0x000064E9 File Offset: 0x000046E9
	public static Type smethod_0(object object_0, Delegate284 delegate284_1)
	{
		return delegate284_1(object_0);
	}

	// Token: 0x06000B6E RID: 2926
	public extern Delegate284(object object_0, IntPtr intptr_0);

	// Token: 0x06000B6F RID: 2927 RVA: 0x000064F4 File Offset: 0x000046F4
	static Delegate284()
	{
		Class2.smethod_14(typeof(Delegate284).TypeHandle);
	}

	// Token: 0x04000269 RID: 617
	internal static Delegate284 delegate284_0;
}

using System;

// Token: 0x02000148 RID: 328
internal sealed class Delegate253 : MulticastDelegate
{
	// Token: 0x06000AF0 RID: 2800
	public extern Exception Invoke(object object_0);

	// Token: 0x06000AF1 RID: 2801 RVA: 0x000061F6 File Offset: 0x000043F6
	public static Exception smethod_0(object object_0, Delegate253 delegate253_1)
	{
		return delegate253_1(object_0);
	}

	// Token: 0x06000AF2 RID: 2802
	public extern Delegate253(object object_0, IntPtr intptr_0);

	// Token: 0x06000AF3 RID: 2803 RVA: 0x00006201 File Offset: 0x00004401
	static Delegate253()
	{
		Class2.smethod_14(typeof(Delegate253).TypeHandle);
	}

	// Token: 0x0400024A RID: 586
	internal static Delegate253 delegate253_0;
}

using System;

// Token: 0x02000141 RID: 321
internal sealed class Delegate246 : MulticastDelegate
{
	// Token: 0x06000AD4 RID: 2772
	public extern object Invoke(object object_0, int int_0);

	// Token: 0x06000AD5 RID: 2773 RVA: 0x0000614D File Offset: 0x0000434D
	public static object smethod_0(object object_0, int int_0, Delegate246 delegate246_1)
	{
		return delegate246_1(object_0, int_0);
	}

	// Token: 0x06000AD6 RID: 2774
	public extern Delegate246(object object_0, IntPtr intptr_0);

	// Token: 0x06000AD7 RID: 2775 RVA: 0x0000615A File Offset: 0x0000435A
	static Delegate246()
	{
		Class2.smethod_14(typeof(Delegate246).TypeHandle);
	}

	// Token: 0x04000243 RID: 579
	internal static Delegate246 delegate246_0;
}

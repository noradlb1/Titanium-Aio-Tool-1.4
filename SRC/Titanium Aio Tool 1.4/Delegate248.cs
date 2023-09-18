using System;

// Token: 0x02000143 RID: 323
internal sealed class Delegate248 : MulticastDelegate
{
	// Token: 0x06000ADC RID: 2780
	public extern object Invoke(object object_0, object object_1);

	// Token: 0x06000ADD RID: 2781 RVA: 0x0000617D File Offset: 0x0000437D
	public static object smethod_0(object object_0, object object_1, Delegate248 delegate248_1)
	{
		return delegate248_1(object_0, object_1);
	}

	// Token: 0x06000ADE RID: 2782
	public extern Delegate248(object object_0, IntPtr intptr_0);

	// Token: 0x06000ADF RID: 2783 RVA: 0x0000618A File Offset: 0x0000438A
	static Delegate248()
	{
		Class2.smethod_14(typeof(Delegate248).TypeHandle);
	}

	// Token: 0x04000245 RID: 581
	internal static Delegate248 delegate248_0;
}

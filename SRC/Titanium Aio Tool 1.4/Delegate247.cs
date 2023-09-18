using System;

// Token: 0x02000142 RID: 322
internal sealed class Delegate247 : MulticastDelegate
{
	// Token: 0x06000AD8 RID: 2776
	public extern Type Invoke(object object_0);

	// Token: 0x06000AD9 RID: 2777 RVA: 0x00006166 File Offset: 0x00004366
	public static Type smethod_0(object object_0, Delegate247 delegate247_1)
	{
		return delegate247_1(object_0);
	}

	// Token: 0x06000ADA RID: 2778
	public extern Delegate247(object object_0, IntPtr intptr_0);

	// Token: 0x06000ADB RID: 2779 RVA: 0x00006171 File Offset: 0x00004371
	static Delegate247()
	{
		Class2.smethod_14(typeof(Delegate247).TypeHandle);
	}

	// Token: 0x04000244 RID: 580
	internal static Delegate247 delegate247_0;
}

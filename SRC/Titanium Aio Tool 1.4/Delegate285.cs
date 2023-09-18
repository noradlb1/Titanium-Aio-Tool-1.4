using System;

// Token: 0x02000168 RID: 360
internal sealed class Delegate285 : MulticastDelegate
{
	// Token: 0x06000B70 RID: 2928
	public extern Delegate Invoke(object object_0, Type type_0);

	// Token: 0x06000B71 RID: 2929 RVA: 0x00006500 File Offset: 0x00004700
	public static Delegate smethod_0(object object_0, Type type_0, Delegate285 delegate285_1)
	{
		return delegate285_1(object_0, type_0);
	}

	// Token: 0x06000B72 RID: 2930
	public extern Delegate285(object object_0, IntPtr intptr_0);

	// Token: 0x06000B73 RID: 2931 RVA: 0x0000650D File Offset: 0x0000470D
	static Delegate285()
	{
		Class2.smethod_14(typeof(Delegate285).TypeHandle);
	}

	// Token: 0x0400026A RID: 618
	internal static Delegate285 delegate285_0;
}

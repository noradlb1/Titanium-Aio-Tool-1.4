using System;

// Token: 0x02000130 RID: 304
internal sealed class Delegate229 : MulticastDelegate
{
	// Token: 0x06000A91 RID: 2705
	public extern object Invoke(Type type_0, sbyte sbyte_0);

	// Token: 0x06000A92 RID: 2706 RVA: 0x00005FC7 File Offset: 0x000041C7
	public static object smethod_0(Type type_0, sbyte sbyte_0, Delegate229 delegate229_1)
	{
		return delegate229_1(type_0, sbyte_0);
	}

	// Token: 0x06000A93 RID: 2707
	public extern Delegate229(object object_0, IntPtr intptr_0);

	// Token: 0x06000A94 RID: 2708 RVA: 0x00005FD4 File Offset: 0x000041D4
	static Delegate229()
	{
		Class2.smethod_14(typeof(Delegate229).TypeHandle);
	}

	// Token: 0x04000232 RID: 562
	internal static Delegate229 delegate229_0;
}

using System;

// Token: 0x02000128 RID: 296
internal sealed class Delegate221 : MulticastDelegate
{
	// Token: 0x06000A71 RID: 2673
	public extern Type Invoke(Type type_0);

	// Token: 0x06000A72 RID: 2674 RVA: 0x00005F05 File Offset: 0x00004105
	public static Type smethod_0(Type type_0, Delegate221 delegate221_1)
	{
		return delegate221_1(type_0);
	}

	// Token: 0x06000A73 RID: 2675
	public extern Delegate221(object object_0, IntPtr intptr_0);

	// Token: 0x06000A74 RID: 2676 RVA: 0x00005F10 File Offset: 0x00004110
	static Delegate221()
	{
		Class2.smethod_14(typeof(Delegate221).TypeHandle);
	}

	// Token: 0x0400022A RID: 554
	internal static Delegate221 delegate221_0;
}

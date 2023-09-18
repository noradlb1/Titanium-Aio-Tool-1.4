using System;

// Token: 0x0200011C RID: 284
internal sealed class Delegate209 : MulticastDelegate
{
	// Token: 0x06000A41 RID: 2625
	public extern Type Invoke(object object_0);

	// Token: 0x06000A42 RID: 2626 RVA: 0x00005DEB File Offset: 0x00003FEB
	public static Type smethod_0(object object_0, Delegate209 delegate209_1)
	{
		return delegate209_1(object_0);
	}

	// Token: 0x06000A43 RID: 2627
	public extern Delegate209(object object_0, IntPtr intptr_0);

	// Token: 0x06000A44 RID: 2628 RVA: 0x00005DF6 File Offset: 0x00003FF6
	static Delegate209()
	{
		Class2.smethod_14(typeof(Delegate209).TypeHandle);
	}

	// Token: 0x0400021E RID: 542
	internal static Delegate209 delegate209_0;
}

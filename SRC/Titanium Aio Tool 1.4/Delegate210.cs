using System;

// Token: 0x0200011D RID: 285
internal sealed class Delegate210 : MulticastDelegate
{
	// Token: 0x06000A45 RID: 2629
	public extern bool Invoke(Type type_0, Type type_1);

	// Token: 0x06000A46 RID: 2630 RVA: 0x00005E02 File Offset: 0x00004002
	public static bool smethod_0(Type type_0, Type type_1, Delegate210 delegate210_1)
	{
		return delegate210_1(type_0, type_1);
	}

	// Token: 0x06000A47 RID: 2631
	public extern Delegate210(object object_0, IntPtr intptr_0);

	// Token: 0x06000A48 RID: 2632 RVA: 0x00005E0F File Offset: 0x0000400F
	static Delegate210()
	{
		Class2.smethod_14(typeof(Delegate210).TypeHandle);
	}

	// Token: 0x0400021F RID: 543
	internal static Delegate210 delegate210_0;
}

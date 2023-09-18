using System;

// Token: 0x0200014D RID: 333
internal sealed class Delegate258 : MulticastDelegate
{
	// Token: 0x06000B04 RID: 2820
	public extern bool Invoke(object object_0, Type type_0);

	// Token: 0x06000B05 RID: 2821 RVA: 0x0000626D File Offset: 0x0000446D
	public static bool smethod_0(object object_0, Type type_0, Delegate258 delegate258_1)
	{
		return delegate258_1(object_0, type_0);
	}

	// Token: 0x06000B06 RID: 2822
	public extern Delegate258(object object_0, IntPtr intptr_0);

	// Token: 0x06000B07 RID: 2823 RVA: 0x0000627A File Offset: 0x0000447A
	static Delegate258()
	{
		Class2.smethod_14(typeof(Delegate258).TypeHandle);
	}

	// Token: 0x0400024F RID: 591
	internal static Delegate258 delegate258_0;
}

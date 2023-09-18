using System;

// Token: 0x0200012B RID: 299
internal sealed class Delegate224 : MulticastDelegate
{
	// Token: 0x06000A7D RID: 2685
	public extern object Invoke(Type type_0, int int_0);

	// Token: 0x06000A7E RID: 2686 RVA: 0x00005F4A File Offset: 0x0000414A
	public static object smethod_0(Type type_0, int int_0, Delegate224 delegate224_1)
	{
		return delegate224_1(type_0, int_0);
	}

	// Token: 0x06000A7F RID: 2687
	public extern Delegate224(object object_0, IntPtr intptr_0);

	// Token: 0x06000A80 RID: 2688 RVA: 0x00005F57 File Offset: 0x00004157
	static Delegate224()
	{
		Class2.smethod_14(typeof(Delegate224).TypeHandle);
	}

	// Token: 0x0400022D RID: 557
	internal static Delegate224 delegate224_0;
}

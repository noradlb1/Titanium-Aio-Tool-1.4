using System;

// Token: 0x02000132 RID: 306
internal sealed class Delegate231 : MulticastDelegate
{
	// Token: 0x06000A99 RID: 2713
	public extern object Invoke(Type type_0, ulong ulong_0);

	// Token: 0x06000A9A RID: 2714 RVA: 0x00005FF9 File Offset: 0x000041F9
	public static object smethod_0(Type type_0, ulong ulong_0, Delegate231 delegate231_1)
	{
		return delegate231_1(type_0, ulong_0);
	}

	// Token: 0x06000A9B RID: 2715
	public extern Delegate231(object object_0, IntPtr intptr_0);

	// Token: 0x06000A9C RID: 2716 RVA: 0x00006006 File Offset: 0x00004206
	static Delegate231()
	{
		Class2.smethod_14(typeof(Delegate231).TypeHandle);
	}

	// Token: 0x04000234 RID: 564
	internal static Delegate231 delegate231_0;
}

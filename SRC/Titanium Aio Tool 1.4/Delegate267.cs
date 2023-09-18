using System;

// Token: 0x02000156 RID: 342
internal sealed class Delegate267 : MulticastDelegate
{
	// Token: 0x06000B28 RID: 2856
	public extern Array Invoke(Type type_0, int int_0);

	// Token: 0x06000B29 RID: 2857 RVA: 0x00006342 File Offset: 0x00004542
	public static Array smethod_0(Type type_0, int int_0, Delegate267 delegate267_1)
	{
		return delegate267_1(type_0, int_0);
	}

	// Token: 0x06000B2A RID: 2858
	public extern Delegate267(object object_0, IntPtr intptr_0);

	// Token: 0x06000B2B RID: 2859 RVA: 0x0000634F File Offset: 0x0000454F
	static Delegate267()
	{
		Class2.smethod_14(typeof(Delegate267).TypeHandle);
	}

	// Token: 0x04000258 RID: 600
	internal static Delegate267 delegate267_0;
}

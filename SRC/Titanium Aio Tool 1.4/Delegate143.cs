using System;

// Token: 0x020000DA RID: 218
internal sealed class Delegate143 : MulticastDelegate
{
	// Token: 0x0600093E RID: 2366
	public extern object Invoke(Type type_0);

	// Token: 0x0600093F RID: 2367 RVA: 0x000057E8 File Offset: 0x000039E8
	public static object smethod_0(Type type_0, Delegate143 delegate143_1)
	{
		return delegate143_1(type_0);
	}

	// Token: 0x06000940 RID: 2368
	public extern Delegate143(object object_0, IntPtr intptr_0);

	// Token: 0x06000941 RID: 2369 RVA: 0x000057F3 File Offset: 0x000039F3
	static Delegate143()
	{
		Class2.smethod_14(typeof(Delegate143).TypeHandle);
	}

	// Token: 0x040001DC RID: 476
	internal static Delegate143 delegate143_0;
}

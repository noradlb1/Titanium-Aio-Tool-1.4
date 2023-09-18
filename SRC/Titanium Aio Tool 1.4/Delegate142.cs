using System;

// Token: 0x020000D9 RID: 217
internal sealed class Delegate142 : MulticastDelegate
{
	// Token: 0x0600093A RID: 2362
	public extern Type Invoke(Guid guid_0);

	// Token: 0x0600093B RID: 2363 RVA: 0x000057D1 File Offset: 0x000039D1
	public static Type smethod_0(Guid guid_0, Delegate142 delegate142_1)
	{
		return delegate142_1(guid_0);
	}

	// Token: 0x0600093C RID: 2364
	public extern Delegate142(object object_0, IntPtr intptr_0);

	// Token: 0x0600093D RID: 2365 RVA: 0x000057DC File Offset: 0x000039DC
	static Delegate142()
	{
		Class2.smethod_14(typeof(Delegate142).TypeHandle);
	}

	// Token: 0x040001DB RID: 475
	internal static Delegate142 delegate142_0;
}

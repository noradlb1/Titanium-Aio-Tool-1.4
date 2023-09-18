using System;

// Token: 0x02000149 RID: 329
internal sealed class Delegate254 : MulticastDelegate
{
	// Token: 0x06000AF4 RID: 2804
	public extern Type Invoke(object object_0);

	// Token: 0x06000AF5 RID: 2805 RVA: 0x0000620D File Offset: 0x0000440D
	public static Type smethod_0(object object_0, Delegate254 delegate254_1)
	{
		return delegate254_1(object_0);
	}

	// Token: 0x06000AF6 RID: 2806
	public extern Delegate254(object object_0, IntPtr intptr_0);

	// Token: 0x06000AF7 RID: 2807 RVA: 0x00006218 File Offset: 0x00004418
	static Delegate254()
	{
		Class2.smethod_14(typeof(Delegate254).TypeHandle);
	}

	// Token: 0x0400024B RID: 587
	internal static Delegate254 delegate254_0;
}

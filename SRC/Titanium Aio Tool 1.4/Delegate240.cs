using System;

// Token: 0x0200013B RID: 315
internal sealed class Delegate240 : MulticastDelegate
{
	// Token: 0x06000ABC RID: 2748
	public extern Type Invoke(object object_0);

	// Token: 0x06000ABD RID: 2749 RVA: 0x000060BF File Offset: 0x000042BF
	public static Type smethod_0(object object_0, Delegate240 delegate240_1)
	{
		return delegate240_1(object_0);
	}

	// Token: 0x06000ABE RID: 2750
	public extern Delegate240(object object_0, IntPtr intptr_0);

	// Token: 0x06000ABF RID: 2751 RVA: 0x000060CA File Offset: 0x000042CA
	static Delegate240()
	{
		Class2.smethod_14(typeof(Delegate240).TypeHandle);
	}

	// Token: 0x0400023D RID: 573
	internal static Delegate240 delegate240_0;
}

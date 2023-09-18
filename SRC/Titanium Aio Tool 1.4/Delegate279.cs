using System;

// Token: 0x02000162 RID: 354
internal sealed class Delegate279 : MulticastDelegate
{
	// Token: 0x06000B58 RID: 2904
	public extern Type Invoke(object object_0);

	// Token: 0x06000B59 RID: 2905 RVA: 0x00006466 File Offset: 0x00004666
	public static Type smethod_0(object object_0, Delegate279 delegate279_1)
	{
		return delegate279_1(object_0);
	}

	// Token: 0x06000B5A RID: 2906
	public extern Delegate279(object object_0, IntPtr intptr_0);

	// Token: 0x06000B5B RID: 2907 RVA: 0x00006471 File Offset: 0x00004671
	static Delegate279()
	{
		Class2.smethod_14(typeof(Delegate279).TypeHandle);
	}

	// Token: 0x04000264 RID: 612
	internal static Delegate279 delegate279_0;
}

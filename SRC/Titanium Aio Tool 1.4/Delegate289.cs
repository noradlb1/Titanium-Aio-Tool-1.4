using System;

// Token: 0x0200016C RID: 364
internal sealed class Delegate289 : MulticastDelegate
{
	// Token: 0x06000B80 RID: 2944
	public extern object Invoke(object object_0, Type type_0);

	// Token: 0x06000B81 RID: 2945 RVA: 0x0000656A File Offset: 0x0000476A
	public static object smethod_0(object object_0, Type type_0, Delegate289 delegate289_1)
	{
		return delegate289_1(object_0, type_0);
	}

	// Token: 0x06000B82 RID: 2946
	public extern Delegate289(object object_0, IntPtr intptr_0);

	// Token: 0x06000B83 RID: 2947 RVA: 0x00006577 File Offset: 0x00004777
	static Delegate289()
	{
		Class2.smethod_14(typeof(Delegate289).TypeHandle);
	}

	// Token: 0x0400026E RID: 622
	internal static Delegate289 delegate289_0;
}

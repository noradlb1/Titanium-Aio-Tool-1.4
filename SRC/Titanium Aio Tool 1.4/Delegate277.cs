using System;

// Token: 0x02000160 RID: 352
internal sealed class Delegate277 : MulticastDelegate
{
	// Token: 0x06000B50 RID: 2896
	public extern object Invoke(Type type_0);

	// Token: 0x06000B51 RID: 2897 RVA: 0x00006436 File Offset: 0x00004636
	public static object smethod_0(Type type_0, Delegate277 delegate277_1)
	{
		return delegate277_1(type_0);
	}

	// Token: 0x06000B52 RID: 2898
	public extern Delegate277(object object_0, IntPtr intptr_0);

	// Token: 0x06000B53 RID: 2899 RVA: 0x00006441 File Offset: 0x00004641
	static Delegate277()
	{
		Class2.smethod_14(typeof(Delegate277).TypeHandle);
	}

	// Token: 0x04000262 RID: 610
	internal static Delegate277 delegate277_0;
}

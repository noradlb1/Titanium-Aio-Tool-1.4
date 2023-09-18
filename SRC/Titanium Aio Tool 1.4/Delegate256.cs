using System;
using System.Reflection;

// Token: 0x0200014B RID: 331
internal sealed class Delegate256 : MulticastDelegate
{
	// Token: 0x06000AFC RID: 2812
	public extern FieldInfo Invoke(object object_0, int int_0);

	// Token: 0x06000AFD RID: 2813 RVA: 0x0000623B File Offset: 0x0000443B
	public static FieldInfo smethod_0(object object_0, int int_0, Delegate256 delegate256_1)
	{
		return delegate256_1(object_0, int_0);
	}

	// Token: 0x06000AFE RID: 2814
	public extern Delegate256(object object_0, IntPtr intptr_0);

	// Token: 0x06000AFF RID: 2815 RVA: 0x00006248 File Offset: 0x00004448
	static Delegate256()
	{
		Class2.smethod_14(typeof(Delegate256).TypeHandle);
	}

	// Token: 0x0400024D RID: 589
	internal static Delegate256 delegate256_0;
}

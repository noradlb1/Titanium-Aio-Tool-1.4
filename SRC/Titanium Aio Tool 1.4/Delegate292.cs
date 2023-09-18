using System;

// Token: 0x0200016F RID: 367
internal sealed class Delegate292 : MulticastDelegate
{
	// Token: 0x06000B8C RID: 2956
	public extern RuntimeTypeHandle Invoke(object object_0);

	// Token: 0x06000B8D RID: 2957 RVA: 0x000065B3 File Offset: 0x000047B3
	public static RuntimeTypeHandle smethod_0(object object_0, Delegate292 delegate292_1)
	{
		return delegate292_1(object_0);
	}

	// Token: 0x06000B8E RID: 2958
	public extern Delegate292(object object_0, IntPtr intptr_0);

	// Token: 0x06000B8F RID: 2959 RVA: 0x000065BE File Offset: 0x000047BE
	static Delegate292()
	{
		Class2.smethod_14(typeof(Delegate292).TypeHandle);
	}

	// Token: 0x04000271 RID: 625
	internal static Delegate292 delegate292_0;
}

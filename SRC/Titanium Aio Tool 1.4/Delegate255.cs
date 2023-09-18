using System;

// Token: 0x0200014A RID: 330
internal sealed class Delegate255 : MulticastDelegate
{
	// Token: 0x06000AF8 RID: 2808
	public extern string Invoke(object object_0);

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00006224 File Offset: 0x00004424
	public static string smethod_0(object object_0, Delegate255 delegate255_1)
	{
		return delegate255_1(object_0);
	}

	// Token: 0x06000AFA RID: 2810
	public extern Delegate255(object object_0, IntPtr intptr_0);

	// Token: 0x06000AFB RID: 2811 RVA: 0x0000622F File Offset: 0x0000442F
	static Delegate255()
	{
		Class2.smethod_14(typeof(Delegate255).TypeHandle);
	}

	// Token: 0x0400024C RID: 588
	internal static Delegate255 delegate255_0;
}

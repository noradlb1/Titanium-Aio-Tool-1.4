using System;
using System.Drawing;

// Token: 0x02000094 RID: 148
internal sealed class Delegate73 : MulticastDelegate
{
	// Token: 0x0600082E RID: 2094
	public extern void Invoke(object object_0, Point point_0);

	// Token: 0x0600082F RID: 2095 RVA: 0x00005196 File Offset: 0x00003396
	public static void smethod_0(object object_0, Point point_0, Delegate73 delegate73_1)
	{
		delegate73_1(object_0, point_0);
	}

	// Token: 0x06000830 RID: 2096
	public extern Delegate73(object object_0, IntPtr intptr_0);

	// Token: 0x06000831 RID: 2097 RVA: 0x000051A3 File Offset: 0x000033A3
	static Delegate73()
	{
		Class2.smethod_14(typeof(Delegate73).TypeHandle);
	}

	// Token: 0x04000196 RID: 406
	internal static Delegate73 delegate73_0;
}

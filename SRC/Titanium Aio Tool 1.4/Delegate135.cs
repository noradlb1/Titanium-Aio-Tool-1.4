using System;

// Token: 0x020000D2 RID: 210
internal sealed class Delegate135 : MulticastDelegate
{
	// Token: 0x0600091E RID: 2334
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x0600091F RID: 2335 RVA: 0x00005720 File Offset: 0x00003920
	public static void smethod_0(object object_0, bool bool_0, Delegate135 delegate135_1)
	{
		delegate135_1(object_0, bool_0);
	}

	// Token: 0x06000920 RID: 2336
	public extern Delegate135(object object_0, IntPtr intptr_0);

	// Token: 0x06000921 RID: 2337 RVA: 0x0000572D File Offset: 0x0000392D
	static Delegate135()
	{
		Class2.smethod_14(typeof(Delegate135).TypeHandle);
	}

	// Token: 0x040001D4 RID: 468
	internal static Delegate135 delegate135_0;
}

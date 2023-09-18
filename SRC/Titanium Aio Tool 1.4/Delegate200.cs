using System;

// Token: 0x02000113 RID: 275
internal sealed class Delegate200 : MulticastDelegate
{
	// Token: 0x06000A1D RID: 2589
	public extern Type Invoke(object object_0);

	// Token: 0x06000A1E RID: 2590 RVA: 0x00005D1A File Offset: 0x00003F1A
	public static Type smethod_0(object object_0, Delegate200 delegate200_1)
	{
		return delegate200_1(object_0);
	}

	// Token: 0x06000A1F RID: 2591
	public extern Delegate200(object object_0, IntPtr intptr_0);

	// Token: 0x06000A20 RID: 2592 RVA: 0x00005D25 File Offset: 0x00003F25
	static Delegate200()
	{
		Class2.smethod_14(typeof(Delegate200).TypeHandle);
	}

	// Token: 0x04000215 RID: 533
	internal static Delegate200 delegate200_0;
}

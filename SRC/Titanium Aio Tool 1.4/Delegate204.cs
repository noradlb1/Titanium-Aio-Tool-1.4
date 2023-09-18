using System;

// Token: 0x02000117 RID: 279
internal sealed class Delegate204 : MulticastDelegate
{
	// Token: 0x06000A2D RID: 2605
	public extern byte Invoke(object object_0);

	// Token: 0x06000A2E RID: 2606 RVA: 0x00005D78 File Offset: 0x00003F78
	public static byte smethod_0(object object_0, Delegate204 delegate204_1)
	{
		return delegate204_1(object_0);
	}

	// Token: 0x06000A2F RID: 2607
	public extern Delegate204(object object_0, IntPtr intptr_0);

	// Token: 0x06000A30 RID: 2608 RVA: 0x00005D83 File Offset: 0x00003F83
	static Delegate204()
	{
		Class2.smethod_14(typeof(Delegate204).TypeHandle);
	}

	// Token: 0x04000219 RID: 537
	internal static Delegate204 delegate204_0;
}

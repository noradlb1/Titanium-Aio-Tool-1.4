using System;

// Token: 0x020000BD RID: 189
internal sealed class Delegate114 : MulticastDelegate
{
	// Token: 0x060008CE RID: 2254
	public extern bool Invoke(object object_0);

	// Token: 0x060008CF RID: 2255 RVA: 0x00005557 File Offset: 0x00003757
	public static bool smethod_0(object object_0, Delegate114 delegate114_1)
	{
		return delegate114_1(object_0);
	}

	// Token: 0x060008D0 RID: 2256
	public extern Delegate114(object object_0, IntPtr intptr_0);

	// Token: 0x060008D1 RID: 2257 RVA: 0x00005562 File Offset: 0x00003762
	static Delegate114()
	{
		Class2.smethod_14(typeof(Delegate114).TypeHandle);
	}

	// Token: 0x040001BF RID: 447
	internal static Delegate114 delegate114_0;
}

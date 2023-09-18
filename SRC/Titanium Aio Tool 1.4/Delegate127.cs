using System;

// Token: 0x020000CA RID: 202
internal sealed class Delegate127 : MulticastDelegate
{
	// Token: 0x060008FE RID: 2302
	public extern string Invoke(object object_0);

	// Token: 0x060008FF RID: 2303 RVA: 0x00005660 File Offset: 0x00003860
	public static string smethod_0(object object_0, Delegate127 delegate127_1)
	{
		return delegate127_1(object_0);
	}

	// Token: 0x06000900 RID: 2304
	public extern Delegate127(object object_0, IntPtr intptr_0);

	// Token: 0x06000901 RID: 2305 RVA: 0x0000566B File Offset: 0x0000386B
	static Delegate127()
	{
		Class2.smethod_14(typeof(Delegate127).TypeHandle);
	}

	// Token: 0x040001CC RID: 460
	internal static Delegate127 delegate127_0;
}

using System;

// Token: 0x020000C3 RID: 195
internal sealed class Delegate120 : MulticastDelegate
{
	// Token: 0x060008E6 RID: 2278
	public extern void Invoke(string string_0, byte[] byte_0);

	// Token: 0x060008E7 RID: 2279 RVA: 0x000055E5 File Offset: 0x000037E5
	public static void smethod_0(string string_0, byte[] byte_0, Delegate120 delegate120_1)
	{
		delegate120_1(string_0, byte_0);
	}

	// Token: 0x060008E8 RID: 2280
	public extern Delegate120(object object_0, IntPtr intptr_0);

	// Token: 0x060008E9 RID: 2281 RVA: 0x000055F2 File Offset: 0x000037F2
	static Delegate120()
	{
		Class2.smethod_14(typeof(Delegate120).TypeHandle);
	}

	// Token: 0x040001C5 RID: 453
	internal static Delegate120 delegate120_0;
}

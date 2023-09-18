using System;
using System.Diagnostics;

// Token: 0x020000B2 RID: 178
internal sealed class Delegate103 : MulticastDelegate
{
	// Token: 0x060008A4 RID: 2212
	public extern Process Invoke(string string_0);

	// Token: 0x060008A5 RID: 2213 RVA: 0x00005460 File Offset: 0x00003660
	public static Process smethod_0(string string_0, Delegate103 delegate103_1)
	{
		return delegate103_1(string_0);
	}

	// Token: 0x060008A6 RID: 2214
	public extern Delegate103(object object_0, IntPtr intptr_0);

	// Token: 0x060008A7 RID: 2215 RVA: 0x0000546B File Offset: 0x0000366B
	static Delegate103()
	{
		Class2.smethod_14(typeof(Delegate103).TypeHandle);
	}

	// Token: 0x040001B4 RID: 436
	internal static Delegate103 delegate103_0;
}

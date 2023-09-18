using System;
using System.Diagnostics;

// Token: 0x020000BA RID: 186
internal sealed class Delegate111 : MulticastDelegate
{
	// Token: 0x060008C2 RID: 2242
	public extern void Invoke(object object_0, ProcessWindowStyle processWindowStyle_0);

	// Token: 0x060008C3 RID: 2243 RVA: 0x0000550C File Offset: 0x0000370C
	public static void smethod_0(object object_0, ProcessWindowStyle processWindowStyle_0, Delegate111 delegate111_1)
	{
		delegate111_1(object_0, processWindowStyle_0);
	}

	// Token: 0x060008C4 RID: 2244
	public extern Delegate111(object object_0, IntPtr intptr_0);

	// Token: 0x060008C5 RID: 2245 RVA: 0x00005519 File Offset: 0x00003719
	static Delegate111()
	{
		Class2.smethod_14(typeof(Delegate111).TypeHandle);
	}

	// Token: 0x040001BC RID: 444
	internal static Delegate111 delegate111_0;
}

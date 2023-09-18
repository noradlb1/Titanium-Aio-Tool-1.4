using System;
using System.IO;

// Token: 0x0200010F RID: 271
internal sealed class Delegate196 : MulticastDelegate
{
	// Token: 0x06000A0D RID: 2573
	public extern Stream Invoke(object object_0);

	// Token: 0x06000A0E RID: 2574 RVA: 0x00005CBC File Offset: 0x00003EBC
	public static Stream smethod_0(object object_0, Delegate196 delegate196_1)
	{
		return delegate196_1(object_0);
	}

	// Token: 0x06000A0F RID: 2575
	public extern Delegate196(object object_0, IntPtr intptr_0);

	// Token: 0x06000A10 RID: 2576 RVA: 0x00005CC7 File Offset: 0x00003EC7
	static Delegate196()
	{
		Class2.smethod_14(typeof(Delegate196).TypeHandle);
	}

	// Token: 0x04000211 RID: 529
	internal static Delegate196 delegate196_0;
}

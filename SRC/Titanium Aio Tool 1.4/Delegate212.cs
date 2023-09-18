using System;

// Token: 0x0200011F RID: 287
internal sealed class Delegate212 : MulticastDelegate
{
	// Token: 0x06000A4D RID: 2637
	public extern Type Invoke(object object_0);

	// Token: 0x06000A4E RID: 2638 RVA: 0x00005E32 File Offset: 0x00004032
	public static Type smethod_0(object object_0, Delegate212 delegate212_1)
	{
		return delegate212_1(object_0);
	}

	// Token: 0x06000A4F RID: 2639
	public extern Delegate212(object object_0, IntPtr intptr_0);

	// Token: 0x06000A50 RID: 2640 RVA: 0x00005E3D File Offset: 0x0000403D
	static Delegate212()
	{
		Class2.smethod_14(typeof(Delegate212).TypeHandle);
	}

	// Token: 0x04000221 RID: 545
	internal static Delegate212 delegate212_0;
}

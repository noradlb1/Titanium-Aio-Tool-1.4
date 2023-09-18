using System;

// Token: 0x0200016E RID: 366
internal sealed class Delegate291 : MulticastDelegate
{
	// Token: 0x06000B88 RID: 2952
	public extern RuntimeFieldHandle Invoke(object object_0);

	// Token: 0x06000B89 RID: 2953 RVA: 0x0000659C File Offset: 0x0000479C
	public static RuntimeFieldHandle smethod_0(object object_0, Delegate291 delegate291_1)
	{
		return delegate291_1(object_0);
	}

	// Token: 0x06000B8A RID: 2954
	public extern Delegate291(object object_0, IntPtr intptr_0);

	// Token: 0x06000B8B RID: 2955 RVA: 0x000065A7 File Offset: 0x000047A7
	static Delegate291()
	{
		Class2.smethod_14(typeof(Delegate291).TypeHandle);
	}

	// Token: 0x04000270 RID: 624
	internal static Delegate291 delegate291_0;
}

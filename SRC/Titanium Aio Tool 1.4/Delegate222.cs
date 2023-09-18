using System;

// Token: 0x02000129 RID: 297
internal sealed class Delegate222 : MulticastDelegate
{
	// Token: 0x06000A75 RID: 2677
	public extern bool Invoke(object object_0);

	// Token: 0x06000A76 RID: 2678 RVA: 0x00005F1C File Offset: 0x0000411C
	public static bool smethod_0(object object_0, Delegate222 delegate222_1)
	{
		return delegate222_1(object_0);
	}

	// Token: 0x06000A77 RID: 2679
	public extern Delegate222(object object_0, IntPtr intptr_0);

	// Token: 0x06000A78 RID: 2680 RVA: 0x00005F27 File Offset: 0x00004127
	static Delegate222()
	{
		Class2.smethod_14(typeof(Delegate222).TypeHandle);
	}

	// Token: 0x0400022B RID: 555
	internal static Delegate222 delegate222_0;
}

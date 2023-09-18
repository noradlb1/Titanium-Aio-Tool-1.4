using System;
using System.Reflection;

// Token: 0x0200014C RID: 332
internal sealed class Delegate257 : MulticastDelegate
{
	// Token: 0x06000B00 RID: 2816
	public extern MemberInfo Invoke(object object_0, int int_0);

	// Token: 0x06000B01 RID: 2817 RVA: 0x00006254 File Offset: 0x00004454
	public static MemberInfo smethod_0(object object_0, int int_0, Delegate257 delegate257_1)
	{
		return delegate257_1(object_0, int_0);
	}

	// Token: 0x06000B02 RID: 2818
	public extern Delegate257(object object_0, IntPtr intptr_0);

	// Token: 0x06000B03 RID: 2819 RVA: 0x00006261 File Offset: 0x00004461
	static Delegate257()
	{
		Class2.smethod_14(typeof(Delegate257).TypeHandle);
	}

	// Token: 0x0400024E RID: 590
	internal static Delegate257 delegate257_0;
}

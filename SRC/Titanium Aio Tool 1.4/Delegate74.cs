using System;

// Token: 0x02000095 RID: 149
internal sealed class Delegate74 : MulticastDelegate
{
	// Token: 0x06000832 RID: 2098
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06000833 RID: 2099 RVA: 0x000051AF File Offset: 0x000033AF
	public static void smethod_0(object object_0, bool bool_0, Delegate74 delegate74_1)
	{
		delegate74_1(object_0, bool_0);
	}

	// Token: 0x06000834 RID: 2100
	public extern Delegate74(object object_0, IntPtr intptr_0);

	// Token: 0x06000835 RID: 2101 RVA: 0x000051BC File Offset: 0x000033BC
	static Delegate74()
	{
		Class2.smethod_14(typeof(Delegate74).TypeHandle);
	}

	// Token: 0x04000197 RID: 407
	internal static Delegate74 delegate74_0;
}

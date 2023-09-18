using System;

// Token: 0x02000131 RID: 305
internal sealed class Delegate230 : MulticastDelegate
{
	// Token: 0x06000A95 RID: 2709
	public extern object Invoke(Type type_0, long long_0);

	// Token: 0x06000A96 RID: 2710 RVA: 0x00005FE0 File Offset: 0x000041E0
	public static object smethod_0(Type type_0, long long_0, Delegate230 delegate230_1)
	{
		return delegate230_1(type_0, long_0);
	}

	// Token: 0x06000A97 RID: 2711
	public extern Delegate230(object object_0, IntPtr intptr_0);

	// Token: 0x06000A98 RID: 2712 RVA: 0x00005FED File Offset: 0x000041ED
	static Delegate230()
	{
		Class2.smethod_14(typeof(Delegate230).TypeHandle);
	}

	// Token: 0x04000233 RID: 563
	internal static Delegate230 delegate230_0;
}

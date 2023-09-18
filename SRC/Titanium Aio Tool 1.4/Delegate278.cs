using System;
using System.Reflection.Emit;

// Token: 0x02000161 RID: 353
internal sealed class Delegate278 : MulticastDelegate
{
	// Token: 0x06000B54 RID: 2900
	public extern LocalBuilder Invoke(object object_0, Type type_0);

	// Token: 0x06000B55 RID: 2901 RVA: 0x0000644D File Offset: 0x0000464D
	public static LocalBuilder smethod_0(object object_0, Type type_0, Delegate278 delegate278_1)
	{
		return delegate278_1(object_0, type_0);
	}

	// Token: 0x06000B56 RID: 2902
	public extern Delegate278(object object_0, IntPtr intptr_0);

	// Token: 0x06000B57 RID: 2903 RVA: 0x0000645A File Offset: 0x0000465A
	static Delegate278()
	{
		Class2.smethod_14(typeof(Delegate278).TypeHandle);
	}

	// Token: 0x04000263 RID: 611
	internal static Delegate278 delegate278_0;
}

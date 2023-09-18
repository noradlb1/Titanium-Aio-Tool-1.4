using System;
using System.Reflection;

// Token: 0x02000100 RID: 256
internal sealed class Delegate181 : MulticastDelegate
{
	// Token: 0x060009D1 RID: 2513
	public extern Assembly Invoke(object object_0);

	// Token: 0x060009D2 RID: 2514 RVA: 0x00005B45 File Offset: 0x00003D45
	public static Assembly smethod_0(object object_0, Delegate181 delegate181_1)
	{
		return delegate181_1(object_0);
	}

	// Token: 0x060009D3 RID: 2515
	public extern Delegate181(object object_0, IntPtr intptr_0);

	// Token: 0x060009D4 RID: 2516 RVA: 0x00005B50 File Offset: 0x00003D50
	static Delegate181()
	{
		Class2.smethod_14(typeof(Delegate181).TypeHandle);
	}

	// Token: 0x04000202 RID: 514
	internal static Delegate181 delegate181_0;
}

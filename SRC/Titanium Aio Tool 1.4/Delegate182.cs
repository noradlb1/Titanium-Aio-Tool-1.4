using System;
using System.Globalization;

// Token: 0x02000101 RID: 257
internal sealed class Delegate182 : MulticastDelegate
{
	// Token: 0x060009D5 RID: 2517
	public extern object Invoke(object object_0, string string_0, CultureInfo cultureInfo_0);

	// Token: 0x060009D6 RID: 2518 RVA: 0x00005B5C File Offset: 0x00003D5C
	public static object smethod_0(object object_0, string string_0, CultureInfo cultureInfo_0, Delegate182 delegate182_1)
	{
		return delegate182_1(object_0, string_0, cultureInfo_0);
	}

	// Token: 0x060009D7 RID: 2519
	public extern Delegate182(object object_0, IntPtr intptr_0);

	// Token: 0x060009D8 RID: 2520 RVA: 0x00005B6B File Offset: 0x00003D6B
	static Delegate182()
	{
		Class2.smethod_14(typeof(Delegate182).TypeHandle);
	}

	// Token: 0x04000203 RID: 515
	internal static Delegate182 delegate182_0;
}

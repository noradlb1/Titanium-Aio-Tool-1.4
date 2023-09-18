using System;
using System.Globalization;

// Token: 0x02000102 RID: 258
internal sealed class Delegate183 : MulticastDelegate
{
	// Token: 0x060009D9 RID: 2521
	public extern string Invoke(object object_0, string string_0, CultureInfo cultureInfo_0);

	// Token: 0x060009DA RID: 2522 RVA: 0x00005B77 File Offset: 0x00003D77
	public static string smethod_0(object object_0, string string_0, CultureInfo cultureInfo_0, Delegate183 delegate183_1)
	{
		return delegate183_1(object_0, string_0, cultureInfo_0);
	}

	// Token: 0x060009DB RID: 2523
	public extern Delegate183(object object_0, IntPtr intptr_0);

	// Token: 0x060009DC RID: 2524 RVA: 0x00005B86 File Offset: 0x00003D86
	static Delegate183()
	{
		Class2.smethod_14(typeof(Delegate183).TypeHandle);
	}

	// Token: 0x04000204 RID: 516
	internal static Delegate183 delegate183_0;
}

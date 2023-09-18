using System;
using System.Globalization;
using System.IO;

// Token: 0x02000103 RID: 259
internal sealed class Delegate184 : MulticastDelegate
{
	// Token: 0x060009DD RID: 2525
	public extern UnmanagedMemoryStream Invoke(object object_0, string string_0, CultureInfo cultureInfo_0);

	// Token: 0x060009DE RID: 2526 RVA: 0x00005B92 File Offset: 0x00003D92
	public static UnmanagedMemoryStream smethod_0(object object_0, string string_0, CultureInfo cultureInfo_0, Delegate184 delegate184_1)
	{
		return delegate184_1(object_0, string_0, cultureInfo_0);
	}

	// Token: 0x060009DF RID: 2527
	public extern Delegate184(object object_0, IntPtr intptr_0);

	// Token: 0x060009E0 RID: 2528 RVA: 0x00005BA1 File Offset: 0x00003DA1
	static Delegate184()
	{
		Class2.smethod_14(typeof(Delegate184).TypeHandle);
	}

	// Token: 0x04000205 RID: 517
	internal static Delegate184 delegate184_0;
}

using System;
using Microsoft.Win32;

// Token: 0x0200008C RID: 140
internal sealed class Delegate65 : MulticastDelegate
{
	// Token: 0x0600080E RID: 2062
	public extern RegistryKey Invoke(object object_0, string string_0, bool bool_0);

	// Token: 0x0600080F RID: 2063 RVA: 0x000050D4 File Offset: 0x000032D4
	public static RegistryKey smethod_0(object object_0, string string_0, bool bool_0, Delegate65 delegate65_1)
	{
		return delegate65_1(object_0, string_0, bool_0);
	}

	// Token: 0x06000810 RID: 2064
	public extern Delegate65(object object_0, IntPtr intptr_0);

	// Token: 0x06000811 RID: 2065 RVA: 0x000050E3 File Offset: 0x000032E3
	static Delegate65()
	{
		Class2.smethod_14(typeof(Delegate65).TypeHandle);
	}

	// Token: 0x0400018E RID: 398
	internal static Delegate65 delegate65_0;
}

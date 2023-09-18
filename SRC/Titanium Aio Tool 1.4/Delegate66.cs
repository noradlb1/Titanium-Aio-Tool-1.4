using System;
using Microsoft.Win32;

// Token: 0x0200008D RID: 141
internal sealed class Delegate66 : MulticastDelegate
{
	// Token: 0x06000812 RID: 2066
	public extern void Invoke(object object_0, string string_0, object object_1, RegistryValueKind registryValueKind_0);

	// Token: 0x06000813 RID: 2067 RVA: 0x000050EF File Offset: 0x000032EF
	public static void smethod_0(object object_0, string string_0, object object_1, RegistryValueKind registryValueKind_0, Delegate66 delegate66_1)
	{
		delegate66_1(object_0, string_0, object_1, registryValueKind_0);
	}

	// Token: 0x06000814 RID: 2068
	public extern Delegate66(object object_0, IntPtr intptr_0);

	// Token: 0x06000815 RID: 2069 RVA: 0x00005100 File Offset: 0x00003300
	static Delegate66()
	{
		Class2.smethod_14(typeof(Delegate66).TypeHandle);
	}

	// Token: 0x0400018F RID: 399
	internal static Delegate66 delegate66_0;
}

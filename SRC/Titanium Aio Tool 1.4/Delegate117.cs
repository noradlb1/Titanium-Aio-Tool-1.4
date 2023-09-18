using System;
using System.Diagnostics;

// Token: 0x020000C0 RID: 192
internal sealed class Delegate117 : MulticastDelegate
{
	// Token: 0x060008DA RID: 2266
	public extern ProcessStartInfo Invoke(object object_0);

	// Token: 0x060008DB RID: 2267 RVA: 0x0000559C File Offset: 0x0000379C
	public static ProcessStartInfo smethod_0(object object_0, Delegate117 delegate117_1)
	{
		return delegate117_1(object_0);
	}

	// Token: 0x060008DC RID: 2268
	public extern Delegate117(object object_0, IntPtr intptr_0);

	// Token: 0x060008DD RID: 2269 RVA: 0x000055A7 File Offset: 0x000037A7
	static Delegate117()
	{
		Class2.smethod_14(typeof(Delegate117).TypeHandle);
	}

	// Token: 0x040001C2 RID: 450
	internal static Delegate117 delegate117_0;
}

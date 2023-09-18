using System;
using System.Diagnostics;

// Token: 0x02000086 RID: 134
internal sealed class Delegate59 : MulticastDelegate
{
	// Token: 0x060007F6 RID: 2038
	public extern Process[] Invoke(string string_0);

	// Token: 0x060007F7 RID: 2039 RVA: 0x0000504A File Offset: 0x0000324A
	public static Process[] smethod_0(string string_0, Delegate59 delegate59_1)
	{
		return delegate59_1(string_0);
	}

	// Token: 0x060007F8 RID: 2040
	public extern Delegate59(object object_0, IntPtr intptr_0);

	// Token: 0x060007F9 RID: 2041 RVA: 0x00005055 File Offset: 0x00003255
	static Delegate59()
	{
		Class2.smethod_14(typeof(Delegate59).TypeHandle);
	}

	// Token: 0x04000188 RID: 392
	internal static Delegate59 delegate59_0;
}

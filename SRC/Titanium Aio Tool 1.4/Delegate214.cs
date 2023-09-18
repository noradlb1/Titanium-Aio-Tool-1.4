using System;
using System.IO;

// Token: 0x02000121 RID: 289
internal sealed class Delegate214 : MulticastDelegate
{
	// Token: 0x06000A55 RID: 2645
	public extern Stream Invoke(object object_0, string string_0);

	// Token: 0x06000A56 RID: 2646 RVA: 0x00005E60 File Offset: 0x00004060
	public static Stream smethod_0(object object_0, string string_0, Delegate214 delegate214_1)
	{
		return delegate214_1(object_0, string_0);
	}

	// Token: 0x06000A57 RID: 2647
	public extern Delegate214(object object_0, IntPtr intptr_0);

	// Token: 0x06000A58 RID: 2648 RVA: 0x00005E6D File Offset: 0x0000406D
	static Delegate214()
	{
		Class2.smethod_14(typeof(Delegate214).TypeHandle);
	}

	// Token: 0x04000223 RID: 547
	internal static Delegate214 delegate214_0;
}

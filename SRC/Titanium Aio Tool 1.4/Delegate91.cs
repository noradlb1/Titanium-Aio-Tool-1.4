using System;
using System.Drawing;

// Token: 0x020000A6 RID: 166
internal sealed class Delegate91 : MulticastDelegate
{
	// Token: 0x06000875 RID: 2165
	public extern void Invoke(object object_0, Icon icon_0);

	// Token: 0x06000876 RID: 2166 RVA: 0x00005345 File Offset: 0x00003545
	public static void smethod_0(object object_0, Icon icon_0, Delegate91 delegate91_1)
	{
		delegate91_1(object_0, icon_0);
	}

	// Token: 0x06000877 RID: 2167
	public extern Delegate91(object object_0, IntPtr intptr_0);

	// Token: 0x06000878 RID: 2168 RVA: 0x00005352 File Offset: 0x00003552
	static Delegate91()
	{
		Class2.smethod_14(typeof(Delegate91).TypeHandle);
	}

	// Token: 0x040001A8 RID: 424
	internal static Delegate91 delegate91_0;
}

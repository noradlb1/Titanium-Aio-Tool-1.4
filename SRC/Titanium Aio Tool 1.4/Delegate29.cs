using System;
using System.Drawing;

// Token: 0x02000068 RID: 104
internal sealed class Delegate29 : MulticastDelegate
{
	// Token: 0x06000780 RID: 1920
	public extern int Invoke(ref Rectangle rectangle_0);

	// Token: 0x06000781 RID: 1921 RVA: 0x00004D7E File Offset: 0x00002F7E
	public static int smethod_0(ref Rectangle rectangle_0, Delegate29 delegate29_1)
	{
		return delegate29_1(ref rectangle_0);
	}

	// Token: 0x06000782 RID: 1922
	public extern Delegate29(object object_0, IntPtr intptr_0);

	// Token: 0x06000783 RID: 1923 RVA: 0x00004D89 File Offset: 0x00002F89
	static Delegate29()
	{
		Class2.smethod_14(typeof(Delegate29).TypeHandle);
	}

	// Token: 0x0400016A RID: 362
	internal static Delegate29 delegate29_0;
}

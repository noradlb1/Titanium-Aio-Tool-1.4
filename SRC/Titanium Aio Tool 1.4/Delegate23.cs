using System;
using System.Drawing;

// Token: 0x02000062 RID: 98
internal sealed class Delegate23 : MulticastDelegate
{
	// Token: 0x06000768 RID: 1896
	public extern float Invoke(ref RectangleF rectangleF_0);

	// Token: 0x06000769 RID: 1897 RVA: 0x00004CF0 File Offset: 0x00002EF0
	public static float smethod_0(ref RectangleF rectangleF_0, Delegate23 delegate23_1)
	{
		return delegate23_1(ref rectangleF_0);
	}

	// Token: 0x0600076A RID: 1898
	public extern Delegate23(object object_0, IntPtr intptr_0);

	// Token: 0x0600076B RID: 1899 RVA: 0x00004CFB File Offset: 0x00002EFB
	static Delegate23()
	{
		Class2.smethod_14(typeof(Delegate23).TypeHandle);
	}

	// Token: 0x04000164 RID: 356
	internal static Delegate23 delegate23_0;
}

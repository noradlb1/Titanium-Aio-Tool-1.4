using System;
using System.Drawing;

// Token: 0x02000060 RID: 96
internal sealed class Delegate21 : MulticastDelegate
{
	// Token: 0x06000760 RID: 1888
	public extern float Invoke(ref RectangleF rectangleF_0);

	// Token: 0x06000761 RID: 1889 RVA: 0x00004CB6 File Offset: 0x00002EB6
	public static float smethod_0(ref RectangleF rectangleF_0, Delegate21 delegate21_1)
	{
		return delegate21_1(ref rectangleF_0);
	}

	// Token: 0x06000762 RID: 1890
	public extern Delegate21(object object_0, IntPtr intptr_0);

	// Token: 0x06000763 RID: 1891 RVA: 0x00004CC1 File Offset: 0x00002EC1
	static Delegate21()
	{
		Class2.smethod_14(typeof(Delegate21).TypeHandle);
	}

	// Token: 0x04000162 RID: 354
	internal static Delegate21 delegate21_0;
}

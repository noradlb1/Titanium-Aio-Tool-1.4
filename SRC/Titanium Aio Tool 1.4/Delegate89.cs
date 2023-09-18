using System;
using System.Windows.Forms;

// Token: 0x020000A4 RID: 164
internal sealed class Delegate89 : MulticastDelegate
{
	// Token: 0x0600086D RID: 2157
	public extern void Invoke(object object_0, FormBorderStyle formBorderStyle_0);

	// Token: 0x0600086E RID: 2158 RVA: 0x00005313 File Offset: 0x00003513
	public static void smethod_0(object object_0, FormBorderStyle formBorderStyle_0, Delegate89 delegate89_1)
	{
		delegate89_1(object_0, formBorderStyle_0);
	}

	// Token: 0x0600086F RID: 2159
	public extern Delegate89(object object_0, IntPtr intptr_0);

	// Token: 0x06000870 RID: 2160 RVA: 0x00005320 File Offset: 0x00003520
	static Delegate89()
	{
		Class2.smethod_14(typeof(Delegate89).TypeHandle);
	}

	// Token: 0x040001A6 RID: 422
	internal static Delegate89 delegate89_0;
}

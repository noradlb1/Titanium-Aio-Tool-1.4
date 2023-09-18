using System;
using System.Windows.Forms;

// Token: 0x020000FF RID: 255
internal sealed class Delegate180 : MulticastDelegate
{
	// Token: 0x060009CD RID: 2509
	public extern void Invoke(Form form_0);

	// Token: 0x060009CE RID: 2510 RVA: 0x00005B2E File Offset: 0x00003D2E
	public static void smethod_0(Form form_0, Delegate180 delegate180_1)
	{
		delegate180_1(form_0);
	}

	// Token: 0x060009CF RID: 2511
	public extern Delegate180(object object_0, IntPtr intptr_0);

	// Token: 0x060009D0 RID: 2512 RVA: 0x00005B39 File Offset: 0x00003D39
	static Delegate180()
	{
		Class2.smethod_14(typeof(Delegate180).TypeHandle);
	}

	// Token: 0x04000201 RID: 513
	internal static Delegate180 delegate180_0;
}

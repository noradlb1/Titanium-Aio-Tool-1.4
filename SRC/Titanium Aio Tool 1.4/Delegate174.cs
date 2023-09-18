using System;
using System.Windows.Forms;

// Token: 0x020000F9 RID: 249
internal sealed class Delegate174 : MulticastDelegate
{
	// Token: 0x060009B5 RID: 2485
	public extern void Invoke(object object_0, FormClosingEventHandler formClosingEventHandler_0);

	// Token: 0x060009B6 RID: 2486 RVA: 0x00005AA2 File Offset: 0x00003CA2
	public static void smethod_0(object object_0, FormClosingEventHandler formClosingEventHandler_0, Delegate174 delegate174_1)
	{
		delegate174_1(object_0, formClosingEventHandler_0);
	}

	// Token: 0x060009B7 RID: 2487
	public extern Delegate174(object object_0, IntPtr intptr_0);

	// Token: 0x060009B8 RID: 2488 RVA: 0x00005AAF File Offset: 0x00003CAF
	static Delegate174()
	{
		Class2.smethod_14(typeof(Delegate174).TypeHandle);
	}

	// Token: 0x040001FB RID: 507
	internal static Delegate174 delegate174_0;
}

using System;
using System.Windows.Forms;

// Token: 0x020000A1 RID: 161
internal sealed class Delegate86 : MulticastDelegate
{
	// Token: 0x06000862 RID: 2146
	public extern void Invoke(object object_0, Control control_0);

	// Token: 0x06000863 RID: 2147 RVA: 0x000052D5 File Offset: 0x000034D5
	public static void smethod_0(object object_0, Control control_0, Delegate86 delegate86_1)
	{
		delegate86_1(object_0, control_0);
	}

	// Token: 0x06000864 RID: 2148
	public extern Delegate86(object object_0, IntPtr intptr_0);

	// Token: 0x06000865 RID: 2149 RVA: 0x000052E2 File Offset: 0x000034E2
	static Delegate86()
	{
		Class2.smethod_14(typeof(Delegate86).TypeHandle);
	}

	// Token: 0x040001A3 RID: 419
	internal static Delegate86 delegate86_0;
}

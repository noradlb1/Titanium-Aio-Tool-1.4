using System;
using System.Windows.Forms;

// Token: 0x020000F2 RID: 242
internal sealed class Delegate167 : MulticastDelegate
{
	// Token: 0x0600099A RID: 2458
	public extern void Invoke(object object_0, ComboBoxStyle comboBoxStyle_0);

	// Token: 0x0600099B RID: 2459 RVA: 0x00005A00 File Offset: 0x00003C00
	public static void smethod_0(object object_0, ComboBoxStyle comboBoxStyle_0, Delegate167 delegate167_1)
	{
		delegate167_1(object_0, comboBoxStyle_0);
	}

	// Token: 0x0600099C RID: 2460
	public extern Delegate167(object object_0, IntPtr intptr_0);

	// Token: 0x0600099D RID: 2461 RVA: 0x00005A0D File Offset: 0x00003C0D
	static Delegate167()
	{
		Class2.smethod_14(typeof(Delegate167).TypeHandle);
	}

	// Token: 0x040001F4 RID: 500
	internal static Delegate167 delegate167_0;
}

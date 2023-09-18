using System;
using System.Windows.Forms;

// Token: 0x02000081 RID: 129
internal sealed class Delegate54 : MulticastDelegate
{
	// Token: 0x060007E2 RID: 2018
	public extern void Invoke(object object_0, FormStartPosition formStartPosition_0);

	// Token: 0x060007E3 RID: 2019 RVA: 0x00004FD3 File Offset: 0x000031D3
	public static void smethod_0(object object_0, FormStartPosition formStartPosition_0, Delegate54 delegate54_0)
	{
		delegate54_0(object_0, formStartPosition_0);
	}

	// Token: 0x060007E4 RID: 2020
	public extern Delegate54(object object_0, IntPtr intptr_0);

	// Token: 0x060007E5 RID: 2021 RVA: 0x00004FE0 File Offset: 0x000031E0
	static Delegate54()
	{
		Class2.smethod_14(typeof(Delegate54).TypeHandle);
	}

	// Token: 0x04000183 RID: 387
	internal static Delegate54 cBeKjgqiWW;
}

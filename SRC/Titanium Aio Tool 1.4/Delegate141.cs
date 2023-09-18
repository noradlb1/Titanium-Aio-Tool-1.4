using System;
using System.Windows.Forms;

// Token: 0x020000D8 RID: 216
internal sealed class Delegate141 : MulticastDelegate
{
	// Token: 0x06000936 RID: 2358
	public extern DialogResult Invoke(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	// Token: 0x06000937 RID: 2359 RVA: 0x000057B4 File Offset: 0x000039B4
	public static DialogResult smethod_0(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, Delegate141 delegate141_1)
	{
		return delegate141_1(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	// Token: 0x06000938 RID: 2360
	public extern Delegate141(object object_0, IntPtr intptr_0);

	// Token: 0x06000939 RID: 2361 RVA: 0x000057C5 File Offset: 0x000039C5
	static Delegate141()
	{
		Class2.smethod_14(typeof(Delegate141).TypeHandle);
	}

	// Token: 0x040001DA RID: 474
	internal static Delegate141 delegate141_0;
}

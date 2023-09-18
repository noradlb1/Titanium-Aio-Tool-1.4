using System;
using System.Windows.Forms;

// Token: 0x02000089 RID: 137
internal sealed class Delegate62 : MulticastDelegate
{
	// Token: 0x06000802 RID: 2050
	public extern DialogResult Invoke(string string_0);

	// Token: 0x06000803 RID: 2051 RVA: 0x0000508F File Offset: 0x0000328F
	public static DialogResult smethod_0(string string_0, Delegate62 delegate62_1)
	{
		return delegate62_1(string_0);
	}

	// Token: 0x06000804 RID: 2052
	public extern Delegate62(object object_0, IntPtr intptr_0);

	// Token: 0x06000805 RID: 2053 RVA: 0x0000509A File Offset: 0x0000329A
	static Delegate62()
	{
		Class2.smethod_14(typeof(Delegate62).TypeHandle);
	}

	// Token: 0x0400018B RID: 395
	internal static Delegate62 delegate62_0;
}

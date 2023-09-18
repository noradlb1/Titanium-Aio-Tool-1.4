using System;
using System.Windows.Forms;

// Token: 0x020000ED RID: 237
internal sealed class Delegate162 : MulticastDelegate
{
	// Token: 0x06000987 RID: 2439
	public extern FlatButtonAppearance Invoke(object object_0);

	// Token: 0x06000988 RID: 2440 RVA: 0x00005992 File Offset: 0x00003B92
	public static FlatButtonAppearance smethod_0(object object_0, Delegate162 delegate162_1)
	{
		return delegate162_1(object_0);
	}

	// Token: 0x06000989 RID: 2441
	public extern Delegate162(object object_0, IntPtr intptr_0);

	// Token: 0x0600098A RID: 2442 RVA: 0x0000599D File Offset: 0x00003B9D
	static Delegate162()
	{
		Class2.smethod_14(typeof(Delegate162).TypeHandle);
	}

	// Token: 0x040001EF RID: 495
	internal static Delegate162 delegate162_0;
}

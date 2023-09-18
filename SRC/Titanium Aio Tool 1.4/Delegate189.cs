using System;
using System.Reflection;

// Token: 0x02000108 RID: 264
internal sealed class Delegate189 : MulticastDelegate
{
	// Token: 0x060009F1 RID: 2545
	public extern FieldInfo[] Invoke(object object_0);

	// Token: 0x060009F2 RID: 2546 RVA: 0x00005C11 File Offset: 0x00003E11
	public static FieldInfo[] smethod_0(object object_0, Delegate189 delegate189_1)
	{
		return delegate189_1(object_0);
	}

	// Token: 0x060009F3 RID: 2547
	public extern Delegate189(object object_0, IntPtr intptr_0);

	// Token: 0x060009F4 RID: 2548 RVA: 0x00005C1C File Offset: 0x00003E1C
	static Delegate189()
	{
		Class2.smethod_14(typeof(Delegate189).TypeHandle);
	}

	// Token: 0x0400020A RID: 522
	internal static Delegate189 delegate189_0;
}

using System;
using System.Windows.Forms;

// Token: 0x020000EC RID: 236
internal sealed class Delegate161 : MulticastDelegate
{
	// Token: 0x06000983 RID: 2435
	public extern void Invoke(object object_0, ImageLayout imageLayout_0);

	// Token: 0x06000984 RID: 2436 RVA: 0x00005979 File Offset: 0x00003B79
	public static void smethod_0(object object_0, ImageLayout imageLayout_0, Delegate161 delegate161_1)
	{
		delegate161_1(object_0, imageLayout_0);
	}

	// Token: 0x06000985 RID: 2437
	public extern Delegate161(object object_0, IntPtr intptr_0);

	// Token: 0x06000986 RID: 2438 RVA: 0x00005986 File Offset: 0x00003B86
	static Delegate161()
	{
		Class2.smethod_14(typeof(Delegate161).TypeHandle);
	}

	// Token: 0x040001EE RID: 494
	internal static Delegate161 delegate161_0;
}

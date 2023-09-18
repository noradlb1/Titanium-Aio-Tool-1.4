using System;
using System.Diagnostics;

// Token: 0x020000BC RID: 188
internal sealed class Delegate113 : MulticastDelegate
{
	// Token: 0x060008CA RID: 2250
	public extern void Invoke(object object_0, ProcessStartInfo processStartInfo_0);

	// Token: 0x060008CB RID: 2251 RVA: 0x0000553E File Offset: 0x0000373E
	public static void smethod_0(object object_0, ProcessStartInfo processStartInfo_0, Delegate113 delegate113_1)
	{
		delegate113_1(object_0, processStartInfo_0);
	}

	// Token: 0x060008CC RID: 2252
	public extern Delegate113(object object_0, IntPtr intptr_0);

	// Token: 0x060008CD RID: 2253 RVA: 0x0000554B File Offset: 0x0000374B
	static Delegate113()
	{
		Class2.smethod_14(typeof(Delegate113).TypeHandle);
	}

	// Token: 0x040001BE RID: 446
	internal static Delegate113 delegate113_0;
}

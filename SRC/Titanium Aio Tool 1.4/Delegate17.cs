using System;

// Token: 0x0200005C RID: 92
internal sealed class Delegate17 : MulticastDelegate
{
	// Token: 0x06000750 RID: 1872
	public extern int Invoke(int int_0);

	// Token: 0x06000751 RID: 1873 RVA: 0x00004C5A File Offset: 0x00002E5A
	public static int smethod_0(int int_0, Delegate17 delegate17_1)
	{
		return delegate17_1(int_0);
	}

	// Token: 0x06000752 RID: 1874
	public extern Delegate17(object object_0, IntPtr intptr_0);

	// Token: 0x06000753 RID: 1875 RVA: 0x00004C65 File Offset: 0x00002E65
	static Delegate17()
	{
		Class2.smethod_14(typeof(Delegate17).TypeHandle);
	}

	// Token: 0x0400015E RID: 350
	internal static Delegate17 delegate17_0;
}

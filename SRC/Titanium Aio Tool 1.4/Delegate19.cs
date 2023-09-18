using System;

// Token: 0x0200005E RID: 94
internal sealed class Delegate19 : MulticastDelegate
{
	// Token: 0x06000758 RID: 1880
	public extern int Invoke(object object_0);

	// Token: 0x06000759 RID: 1881 RVA: 0x00004C88 File Offset: 0x00002E88
	public static int smethod_0(object object_0, Delegate19 delegate19_1)
	{
		return delegate19_1(object_0);
	}

	// Token: 0x0600075A RID: 1882
	public extern Delegate19(object object_0, IntPtr intptr_0);

	// Token: 0x0600075B RID: 1883 RVA: 0x00004C93 File Offset: 0x00002E93
	static Delegate19()
	{
		Class2.smethod_14(typeof(Delegate19).TypeHandle);
	}

	// Token: 0x04000160 RID: 352
	internal static Delegate19 delegate19_0;
}

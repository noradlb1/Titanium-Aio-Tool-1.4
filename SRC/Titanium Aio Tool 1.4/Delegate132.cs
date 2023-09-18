using System;

// Token: 0x020000CF RID: 207
internal sealed class Delegate132 : MulticastDelegate
{
	// Token: 0x06000912 RID: 2322
	public extern string Invoke(object object_0);

	// Token: 0x06000913 RID: 2323 RVA: 0x000056D7 File Offset: 0x000038D7
	public static string smethod_0(object object_0, Delegate132 delegate132_1)
	{
		return delegate132_1(object_0);
	}

	// Token: 0x06000914 RID: 2324
	public extern Delegate132(object object_0, IntPtr intptr_0);

	// Token: 0x06000915 RID: 2325 RVA: 0x000056E2 File Offset: 0x000038E2
	static Delegate132()
	{
		Class2.smethod_14(typeof(Delegate132).TypeHandle);
	}

	// Token: 0x040001D1 RID: 465
	internal static Delegate132 delegate132_0;
}

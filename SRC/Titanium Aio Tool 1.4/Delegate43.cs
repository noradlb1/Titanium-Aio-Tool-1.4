using System;

// Token: 0x02000076 RID: 118
internal sealed class Delegate43 : MulticastDelegate
{
	// Token: 0x060007B8 RID: 1976
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060007B9 RID: 1977 RVA: 0x00004EDE File Offset: 0x000030DE
	public static void smethod_0(object object_0, string string_0, Delegate43 delegate43_1)
	{
		delegate43_1(object_0, string_0);
	}

	// Token: 0x060007BA RID: 1978
	public extern Delegate43(object object_0, IntPtr intptr_0);

	// Token: 0x060007BB RID: 1979 RVA: 0x00004EEB File Offset: 0x000030EB
	static Delegate43()
	{
		Class2.smethod_14(typeof(Delegate43).TypeHandle);
	}

	// Token: 0x04000178 RID: 376
	internal static Delegate43 delegate43_0;
}

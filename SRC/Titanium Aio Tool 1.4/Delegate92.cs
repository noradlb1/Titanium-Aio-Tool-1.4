using System;

// Token: 0x020000A7 RID: 167
internal sealed class Delegate92 : MulticastDelegate
{
	// Token: 0x06000879 RID: 2169
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x0600087A RID: 2170 RVA: 0x0000535E File Offset: 0x0000355E
	public static void smethod_0(object object_0, string string_0, Delegate92 delegate92_1)
	{
		delegate92_1(object_0, string_0);
	}

	// Token: 0x0600087B RID: 2171
	public extern Delegate92(object object_0, IntPtr intptr_0);

	// Token: 0x0600087C RID: 2172 RVA: 0x0000536B File Offset: 0x0000356B
	static Delegate92()
	{
		Class2.smethod_14(typeof(Delegate92).TypeHandle);
	}

	// Token: 0x040001A9 RID: 425
	internal static Delegate92 delegate92_0;
}

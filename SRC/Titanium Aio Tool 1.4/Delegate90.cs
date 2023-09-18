using System;

// Token: 0x020000A5 RID: 165
internal sealed class Delegate90 : MulticastDelegate
{
	// Token: 0x06000871 RID: 2161
	public extern object Invoke(object object_0, string string_0);

	// Token: 0x06000872 RID: 2162 RVA: 0x0000532C File Offset: 0x0000352C
	public static object smethod_0(object object_0, string string_0, Delegate90 delegate90_1)
	{
		return delegate90_1(object_0, string_0);
	}

	// Token: 0x06000873 RID: 2163
	public extern Delegate90(object object_0, IntPtr intptr_0);

	// Token: 0x06000874 RID: 2164 RVA: 0x00005339 File Offset: 0x00003539
	static Delegate90()
	{
		Class2.smethod_14(typeof(Delegate90).TypeHandle);
	}

	// Token: 0x040001A7 RID: 423
	internal static Delegate90 delegate90_0;
}

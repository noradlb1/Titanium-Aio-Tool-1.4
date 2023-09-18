using System;

// Token: 0x0200012E RID: 302
internal sealed class Delegate227 : MulticastDelegate
{
	// Token: 0x06000A89 RID: 2697
	public extern object Invoke(Type type_0, ushort ushort_0);

	// Token: 0x06000A8A RID: 2698 RVA: 0x00005F95 File Offset: 0x00004195
	public static object smethod_0(Type type_0, ushort ushort_0, Delegate227 delegate227_1)
	{
		return delegate227_1(type_0, ushort_0);
	}

	// Token: 0x06000A8B RID: 2699
	public extern Delegate227(object object_0, IntPtr intptr_0);

	// Token: 0x06000A8C RID: 2700 RVA: 0x00005FA2 File Offset: 0x000041A2
	static Delegate227()
	{
		Class2.smethod_14(typeof(Delegate227).TypeHandle);
	}

	// Token: 0x04000230 RID: 560
	internal static Delegate227 delegate227_0;
}

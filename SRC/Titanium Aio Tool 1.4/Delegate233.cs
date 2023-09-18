using System;

// Token: 0x02000134 RID: 308
internal sealed class Delegate233 : MulticastDelegate
{
	// Token: 0x06000AA0 RID: 2720
	public extern string Invoke(ref int int_0);

	// Token: 0x06000AA1 RID: 2721 RVA: 0x0000601E File Offset: 0x0000421E
	public static string smethod_0(ref int int_0, Delegate233 delegate233_1)
	{
		return delegate233_1(ref int_0);
	}

	// Token: 0x06000AA2 RID: 2722
	public extern Delegate233(object object_0, IntPtr intptr_0);

	// Token: 0x06000AA3 RID: 2723 RVA: 0x00006029 File Offset: 0x00004229
	static Delegate233()
	{
		Class2.smethod_14(typeof(Delegate233).TypeHandle);
	}

	// Token: 0x04000236 RID: 566
	internal static Delegate233 delegate233_0;
}

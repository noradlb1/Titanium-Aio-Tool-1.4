using System;

// Token: 0x020000AD RID: 173
internal sealed class Delegate98 : MulticastDelegate
{
	// Token: 0x06000891 RID: 2193
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06000892 RID: 2194 RVA: 0x000053F2 File Offset: 0x000035F2
	public static void smethod_0(object object_0, bool bool_0, Delegate98 delegate98_1)
	{
		delegate98_1(object_0, bool_0);
	}

	// Token: 0x06000893 RID: 2195
	public extern Delegate98(object object_0, IntPtr intptr_0);

	// Token: 0x06000894 RID: 2196 RVA: 0x000053FF File Offset: 0x000035FF
	static Delegate98()
	{
		Class2.smethod_14(typeof(Delegate98).TypeHandle);
	}

	// Token: 0x040001AF RID: 431
	internal static Delegate98 delegate98_0;
}

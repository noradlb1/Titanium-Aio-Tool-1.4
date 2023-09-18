using System;
using System.Text;

// Token: 0x02000125 RID: 293
internal sealed class Delegate218 : MulticastDelegate
{
	// Token: 0x06000A65 RID: 2661
	public extern Encoding Invoke();

	// Token: 0x06000A66 RID: 2662 RVA: 0x00005EC0 File Offset: 0x000040C0
	public static Encoding smethod_0(Delegate218 delegate218_1)
	{
		return delegate218_1();
	}

	// Token: 0x06000A67 RID: 2663
	public extern Delegate218(object object_0, IntPtr intptr_0);

	// Token: 0x06000A68 RID: 2664 RVA: 0x00005EC9 File Offset: 0x000040C9
	static Delegate218()
	{
		Class2.smethod_14(typeof(Delegate218).TypeHandle);
	}

	// Token: 0x04000227 RID: 551
	internal static Delegate218 delegate218_0;
}

using System;

// Token: 0x020000AA RID: 170
internal sealed class Delegate95 : MulticastDelegate
{
	// Token: 0x06000885 RID: 2181
	public extern void Invoke(object object_0, EventHandler eventHandler_0);

	// Token: 0x06000886 RID: 2182 RVA: 0x000053A9 File Offset: 0x000035A9
	public static void smethod_0(object object_0, EventHandler eventHandler_0, Delegate95 delegate95_1)
	{
		delegate95_1(object_0, eventHandler_0);
	}

	// Token: 0x06000887 RID: 2183
	public extern Delegate95(object object_0, IntPtr intptr_0);

	// Token: 0x06000888 RID: 2184 RVA: 0x000053B6 File Offset: 0x000035B6
	static Delegate95()
	{
		Class2.smethod_14(typeof(Delegate95).TypeHandle);
	}

	// Token: 0x040001AC RID: 428
	internal static Delegate95 delegate95_0;
}

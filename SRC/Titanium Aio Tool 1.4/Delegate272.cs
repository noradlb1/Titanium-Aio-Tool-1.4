using System;
using System.Reflection.Emit;

// Token: 0x0200015B RID: 347
internal sealed class Delegate272 : MulticastDelegate
{
	// Token: 0x06000B3C RID: 2876
	public extern ILGenerator Invoke(object object_0);

	// Token: 0x06000B3D RID: 2877 RVA: 0x000063BB File Offset: 0x000045BB
	public static ILGenerator smethod_0(object object_0, Delegate272 delegate272_1)
	{
		return delegate272_1(object_0);
	}

	// Token: 0x06000B3E RID: 2878
	public extern Delegate272(object object_0, IntPtr intptr_0);

	// Token: 0x06000B3F RID: 2879 RVA: 0x000063C6 File Offset: 0x000045C6
	static Delegate272()
	{
		Class2.smethod_14(typeof(Delegate272).TypeHandle);
	}

	// Token: 0x0400025D RID: 605
	internal static Delegate272 delegate272_0;
}

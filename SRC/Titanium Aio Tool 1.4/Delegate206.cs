using System;

// Token: 0x02000119 RID: 281
internal sealed class Delegate206 : MulticastDelegate
{
	// Token: 0x06000A35 RID: 2613
	public extern float Invoke(object object_0);

	// Token: 0x06000A36 RID: 2614 RVA: 0x00005DA6 File Offset: 0x00003FA6
	public static float smethod_0(object object_0, Delegate206 delegate206_1)
	{
		return delegate206_1(object_0);
	}

	// Token: 0x06000A37 RID: 2615
	public extern Delegate206(object object_0, IntPtr intptr_0);

	// Token: 0x06000A38 RID: 2616 RVA: 0x00005DB1 File Offset: 0x00003FB1
	static Delegate206()
	{
		Class2.smethod_14(typeof(Delegate206).TypeHandle);
	}

	// Token: 0x0400021B RID: 539
	internal static Delegate206 delegate206_0;
}

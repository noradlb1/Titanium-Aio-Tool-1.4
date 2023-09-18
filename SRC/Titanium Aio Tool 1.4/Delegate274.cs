using System;
using System.Reflection.Emit;

// Token: 0x0200015D RID: 349
internal sealed class Delegate274 : MulticastDelegate
{
	// Token: 0x06000B44 RID: 2884
	public extern void Invoke(object object_0, OpCode opCode_0);

	// Token: 0x06000B45 RID: 2885 RVA: 0x000063ED File Offset: 0x000045ED
	public static void smethod_0(object object_0, OpCode opCode_0, Delegate274 delegate274_1)
	{
		delegate274_1(object_0, opCode_0);
	}

	// Token: 0x06000B46 RID: 2886
	public extern Delegate274(object object_0, IntPtr intptr_0);

	// Token: 0x06000B47 RID: 2887 RVA: 0x000063FA File Offset: 0x000045FA
	static Delegate274()
	{
		Class2.smethod_14(typeof(Delegate274).TypeHandle);
	}

	// Token: 0x0400025F RID: 607
	internal static Delegate274 delegate274_0;
}

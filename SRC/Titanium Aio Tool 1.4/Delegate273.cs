using System;
using System.Reflection.Emit;

// Token: 0x0200015C RID: 348
internal sealed class Delegate273 : MulticastDelegate
{
	// Token: 0x06000B40 RID: 2880
	public extern void Invoke(object object_0, OpCode opCode_0, Type type_0);

	// Token: 0x06000B41 RID: 2881 RVA: 0x000063D2 File Offset: 0x000045D2
	public static void smethod_0(object object_0, OpCode opCode_0, Type type_0, Delegate273 delegate273_1)
	{
		delegate273_1(object_0, opCode_0, type_0);
	}

	// Token: 0x06000B42 RID: 2882
	public extern Delegate273(object object_0, IntPtr intptr_0);

	// Token: 0x06000B43 RID: 2883 RVA: 0x000063E1 File Offset: 0x000045E1
	static Delegate273()
	{
		Class2.smethod_14(typeof(Delegate273).TypeHandle);
	}

	// Token: 0x0400025E RID: 606
	internal static Delegate273 delegate273_0;
}

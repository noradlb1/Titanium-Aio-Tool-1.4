using System;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x02000165 RID: 357
internal sealed class Delegate282 : MulticastDelegate
{
	// Token: 0x06000B64 RID: 2916
	public extern void Invoke(object object_0, OpCode opCode_0, ConstructorInfo constructorInfo_0);

	// Token: 0x06000B65 RID: 2917 RVA: 0x000064B5 File Offset: 0x000046B5
	public static void smethod_0(object object_0, OpCode opCode_0, ConstructorInfo constructorInfo_0, Delegate282 delegate282_1)
	{
		delegate282_1(object_0, opCode_0, constructorInfo_0);
	}

	// Token: 0x06000B66 RID: 2918
	public extern Delegate282(object object_0, IntPtr intptr_0);

	// Token: 0x06000B67 RID: 2919 RVA: 0x000064C4 File Offset: 0x000046C4
	static Delegate282()
	{
		Class2.smethod_14(typeof(Delegate282).TypeHandle);
	}

	// Token: 0x04000267 RID: 615
	internal static Delegate282 delegate282_0;
}

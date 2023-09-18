using System;

// Token: 0x0200012A RID: 298
internal sealed class Delegate223 : MulticastDelegate
{
	// Token: 0x06000A79 RID: 2681
	public extern Type Invoke(Type type_0);

	// Token: 0x06000A7A RID: 2682 RVA: 0x00005F33 File Offset: 0x00004133
	public static Type smethod_0(Type type_0, Delegate223 delegate223_1)
	{
		return delegate223_1(type_0);
	}

	// Token: 0x06000A7B RID: 2683
	public extern Delegate223(object object_0, IntPtr intptr_0);

	// Token: 0x06000A7C RID: 2684 RVA: 0x00005F3E File Offset: 0x0000413E
	static Delegate223()
	{
		Class2.smethod_14(typeof(Delegate223).TypeHandle);
	}

	// Token: 0x0400022C RID: 556
	internal static Delegate223 delegate223_0;
}

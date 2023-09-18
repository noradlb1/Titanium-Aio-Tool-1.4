using System;

// Token: 0x02000116 RID: 278
internal sealed class Delegate203 : MulticastDelegate
{
	// Token: 0x06000A29 RID: 2601
	public extern bool Invoke(Type type_0, Type type_1);

	// Token: 0x06000A2A RID: 2602 RVA: 0x00005D5F File Offset: 0x00003F5F
	public static bool smethod_0(Type type_0, Type type_1, Delegate203 delegate203_1)
	{
		return delegate203_1(type_0, type_1);
	}

	// Token: 0x06000A2B RID: 2603
	public extern Delegate203(object object_0, IntPtr intptr_0);

	// Token: 0x06000A2C RID: 2604 RVA: 0x00005D6C File Offset: 0x00003F6C
	static Delegate203()
	{
		Class2.smethod_14(typeof(Delegate203).TypeHandle);
	}

	// Token: 0x04000218 RID: 536
	internal static Delegate203 delegate203_0;
}

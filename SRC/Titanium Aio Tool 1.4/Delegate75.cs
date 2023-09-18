using System;

// Token: 0x02000096 RID: 150
internal sealed class Delegate75 : MulticastDelegate
{
	// Token: 0x06000836 RID: 2102
	public extern Type Invoke(RuntimeTypeHandle runtimeTypeHandle_0);

	// Token: 0x06000837 RID: 2103 RVA: 0x000051C8 File Offset: 0x000033C8
	public static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0, Delegate75 delegate75_1)
	{
		return delegate75_1(runtimeTypeHandle_0);
	}

	// Token: 0x06000838 RID: 2104
	public extern Delegate75(object object_0, IntPtr intptr_0);

	// Token: 0x06000839 RID: 2105 RVA: 0x000051D3 File Offset: 0x000033D3
	static Delegate75()
	{
		Class2.smethod_14(typeof(Delegate75).TypeHandle);
	}

	// Token: 0x04000198 RID: 408
	internal static Delegate75 delegate75_0;
}

using System;

// Token: 0x02000093 RID: 147
internal sealed class Delegate72 : MulticastDelegate
{
	// Token: 0x0600082A RID: 2090
	public extern int Invoke(object object_0);

	// Token: 0x0600082B RID: 2091 RVA: 0x0000517F File Offset: 0x0000337F
	public static int smethod_0(object object_0, Delegate72 delegate72_1)
	{
		return delegate72_1(object_0);
	}

	// Token: 0x0600082C RID: 2092
	public extern Delegate72(object object_0, IntPtr intptr_0);

	// Token: 0x0600082D RID: 2093 RVA: 0x0000518A File Offset: 0x0000338A
	static Delegate72()
	{
		Class2.smethod_14(typeof(Delegate72).TypeHandle);
	}

	// Token: 0x04000195 RID: 405
	internal static Delegate72 delegate72_0;
}

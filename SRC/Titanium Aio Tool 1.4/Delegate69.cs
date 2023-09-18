using System;
using System.Drawing;

// Token: 0x02000090 RID: 144
internal sealed class Delegate69 : MulticastDelegate
{
	// Token: 0x0600081E RID: 2078
	public extern int Invoke(ref Size size_0);

	// Token: 0x0600081F RID: 2079 RVA: 0x0000513A File Offset: 0x0000333A
	public static int smethod_0(ref Size size_0, Delegate69 delegate69_1)
	{
		return delegate69_1(ref size_0);
	}

	// Token: 0x06000820 RID: 2080
	public extern Delegate69(object object_0, IntPtr intptr_0);

	// Token: 0x06000821 RID: 2081 RVA: 0x00005145 File Offset: 0x00003345
	static Delegate69()
	{
		Class2.smethod_14(typeof(Delegate69).TypeHandle);
	}

	// Token: 0x04000192 RID: 402
	internal static Delegate69 delegate69_0;
}

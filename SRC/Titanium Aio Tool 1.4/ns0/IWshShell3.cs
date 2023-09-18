using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x0200000C RID: 12
	[TypeIdentifier]
	[Guid("41904400-BE18-11D3-A28B-00104BD35090")]
	[CompilerGenerated]
	[ComImport]
	public interface IWshShell3
	{
		// Token: 0x0600014C RID: 332
		void _VtblGap1_4();

		// Token: 0x0600014D RID: 333
		[DispId(1002)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateShortcut([MarshalAs(UnmanagedType.BStr)] [In] string PathLink);
	}
}

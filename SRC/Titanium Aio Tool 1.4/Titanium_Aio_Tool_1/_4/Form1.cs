using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Windows.Forms;
using DiscordRPC;
using Microsoft.Win32;
using Titanium_Aio_Tool_1._4.Properties;

namespace Titanium_Aio_Tool_1._4
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00006958 File Offset: 0x00004B58
		public Form1()
		{
			this.InitializeComponent();
			this.CenterFormOnScreen();
			this.timer1 = new Timer();
			this.timer1.Interval = 8000;
			this.timer1.Tick += this.timer1_Tick;
			this.timer1.Start();
			RPC.rpctimestamp = Timestamps.Now;
			RPC.InitializeRPC();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000069CC File Offset: 0x00004BCC
		private void RoundCorners(int radius)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			Rectangle rectangle = new Rectangle(0, 0, base.Width, base.Height);
			graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180f, 90f);
			graphicsPath.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y, radius, radius, 270f, 90f);
			graphicsPath.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y + rectangle.Height - radius, radius, radius, 0f, 90f);
			graphicsPath.AddArc(rectangle.X, rectangle.Y + rectangle.Height - radius, radius, radius, 90f, 90f);
			graphicsPath.CloseFigure();
			base.Region = new Region(graphicsPath);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00006AB8 File Offset: 0x00004CB8
		private void CenterFormOnScreen()
		{
			int width = Screen.PrimaryScreen.Bounds.Width;
			int height = Screen.PrimaryScreen.Bounds.Height;
			int width2 = base.Width;
			int height2 = base.Height;
			int x = (width - width2) / 2;
			int y = (height - height2) / 2;
			base.StartPosition = FormStartPosition.Manual;
			base.Location = new Point(x, y);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00006B28 File Offset: 0x00004D28
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.timer1.Stop();
			Form2 form = new Form2();
			form.Show();
			base.Hide();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00006B54 File Offset: 0x00004D54
		private void KillProcess(string processName)
		{
			Process[] processesByName = Process.GetProcessesByName(processName);
			foreach (Process process in processesByName)
			{
				try
				{
					process.Kill();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error killing process: " + ex.Message);
				}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00006BBC File Offset: 0x00004DBC
		private void Form1_Load(object sender, EventArgs e)
		{
			this.RoundCorners(30);
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.titanium2))
			{
				soundPlayer.Play();
			}
			string[] array = new string[]
			{
				"adb.exe",
				"AppMarket",
				"AndroidEmulatorEx",
				"AndroidEmulatorEn"
			};
			foreach (string processName in array)
			{
				this.KillProcess(processName);
			}
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Tencent\\MobileGamePC", true);
				if (registryKey != null)
				{
					registryKey.SetValue("ForceDirectX", 1, RegistryValueKind.DWord);
					registryKey.SetValue("AdbDisable", 0, RegistryValueKind.DWord);
					registryKey.SetValue("RootEnabled", 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006CBC File Offset: 0x00004EBC
		private void Form1_Resize(object sender, EventArgs e)
		{
			int x = (base.ClientSize.Width - this.roundedPictureBox1.Width) / 2;
			int y = (base.ClientSize.Height - this.roundedPictureBox1.Height) / 2;
			this.roundedPictureBox1.Location = new Point(x, y);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_0()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_1()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000023D8 File Offset: 0x000005D8
		internal static void smethod_2(object object_0, int int_0, Delegate48 delegate48_0)
		{
			Delegate48.smethod_0(object_0, int_0, delegate48_0);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000023EB File Offset: 0x000005EB
		internal static void smethod_3(object object_0, EventHandler eventHandler_0, Delegate49 delegate49_0)
		{
			Delegate49.smethod_0(object_0, eventHandler_0, delegate49_0);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000023FE File Offset: 0x000005FE
		internal static object smethod_4(Delegate51 delegate51_0)
		{
			return delegate51_0();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002409 File Offset: 0x00000609
		internal static void smethod_5(Timestamps timestamps_0)
		{
			RPC.rpctimestamp = timestamps_0;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002414 File Offset: 0x00000614
		internal static void smethod_6()
		{
			RPC.InitializeRPC();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002263 File Offset: 0x00000463
		internal static int smethod_7(object object_0, Delegate18 delegate18_0)
		{
			return Delegate18.smethod_0(object_0, delegate18_0);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002272 File Offset: 0x00000472
		internal static int smethod_8(object object_0, Delegate19 delegate19_0)
		{
			return Delegate19.smethod_0(object_0, delegate19_0);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000022DD File Offset: 0x000004DD
		internal static void smethod_9(object object_0, int int_0, int int_1, int int_2, int int_3, float float_0, float float_1, Delegate30 delegate30_0)
		{
			Delegate30.smethod_0(object_0, int_0, int_1, int_2, int_3, float_0, float_1, delegate30_0);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000022A8 File Offset: 0x000004A8
		internal static void smethod_10(object object_0, Delegate25 delegate25_0)
		{
			Delegate25.smethod_0(object_0, delegate25_0);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000022B7 File Offset: 0x000004B7
		internal static void smethod_11(object object_0, Region region_0, Delegate26 delegate26_0)
		{
			Delegate26.smethod_0(object_0, region_0, delegate26_0);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000241B File Offset: 0x0000061B
		internal static object smethod_12(Delegate52 delegate52_0)
		{
			return delegate52_0();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002426 File Offset: 0x00000626
		internal static Rectangle smethod_13(object object_0, Delegate53 delegate53_0)
		{
			return Delegate53.smethod_0(object_0, delegate53_0);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002435 File Offset: 0x00000635
		internal static void smethod_14(object object_0, Point point_0, Delegate55 delegate55_0)
		{
			Delegate55.smethod_0(object_0, point_0, delegate55_0);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002448 File Offset: 0x00000648
		internal static void smethod_15(object object_0, Delegate56 delegate56_0)
		{
			Delegate56.smethod_0(object_0, delegate56_0);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002457 File Offset: 0x00000657
		internal static void smethod_16(object object_0, Delegate58 delegate58_0)
		{
			Delegate58.smethod_0(object_0, delegate58_0);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002466 File Offset: 0x00000666
		internal static object smethod_17(string string_0, Delegate59 delegate59_0)
		{
			return Delegate59.smethod_0(string_0, delegate59_0);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002475 File Offset: 0x00000675
		internal static void smethod_18(object object_0, Delegate60 delegate60_0)
		{
			Delegate60.smethod_0(object_0, delegate60_0);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002335 File Offset: 0x00000535
		internal static object smethod_19(int int_0)
		{
			return Class2.smethod_17(int_0);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002484 File Offset: 0x00000684
		internal static object smethod_20(string string_0, string string_1, Delegate46 delegate46_0)
		{
			return Delegate46.smethod_0(string_0, string_1, delegate46_0);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002497 File Offset: 0x00000697
		internal static DialogResult smethod_21(string string_0, Delegate62 delegate62_0)
		{
			return Delegate62.smethod_0(string_0, delegate62_0);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000024A6 File Offset: 0x000006A6
		internal static void smethod_22(object object_0, Delegate64 delegate64_0)
		{
			Delegate64.smethod_0(object_0, delegate64_0);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000024B5 File Offset: 0x000006B5
		internal static object smethod_23(object object_0, string string_0, bool bool_0, Delegate65 delegate65_0)
		{
			return Delegate65.smethod_0(object_0, string_0, bool_0, delegate65_0);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000024CC File Offset: 0x000006CC
		internal static void smethod_24(object object_0, string string_0, object object_1, RegistryValueKind registryValueKind_0, Delegate66 delegate66_0)
		{
			Delegate66.smethod_0(object_0, string_0, object_1, registryValueKind_0, delegate66_0);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000024E7 File Offset: 0x000006E7
		internal static void smethod_25(object object_0, Delegate67 delegate67_0)
		{
			Delegate67.smethod_0(object_0, delegate67_0);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000024F6 File Offset: 0x000006F6
		internal static Size smethod_26(object object_0, Delegate68 delegate68_0)
		{
			return Delegate68.smethod_0(object_0, delegate68_0);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002505 File Offset: 0x00000705
		internal static int smethod_27(object object_0, Delegate70 delegate70_0)
		{
			return Delegate70.smethod_0(object_0, delegate70_0);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002514 File Offset: 0x00000714
		internal static int smethod_28(object object_0, Delegate72 delegate72_0)
		{
			return Delegate72.smethod_0(object_0, delegate72_0);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002523 File Offset: 0x00000723
		internal static void smethod_29(object object_0, Point point_0, Delegate73 delegate73_0)
		{
			Delegate73.smethod_0(object_0, point_0, delegate73_0);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002536 File Offset: 0x00000736
		internal static void smethod_30(object object_0, bool bool_0, Delegate74 delegate74_0)
		{
			Delegate74.smethod_0(object_0, bool_0, delegate74_0);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002549 File Offset: 0x00000749
		internal static void smethod_31(object object_0, Delegate76 delegate76_0)
		{
			Delegate76.smethod_0(object_0, delegate76_0);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002558 File Offset: 0x00000758
		internal static void smethod_32(object object_0, Delegate77 delegate77_0)
		{
			Delegate77.smethod_0(object_0, delegate77_0);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002567 File Offset: 0x00000767
		internal static object smethod_33()
		{
			return Resources.ezgif_com_resize;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000256E File Offset: 0x0000076E
		internal static void smethod_34(object object_0, Image image_0, Delegate78 delegate78_0)
		{
			Delegate78.smethod_0(object_0, image_0, delegate78_0);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002581 File Offset: 0x00000781
		internal static void smethod_35(object object_0, Size size_0, Delegate80 delegate80_0)
		{
			Delegate80.smethod_0(object_0, size_0, delegate80_0);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002594 File Offset: 0x00000794
		internal static void smethod_36(object object_0, int int_0, Delegate81 delegate81_0)
		{
			Delegate81.smethod_0(object_0, int_0, delegate81_0);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000025A7 File Offset: 0x000007A7
		internal static void smethod_37(object object_0, bool bool_0, Delegate82 delegate82_0)
		{
			Delegate82.smethod_0(object_0, bool_0, delegate82_0);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000025BA File Offset: 0x000007BA
		internal static void smethod_38(object object_0, SizeF sizeF_0, Delegate83 delegate83_0)
		{
			Delegate83.smethod_0(object_0, sizeF_0, delegate83_0);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000025CD File Offset: 0x000007CD
		internal static void smethod_39(object object_0, AutoScaleMode autoScaleMode_0, Delegate84 delegate84_0)
		{
			Delegate84.smethod_0(object_0, autoScaleMode_0, delegate84_0);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000025E0 File Offset: 0x000007E0
		internal static void smethod_40(object object_0, Size size_0, Delegate85 delegate85_0)
		{
			Delegate85.smethod_0(object_0, size_0, delegate85_0);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000025F3 File Offset: 0x000007F3
		internal static object smethod_41(Control control_0)
		{
			return control_0.Controls;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000025FE File Offset: 0x000007FE
		internal static void smethod_42(object object_0, Control control_0, Delegate86 delegate86_0)
		{
			Delegate86.smethod_0(object_0, control_0, delegate86_0);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002611 File Offset: 0x00000811
		internal static object smethod_43(Delegate87 delegate87_0)
		{
			return delegate87_0();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000261C File Offset: 0x0000081C
		internal static void smethod_44(object object_0, Cursor cursor_0, Delegate88 delegate88_0)
		{
			Delegate88.smethod_0(object_0, cursor_0, delegate88_0);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000262F File Offset: 0x0000082F
		internal static void smethod_45(object object_0, FormBorderStyle formBorderStyle_0, Delegate89 delegate89_0)
		{
			Delegate89.smethod_0(object_0, formBorderStyle_0, delegate89_0);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002642 File Offset: 0x00000842
		internal static object smethod_46(object object_0, string string_0, Delegate90 delegate90_0)
		{
			return Delegate90.smethod_0(object_0, string_0, delegate90_0);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002655 File Offset: 0x00000855
		internal static void smethod_47(object object_0, Icon icon_0, Delegate91 delegate91_0)
		{
			Delegate91.smethod_0(object_0, icon_0, delegate91_0);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002668 File Offset: 0x00000868
		internal static void smethod_48(object object_0, string string_0, Delegate92 delegate92_0)
		{
			Delegate92.smethod_0(object_0, string_0, delegate92_0);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000267B File Offset: 0x0000087B
		internal static void smethod_49(object object_0, string string_0, Delegate93 delegate93_0)
		{
			Delegate93.smethod_0(object_0, string_0, delegate93_0);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000268E File Offset: 0x0000088E
		internal static void smethod_50(object object_0, EventHandler eventHandler_0, Delegate94 delegate94_0)
		{
			Delegate94.smethod_0(object_0, eventHandler_0, delegate94_0);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000026A1 File Offset: 0x000008A1
		internal static void smethod_51(object object_0, Delegate96 delegate96_0)
		{
			Delegate96.smethod_0(object_0, delegate96_0);
		}
	}
}

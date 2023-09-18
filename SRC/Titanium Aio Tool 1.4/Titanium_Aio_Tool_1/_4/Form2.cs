using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Win32;
using ns0;
using Titanium_Aio_Tool_1._4.Properties;

namespace Titanium_Aio_Tool_1._4
{
	// Token: 0x02000006 RID: 6
	public partial class Form2 : Form
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00006ED4 File Offset: 0x000050D4
		public Form2()
		{
			this.InitializeComponent();
			base.MaximizeBox = false;
			this.CenterFormOnScreen();
			Settings @default = Settings.Default;
			int usageCount = @default.UsageCount;
			@default.UsageCount = usageCount + 1;
			Settings.Default.Save();
			this.lblUsageCount.Text = string.Format("Application Usage Count: {0}", Settings.Default.UsageCount);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00006F48 File Offset: 0x00005148
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

		// Token: 0x06000070 RID: 112 RVA: 0x00006FB8 File Offset: 0x000051B8
		private void Form2_Load(object sender, EventArgs e)
		{
			this.comboBox1.SelectedIndex = 0;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00006FD4 File Offset: 0x000051D4
		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00006FE8 File Offset: 0x000051E8
		private void button1_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("https://discord.gg/jpDEJ5bWdk");
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00007030 File Offset: 0x00005230
		private void button2_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("https://titaniumvip.net/");
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000707C File Offset: 0x0000527C
		private void roundedButton3_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			this.panel1.Visible = false;
			this.panel2.Visible = false;
			this.panel3.Visible = true;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000070E0 File Offset: 0x000052E0
		private void roundedButton2_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			this.panel1.Visible = false;
			this.panel2.Visible = true;
			this.panel3.Visible = false;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00007144 File Offset: 0x00005344
		private void roundedButton1_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			this.panel1.Visible = true;
			this.panel2.Visible = false;
			this.panel3.Visible = false;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000071A8 File Offset: 0x000053A8
		private void button5_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("https://t.me/MONSTERMCSY");
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00006FE8 File Offset: 0x000051E8
		private void button6_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("https://discord.gg/jpDEJ5bWdk");
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000071A8 File Offset: 0x000053A8
		private void button3_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("https://t.me/MONSTERMCSY");
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00006FE8 File Offset: 0x000051E8
		private void button4_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("https://discord.gg/jpDEJ5bWdk");
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000071F0 File Offset: 0x000053F0
		private void roundedButton5_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			try
			{
				string path = "C:\\Program Files\\Synaptics";
				Directory.Delete(path, true);
				this.cleanstatus.Text = "Synaptics folder deleted successfully";
				this.cleanstatus.ForeColor = Color.Green;
			}
			catch (Exception)
			{
				this.cleanstatus.Text = "Your pc dont have any synaptics virus";
				this.cleanstatus.ForeColor = Color.Red;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007290 File Offset: 0x00005490
		private void roundedButton6_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = "/c netsh advfirewall reset";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			using (Process process = new Process())
			{
				process.StartInfo = processStartInfo;
				process.Start();
				process.WaitForExit();
				if (process.ExitCode == 0)
				{
					this.cleanstatus.ForeColor = Color.Green;
					this.cleanstatus.Text = "Firewall settings reset successfully";
				}
				else
				{
					this.cleanstatus.ForeColor = Color.Red;
					this.cleanstatus.Text = "Failed to reset firewall settings";
				}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00007384 File Offset: 0x00005584
		private void roundedButton7_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "ipconfig";
				process.StartInfo.Arguments = "/release";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.WaitForExit();
				Process process2 = new Process();
				process2.StartInfo.FileName = "ipconfig";
				process2.StartInfo.Arguments = "/renew";
				process2.StartInfo.UseShellExecute = false;
				process2.StartInfo.CreateNoWindow = true;
				process2.Start();
				process2.WaitForExit();
				Process process3 = new Process();
				process3.StartInfo.FileName = "ipconfig";
				process3.StartInfo.Arguments = "/flushdns";
				process3.StartInfo.UseShellExecute = false;
				process3.StartInfo.CreateNoWindow = true;
				process3.Start();
				process3.WaitForExit();
				Process process4 = new Process();
				process4.StartInfo.FileName = "netsh";
				process4.StartInfo.Arguments = "int ip reset";
				process4.StartInfo.UseShellExecute = false;
				process4.StartInfo.CreateNoWindow = true;
				process4.Start();
				process4.WaitForExit();
				Process process5 = new Process();
				process5.StartInfo.FileName = "netsh";
				process5.StartInfo.Arguments = "winsock reset";
				process5.StartInfo.UseShellExecute = false;
				process5.StartInfo.CreateNoWindow = true;
				process5.Start();
				process5.WaitForExit();
				Process process6 = new Process();
				process6.StartInfo.FileName = "netsh";
				process6.StartInfo.Arguments = "interface ipv4 reset";
				process6.StartInfo.UseShellExecute = false;
				process6.StartInfo.CreateNoWindow = true;
				process6.Start();
				process6.WaitForExit();
				Process process7 = new Process();
				process7.StartInfo.FileName = "netsh";
				process7.StartInfo.Arguments = "interface ipv6 reset";
				process7.StartInfo.UseShellExecute = false;
				process7.StartInfo.CreateNoWindow = true;
				process7.Start();
				process7.WaitForExit();
				this.cleanstatus.Text = "IP flushing completed successfully";
				this.cleanstatus.ForeColor = Color.Green;
			}
			catch (Exception ex)
			{
				this.cleanstatus.Text = "Error: " + ex.Message;
				this.cleanstatus.ForeColor = Color.Red;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007678 File Offset: 0x00005878
		private void roundedButton8_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			try
			{
				string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\hosts");
				File.WriteAllBytes(path, Resources.hosts);
				this.cleanstatus.Text = "Default host file updated successfully";
				this.cleanstatus.ForeColor = Color.Green;
			}
			catch (Exception ex)
			{
				this.cleanstatus.Text = "Error: " + ex.Message;
				this.cleanstatus.ForeColor = Color.Red;
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007734 File Offset: 0x00005934
		private void roundedButton4_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			this.cleanstatus.Text = "Wait entil the cleaning not done";
			this.cleanstatus.ForeColor = Color.Yellow;
			string text = Path.Combine(Path.GetTempPath(), "Cleaning.bat");
			string titanium_Cleaning = Resources.Titanium_Cleaning;
			byte[] bytes = Encoding.ASCII.GetBytes(titanium_Cleaning);
			File.WriteAllBytes(text, bytes);
			base.Enabled = false;
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = text;
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.CreateNoWindow = true;
			using (Process process = new Process())
			{
				process.StartInfo = processStartInfo;
				process.Start();
				process.WaitForExit();
				if (process.ExitCode == 0)
				{
					this.cleanstatus.ForeColor = Color.Green;
					this.cleanstatus.Text = "Cleaning successfully done";
				}
				else
				{
					this.cleanstatus.ForeColor = Color.Green;
					this.cleanstatus.Text = "Cleaning successfully done";
				}
			}
			base.Enabled = true;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007878 File Offset: 0x00005A78
		private void roundedButton9_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("https://mega.nz/file/ToUDxBYC#KSOAVXRSao-DqrVRP0AFPIVIb8_dJnG47YZuDLagTYE");
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000078C4 File Offset: 0x00005AC4
		private void roundedButton10_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			try
			{
				string text = Path.Combine(Path.GetTempPath(), "DnsJumper.exe");
				File.WriteAllBytes(text, Resources.DnsJumper);
				Process.Start(text);
				this.cleanstatus.Text = "Dns jumper open successfully";
				this.cleanstatus.ForeColor = Color.Green;
			}
			catch (Exception ex)
			{
				this.cleanstatus.Text = "Error: " + ex.Message;
				this.cleanstatus.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00007988 File Offset: 0x00005B88
		private void roundedButton11_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			try
			{
				string text = Path.Combine(Path.GetTempPath(), "WinUpdatesDisabler.exe");
				File.WriteAllBytes(text, Resources.WinUpdatesDisabler);
				Process.Start(text);
				this.cleanstatus.Text = "Windows Update disabler open successfully";
				this.cleanstatus.ForeColor = Color.Green;
			}
			catch (Exception ex)
			{
				this.cleanstatus.Text = "Error: " + ex.Message;
				this.cleanstatus.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00007A4C File Offset: 0x00005C4C
		private void roundedButton12_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			try
			{
				string text = Path.Combine(Path.GetTempPath(), "SystemInformationChanger.exe");
				File.WriteAllBytes(text, Resources.ChangeComputerInfo);
				Process.Start(text);
				this.cleanstatus.Text = "System info changer open successfully";
				this.cleanstatus.ForeColor = Color.Green;
			}
			catch (Exception ex)
			{
				this.cleanstatus.Text = "Error: " + ex.Message;
				this.cleanstatus.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007B10 File Offset: 0x00005D10
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00007B50 File Offset: 0x00005D50
		private void roundedButton13_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			bool flag = false;
			foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
			{
				string text = Path.Combine(driveInfo.Name, "Program Files\\TxGameAssistant\\ui\\", "AndroidEmulatorEn.exe");
				if (File.Exists(text))
				{
					flag = true;
					ProcessStartInfo startInfo = new ProcessStartInfo(text, "-vm 100");
					try
					{
						Process.Start(startInfo);
						this.toolstatus.Text = "Emulator opened successfully.";
						this.toolstatus.ForeColor = Color.Green;
						break;
					}
					catch (Exception ex)
					{
						this.toolstatus.Text = "Error occurred: " + ex.Message;
						this.toolstatus.ForeColor = Color.Red;
					}
				}
			}
			if (!flag)
			{
				this.toolstatus.Text = "Error: Emulator not found on any drive.";
				this.toolstatus.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002240 File Offset: 0x00000440
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00007C78 File Offset: 0x00005E78
		private void roundedButton14_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			string[] array = new string[]
			{
				"AndroidEmulatorEn",
				"AndroidEmulatorEx",
				"AndroidEmulator",
				"AppMarket",
				"adb",
				"aow_exe"
			};
			foreach (string processName in array)
			{
				Process[] processesByName = Process.GetProcessesByName(processName);
				foreach (Process process in processesByName)
				{
					try
					{
						process.Kill();
						goto IL_A2;
					}
					catch (Exception)
					{
						goto IL_A2;
					}
					break;
					IL_A2:;
				}
			}
			this.toolstatus.Text = "Processes terminated successfully.";
			this.toolstatus.ForeColor = Color.Green;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007D6C File Offset: 0x00005F6C
		private void roundedButton15_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			string[] array = new string[]
			{
				"AndroidEmulatorEn",
				"AndroidEmulatorEx",
				"AndroidEmulator",
				"AppMarket",
				"adb",
				"aow_exe"
			};
			bool flag = false;
			foreach (string processName in array)
			{
				Process[] processesByName = Process.GetProcessesByName(processName);
				if (processesByName.Length != 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				this.toolstatus.Text = "Start the emulator first and then try again.";
				this.toolstatus.ForeColor = Color.Red;
			}
			else if (this.comboBox1.SelectedItem != null)
			{
				this.toolstatus.Text = "Please wait until the fix ban id is done. The application will be locked during the process.";
				this.toolstatus.ForeColor = Color.Yellow;
				base.Enabled = false;
				string text = this.comboBox1.SelectedItem.ToString();
				string text2 = text;
				string a = text2;
				string contents;
				if (!(a == "Gl (Global)"))
				{
					if (a == "Kr (Korea)")
					{
						contents = Resources.koreaban;
					}
					else if (!(a == "Vn (Vietnam)"))
					{
						if (a == "Tw (Taiwan)")
						{
							contents = Resources.taiwanban;
						}
						else
						{
							if (!(a == "India (Bgmi)"))
							{
								base.Enabled = true;
								this.toolstatus.Text = "Invalid game version selected.";
								this.toolstatus.ForeColor = Color.Red;
								return;
							}
							contents = Resources.bgmiban;
						}
					}
					else
					{
						contents = Resources.vietnamban;
					}
				}
				else
				{
					contents = Resources.globalban;
				}
				string text3 = Path.Combine(Path.GetTempPath(), "temp.bat");
				File.WriteAllText(text3, contents);
				ProcessStartInfo startInfo = new ProcessStartInfo(text3)
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					Verb = "runas"
				};
				try
				{
					Process process = new Process
					{
						StartInfo = startInfo
					};
					process.Start();
					process.WaitForExit();
				}
				catch (Exception ex)
				{
					base.Enabled = true;
					this.toolstatus.Text = "Failed to fix ban ID. Error: " + ex.Message;
					this.toolstatus.ForeColor = Color.Red;
					return;
				}
				this.KillProcesses();
				this.toolstatus.Text = "Fix Ban ID done successfully.";
				this.toolstatus.ForeColor = Color.Green;
				this.ModifyRegistryValues();
				this.FindLocationAndCreateShortcut();
				base.Enabled = true;
			}
			else
			{
				this.toolstatus.Text = "Please choose your game version first.";
				this.toolstatus.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00008044 File Offset: 0x00006244
		private bool KillProcesses()
		{
			bool result;
			try
			{
				foreach (Process process in Process.GetProcessesByName("AndroidEmulatorEn"))
				{
					process.Kill();
				}
				foreach (Process process2 in Process.GetProcessesByName("AndroidEmulatorEx"))
				{
					process2.Kill();
				}
				foreach (Process process3 in Process.GetProcessesByName("AppMarket"))
				{
					process3.Kill();
				}
				foreach (Process process4 in Process.GetProcessesByName("adb"))
				{
					process4.Kill();
				}
				foreach (Process process5 in Process.GetProcessesByName("aow_exe"))
				{
					process5.Kill();
				}
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00008150 File Offset: 0x00006350
		private void ModifyRegistryValues()
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Tencent\\MobileGamePC", true);
				if (registryKey != null)
				{
					registryKey.SetValue("VMDeviceManufacturer", "Ghost Vip 000");
					registryKey.SetValue("VMDeviceModel", "ASUS_I001DA");
					registryKey.Close();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000081B8 File Offset: 0x000063B8
		private void FindLocationAndCreateShortcut()
		{
			string path = "Program Files\\TxGameAssistant\\ui\\AndroidEmulatorEn.exe";
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				string fullName = driveInfo.RootDirectory.FullName;
				string text = Path.Combine(fullName, path);
				if (File.Exists(text))
				{
					this.CreateShortcutOnDesktop(text);
					return;
				}
			}
			MessageBox.Show("Gameloop shortcut not found on any drive run it manumally.", "Ghost Fixer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00008230 File Offset: 0x00006430
		private void CreateShortcutOnDesktop(string executablePath)
		{
			string pathLink = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "AndroidEmulatorEn.lnk");
			try
			{
				 <<<NULL>>> = ()Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
				if (Form2.<>o__30.<>p__0 == null)
				{
					Form2.<>o__30.<>p__0 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(Form2)));
				}
				IWshShortcut wshShortcut = Form2.<>o__30.<>p__0.Target(Form2.<>o__30.<>p__0, <<<NULL>>>.CreateShortcut(pathLink));
				wshShortcut.TargetPath = executablePath;
				wshShortcut.Arguments = "-vm 100";
				wshShortcut.WorkingDirectory = Path.GetDirectoryName(executablePath);
				wshShortcut.Description = "AndroidEmulatorEn";
				wshShortcut.IconLocation = executablePath;
				wshShortcut.Save();
				MessageBox.Show("Shortcut created on the desktop. You can now run gameloop from that shortcut.", "Ghost Fixer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while creating the shortcut: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000833C File Offset: 0x0000653C
		private void roundedButton16_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			string[] array = new string[]
			{
				"AndroidEmulatorEn",
				"AndroidEmulatorEx",
				"AndroidEmulator",
				"AppMarket",
				"adb",
				"aow_exe"
			};
			bool flag = false;
			foreach (string processName in array)
			{
				Process[] processesByName = Process.GetProcessesByName(processName);
				if (processesByName.Length != 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				this.toolstatus.Text = "Start the emulator first and then try again.";
				this.toolstatus.ForeColor = Color.Red;
			}
			else if (this.comboBox1.SelectedItem != null)
			{
				this.toolstatus.Text = "Please wait until the guest reset is done. The application will be locked during the process.";
				this.toolstatus.ForeColor = Color.Yellow;
				base.Enabled = false;
				string text = this.comboBox1.SelectedItem.ToString();
				string text2 = text;
				string a = text2;
				string contents;
				if (!(a == "Gl (Global)"))
				{
					if (!(a == "Kr (Korea)"))
					{
						if (a == "Vn (Vietnam)")
						{
							contents = Resources.vietnam;
						}
						else if (a == "Tw (Taiwan)")
						{
							contents = Resources.taiwan;
						}
						else
						{
							if (!(a == "India (Bgmi)"))
							{
								base.Enabled = true;
								this.toolstatus.Text = "Invalid game version selected.";
								this.toolstatus.ForeColor = Color.Red;
								return;
							}
							contents = Resources.bgmi;
						}
					}
					else
					{
						contents = Resources.korea;
					}
				}
				else
				{
					contents = Resources.global;
				}
				string text3 = Path.Combine(Path.GetTempPath(), "temp.bat");
				File.WriteAllText(text3, contents);
				ProcessStartInfo startInfo = new ProcessStartInfo(text3)
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					Verb = "runas"
				};
				try
				{
					Process process = new Process
					{
						StartInfo = startInfo
					};
					process.Start();
					process.WaitForExit();
				}
				catch (Exception ex)
				{
					base.Enabled = true;
					this.toolstatus.Text = "Failed to do guest reset. Error: " + ex.Message;
					this.toolstatus.ForeColor = Color.Red;
					return;
				}
				this.toolstatus.Text = "Guest Reset done successfully.";
				this.toolstatus.ForeColor = Color.Green;
				base.Enabled = true;
			}
			else
			{
				this.toolstatus.Text = "Please choose your game version first.";
				this.toolstatus.ForeColor = Color.Red;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00008600 File Offset: 0x00006800
		private void roundedButton17_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			string path = "C:\\Windows\\Temp";
			string path2 = "C:\\Windows\\Prefetch";
			string path3 = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp";
			try
			{
				foreach (string path4 in Directory.GetFiles(path))
				{
					try
					{
						File.Delete(path4);
					}
					catch
					{
					}
				}
				foreach (string path5 in Directory.GetFiles(path2))
				{
					try
					{
						File.Delete(path5);
					}
					catch
					{
					}
				}
				foreach (string path6 in Directory.GetFiles(path3))
				{
					try
					{
						File.Delete(path6);
					}
					catch
					{
					}
				}
				this.toolstatus.Text = "All files deleted successfully";
				this.toolstatus.ForeColor = Color.Green;
			}
			catch (Exception ex)
			{
				this.toolstatus.Text = "Error deleting files: " + ex.Message;
				this.toolstatus.ForeColor = Color.Red;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00008774 File Offset: 0x00006974
		private void roundedButton19_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("https://mega.nz/file/X1VRQRRD#kTxbix5pF70ZM5ig1cTlru8aEzGniDpiQ7UY-suwKbE");
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00007B10 File Offset: 0x00005D10
		private void roundedButton18_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000087C0 File Offset: 0x000069C0
		private void roundedButton20_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			try
			{
				string text = Path.Combine(Path.GetTempPath(), "HWIDkey_Changer.exe");
				File.WriteAllBytes(text, Resources.HWIDkey_Changer);
				Process.Start(text);
				this.cleanstatus.Text = "Hwid changer open successfully";
				this.cleanstatus.ForeColor = Color.Green;
			}
			catch (Exception ex)
			{
				this.cleanstatus.Text = "Error: " + ex.Message;
				this.cleanstatus.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00008884 File Offset: 0x00006A84
		private void roundedButton21_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("https://down.gameloop.com/channel/3/16412/GLP_installer_1000218456_market.exe");
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000088D0 File Offset: 0x00006AD0
		private void roundedButton24_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("https://pubgm.vcdn.vn/PUBGMOBILEVN_2.7.0.apk");
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000891C File Offset: 0x00006B1C
		private void roundedButton25_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("https://sim.gpubgm.com/AOS_Release2.7.0_No14_2.7.0.17730_Shipping_Google_TW.shell.signed.apk");
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00008968 File Offset: 0x00006B68
		private void roundedButton27_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("https://down.gameloop.com/channel/3/25883/GLP_installer_900223086_market.exe");
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000089B4 File Offset: 0x00006BB4
		private void roundedButton22_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("https://magholarabeee.blogspot.com/");
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000089FC File Offset: 0x00006BFC
		private void roundedButton26_Click(object sender, EventArgs e)
		{
			using (SoundPlayer soundPlayer = new SoundPlayer(Resources.buttonclick))
			{
				soundPlayer.Play();
			}
			Process.Start("http://static.updatestar.net/dl/allinone/aio-runtimes_v2.5.0.exe");
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_0()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_1()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000026B0 File Offset: 0x000008B0
		internal static void smethod_2(object object_0, bool bool_0, Delegate98 delegate98_0)
		{
			Delegate98.smethod_0(object_0, bool_0, delegate98_0);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000026C3 File Offset: 0x000008C3
		internal static object smethod_3()
		{
			return Settings.Default;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000026CA File Offset: 0x000008CA
		internal static void smethod_4(Settings settings_0, int value)
		{
			settings_0.UsageCount = value;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000026D9 File Offset: 0x000008D9
		internal static void smethod_5(object object_0, Delegate99 delegate99_0)
		{
			Delegate99.smethod_0(object_0, delegate99_0);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002335 File Offset: 0x00000535
		internal static object smethod_6(int int_0)
		{
			return Class2.smethod_17(int_0);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000026E8 File Offset: 0x000008E8
		internal static int smethod_7(Settings settings_0)
		{
			return settings_0.UsageCount;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000026F3 File Offset: 0x000008F3
		internal static object smethod_8(string string_0, object object_0, Delegate100 delegate100_0)
		{
			return Delegate100.smethod_0(string_0, object_0, delegate100_0);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000267B File Offset: 0x0000087B
		internal static void smethod_9(object object_0, string string_0, Delegate93 delegate93_0)
		{
			Delegate93.smethod_0(object_0, string_0, delegate93_0);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000241B File Offset: 0x0000061B
		internal static object smethod_10(Delegate52 delegate52_0)
		{
			return delegate52_0();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002426 File Offset: 0x00000626
		internal static Rectangle smethod_11(object object_0, Delegate53 delegate53_0)
		{
			return Delegate53.smethod_0(object_0, delegate53_0);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002263 File Offset: 0x00000463
		internal static int smethod_12(object object_0, Delegate18 delegate18_0)
		{
			return Delegate18.smethod_0(object_0, delegate18_0);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002272 File Offset: 0x00000472
		internal static int smethod_13(object object_0, Delegate19 delegate19_0)
		{
			return Delegate19.smethod_0(object_0, delegate19_0);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002706 File Offset: 0x00000906
		internal static void smethod_14(object object_0, FormStartPosition formStartPosition_0, Delegate54 delegate54_0)
		{
			Delegate54.smethod_0(object_0, formStartPosition_0, delegate54_0);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002435 File Offset: 0x00000635
		internal static void smethod_15(object object_0, Point point_0, Delegate55 delegate55_0)
		{
			Delegate55.smethod_0(object_0, point_0, delegate55_0);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002719 File Offset: 0x00000919
		internal static void smethod_16(Delegate102 delegate102_0)
		{
			delegate102_0();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002724 File Offset: 0x00000924
		internal static object smethod_17()
		{
			return Resources.buttonclick;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000272B File Offset: 0x0000092B
		internal static void smethod_18(object object_0, Delegate63 delegate63_0)
		{
			Delegate63.smethod_0(object_0, delegate63_0);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000024A6 File Offset: 0x000006A6
		internal static void smethod_19(object object_0, Delegate64 delegate64_0)
		{
			Delegate64.smethod_0(object_0, delegate64_0);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000273A File Offset: 0x0000093A
		internal static object smethod_20(string string_0, Delegate103 delegate103_0)
		{
			return Delegate103.smethod_0(string_0, delegate103_0);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002749 File Offset: 0x00000949
		internal static void smethod_21(object object_0, bool bool_0, Delegate104 delegate104_0)
		{
			Delegate104.smethod_0(object_0, bool_0, delegate104_0);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000275C File Offset: 0x0000095C
		internal static void smethod_22(string string_0, bool bool_0, Delegate105 delegate105_0)
		{
			Delegate105.smethod_0(string_0, bool_0, delegate105_0);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000276F File Offset: 0x0000096F
		internal static Color smethod_23(Delegate106 delegate106_0)
		{
			return delegate106_0();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000277A File Offset: 0x0000097A
		internal static Color smethod_24(Delegate108 delegate108_0)
		{
			return delegate108_0();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002785 File Offset: 0x00000985
		internal static void smethod_25(object object_0, string string_0, Delegate110 delegate110_0)
		{
			Delegate110.smethod_0(object_0, string_0, delegate110_0);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002798 File Offset: 0x00000998
		internal static void smethod_26(object object_0, ProcessWindowStyle processWindowStyle_0, Delegate111 delegate111_0)
		{
			Delegate111.smethod_0(object_0, processWindowStyle_0, delegate111_0);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000027AB File Offset: 0x000009AB
		internal static void smethod_27(object object_0, bool bool_0, Delegate112 delegate112_0)
		{
			Delegate112.smethod_0(object_0, bool_0, delegate112_0);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000027BE File Offset: 0x000009BE
		internal static void smethod_28(object object_0, ProcessStartInfo processStartInfo_0, Delegate113 delegate113_0)
		{
			Delegate113.smethod_0(object_0, processStartInfo_0, delegate113_0);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000027D1 File Offset: 0x000009D1
		internal static bool smethod_29(object object_0, Delegate114 delegate114_0)
		{
			return Delegate114.smethod_0(object_0, delegate114_0);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000027E0 File Offset: 0x000009E0
		internal static int smethod_30(object object_0, Delegate116 delegate116_0)
		{
			return Delegate116.smethod_0(object_0, delegate116_0);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000027EF File Offset: 0x000009EF
		internal static object smethod_31(object object_0, Delegate117 delegate117_0)
		{
			return Delegate117.smethod_0(object_0, delegate117_0);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000027FE File Offset: 0x000009FE
		internal static void smethod_32(object object_0, string string_0, Delegate109 delegate109_0)
		{
			Delegate109.smethod_0(object_0, string_0, delegate109_0);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002811 File Offset: 0x00000A11
		internal static void smethod_33(object object_0, bool bool_0, Delegate118 delegate118_0)
		{
			Delegate118.smethod_0(object_0, bool_0, delegate118_0);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002824 File Offset: 0x00000A24
		internal static void smethod_34(object object_0, Delegate115 delegate115_0)
		{
			Delegate115.smethod_0(object_0, delegate115_0);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002833 File Offset: 0x00000A33
		internal static void smethod_35(object object_0, Color color_0, Delegate107 delegate107_0)
		{
			Delegate107.smethod_0(object_0, color_0, delegate107_0);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002846 File Offset: 0x00000A46
		internal static object smethod_36(object object_0, Delegate61 delegate61_0)
		{
			return Delegate61.smethod_0(object_0, delegate61_0);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002855 File Offset: 0x00000A55
		internal static object smethod_37(string string_0, string string_1, Delegate119 delegate119_0)
		{
			return Delegate119.smethod_0(string_0, string_1, delegate119_0);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002868 File Offset: 0x00000A68
		internal static object smethod_38()
		{
			return Resources.hosts;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000286F File Offset: 0x00000A6F
		internal static void smethod_39(string string_0, byte[] byte_0, Delegate120 delegate120_0)
		{
			Delegate120.smethod_0(string_0, byte_0, delegate120_0);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002882 File Offset: 0x00000A82
		internal static object smethod_40(Delegate122 delegate122_0)
		{
			return delegate122_0();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000288D File Offset: 0x00000A8D
		internal static object smethod_41()
		{
			return Resources.Titanium_Cleaning;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002894 File Offset: 0x00000A94
		internal static object smethod_42(Delegate123 delegate123_0)
		{
			return delegate123_0();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000289F File Offset: 0x00000A9F
		internal static object smethod_43(object object_0, string string_0, Delegate124 delegate124_0)
		{
			return Delegate124.smethod_0(object_0, string_0, delegate124_0);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000028B2 File Offset: 0x00000AB2
		internal static void smethod_44(object object_0, bool bool_0, Delegate125 delegate125_0)
		{
			Delegate125.smethod_0(object_0, bool_0, delegate125_0);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000028C5 File Offset: 0x00000AC5
		internal static object smethod_45()
		{
			return Resources.DnsJumper;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002484 File Offset: 0x00000684
		internal static object smethod_46(string string_0, string string_1, Delegate46 delegate46_0)
		{
			return Delegate46.smethod_0(string_0, string_1, delegate46_0);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000028CC File Offset: 0x00000ACC
		internal static object smethod_47()
		{
			return Resources.WinUpdatesDisabler;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000028D3 File Offset: 0x00000AD3
		internal static object smethod_48(Delegate126 delegate126_0)
		{
			return delegate126_0();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000028DE File Offset: 0x00000ADE
		internal static bool smethod_49(string string_0, Delegate129 delegate129_0)
		{
			return Delegate129.smethod_0(string_0, delegate129_0);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002466 File Offset: 0x00000666
		internal static object smethod_50(string string_0, Delegate59 delegate59_0)
		{
			return Delegate59.smethod_0(string_0, delegate59_0);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002475 File Offset: 0x00000675
		internal static void smethod_51(object object_0, Delegate60 delegate60_0)
		{
			Delegate60.smethod_0(object_0, delegate60_0);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000028ED File Offset: 0x00000AED
		internal static object smethod_52(object object_0, Delegate131 delegate131_0)
		{
			return Delegate131.smethod_0(object_0, delegate131_0);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000028FC File Offset: 0x00000AFC
		internal static object smethod_53(object object_0, Delegate132 delegate132_0)
		{
			return Delegate132.smethod_0(object_0, delegate132_0);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000290B File Offset: 0x00000B0B
		internal static bool smethod_54(string string_0, string string_1, Delegate133 delegate133_0)
		{
			return Delegate133.smethod_0(string_0, string_1, delegate133_0);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000291E File Offset: 0x00000B1E
		internal static object smethod_55()
		{
			return Resources.globalban;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002925 File Offset: 0x00000B25
		internal static object smethod_56()
		{
			return Resources.koreaban;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000292C File Offset: 0x00000B2C
		internal static object smethod_57()
		{
			return Resources.vietnamban;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002933 File Offset: 0x00000B33
		internal static object smethod_58()
		{
			return Resources.taiwanban;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000293A File Offset: 0x00000B3A
		internal static object smethod_59()
		{
			return Resources.bgmiban;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002941 File Offset: 0x00000B41
		internal static void smethod_60(object object_0, bool bool_0, Delegate135 delegate135_0)
		{
			Delegate135.smethod_0(object_0, bool_0, delegate135_0);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002954 File Offset: 0x00000B54
		internal static void smethod_61(object object_0, bool bool_0, Delegate136 delegate136_0)
		{
			Delegate136.smethod_0(object_0, bool_0, delegate136_0);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002967 File Offset: 0x00000B67
		internal static void smethod_62(object object_0, string string_0, object object_1, Delegate138 delegate138_0)
		{
			Delegate138.smethod_0(object_0, string_0, object_1, delegate138_0);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000024E7 File Offset: 0x000006E7
		internal static void smethod_63(object object_0, Delegate67 delegate67_0)
		{
			Delegate67.smethod_0(object_0, delegate67_0);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000297E File Offset: 0x00000B7E
		internal static object smethod_64(object object_0, Delegate140 delegate140_0)
		{
			return Delegate140.smethod_0(object_0, delegate140_0);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000298D File Offset: 0x00000B8D
		internal static DialogResult smethod_65(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, Delegate141 delegate141_0)
		{
			return Delegate141.smethod_0(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, delegate141_0);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000029A8 File Offset: 0x00000BA8
		internal static object smethod_66(Environment.SpecialFolder specialFolder_0)
		{
			return Environment.GetFolderPath(specialFolder_0);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000029B3 File Offset: 0x00000BB3
		internal static Type smethod_67(Guid guid_0, Delegate142 delegate142_0)
		{
			return Delegate142.smethod_0(guid_0, delegate142_0);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000029C2 File Offset: 0x00000BC2
		internal static Type smethod_68(RuntimeTypeHandle runtimeTypeHandle_0, Delegate75 delegate75_0)
		{
			return Delegate75.smethod_0(runtimeTypeHandle_0, delegate75_0);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000029D1 File Offset: 0x00000BD1
		internal static object smethod_69(CSharpBinderFlags csharpBinderFlags_0, Type type_0, Type type_1, Delegate144 delegate144_0)
		{
			return Delegate144.smethod_0(csharpBinderFlags_0, type_0, type_1, delegate144_0);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000029E8 File Offset: 0x00000BE8
		internal static object smethod_70(string string_0, Delegate145 delegate145_0)
		{
			return Delegate145.smethod_0(string_0, delegate145_0);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000029F7 File Offset: 0x00000BF7
		internal static void smethod_71(IWshShortcut iwshShortcut_0)
		{
			iwshShortcut_0.Save();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002A02 File Offset: 0x00000C02
		internal static Color smethod_72(Delegate121 delegate121_0)
		{
			return delegate121_0();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002A0D File Offset: 0x00000C0D
		internal static object smethod_73()
		{
			return Resources.taiwan;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002A14 File Offset: 0x00000C14
		internal static void smethod_74(string string_0, string string_1, Delegate134 delegate134_0)
		{
			Delegate134.smethod_0(string_0, string_1, delegate134_0);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002A27 File Offset: 0x00000C27
		internal static object smethod_75(string string_0, string string_1, string string_2, Delegate147 delegate147_0)
		{
			return Delegate147.smethod_0(string_0, string_1, string_2, delegate147_0);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002A3E File Offset: 0x00000C3E
		internal static void smethod_76(string string_0, Delegate149 delegate149_0)
		{
			Delegate149.smethod_0(string_0, delegate149_0);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002A4D File Offset: 0x00000C4D
		internal static object smethod_77(string string_0, Delegate148 delegate148_0)
		{
			return Delegate148.smethod_0(string_0, delegate148_0);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002A5C File Offset: 0x00000C5C
		internal static object smethod_78()
		{
			return Resources.HWIDkey_Changer;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002A63 File Offset: 0x00000C63
		internal static void smethod_79(object object_0, Delegate150 delegate150_0)
		{
			Delegate150.smethod_0(object_0, delegate150_0);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002558 File Offset: 0x00000758
		internal static void smethod_80(object object_0, Delegate77 delegate77_0)
		{
			Delegate77.smethod_0(object_0, delegate77_0);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002A72 File Offset: 0x00000C72
		internal static Color smethod_81(Delegate151 delegate151_0)
		{
			return delegate151_0();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal static void smethod_82(object object_0, Color color_0, Delegate152 delegate152_0)
		{
			Delegate152.smethod_0(object_0, color_0, delegate152_0);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002A90 File Offset: 0x00000C90
		internal static object smethod_83(Control control_0)
		{
			return control_0.Controls;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000025FE File Offset: 0x000007FE
		internal static void smethod_84(object object_0, Control control_0, Delegate86 delegate86_0)
		{
			Delegate86.smethod_0(object_0, control_0, delegate86_0);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002523 File Offset: 0x00000723
		internal static void smethod_85(object object_0, Point point_0, Delegate73 delegate73_0)
		{
			Delegate73.smethod_0(object_0, point_0, delegate73_0);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002A9B File Offset: 0x00000C9B
		internal static void smethod_86(object object_0, string string_0, Delegate79 delegate79_0)
		{
			Delegate79.smethod_0(object_0, string_0, delegate79_0);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002AAE File Offset: 0x00000CAE
		internal static void smethod_87(object object_0, int int_0, Delegate153 delegate153_0)
		{
			Delegate153.smethod_0(object_0, int_0, delegate153_0);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002AC1 File Offset: 0x00000CC1
		internal static object smethod_88(Delegate154 delegate154_0)
		{
			return delegate154_0();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000261C File Offset: 0x0000081C
		internal static void smethod_89(object object_0, Cursor cursor_0, Delegate88 delegate88_0)
		{
			Delegate88.smethod_0(object_0, cursor_0, delegate88_0);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002ACC File Offset: 0x00000CCC
		internal static void smethod_90(object object_0, Font font_0, Delegate155 delegate155_0)
		{
			Delegate155.smethod_0(object_0, font_0, delegate155_0);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002ADF File Offset: 0x00000CDF
		internal static void smethod_91(object object_0, bool bool_0, Delegate156 delegate156_0)
		{
			Delegate156.smethod_0(object_0, bool_0, delegate156_0);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002AF2 File Offset: 0x00000CF2
		internal static void smethod_92(object object_0, EventHandler eventHandler_0, Delegate157 delegate157_0)
		{
			Delegate157.smethod_0(object_0, eventHandler_0, delegate157_0);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002581 File Offset: 0x00000781
		internal static void smethod_93(object object_0, Size size_0, Delegate80 delegate80_0)
		{
			Delegate80.smethod_0(object_0, size_0, delegate80_0);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002B05 File Offset: 0x00000D05
		internal static void smethod_94(object object_0, bool bool_0, Delegate158 delegate158_0)
		{
			Delegate158.smethod_0(object_0, bool_0, delegate158_0);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002B18 File Offset: 0x00000D18
		internal static object smethod_95()
		{
			return Resources.icons8_website_48;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002B1F File Offset: 0x00000D1F
		internal static void smethod_96(object object_0, Image image_0, Delegate160 delegate160_0)
		{
			Delegate160.smethod_0(object_0, image_0, delegate160_0);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002B32 File Offset: 0x00000D32
		internal static void smethod_97(object object_0, ImageLayout imageLayout_0, Delegate161 delegate161_0)
		{
			Delegate161.smethod_0(object_0, imageLayout_0, delegate161_0);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002B45 File Offset: 0x00000D45
		internal static object smethod_98(object object_0, Delegate162 delegate162_0)
		{
			return Delegate162.smethod_0(object_0, delegate162_0);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002B54 File Offset: 0x00000D54
		internal static void smethod_99(object object_0, int int_0, Delegate163 delegate163_0)
		{
			Delegate163.smethod_0(object_0, int_0, delegate163_0);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002B67 File Offset: 0x00000D67
		internal static void smethod_100(object object_0, FlatStyle flatStyle_0, Delegate164 delegate164_0)
		{
			Delegate164.smethod_0(object_0, flatStyle_0, delegate164_0);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002B7A File Offset: 0x00000D7A
		internal static Color smethod_101(Delegate159 delegate159_0)
		{
			return delegate159_0();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002B85 File Offset: 0x00000D85
		internal static Color smethod_102(Delegate165 delegate165_0)
		{
			return delegate165_0();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002B90 File Offset: 0x00000D90
		internal static void smethod_103(object object_0, PaintEventHandler paintEventHandler_0, Delegate166 delegate166_0)
		{
			Delegate166.smethod_0(object_0, paintEventHandler_0, delegate166_0);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002BA3 File Offset: 0x00000DA3
		internal static void smethod_104(object object_0, ComboBoxStyle comboBoxStyle_0, Delegate167 delegate167_0)
		{
			Delegate167.smethod_0(object_0, comboBoxStyle_0, delegate167_0);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002BB6 File Offset: 0x00000DB6
		internal static object smethod_105(ComboBox comboBox_0)
		{
			return comboBox_0.Items;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002BC1 File Offset: 0x00000DC1
		internal static void smethod_106(object object_0, EventHandler eventHandler_0, Delegate170 delegate170_0)
		{
			Delegate170.smethod_0(object_0, eventHandler_0, delegate170_0);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002BD4 File Offset: 0x00000DD4
		internal static object smethod_107()
		{
			return Resources.icons8_discord_48;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002BDB File Offset: 0x00000DDB
		internal static void smethod_108(object object_0, Image image_0, Delegate171 delegate171_0)
		{
			Delegate171.smethod_0(object_0, image_0, delegate171_0);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002BEE File Offset: 0x00000DEE
		internal static void smethod_109(object object_0, ContentAlignment contentAlignment_0, Delegate172 delegate172_0)
		{
			Delegate172.smethod_0(object_0, contentAlignment_0, delegate172_0);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002C01 File Offset: 0x00000E01
		internal static object smethod_110()
		{
			return Resources.icons8_tools_40;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002C08 File Offset: 0x00000E08
		internal static object smethod_111()
		{
			return Resources.icons8_dustbin_40;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000025BA File Offset: 0x000007BA
		internal static void smethod_112(object object_0, SizeF sizeF_0, Delegate83 delegate83_0)
		{
			Delegate83.smethod_0(object_0, sizeF_0, delegate83_0);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002C0F File Offset: 0x00000E0F
		internal static Color smethod_113(Delegate173 delegate173_0)
		{
			return delegate173_0();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000025E0 File Offset: 0x000007E0
		internal static void smethod_114(object object_0, Size size_0, Delegate85 delegate85_0)
		{
			Delegate85.smethod_0(object_0, size_0, delegate85_0);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000025F3 File Offset: 0x000007F3
		internal static object smethod_115(Control control_0)
		{
			return control_0.Controls;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002642 File Offset: 0x00000842
		internal static object smethod_116(object object_0, string string_0, Delegate90 delegate90_0)
		{
			return Delegate90.smethod_0(object_0, string_0, delegate90_0);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002655 File Offset: 0x00000855
		internal static void smethod_117(object object_0, Icon icon_0, Delegate91 delegate91_0)
		{
			Delegate91.smethod_0(object_0, icon_0, delegate91_0);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002668 File Offset: 0x00000868
		internal static void smethod_118(object object_0, string string_0, Delegate92 delegate92_0)
		{
			Delegate92.smethod_0(object_0, string_0, delegate92_0);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002C1A File Offset: 0x00000E1A
		internal static void smethod_119(object object_0, FormClosingEventHandler formClosingEventHandler_0, Delegate174 delegate174_0)
		{
			Delegate174.smethod_0(object_0, formClosingEventHandler_0, delegate174_0);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000268E File Offset: 0x0000088E
		internal static void smethod_120(object object_0, EventHandler eventHandler_0, Delegate94 delegate94_0)
		{
			Delegate94.smethod_0(object_0, eventHandler_0, delegate94_0);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002C2D File Offset: 0x00000E2D
		internal static void smethod_121(object object_0, bool bool_0, Delegate175 delegate175_0)
		{
			Delegate175.smethod_0(object_0, bool_0, delegate175_0);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002C40 File Offset: 0x00000E40
		internal static void smethod_122(object object_0, bool bool_0, Delegate97 delegate97_0)
		{
			Delegate97.smethod_0(object_0, bool_0, delegate97_0);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002C53 File Offset: 0x00000E53
		internal static void smethod_123(object object_0, Delegate177 delegate177_0)
		{
			Delegate177.smethod_0(object_0, delegate177_0);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_124()
		{
		}
	}
}

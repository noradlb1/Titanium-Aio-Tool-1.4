using System;
using DiscordRPC;

namespace Titanium_Aio_Tool_1
{
	// Token: 0x02000004 RID: 4
	public class RPC
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002317 File Offset: 0x00000517
		// (set) Token: 0x06000020 RID: 32 RVA: 0x0000231E File Offset: 0x0000051E
		public static Timestamps rpctimestamp { get; set; }

		// Token: 0x06000021 RID: 33 RVA: 0x0000682C File Offset: 0x00004A2C
		public static void InitializeRPC()
		{
			RPC.client = new DiscordRpcClient("1123542319174516847");
			RPC.client.Initialize();
			Button[] buttons = new Button[]
			{
				new Button
				{
					Label = "\ud83d\udc7bDISCORD",
					Url = "https://discord.gg/TTkbfKXMqZ"
				},
				new Button
				{
					Label = "\ud83e\udd16WEBSITE",
					Url = "https://titaniumvip.net/"
				}
			};
			RPC.presence = new RichPresence
			{
				Details = "",
				State = "",
				Timestamps = RPC.<rpctimestamp>k__BackingField,
				Buttons = buttons,
				Assets = new Assets
				{
					LargeImageKey = "https://media3.giphy.com/media/v1.Y2lkPTc5MGI3NjExeWNobGhwYTIzYXdhaDk1aTZ2MzYyenN4cGNlZzk2NHQ5OWFibmdkZiZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/fH2KEcCAenrEJ3uIO7/giphy.gif",
					LargeImageText = "Titanium Aio Tool 1.4",
					SmallImageKey = "https://i.pinimg.com/originals/6b/17/28/6b17287c0580c33894286a585bdd3f07.gif",
					SmallImageText = "Verified"
				}
			};
			RPC.SetState("Best aio tool with 0% virus 100% working", false);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000690C File Offset: 0x00004B0C
		public static void SetState(string state, bool watching = false)
		{
			if (watching)
			{
				state = "Looking at " + state;
			}
			RPC.presence.State = state;
			RPC.client.SetPresence(RPC.presence);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002326 File Offset: 0x00000526
		internal static bool smethod_0(object object_0, Delegate34 delegate34_0)
		{
			return Delegate34.smethod_0(object_0, delegate34_0);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002335 File Offset: 0x00000535
		internal static object smethod_1(int int_0)
		{
			return Class2.smethod_17(int_0);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002340 File Offset: 0x00000540
		internal static void smethod_2(object object_0, string string_0, Delegate35 delegate35_0)
		{
			Delegate35.smethod_0(object_0, string_0, delegate35_0);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002353 File Offset: 0x00000553
		internal static void smethod_3(object object_0, string string_0, Delegate37 delegate37_0)
		{
			Delegate37.smethod_0(object_0, string_0, delegate37_0);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002366 File Offset: 0x00000566
		internal static void smethod_4(object object_0, string string_0, Delegate38 delegate38_0)
		{
			Delegate38.smethod_0(object_0, string_0, delegate38_0);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002317 File Offset: 0x00000517
		internal static object smethod_5()
		{
			return RPC.<rpctimestamp>k__BackingField;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002379 File Offset: 0x00000579
		internal static void smethod_6(object object_0, Timestamps timestamps_0, Delegate39 delegate39_0)
		{
			Delegate39.smethod_0(object_0, timestamps_0, delegate39_0);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000238C File Offset: 0x0000058C
		internal static void smethod_7(object object_0, string string_0, Delegate42 delegate42_0)
		{
			Delegate42.smethod_0(object_0, string_0, delegate42_0);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000239F File Offset: 0x0000059F
		internal static void smethod_8(object object_0, string string_0, Delegate43 delegate43_0)
		{
			Delegate43.smethod_0(object_0, string_0, delegate43_0);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000023B2 File Offset: 0x000005B2
		internal static void smethod_9(object object_0, Assets assets_0, Delegate45 delegate45_0)
		{
			Delegate45.smethod_0(object_0, assets_0, delegate45_0);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000023C5 File Offset: 0x000005C5
		internal static void smethod_10(object object_0, RichPresence richPresence_0, Delegate47 delegate47_0)
		{
			Delegate47.smethod_0(object_0, richPresence_0, delegate47_0);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_11()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_12()
		{
		}

		// Token: 0x04000003 RID: 3
		public static DiscordRpcClient client;

		// Token: 0x04000005 RID: 5
		private static RichPresence presence;
	}
}

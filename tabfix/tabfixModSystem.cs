using System;
using HarmonyLib;
using Vintagestory.API.Client;
using Vintagestory.API.Common;

namespace tabfix
{
    public class tabfixModSystem : ModSystem
    {
		[HarmonyPatch(typeof(GuiComposer))]
		[HarmonyPatch("OnKeyDown")]
		private class Patch_GuiComposer_OnKeyDown
		{
			private static void Prefix(GuiComposer __instance, KeyEvent args, bool haveFocus)
			{
				__instance.Tabbable = false;
			}
		}

		public class TranslokatorChunkSaverModSystemClient : ModSystem
		{
			public override void StartClientSide(ICoreClientAPI api)
			{
				this.harmony = new Harmony("client_patches");
				this.harmony.PatchAll();
			}

			private Harmony harmony;
		}
	}
}
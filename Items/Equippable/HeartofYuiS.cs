using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.Localization;

namespace AlchemistNPC.Items.Equippable
{
	public class HeartofYuiS : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heart of Yui");
			Tooltip.SetDefault("Summons small Pixie Helper"
			+"\nHighlights treasures, creatures and traps");
			DisplayName.AddTranslation(GameCulture.Russian, "Сердце Юи");
            Tooltip.AddTranslation(GameCulture.Russian, "Вызывает маленькую Фею-Помошника\nПодсвечивает сокровища, существ и ловушки");

            DisplayName.AddTranslation(GameCulture.Chinese, "小悠之心");
            Tooltip.AddTranslation(GameCulture.Chinese, "召唤小精灵助手\n照亮宝物, 生物和陷阱");
        }

		public override void SetDefaults()
		{
			item.damage = 0;
			item.useStyle = 1;
			item.shoot = mod.ProjectileType("YuiS");
			item.width = 16;
			item.height = 30;
			item.UseSound = SoundID.Item2;
			item.useAnimation = 20;
			item.useTime = 20;
			item.rare = 8;
			item.noMelee = true;
			item.value = Item.sellPrice(3, 0, 0, 0);
			item.buffType = mod.BuffType("YuiS");
			item.expert = true;
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HeartofYui");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
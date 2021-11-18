using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TranslationAPI
{
    public class ExampleModule : ETGModule
    {
        public override void Init() 
        { 
        }

        public override void Start()
        {
            //adds new translations to the sunglasses, they will say "Translation Example 1" in russian, but they will say "Translation Example 2" in spanish
            Gungeon.Game.Items["sunglasses"].TranslateItemName(StringTableManager.GungeonSupportedLanguages.RUSSIAN, "Translation Example 1");
            Gungeon.Game.Items["sunglasses"].TranslateItemShortDescription(StringTableManager.GungeonSupportedLanguages.RUSSIAN, "Translation Example 1");
            Gungeon.Game.Items["sunglasses"].TranslateItemLongDescription(StringTableManager.GungeonSupportedLanguages.RUSSIAN, "Translation Example 1");

            Gungeon.Game.Items["sunglasses"].TranslateItemName(StringTableManager.GungeonSupportedLanguages.SPANISH, "Translation Example 2");
            Gungeon.Game.Items["sunglasses"].TranslateItemShortDescription(StringTableManager.GungeonSupportedLanguages.SPANISH, "Translation Example 2 shortdesc");
            Gungeon.Game.Items["sunglasses"].TranslateItemLongDescription(StringTableManager.GungeonSupportedLanguages.SPANISH, "Translation Example 2 longdesc");

            //adds new translations to the bullet kin, they will say "Enemy Translation Example 1" in german, but they will say "Enemy Translation Example 2" in french
            Gungeon.Game.Enemies["bullet_kin"].TranslateEnemyName(StringTableManager.GungeonSupportedLanguages.GERMAN, "Enemy Translation Example 1");
            Gungeon.Game.Enemies["bullet_kin"].TranslateEnemyShortDescription(StringTableManager.GungeonSupportedLanguages.GERMAN, "Enemy Translation Example 1");
            Gungeon.Game.Enemies["bullet_kin"].TranslateEnemyLongDescription(StringTableManager.GungeonSupportedLanguages.GERMAN, "Enemy Translation Example 1");

            Gungeon.Game.Enemies["bullet_kin"].TranslateEnemyName(StringTableManager.GungeonSupportedLanguages.FRENCH, "Enemy Translation Example 2");
            Gungeon.Game.Enemies["bullet_kin"].TranslateEnemyShortDescription(StringTableManager.GungeonSupportedLanguages.FRENCH, "Enemy Translation Example 2");
            Gungeon.Game.Enemies["bullet_kin"].TranslateEnemyLongDescription(StringTableManager.GungeonSupportedLanguages.FRENCH, "Enemy Translation Example 2");

            //adds a new string with a key "#INDIVIDUAL_TRANSLATION_TEST" that defaults to "Individual String Translation 1" in english, but will change to "Individual String Translation 2" in russian and adds a command to check the string's current
            // value
            TranslationManager.AddTranslation(StringTableManager.GungeonSupportedLanguages.ENGLISH, "#INDIVIDUAL_TRANSLATION_TEST", "Individual String Translation 1", StringTableType.Core);
            TranslationManager.AddTranslation(StringTableManager.GungeonSupportedLanguages.RUSSIAN, "#INDIVIDUAL_TRANSLATION_TEST", "Individual String Translation 2", StringTableType.Core);
            ETGModConsole.Commands.AddUnit("individual_translation_test", delegate (string[] s)
            {
                ETGModConsole.Log(StringTableManager.GetString("#INDIVIDUAL_TRANSLATION_TEST"));
            });
        }

        public override void Exit() 
        {
        }
    }
}

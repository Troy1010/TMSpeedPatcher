using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace TMSpeedPatcher;

public class Settings
{
    [MaintainOrder]

    [SettingName("Speed Multiplier")]
    [Tooltip("Multiplies each npc and creature's speed")]
    public float SpeedMult = 1.2f;

    [SettingName("NPC Blacklist")]
    [Tooltip("These NPCs will not be adjusted")]
    public HashSet<IFormLinkGetter<INpcGetter>> NpcBlacklist = new();

    [SettingName("Creature Blacklist")]
    [Tooltip("These NPCs will not be adjusted")]
    public HashSet<IFormLinkGetter<ICreatureGetter>> CreatureBlacklist = new();
}
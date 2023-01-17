// Namespace: 
[FlagsAttribute] // RVA: 0x2790D0 Offset: 0x2791D1 VA: 0x2790D0
public enum GameUserGlobalData.Flags // TypeDefIndex: 13614
{
	// Fields
	public int value__; // 0x0
	public const GameUserGlobalData.Flags Cleared_Difficulty_Normal = 1;
	public const GameUserGlobalData.Flags Cleared_Difficulty_Hard = 2;
	public const GameUserGlobalData.Flags Cleared_Difficulty_Lunatic = 4;
	public const GameUserGlobalData.Flags Cleared_Difficulty_Mask = 7;
	public const GameUserGlobalData.Flags Cleared_Mode_Classic = 8;
	public const GameUserGlobalData.Flags Cleared_Mode_Casual = 16;
	public const GameUserGlobalData.Flags Cleared_Mode_Phoenix = 32;
	public const GameUserGlobalData.Flags Cleared_Mode_Mask = 56;
	public const GameUserGlobalData.Flags Cleared_Mask = 63;
}

// Namespace: 
public class GameUserGlobalData.FlagsField : BitFieldTemplate32<GameUserGlobalData.Flags> // TypeDefIndex: 13615
{
	// Methods

	// RVA: 0x22E9EC0 Offset: 0x22E9FC1 VA: 0x22E9EC0 Slot: 5
	protected override int ToInt(GameUserGlobalData.Flags value) { }

	// RVA: 0x22E9ED0 Offset: 0x22E9FD1 VA: 0x22E9ED0
	public void .ctor() { }
}


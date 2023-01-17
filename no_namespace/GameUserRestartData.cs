// Namespace: 
public class GameUserRestartData.RestartStream : Stream // TypeDefIndex: 13627
{
	// Fields
	public const int Version = 3;
	public const int MaxSize = 2097152;
	public const int MagicNumber = 539035145;

	// Methods

	// RVA: 0x22EB5B0 Offset: 0x22EB6B1 VA: 0x22EB5B0
	public void .ctor() { }

	// RVA: 0x22EB5C0 Offset: 0x22EB6C1 VA: 0x22EB5C0
	public ChapterData TryReadHeader() { }

	// RVA: 0x22EB750 Offset: 0x22EB851 VA: 0x22EB750
	public bool IsEnable() { }

	// RVA: 0x22EB770 Offset: 0x22EB871 VA: 0x22EB770
	public void Save() { }

	// RVA: 0x22EBA60 Offset: 0x22EBB61 VA: 0x22EBA60
	public bool Load(bool keepLevel, bool keepAchieve, bool completed) { }
}


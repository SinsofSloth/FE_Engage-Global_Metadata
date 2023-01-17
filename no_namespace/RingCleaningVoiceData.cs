// Namespace: 
public enum RingCleaningVoiceData.VoiceLabel // TypeDefIndex: 10049
{
	// Fields
	public int value__; // 0x0
	public const RingCleaningVoiceData.VoiceLabel Touch01 = 0;
	public const RingCleaningVoiceData.VoiceLabel Touch02 = 1;
	public const RingCleaningVoiceData.VoiceLabel Touch03 = 2;
	public const RingCleaningVoiceData.VoiceLabel Touch04 = 3;
	public const RingCleaningVoiceData.VoiceLabel Touch05 = 4;
	public const RingCleaningVoiceData.VoiceLabel Touch06 = 5;
	public const RingCleaningVoiceData.VoiceLabel Touch07 = 6;
	public const RingCleaningVoiceData.VoiceLabel Touch08 = 7;
	public const RingCleaningVoiceData.VoiceLabel Touch09 = 8;
	public const RingCleaningVoiceData.VoiceLabel Touch10 = 9;
	public const RingCleaningVoiceData.VoiceLabel Dirt01 = 10;
	public const RingCleaningVoiceData.VoiceLabel Dirt02 = 11;
	public const RingCleaningVoiceData.VoiceLabel Dirt03 = 12;
	public const RingCleaningVoiceData.VoiceLabel Thank01 = 13;
	public const RingCleaningVoiceData.VoiceLabel Thank02 = 14;
	public const RingCleaningVoiceData.VoiceLabel Thank03 = 15;
}

// Namespace: 
public enum RingCleaningVoiceData.Situation // TypeDefIndex: 10050
{
	// Fields
	public int value__; // 0x0
	public const RingCleaningVoiceData.Situation Start = 0;
	public const RingCleaningVoiceData.Situation CleanStronglyNotDirty = 1;
	public const RingCleaningVoiceData.Situation CleanDirty = 2;
	public const RingCleaningVoiceData.Situation CleanStronglyDiry = 3;
	public const RingCleaningVoiceData.Situation Finish = 4;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2764F0 Offset: 0x2765F1 VA: 0x2764F0
private sealed class RingCleaningVoiceData.<>c__DisplayClass26_0 // TypeDefIndex: 10051
{
	// Fields
	public bool isFinish; // 0x10
	public RingCleaningVoiceData.Situation situation; // 0x14
	public List<RingCleaningVoiceData> datas; // 0x18

	// Methods

	// RVA: 0x1F4AA00 Offset: 0x1F4AB01 VA: 0x1F4AA00
	public void .ctor() { }

	// RVA: 0x1F4AA10 Offset: 0x1F4AB11 VA: 0x1F4AA10
	internal void <GetRandomVoiceEvent>b__0(RingCleaningVoiceData data) { }
}


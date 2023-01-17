// Namespace: 
[FlagsAttribute] // RVA: 0x276140 Offset: 0x276241 VA: 0x276140
public enum EncountJobData.Flags // TypeDefIndex: 9886
{
	// Fields
	public int value__; // 0x0
	public const EncountJobData.Flags None = 0;
	public const EncountJobData.Flags CcRandomSelected = 1;
	public const EncountJobData.Flags Reserve = 2;
}

// Namespace: 
public sealed class EncountJobData.FlagField : BitFieldTemplate32<EncountJobData.Flags> // TypeDefIndex: 9887
{
	// Methods

	// RVA: 0x1F02BF0 Offset: 0x1F02CF1 VA: 0x1F02BF0
	public void .ctor(int f) { }

	// RVA: 0x1F02C50 Offset: 0x1F02D51 VA: 0x1F02C50
	public void .ctor(EncountJobData.Flags f) { }

	// RVA: 0x1F02CB0 Offset: 0x1F02DB1 VA: 0x1F02CB0 Slot: 5
	protected override int ToInt(EncountJobData.Flags value) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276150 Offset: 0x276251 VA: 0x276150
private sealed class EncountJobData.<>c__DisplayClass22_0 // TypeDefIndex: 9888
{
	// Fields
	public string jid; // 0x10
	public EncountJobData jobData; // 0x18

	// Methods

	// RVA: 0x1F02B90 Offset: 0x1F02C91 VA: 0x1F02B90
	public void .ctor() { }

	// RVA: 0x1F02BA0 Offset: 0x1F02CA1 VA: 0x1F02BA0
	internal void <GetFromJid>b__0(EncountJobData data) { }
}


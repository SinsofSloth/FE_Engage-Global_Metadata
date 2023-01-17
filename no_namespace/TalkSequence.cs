// Namespace: 
public enum TalkSequence.PlayMode // TypeDefIndex: 14135
{
	// Fields
	public int value__; // 0x0
	public const TalkSequence.PlayMode Manual = 0;
	public const TalkSequence.PlayMode AutoPlay = 1;
}

// Namespace: 
private enum TalkSequence.Label // TypeDefIndex: 14136
{
	// Fields
	public int value__; // 0x0
	public const TalkSequence.Label Load = 0;
	public const TalkSequence.Label FadeIn = 1;
	public const TalkSequence.Label SoundBefore = 2;
	public const TalkSequence.Label Main = 3;
	public const TalkSequence.Label SoundAfter = 4;
	public const TalkSequence.Label CheckContinue = 5;
	public const TalkSequence.Label Skip = 6;
	public const TalkSequence.Label Close = 7;
	public const TalkSequence.Label SkipWaitToEnd = 8;
	public const TalkSequence.Label End = 9;
}

// Namespace: 
private class TalkSequence.ReplaceText // TypeDefIndex: 14137
{
	// Fields
	private string m_Text; // 0x10
	private int m_Index; // 0x18

	// Properties
	public string Text { get; set; }
	public char CurrentCharacter { get; }

	// Methods

	// RVA: 0x238B3C0 Offset: 0x238B4C1 VA: 0x238B3C0
	public void set_Text(string value) { }

	// RVA: 0x238B400 Offset: 0x238B501 VA: 0x238B400
	public string get_Text() { }

	// RVA: 0x238B410 Offset: 0x238B511 VA: 0x238B410
	public void Next() { }

	// RVA: 0x238B420 Offset: 0x238B521 VA: 0x238B420
	public char get_CurrentCharacter() { }

	// RVA: 0x238B440 Offset: 0x238B541 VA: 0x238B440
	public bool NeedReplace() { }

	// RVA: 0x238B470 Offset: 0x238B571 VA: 0x238B470
	public void .ctor() { }
}


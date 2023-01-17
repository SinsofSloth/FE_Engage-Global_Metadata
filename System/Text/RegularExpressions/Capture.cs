// Namespace: System.Text.RegularExpressions
[Serializable]
public class Capture // TypeDefIndex: 2251
{
	// Fields
	internal string _text; // 0x10
	internal int _index; // 0x18
	internal int _length; // 0x1C

	// Properties
	public int Index { get; }
	public int Length { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1B48310 Offset: 0x1B48411 VA: 0x1B48310
	internal void .ctor(string text, int i, int l) { }

	// RVA: 0x1B48360 Offset: 0x1B48461 VA: 0x1B48360
	public int get_Index() { }

	// RVA: 0x1B48370 Offset: 0x1B48471 VA: 0x1B48370
	public int get_Length() { }

	// RVA: 0x1B48380 Offset: 0x1B48481 VA: 0x1B48380
	public string get_Value() { }

	// RVA: 0x1B483A0 Offset: 0x1B484A1 VA: 0x1B483A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B483C0 Offset: 0x1B484C1 VA: 0x1B483C0
	internal string GetOriginalString() { }

	// RVA: 0x1B483D0 Offset: 0x1B484D1 VA: 0x1B483D0
	internal string GetLeftSubstring() { }

	// RVA: 0x1B483F0 Offset: 0x1B484F1 VA: 0x1B483F0
	internal string GetRightSubstring() { }

	// RVA: 0x1B48410 Offset: 0x1B48511 VA: 0x1B48410
	internal void .ctor() { }
}


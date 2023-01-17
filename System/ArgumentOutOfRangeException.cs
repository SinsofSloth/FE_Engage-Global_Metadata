// Namespace: System
[ComVisibleAttribute] // RVA: 0x46FCC0 Offset: 0x46FDC1 VA: 0x46FCC0
[Serializable]
public class ArgumentOutOfRangeException : ArgumentException, ISerializable // TypeDefIndex: 167
{
	// Fields
	private static string _rangeMessage; // 0x0
	private object m_actualValue; // 0x90

	// Properties
	private static string RangeMessage { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x355F690 Offset: 0x355F791 VA: 0x355F690
	private static string get_RangeMessage() { }

	// RVA: 0x355F740 Offset: 0x355F841 VA: 0x355F740
	public void .ctor() { }

	// RVA: 0x355F7A0 Offset: 0x355F8A1 VA: 0x355F7A0
	public void .ctor(string paramName) { }

	// RVA: 0x35549F0 Offset: 0x3554AF1 VA: 0x35549F0
	public void .ctor(string paramName, string message) { }

	// RVA: 0x355F810 Offset: 0x355F911 VA: 0x355F810
	public void .ctor(string paramName, object actualValue, string message) { }

	// RVA: 0x355F890 Offset: 0x355F991 VA: 0x355F890 Slot: 5
	public override string get_Message() { }

	// RVA: 0x355F9C0 Offset: 0x355FAC1 VA: 0x355F9C0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x355FAF0 Offset: 0x355FBF1 VA: 0x355FAF0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}


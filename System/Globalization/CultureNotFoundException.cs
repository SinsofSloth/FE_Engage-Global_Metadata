// Namespace: System.Globalization
[ComVisibleAttribute] // RVA: 0x472E80 Offset: 0x472F81 VA: 0x472E80
[Serializable]
public class CultureNotFoundException : ArgumentException, ISerializable // TypeDefIndex: 685
{
	// Fields
	private string m_invalidCultureName; // 0x90
	private Nullable<int> m_invalidCultureId; // 0x98

	// Properties
	public virtual Nullable<int> InvalidCultureId { get; }
	public virtual string InvalidCultureName { get; }
	private static string DefaultMessage { get; }
	private string FormatedInvalidCultureId { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x37E2C60 Offset: 0x37E2D61 VA: 0x37E2C60
	public void .ctor() { }

	// RVA: 0x37DF660 Offset: 0x37DF761 VA: 0x37DF660
	public void .ctor(string paramName, string message) { }

	// RVA: 0x37E2D20 Offset: 0x37E2E21 VA: 0x37E2D20
	public void .ctor(string paramName, string invalidCultureName, string message) { }

	// RVA: 0x37E2D60 Offset: 0x37E2E61 VA: 0x37E2D60
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x37E2F20 Offset: 0x37E3021 VA: 0x37E2F20 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x37E30E0 Offset: 0x37E31E1 VA: 0x37E30E0 Slot: 18
	public virtual Nullable<int> get_InvalidCultureId() { }

	// RVA: 0x37E30F0 Offset: 0x37E31F1 VA: 0x37E30F0 Slot: 19
	public virtual string get_InvalidCultureName() { }

	// RVA: 0x37E2CD0 Offset: 0x37E2DD1 VA: 0x37E2CD0
	private static string get_DefaultMessage() { }

	// RVA: 0x37E3100 Offset: 0x37E3201 VA: 0x37E3100
	private string get_FormatedInvalidCultureId() { }

	// RVA: 0x37E32A0 Offset: 0x37E33A1 VA: 0x37E32A0 Slot: 5
	public override string get_Message() { }
}


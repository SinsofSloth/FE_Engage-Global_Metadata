// Namespace: UTJ
public class CSVBuilder // TypeDefIndex: 6406
{
	// Fields
	private StringBuilder builder; // 0x10
	private char separatorCharacter; // 0x18
	private string currentSeparator; // 0x20

	// Methods

	// RVA: 0x3106070 Offset: 0x3106171 VA: 0x3106070
	public void .ctor(char newSeparatorCharacter = '\x2c') { }

	// RVA: 0x3106120 Offset: 0x3106221 VA: 0x3106120
	public void Append(string item) { }

	// RVA: 0x3106260 Offset: 0x3106361 VA: 0x3106260
	public void Append(GameObject gameObject) { }

	// RVA: 0x31063C0 Offset: 0x31064C1 VA: 0x31063C0
	public void Append(object item) { }

	// RVA: 0x3106DF0 Offset: 0x3106EF1 VA: 0x3106DF0
	public void Append(Vector3 vector) { }

	// RVA: 0x31065D0 Offset: 0x31066D1 VA: 0x31065D0
	public void Append(Transform transform) { }

	// RVA: 0x3106EC0 Offset: 0x3106FC1 VA: 0x3106EC0
	public void Append(IEnumerable<string> list) { }

	// RVA: 0x3107140 Offset: 0x3107241 VA: 0x3107140
	public void AppendLine() { }

	// RVA: 0x31071B0 Offset: 0x31072B1 VA: 0x31071B0
	public void AppendLine(string item) { }

	// RVA: 0x3107220 Offset: 0x3107321 VA: 0x3107220
	public void AppendLine(IEnumerable<string> list) { }

	// RVA: 0x3107290 Offset: 0x3107391 VA: 0x3107290 Slot: 3
	public override string ToString() { }

	// RVA: 0x3106720 Offset: 0x3106821 VA: 0x3106720
	private void InternalAppend(Type itemType, object item) { }
}


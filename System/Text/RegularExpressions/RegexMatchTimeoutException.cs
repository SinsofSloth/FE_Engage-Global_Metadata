// Namespace: System.Text.RegularExpressions
[Serializable]
public class RegexMatchTimeoutException : TimeoutException, ISerializable // TypeDefIndex: 2268
{
	// Fields
	private string regexInput; // 0x88
	private string regexPattern; // 0x90
	private TimeSpan matchTimeout; // 0x98

	// Methods

	// RVA: 0x3C0FBD0 Offset: 0x3C0FCD1 VA: 0x3C0FBD0
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x3C0FD00 Offset: 0x3C0FE01 VA: 0x3C0FD00
	public void .ctor() { }

	// RVA: 0x3C0FE40 Offset: 0x3C0FF41 VA: 0x3C0FE40
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3C0FF90 Offset: 0x3C10091 VA: 0x3C0FF90 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x3C0FD90 Offset: 0x3C0FE91 VA: 0x3C0FD90
	private void Init() { }

	// RVA: 0x3C0FCB0 Offset: 0x3C0FDB1 VA: 0x3C0FCB0
	private void Init(string input, string pattern, TimeSpan timeout) { }
}


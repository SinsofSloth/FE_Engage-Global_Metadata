// Namespace: System.Net
public class Authorization // TypeDefIndex: 2448
{
	// Fields
	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	internal string ModuleAuthenticationType; // 0x20

	// Properties
	public string Message { get; }
	public bool Complete { get; }

	// Methods

	// RVA: 0x1B3FE70 Offset: 0x1B3FF71 VA: 0x1B3FE70
	public void .ctor(string token) { }

	// RVA: 0x1B3FF10 Offset: 0x1B40011 VA: 0x1B3FF10
	public void .ctor(string token, bool finished) { }

	// RVA: 0x1B3FFC0 Offset: 0x1B400C1 VA: 0x1B3FFC0
	public string get_Message() { }

	// RVA: 0x1B3FFD0 Offset: 0x1B400D1 VA: 0x1B3FFD0
	public bool get_Complete() { }
}


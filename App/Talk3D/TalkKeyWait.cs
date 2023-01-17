// Namespace: App.Talk3D
public class TalkKeyWait : ProcInst // TypeDefIndex: 14158
{
	// Fields
	private string m_Mid; // 0x70
	private string m_VoiceEventName; // 0x78
	private float m_WaitSecForAutoPlay; // 0x80
	private float m_waitCounter; // 0x84

	// Methods

	// RVA: 0x2C298C0 Offset: 0x2C299C1 VA: 0x2C298C0
	private void .ctor(string mid) { }

	// RVA: 0x2C2A1E0 Offset: 0x2C2A2E1 VA: 0x2C2A1E0 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x2C2A2A0 Offset: 0x2C2A3A1 VA: 0x2C2A2A0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2C2A470 Offset: 0x2C2A571 VA: 0x2C2A470
	protected void Tick() { }

	// RVA: 0x2C2A9C0 Offset: 0x2C2AAC1 VA: 0x2C2A9C0 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x2C2A9D0 Offset: 0x2C2AAD1 VA: 0x2C2A9D0
	public static TalkKeyWait CreateInstBind(ProcInst parent, string mid) { }
}


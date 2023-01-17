// Namespace: 
public class VolumeVoiceMenuItem : ConfigBasicMenuItem // TypeDefIndex: 7687
{
	// Fields
	private const string EventName = "V_SystemConfig";
	private const string UnitNameF = "PlayerF";
	private const string UnitNameM = "PlayerM";
	private const int PlayWaitFrame = 10;
	private Unit m_Hero; // 0x88
	private bool m_IsPlay; // 0x90
	private int m_WaitFrame; // 0x94

	// Methods

	// RVA: 0x26C6B50 Offset: 0x26C6C51 VA: 0x26C6B50
	public void .ctor() { }

	// RVA: 0x26C6D70 Offset: 0x26C6E71 VA: 0x26C6D70 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x26C6D80 Offset: 0x26C6E81 VA: 0x26C6D80 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x26C6D90 Offset: 0x26C6E91 VA: 0x26C6D90 Slot: 9
	public override void Tick() { }

	// RVA: 0x26C6FC0 Offset: 0x26C70C1 VA: 0x26C6FC0 Slot: 26
	public override BasicMenu.Result CustomCall() { }

	// RVA: 0x26C70F0 Offset: 0x26C71F1 VA: 0x26C70F0 Slot: 27
	public override void InitContent() { }

	// RVA: 0x26C6CE0 Offset: 0x26C6DE1 VA: 0x26C6CE0
	private void SetHelpText() { }
}


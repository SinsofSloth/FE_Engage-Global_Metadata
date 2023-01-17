// Namespace: App
public class PhotographSelectCharacterMenuItem : BasicMenuItem // TypeDefIndex: 11502
{
	// Fields
	private string m_CharacterId; // 0x68
	private bool m_IsCurrentCharacter; // 0x70
	private PhotographDisposManager m_DisposManager; // 0x78
	private PhotographPauseData m_PauseData; // 0x80
	private ItemData m_WeaponData; // 0x88

	// Properties
	public string CharacterId { get; }
	public bool IsCurrentCharacter { get; }

	// Methods

	// RVA: 0x2A35D70 Offset: 0x2A35E71 VA: 0x2A35D70
	public string get_CharacterId() { }

	// RVA: 0x2A35D80 Offset: 0x2A35E81 VA: 0x2A35D80
	public bool get_IsCurrentCharacter() { }

	// RVA: 0x2A35890 Offset: 0x2A35991 VA: 0x2A35890
	public void .ctor(string characterId, PhotographDisposManager disposManager, bool isCurrentCharacter) { }

	// RVA: 0x2A35D90 Offset: 0x2A35E91 VA: 0x2A35D90 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2A35DD0 Offset: 0x2A35ED1 VA: 0x2A35DD0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2A35DF0 Offset: 0x2A35EF1 VA: 0x2A35DF0 Slot: 19
	public override BasicMenu.Result BCall() { }
}


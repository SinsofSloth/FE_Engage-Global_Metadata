// Namespace: App
public class RelayUserData // TypeDefIndex: 12865
{
	// Fields
	public const int MaxEnteredBattle = 20;
	private const byte Version = 0;
	private List<RelayUserData.EnteredBattle> m_EnteredBattles; // 0x10

	// Properties
	public List<RelayUserData.EnteredBattle> EnteredBattles { get; }

	// Methods

	// RVA: 0x24C7A30 Offset: 0x24C7B31 VA: 0x24C7A30
	public void .ctor() { }

	// RVA: 0x24C7AC0 Offset: 0x24C7BC1 VA: 0x24C7AC0
	public void .ctor(RelayUserData from) { }

	// RVA: 0x24C7B60 Offset: 0x24C7C61 VA: 0x24C7B60
	public void AddEnteredBattle(RelayUserData.EnteredBattle newBattle) { }

	// RVA: 0x24C7B70 Offset: 0x24C7C71 VA: 0x24C7B70
	private void AddEnteredBattleImpl(RelayUserData.EnteredBattle newBattle) { }

	// RVA: 0x24C7CD0 Offset: 0x24C7DD1 VA: 0x24C7CD0
	public RelayUserData.EnteredBattle GetEnteredBattle(ulong dataId) { }

	// RVA: 0x24C7DB0 Offset: 0x24C7EB1 VA: 0x24C7DB0
	public void Clear() { }

	// RVA: 0x24C7E10 Offset: 0x24C7F11 VA: 0x24C7E10
	public void Serialize(Stream stream) { }

	// RVA: 0x24C7F50 Offset: 0x24C8051 VA: 0x24C7F50
	public void Deserialize(Stream stream) { }

	// RVA: 0x24C80F0 Offset: 0x24C81F1 VA: 0x24C80F0
	public List<RelayUserData.EnteredBattle> get_EnteredBattles() { }

	[ConditionalAttribute] // RVA: 0x2CA0C0 Offset: 0x2CA1C1 VA: 0x2CA0C0
	// RVA: 0x24C8100 Offset: 0x24C8201 VA: 0x24C8100
	public void DbgDump() { }
}


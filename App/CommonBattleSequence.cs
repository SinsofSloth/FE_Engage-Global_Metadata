// Namespace: App
public class CommonBattleSequence<T> : SingletonProcInst<T> // TypeDefIndex: 12974
{
	// Fields
	protected BattleInfo m_Info; // 0x0
	protected BattleInfo m_SimInfo; // 0x0
	protected BattleCalculator m_Calculator; // 0x0
	protected BattleCalculator m_SimCalculator; // 0x0
	protected CommonBattleSequence.RelianceList<T> m_Reliances; // 0x0

	// Properties
	protected override bool CanWaitSkip { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E4AA0 Offset: 0x30E4BA1 VA: 0x30E4AA0
	|-CommonBattleSequence<MapSequenceBattle>..ctor
	|-CommonBattleSequence<MapSequenceContract>..ctor
	|-CommonBattleSequence<MapSequenceDance>..ctor
	|-CommonBattleSequence<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected override bool get_CanWaitSkip() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E4C80 Offset: 0x30E4D81 VA: 0x30E4C80
	|-CommonBattleSequence<MapSequenceContract>.get_CanWaitSkip
	|-CommonBattleSequence<MapSequenceDance>.get_CanWaitSkip
	|-CommonBattleSequence<object>.get_CanWaitSkip
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void OnCreate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E4C90 Offset: 0x30E4D91 VA: 0x30E4C90
	|-CommonBattleSequence<MapSequenceBattle>.OnCreate
	|-CommonBattleSequence<MapSequenceContract>.OnCreate
	|-CommonBattleSequence<MapSequenceDance>.OnCreate
	|-CommonBattleSequence<object>.OnCreate
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void OnDispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E4E10 Offset: 0x30E4F11 VA: 0x30E4E10
	|-CommonBattleSequence<MapSequenceBattle>.OnDispose
	|-CommonBattleSequence<MapSequenceContract>.OnDispose
	|-CommonBattleSequence<MapSequenceDance>.OnDispose
	|-CommonBattleSequence<object>.OnDispose
	*/

	// RVA: -1 Offset: -1
	protected BattleInfoSide GetSide(BattleSide.Type side) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E4F90 Offset: 0x30E5091 VA: 0x30E4F90
	|-CommonBattleSequence<MapSequenceBattle>.GetSide
	|-CommonBattleSequence<MapSequenceDance>.GetSide
	|-CommonBattleSequence<object>.GetSide
	*/

	// RVA: -1 Offset: -1
	protected BattleInfoSide GetOffenseSide() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E4FF0 Offset: 0x30E50F1 VA: 0x30E4FF0
	|-CommonBattleSequence<MapSequenceBattle>.GetOffenseSide
	|-CommonBattleSequence<object>.GetOffenseSide
	*/

	// RVA: -1 Offset: -1
	protected BattleInfoSide GetDefenseSide() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E5010 Offset: 0x30E5111 VA: 0x30E5010
	|-CommonBattleSequence<MapSequenceBattle>.GetDefenseSide
	|-CommonBattleSequence<object>.GetDefenseSide
	*/

	// RVA: -1 Offset: -1
	protected Unit GetUnit(BattleSide.Type side) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E5030 Offset: 0x30E5131 VA: 0x30E5030
	|-CommonBattleSequence<MapSequenceBattle>.GetUnit
	|-CommonBattleSequence<object>.GetUnit
	*/

	// RVA: -1 Offset: -1
	protected Unit GetOffenseUnit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E50A0 Offset: 0x30E51A1 VA: 0x30E50A0
	|-CommonBattleSequence<MapSequenceBattle>.GetOffenseUnit
	|-CommonBattleSequence<object>.GetOffenseUnit
	*/

	// RVA: -1 Offset: -1
	protected Unit GetDefenseUnit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E50D0 Offset: 0x30E51D1 VA: 0x30E50D0
	|-CommonBattleSequence<MapSequenceBattle>.GetDefenseUnit
	|-CommonBattleSequence<object>.GetDefenseUnit
	*/

	// RVA: -1 Offset: -1
	protected BattleInfoSide GetWinSide() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E5100 Offset: 0x30E5201 VA: 0x30E5100
	|-CommonBattleSequence<object>.GetWinSide
	*/

	// RVA: -1 Offset: -1
	protected BattleInfoSide GetDeadSide() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E5240 Offset: 0x30E5341 VA: 0x30E5240
	|-CommonBattleSequence<MapSequenceBattle>.GetDeadSide
	|-CommonBattleSequence<object>.GetDeadSide
	*/

	// RVA: -1 Offset: -1
	protected bool IsEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E52A0 Offset: 0x30E53A1 VA: 0x30E52A0
	|-CommonBattleSequence<MapSequenceBattle>.IsEvent
	|-CommonBattleSequence<object>.IsEvent
	*/

	// RVA: -1 Offset: -1
	protected bool IsSkip() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E52B0 Offset: 0x30E53B1 VA: 0x30E52B0
	|-CommonBattleSequence<object>.IsSkip
	*/

	// RVA: -1 Offset: -1
	protected bool IsDead(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E52C0 Offset: 0x30E53C1 VA: 0x30E52C0
	|-CommonBattleSequence<MapSequenceBattle>.IsDead
	|-CommonBattleSequence<object>.IsDead
	*/

	// RVA: -1 Offset: -1
	private bool CanGainReliance(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E5330 Offset: 0x30E5431 VA: 0x30E5330
	|-CommonBattleSequence<object>.CanGainReliance
	*/

	// RVA: -1 Offset: -1
	protected void GainReliance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E53F0 Offset: 0x30E54F1 VA: 0x30E53F0
	|-CommonBattleSequence<MapSequenceBattle>.GainReliance
	|-CommonBattleSequence<MapSequenceContract>.GainReliance
	|-CommonBattleSequence<MapSequenceDance>.GainReliance
	|-CommonBattleSequence<object>.GainReliance
	*/

	// RVA: -1 Offset: -1
	protected void AddBattleReliance(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E56B0 Offset: 0x30E57B1 VA: 0x30E56B0
	|-CommonBattleSequence<MapSequenceBattle>.AddBattleReliance
	|-CommonBattleSequence<object>.AddBattleReliance
	*/

	// RVA: -1 Offset: -1
	protected void AddRodReliance(Unit unit, Unit target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E5A60 Offset: 0x30E5B61 VA: 0x30E5A60
	|-CommonBattleSequence<MapSequenceBattle>.AddRodReliance
	|-CommonBattleSequence<object>.AddRodReliance
	*/

	// RVA: -1 Offset: -1
	protected void AddDanceReliance(Unit unit, Unit target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E5B30 Offset: 0x30E5C31 VA: 0x30E5B30
	|-CommonBattleSequence<MapSequenceContract>.AddDanceReliance
	|-CommonBattleSequence<MapSequenceDance>.AddDanceReliance
	|-CommonBattleSequence<object>.AddDanceReliance
	*/

	// RVA: -1 Offset: -1 Slot: 22
	protected virtual bool CanGainSituation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E5C00 Offset: 0x30E5D01 VA: 0x30E5C00
	|-CommonBattleSequence<MapSequenceContract>.CanGainSituation
	|-CommonBattleSequence<MapSequenceDance>.CanGainSituation
	|-CommonBattleSequence<object>.CanGainSituation
	*/
}


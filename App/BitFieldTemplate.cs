// Namespace: App
public abstract class BitFieldTemplate32<T> : BitField32 // TypeDefIndex: 9176
{
	// Properties
	protected override Type ValueType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected override Type get_ValueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC010 Offset: 0x1DFC111 VA: 0x1DFC010
	|-BitFieldTemplate32<Int32Enum>.get_ValueType
	|-BitFieldTemplate32<BasicMenu.Status>.get_ValueType
	|-BitFieldTemplate32<BattleCalculator.Flags>.get_ValueType
	|-BitFieldTemplate32<BattleInfo.Flags>.get_ValueType
	|-BitFieldTemplate32<BattleInfoSide.Status>.get_ValueType
	|-BitFieldTemplate32<BattleScene.Result>.get_ValueType
	|-BitFieldTemplate32<ChartGodData.Flags>.get_ValueType
	|-BitFieldTemplate32<DisposData.AIFlags>.get_ValueType
	|-BitFieldTemplate32<DisposData.Flags>.get_ValueType
	|-BitFieldTemplate32<EncountJobData.Flags>.get_ValueType
	|-BitFieldTemplate32<FoodstuffData.Flags>.get_ValueType
	|-BitFieldTemplate32<GameUserData.Statuses>.get_ValueType
	|-BitFieldTemplate32<GameUserGlobalData.Flags>.get_ValueType
	|-BitFieldTemplate32<GodData.Flags>.get_ValueType
	|-BitFieldTemplate32<GodGrowthData.Flags>.get_ValueType
	|-BitFieldTemplate32<ItemData.Flags>.get_ValueType
	|-BitFieldTemplate32<JobData.Flags>.get_ValueType
	|-BitFieldTemplate32<KilledBonusData.Flags>.get_ValueType
	|-BitFieldTemplate32<MapCursor.Flag>.get_ValueType
	|-BitFieldTemplate32<MapMind.Done>.get_ValueType
	|-BitFieldTemplate32<MapSequenceBattle.Status>.get_ValueType
	|-BitFieldTemplate32<MapSituation.Status>.get_ValueType
	|-BitFieldTemplate32<PersonData.Flags>.get_ValueType
	|-BitFieldTemplate32<PhotographDisposInfo.Flags>.get_ValueType
	|-BitFieldTemplate32<Relay.Flags>.get_ValueType
	|-BitFieldTemplate32<RelayAwardData.Flags>.get_ValueType
	|-BitFieldTemplate32<RelayCompletionAwardData.Flags>.get_ValueType
	|-BitFieldTemplate32<RelayStampData.Flags>.get_ValueType
	|-BitFieldTemplate32<TasteData.Flags>.get_ValueType
	|-BitFieldTemplate32<UnitActor.Status>.get_ValueType
	|-BitFieldTemplate32<WeaponMask.Flag>.get_ValueType
	|-BitFieldTemplate32<GmapSequence.GmapFreeCameraSequence.DirFlag>.get_ValueType
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract int ToInt(T value);

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC090 Offset: 0x1DFC191 VA: 0x1DFC090
	|-BitFieldTemplate32<Int32Enum>..ctor
	|-BitFieldTemplate32<BasicMenu.Status>..ctor
	|-BitFieldTemplate32<BattleCalculator.Flags>..ctor
	|-BitFieldTemplate32<BattleInfo.Flags>..ctor
	|-BitFieldTemplate32<BattleInfoSide.Status>..ctor
	|-BitFieldTemplate32<BattleScene.Result>..ctor
	|-BitFieldTemplate32<ChartGodData.Flags>..ctor
	|-BitFieldTemplate32<DisposData.AIFlags>..ctor
	|-BitFieldTemplate32<DisposData.Flags>..ctor
	|-BitFieldTemplate32<EncountJobData.Flags>..ctor
	|-BitFieldTemplate32<FoodstuffData.Flags>..ctor
	|-BitFieldTemplate32<GameUserData.Statuses>..ctor
	|-BitFieldTemplate32<GameUserGlobalData.Flags>..ctor
	|-BitFieldTemplate32<GodData.Flags>..ctor
	|-BitFieldTemplate32<GodGrowthData.Flags>..ctor
	|-BitFieldTemplate32<ItemData.Flags>..ctor
	|-BitFieldTemplate32<JobData.Flags>..ctor
	|-BitFieldTemplate32<KilledBonusData.Flags>..ctor
	|-BitFieldTemplate32<MapCursor.Flag>..ctor
	|-BitFieldTemplate32<MapMind.Done>..ctor
	|-BitFieldTemplate32<MapSequenceBattle.Status>..ctor
	|-BitFieldTemplate32<MapSituation.Status>..ctor
	|-BitFieldTemplate32<PersonData.Flags>..ctor
	|-BitFieldTemplate32<PhotographDisposInfo.Flags>..ctor
	|-BitFieldTemplate32<Relay.Flags>..ctor
	|-BitFieldTemplate32<RelayAwardData.Flags>..ctor
	|-BitFieldTemplate32<RelayCompletionAwardData.Flags>..ctor
	|-BitFieldTemplate32<RelayStampData.Flags>..ctor
	|-BitFieldTemplate32<TasteData.Flags>..ctor
	|-BitFieldTemplate32<UnitActor.Status>..ctor
	|-BitFieldTemplate32<WeaponMask.Flag>..ctor
	|-BitFieldTemplate32<GmapSequence.GmapFreeCameraSequence.DirFlag>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Set(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC0C0 Offset: 0x1DFC1C1 VA: 0x1DFC0C0
	|-BitFieldTemplate32<Int32Enum>.Set
	|-BitFieldTemplate32<BasicMenu.Status>.Set
	|-BitFieldTemplate32<BattleCalculator.Flags>.Set
	|-BitFieldTemplate32<BattleInfo.Flags>.Set
	|-BitFieldTemplate32<BattleInfoSide.Status>.Set
	|-BitFieldTemplate32<GameUserData.Statuses>.Set
	|-BitFieldTemplate32<GameUserGlobalData.Flags>.Set
	|-BitFieldTemplate32<GodData.Flags>.Set
	|-BitFieldTemplate32<ItemData.Flags>.Set
	|-BitFieldTemplate32<MapCursor.Flag>.Set
	|-BitFieldTemplate32<MapMind.Done>.Set
	|-BitFieldTemplate32<MapSequenceBattle.Status>.Set
	|-BitFieldTemplate32<MapSituation.Status>.Set
	|-BitFieldTemplate32<PhotographDisposInfo.Flags>.Set
	|-BitFieldTemplate32<Relay.Flags>.Set
	|-BitFieldTemplate32<UnitActor.Status>.Set
	|-BitFieldTemplate32<GmapSequence.GmapFreeCameraSequence.DirFlag>.Set
	*/

	// RVA: -1 Offset: -1
	public void Clear(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC100 Offset: 0x1DFC201 VA: 0x1DFC100
	|-BitFieldTemplate32<Int32Enum>.Clear
	|-BitFieldTemplate32<BasicMenu.Status>.Clear
	|-BitFieldTemplate32<BattleCalculator.Flags>.Clear
	|-BitFieldTemplate32<BattleInfoSide.Status>.Clear
	|-BitFieldTemplate32<GameUserData.Statuses>.Clear
	|-BitFieldTemplate32<GameUserGlobalData.Flags>.Clear
	|-BitFieldTemplate32<MapCursor.Flag>.Clear
	|-BitFieldTemplate32<MapSequenceBattle.Status>.Clear
	|-BitFieldTemplate32<MapSituation.Status>.Clear
	|-BitFieldTemplate32<Relay.Flags>.Clear
	|-BitFieldTemplate32<UnitActor.Status>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Change(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC140 Offset: 0x1DFC241 VA: 0x1DFC140
	|-BitFieldTemplate32<Int32Enum>.Change
	*/

	// RVA: -1 Offset: -1
	public int Mask(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC180 Offset: 0x1DFC281 VA: 0x1DFC180
	|-BitFieldTemplate32<Int32Enum>.Mask
	|-BitFieldTemplate32<BattleInfoSide.Status>.Mask
	|-BitFieldTemplate32<MapSituation.Status>.Mask
	*/

	// RVA: -1 Offset: -1
	public bool Test(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC1B0 Offset: 0x1DFC2B1 VA: 0x1DFC1B0
	|-BitFieldTemplate32<Int32Enum>.Test
	|-BitFieldTemplate32<BasicMenu.Status>.Test
	|-BitFieldTemplate32<BattleCalculator.Flags>.Test
	|-BitFieldTemplate32<BattleInfo.Flags>.Test
	|-BitFieldTemplate32<BattleInfoSide.Status>.Test
	|-BitFieldTemplate32<BattleScene.Result>.Test
	|-BitFieldTemplate32<DisposData.AIFlags>.Test
	|-BitFieldTemplate32<DisposData.Flags>.Test
	|-BitFieldTemplate32<EncountJobData.Flags>.Test
	|-BitFieldTemplate32<FoodstuffData.Flags>.Test
	|-BitFieldTemplate32<GameUserData.Statuses>.Test
	|-BitFieldTemplate32<GameUserGlobalData.Flags>.Test
	|-BitFieldTemplate32<GodData.Flags>.Test
	|-BitFieldTemplate32<GodGrowthData.Flags>.Test
	|-BitFieldTemplate32<ItemData.Flags>.Test
	|-BitFieldTemplate32<JobData.Flags>.Test
	|-BitFieldTemplate32<MapCursor.Flag>.Test
	|-BitFieldTemplate32<MapMind.Done>.Test
	|-BitFieldTemplate32<MapSequenceBattle.Status>.Test
	|-BitFieldTemplate32<MapSituation.Status>.Test
	|-BitFieldTemplate32<PersonData.Flags>.Test
	|-BitFieldTemplate32<PhotographDisposInfo.Flags>.Test
	|-BitFieldTemplate32<Relay.Flags>.Test
	|-BitFieldTemplate32<RelayAwardData.Flags>.Test
	|-BitFieldTemplate32<RelayCompletionAwardData.Flags>.Test
	|-BitFieldTemplate32<RelayStampData.Flags>.Test
	|-BitFieldTemplate32<TasteData.Flags>.Test
	|-BitFieldTemplate32<UnitActor.Status>.Test
	|-BitFieldTemplate32<WeaponMask.Flag>.Test
	|-BitFieldTemplate32<GmapSequence.GmapFreeCameraSequence.DirFlag>.Test
	*/

	// RVA: -1 Offset: -1
	public bool Not(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC1F0 Offset: 0x1DFC2F1 VA: 0x1DFC1F0
	|-BitFieldTemplate32<Int32Enum>.Not
	|-BitFieldTemplate32<BasicMenu.Status>.Not
	|-BitFieldTemplate32<BattleCalculator.Flags>.Not
	|-BitFieldTemplate32<BattleInfo.Flags>.Not
	|-BitFieldTemplate32<BattleInfoSide.Status>.Not
	|-BitFieldTemplate32<DisposData.AIFlags>.Not
	|-BitFieldTemplate32<DisposData.Flags>.Not
	|-BitFieldTemplate32<GameUserData.Statuses>.Not
	|-BitFieldTemplate32<ItemData.Flags>.Not
	|-BitFieldTemplate32<JobData.Flags>.Not
	|-BitFieldTemplate32<KilledBonusData.Flags>.Not
	|-BitFieldTemplate32<MapSequenceBattle.Status>.Not
	|-BitFieldTemplate32<MapSituation.Status>.Not
	|-BitFieldTemplate32<PersonData.Flags>.Not
	|-BitFieldTemplate32<PhotographDisposInfo.Flags>.Not
	|-BitFieldTemplate32<Relay.Flags>.Not
	|-BitFieldTemplate32<UnitActor.Status>.Not
	*/

	// RVA: -1 Offset: -1
	public void Reset(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC230 Offset: 0x1DFC331 VA: 0x1DFC230
	|-BitFieldTemplate32<Int32Enum>.Reset
	|-BitFieldTemplate32<BattleInfo.Flags>.Reset
	|-BitFieldTemplate32<BattleScene.Result>.Reset
	|-BitFieldTemplate32<GameUserData.Statuses>.Reset
	*/

	// RVA: -1 Offset: -1
	public void SetOrClear(bool isSet, T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC260 Offset: 0x1DFC361 VA: 0x1DFC260
	|-BitFieldTemplate32<Int32Enum>.SetOrClear
	|-BitFieldTemplate32<BasicMenu.Status>.SetOrClear
	|-BitFieldTemplate32<GameUserData.Statuses>.SetOrClear
	|-BitFieldTemplate32<MapCursor.Flag>.SetOrClear
	|-BitFieldTemplate32<MapSituation.Status>.SetOrClear
	*/

	// RVA: -1 Offset: -1
	public bool Exclusive(T n, T m) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC2B0 Offset: 0x1DFC3B1 VA: 0x1DFC2B0
	|-BitFieldTemplate32<Int32Enum>.Exclusive
	|-BitFieldTemplate32<BattleInfoSide.Status>.Exclusive
	*/

	// RVA: -1 Offset: -1
	public void Serialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC310 Offset: 0x1DFC411 VA: 0x1DFC310
	|-BitFieldTemplate32<Int32Enum>.Serialize
	|-BitFieldTemplate32<GameUserGlobalData.Flags>.Serialize
	|-BitFieldTemplate32<WeaponMask.Flag>.Serialize
	*/

	// RVA: -1 Offset: -1
	public void Deserialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC330 Offset: 0x1DFC431 VA: 0x1DFC330
	|-BitFieldTemplate32<Int32Enum>.Deserialize
	|-BitFieldTemplate32<GameUserGlobalData.Flags>.Deserialize
	|-BitFieldTemplate32<WeaponMask.Flag>.Deserialize
	*/
}

// Namespace: App
public abstract class BitFieldTemplate64<T> : BitField64 // TypeDefIndex: 9177
{
	// Properties
	protected override Type ValueType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected override Type get_ValueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC370 Offset: 0x30BC471 VA: 0x30BC370
	|-BitFieldTemplate64<MapDeployTemplate.Flag<MapDeploy>>.get_ValueType
	|-BitFieldTemplate64<Int64Enum>.get_ValueType
	|-BitFieldTemplate64<Unit.Status>.get_ValueType
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract long ToLong(T value);

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC3F0 Offset: 0x30BC4F1 VA: 0x30BC3F0
	|-BitFieldTemplate64<MapDeployTemplate.Flag<MapDeploy>>..ctor
	|-BitFieldTemplate64<Int64Enum>..ctor
	|-BitFieldTemplate64<Unit.Status>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Set(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC420 Offset: 0x30BC521 VA: 0x30BC420
	|-BitFieldTemplate64<Int64Enum>.Set
	|-BitFieldTemplate64<Unit.Status>.Set
	*/

	// RVA: -1 Offset: -1
	public void Clear(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC460 Offset: 0x30BC561 VA: 0x30BC460
	|-BitFieldTemplate64<Int64Enum>.Clear
	|-BitFieldTemplate64<Unit.Status>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Change(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC4A0 Offset: 0x30BC5A1 VA: 0x30BC4A0
	|-BitFieldTemplate64<Int64Enum>.Change
	|-BitFieldTemplate64<Unit.Status>.Change
	*/

	// RVA: -1 Offset: -1
	public long Mask(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC4E0 Offset: 0x30BC5E1 VA: 0x30BC4E0
	|-BitFieldTemplate64<Int64Enum>.Mask
	|-BitFieldTemplate64<Unit.Status>.Mask
	*/

	// RVA: -1 Offset: -1
	public bool Test(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC510 Offset: 0x30BC611 VA: 0x30BC510
	|-BitFieldTemplate64<Int64Enum>.Test
	|-BitFieldTemplate64<Unit.Status>.Test
	*/

	// RVA: -1 Offset: -1
	public bool Not(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC550 Offset: 0x30BC651 VA: 0x30BC550
	|-BitFieldTemplate64<Int64Enum>.Not
	|-BitFieldTemplate64<Unit.Status>.Not
	*/

	// RVA: -1 Offset: -1
	public void Reset(T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC590 Offset: 0x30BC691 VA: 0x30BC590
	|-BitFieldTemplate64<Int64Enum>.Reset
	*/

	// RVA: -1 Offset: -1
	public void SetOrClear(bool isSet, T f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC5C0 Offset: 0x30BC6C1 VA: 0x30BC5C0
	|-BitFieldTemplate64<Int64Enum>.SetOrClear
	|-BitFieldTemplate64<Unit.Status>.SetOrClear
	*/

	// RVA: -1 Offset: -1
	public bool Exclusive(T n, T m) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC610 Offset: 0x30BC711 VA: 0x30BC610
	|-BitFieldTemplate64<Int64Enum>.Exclusive
	*/

	// RVA: -1 Offset: -1
	public void Serialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC670 Offset: 0x30BC771 VA: 0x30BC670
	|-BitFieldTemplate64<Int64Enum>.Serialize
	*/

	// RVA: -1 Offset: -1
	public void Deserialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC690 Offset: 0x30BC791 VA: 0x30BC690
	|-BitFieldTemplate64<Int64Enum>.Deserialize
	*/
}


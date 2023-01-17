// Namespace: Combat.SituationConverter
public abstract class BaseConverter // TypeDefIndex: 8871
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x284B00 Offset: 0x284C01 VA: 0x284B00
	private readonly CameraDataSet <DataSet>k__BackingField; // 0x10

	// Properties
	protected CameraDataSet DataSet { get; }
	protected bool IsFirstAttack { get; }
	protected bool IsPlayerAttack { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AD9D0 Offset: 0x2ADAD1 VA: 0x2AD9D0
	// RVA: 0x28EF830 Offset: 0x28EF931 VA: 0x28EF830
	protected CameraDataSet get_DataSet() { }

	// RVA: 0x28EF840 Offset: 0x28EF941 VA: 0x28EF840
	public void .ctor(CameraDataSet data) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract CameraPosition Convert(CameraSituation style, string arg);

	// RVA: 0x28EF880 Offset: 0x28EF981 VA: 0x28EF880
	protected bool get_IsFirstAttack() { }

	// RVA: 0x28EF8B0 Offset: 0x28EF9B1 VA: 0x28EF8B0
	protected bool get_IsPlayerAttack() { }

	// RVA: 0x28EF8E0 Offset: 0x28EF9E1 VA: 0x28EF8E0
	protected CameraPosition NameToPosition(string name) { }
}


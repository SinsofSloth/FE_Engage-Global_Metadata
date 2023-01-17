// Namespace: Combat.SituationConverter
public abstract class ConverterWithUt : BaseConverter // TypeDefIndex: 8872
{
	// Fields
	protected Character m_Chr; // 0x18
	protected Phase m_Phase; // 0x20
	public static int AtkSide; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x284B10 Offset: 0x284C11 VA: 0x284B10
	private static bool <IsOnDamage>k__BackingField; // 0x4
	private Nullable<bool> m_IsPlayerDragon; // 0x28
	private Nullable<bool> m_IsEnemyDragon; // 0x2A
	private static CameraPosition m_LastCam; // 0x8

	// Properties
	public static bool IsOnAttack { get; }
	public static bool IsOnDamage { get; set; }
	public bool IsPlayerDragon { get; }
	public bool IsEnemyDragon { get; }
	public CameraPosition FullFigureCamera { get; }
	public static bool IsFullFigure { get; }
	protected CameraPosition CurrentPosition { get; }

	// Methods

	// RVA: 0x23BEFD0 Offset: 0x23BF0D1 VA: 0x23BEFD0
	public static bool get_IsOnAttack() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD9E0 Offset: 0x2ADAE1 VA: 0x2AD9E0
	// RVA: 0x23BF030 Offset: 0x23BF131 VA: 0x23BF030
	public static bool get_IsOnDamage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD9F0 Offset: 0x2ADAF1 VA: 0x2AD9F0
	// RVA: 0x23BF080 Offset: 0x23BF181 VA: 0x23BF080
	private static void set_IsOnDamage(bool value) { }

	// RVA: 0x23BADA0 Offset: 0x23BAEA1 VA: 0x23BADA0
	public bool get_IsPlayerDragon() { }

	// RVA: 0x23BAE70 Offset: 0x23BAF71 VA: 0x23BAE70
	public bool get_IsEnemyDragon() { }

	// RVA: 0x23BC2A0 Offset: 0x23BC3A1 VA: 0x23BC2A0
	public CameraPosition get_FullFigureCamera() { }

	// RVA: 0x23BCFA0 Offset: 0x23BD0A1 VA: 0x23BCFA0
	public static bool get_IsFullFigure() { }

	// RVA: 0x23BF0E0 Offset: 0x23BF1E1 VA: 0x23BF0E0
	protected CameraPosition get_CurrentPosition() { }

	// RVA: 0x23BABD0 Offset: 0x23BACD1 VA: 0x23BABD0
	public void .ctor(CameraDataSet data) { }

	// RVA: 0x23BBE80 Offset: 0x23BBF81 VA: 0x23BBE80 Slot: 4
	public override CameraPosition Convert(CameraSituation situation, string arg) { }

	// RVA: 0x23BF0F0 Offset: 0x23BF1F1 VA: 0x23BF0F0 Slot: 5
	protected virtual CameraPosition OnBegin() { }

	// RVA: 0x23BF100 Offset: 0x23BF201 VA: 0x23BF100 Slot: 6
	protected virtual CameraPosition OnApproach() { }

	// RVA: 0x23BF110 Offset: 0x23BF211 VA: 0x23BF110 Slot: 7
	protected virtual CameraPosition OnAttack() { }

	// RVA: 0x23BF120 Offset: 0x23BF221 VA: 0x23BF120 Slot: 8
	protected virtual CameraPosition OnDamage() { }

	// RVA: 0x23BF130 Offset: 0x23BF231 VA: 0x23BF130 Slot: 9
	protected virtual CameraPosition OnUnusable() { }

	// RVA: 0x23BF140 Offset: 0x23BF241 VA: 0x23BF140 Slot: 10
	protected virtual CameraPosition OnEnd() { }
}


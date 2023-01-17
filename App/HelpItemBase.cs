// Namespace: App
public abstract class HelpItemBase : MonoBehaviour // TypeDefIndex: 11793
{
	// Fields
	private bool m_isTempGod; // 0x18
	private GodUnit m_tempGod; // 0x20
	private bool m_isTempRing; // 0x28
	private UnitRing m_tempRing; // 0x30
	private bool m_isTempUnit; // 0x38
	private Unit m_tempUnit; // 0x40
	[SerializeField] // RVA: 0x2992A0 Offset: 0x2993A1 VA: 0x2992A0
	private int m_startItemPriority; // 0x48
	[SerializeField] // RVA: 0x2992B0 Offset: 0x2993B1 VA: 0x2992B0
	private HelpManager.HelpItemType m_HelpItemType; // 0x4C

	// Properties
	public int StartItemPriority { get; }
	public virtual HelpManager.HelpItemType HelpItemType { get; }
	public virtual int StartItemConstPriority { get; }
	protected Unit CurrentUnit { get; }

	// Methods

	// RVA: 0x2DBB340 Offset: 0x2DBB441 VA: 0x2DBB340
	public int get_StartItemPriority() { }

	// RVA: 0x2DBB350 Offset: 0x2DBB451 VA: 0x2DBB350 Slot: 4
	public virtual HelpManager.HelpItemType get_HelpItemType() { }

	// RVA: 0x2DBB360 Offset: 0x2DBB461 VA: 0x2DBB360 Slot: 5
	public virtual int get_StartItemConstPriority() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetContents(HelpParamSetter setter);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool IsValid();

	// RVA: 0x2DBB370 Offset: 0x2DBB471 VA: 0x2DBB370
	protected Unit get_CurrentUnit() { }

	// RVA: 0x2DBB3F0 Offset: 0x2DBB4F1 VA: 0x2DBB3F0
	public void SetTempGod(bool isTempGod, GodUnit god) { }

	// RVA: 0x2DBB410 Offset: 0x2DBB511 VA: 0x2DBB410
	public bool IsTempGod() { }

	// RVA: 0x2DBB420 Offset: 0x2DBB521 VA: 0x2DBB420
	public GodUnit GetTempGod() { }

	// RVA: 0x2DBB430 Offset: 0x2DBB531 VA: 0x2DBB430
	public void SetTempRing(bool isTempRing, UnitRing ring) { }

	// RVA: 0x2DBB450 Offset: 0x2DBB551 VA: 0x2DBB450
	public bool IsTempRing() { }

	// RVA: 0x2DBB460 Offset: 0x2DBB561 VA: 0x2DBB460
	public UnitRing GetTempRing() { }

	// RVA: 0x2DBB470 Offset: 0x2DBB571 VA: 0x2DBB470
	public void SetTempUnit(bool isTempUnit, Unit unit) { }

	// RVA: 0x2DBB490 Offset: 0x2DBB591 VA: 0x2DBB490
	protected void .ctor() { }
}


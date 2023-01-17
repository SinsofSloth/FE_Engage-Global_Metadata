// Namespace: App
public class MyRoomWakeupSelectMenuItem : BasicMenuItem // TypeDefIndex: 11342
{
	// Fields
	private Unit m_UnitL; // 0x68
	private Unit m_UnitR; // 0x70
	private bool[,] m_OpenFlags; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x297B40 Offset: 0x297C41 VA: 0x297B40
	private bool <IsSelected>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x297B50 Offset: 0x297C51 VA: 0x297B50
	private bool <IsTalk>k__BackingField; // 0x81

	// Properties
	public bool IsSelected { get; set; }
	public bool IsTalk { get; set; }
	public MyRoomWakeupSelectRoot.CursorTop Cursor { get; }
	public bool IsBlank { get; }
	public bool IsAPlus { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C5010 Offset: 0x2C5111 VA: 0x2C5010
	// RVA: 0x2842EA0 Offset: 0x2842FA1 VA: 0x2842EA0
	public bool get_IsSelected() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5020 Offset: 0x2C5121 VA: 0x2C5020
	// RVA: 0x2842EB0 Offset: 0x2842FB1 VA: 0x2842EB0
	public void set_IsSelected(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5030 Offset: 0x2C5131 VA: 0x2C5030
	// RVA: 0x2842EC0 Offset: 0x2842FC1 VA: 0x2842EC0
	public bool get_IsTalk() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5040 Offset: 0x2C5141 VA: 0x2C5040
	// RVA: 0x2842ED0 Offset: 0x2842FD1 VA: 0x2842ED0
	private void set_IsTalk(bool value) { }

	// RVA: 0x2842EE0 Offset: 0x2842FE1 VA: 0x2842EE0
	public MyRoomWakeupSelectRoot.CursorTop get_Cursor() { }

	// RVA: 0x2842F90 Offset: 0x2843091 VA: 0x2842F90
	public bool get_IsBlank() { }

	// RVA: 0x2842FB0 Offset: 0x28430B1 VA: 0x2842FB0
	public bool get_IsAPlus() { }

	// RVA: 0x2842FF0 Offset: 0x28430F1 VA: 0x2842FF0
	public Color GetCommandColor() { }

	// RVA: 0x2843070 Offset: 0x2843171 VA: 0x2843070
	public bool CanStart(RelianceData.Level level, GameSound.WakeupVoicePattern pattern) { }

	// RVA: 0x28430C0 Offset: 0x28431C1 VA: 0x28430C0
	public int GetSortOrder() { }

	// RVA: 0x2843100 Offset: 0x2843201 VA: 0x2843100
	public int GetOpenCount() { }

	// RVA: 0x2841BC0 Offset: 0x2841CC1 VA: 0x2841BC0
	public void .ctor(Unit unitL, Unit unitR) { }

	// RVA: 0x28431B0 Offset: 0x28432B1 VA: 0x28431B0
	public void UpdateTalk() { }

	// RVA: 0x2843630 Offset: 0x2843731 VA: 0x2843630 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2843670 Offset: 0x2843771 VA: 0x2843670 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2843760 Offset: 0x2843861 VA: 0x2843760 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2841DA0 Offset: 0x2841EA1 VA: 0x2841DA0
	public void StartRankSelect(RelianceData.Level level, GameSound.WakeupVoicePattern pattern) { }

	// RVA: 0x2843A60 Offset: 0x2843B61 VA: 0x2843A60 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2843BB0 Offset: 0x2843CB1 VA: 0x2843BB0
	public Unit GetUnitL() { }

	// RVA: 0x2843BC0 Offset: 0x2843CC1 VA: 0x2843BC0
	public Unit GetUnitR() { }
}


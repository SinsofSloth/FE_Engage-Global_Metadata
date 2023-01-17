// Namespace: Combat.SituationConverter
public class ConvertChaseArrow : BaseConverter // TypeDefIndex: 8878
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x284B20 Offset: 0x284C21 VA: 0x284B20
	private bool <DoChase>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x284B30 Offset: 0x284C31 VA: 0x284B30
	private bool <IsEnd>k__BackingField; // 0x19
	private int m_ShootCount; // 0x1C

	// Properties
	private bool IsSecondAttack { get; }
	private bool DoChase { get; set; }
	private bool IsEnd { get; set; }

	// Methods

	// RVA: 0x23BBC60 Offset: 0x23BBD61 VA: 0x23BBC60
	private bool get_IsSecondAttack() { }

	// RVA: 0x23BBC90 Offset: 0x23BBD91 VA: 0x23BBC90
	public void .ctor(CameraDataSet data) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADA00 Offset: 0x2ADB01 VA: 0x2ADA00
	// RVA: 0x23BBCE0 Offset: 0x23BBDE1 VA: 0x23BBCE0
	private bool get_DoChase() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADA10 Offset: 0x2ADB11 VA: 0x2ADA10
	// RVA: 0x23BBCF0 Offset: 0x23BBDF1 VA: 0x23BBCF0
	private void set_DoChase(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADA20 Offset: 0x2ADB21 VA: 0x2ADA20
	// RVA: 0x23BBD00 Offset: 0x23BBE01 VA: 0x23BBD00
	private bool get_IsEnd() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADA30 Offset: 0x2ADB31 VA: 0x2ADA30
	// RVA: 0x23BBD10 Offset: 0x23BBE11 VA: 0x23BBD10
	private void set_IsEnd(bool value) { }

	// RVA: 0x23BBD20 Offset: 0x23BBE21 VA: 0x23BBD20 Slot: 4
	public override CameraPosition Convert(CameraSituation situation, string arg) { }
}


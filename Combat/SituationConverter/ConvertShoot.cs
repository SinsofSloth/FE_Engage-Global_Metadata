// Namespace: Combat.SituationConverter
public class ConvertShoot : ConverterWithUt // TypeDefIndex: 8889
{
	// Fields
	private readonly CameraPosition[] CameraList; // 0x30
	private int m_LastUnused; // 0x38

	// Methods

	// RVA: 0x23BE280 Offset: 0x23BE381 VA: 0x23BE280
	public void .ctor(CameraDataSet data) { }

	// RVA: 0x23BE330 Offset: 0x23BE431 VA: 0x23BE330 Slot: 5
	protected override CameraPosition OnBegin() { }

	// RVA: 0x23BE5D0 Offset: 0x23BE6D1 VA: 0x23BE5D0 Slot: 6
	protected override CameraPosition OnApproach() { }

	// RVA: 0x23BE7F0 Offset: 0x23BE8F1 VA: 0x23BE7F0 Slot: 8
	protected override CameraPosition OnDamage() { }

	// RVA: 0x23BE900 Offset: 0x23BEA01 VA: 0x23BE900 Slot: 9
	protected override CameraPosition OnUnusable() { }
}


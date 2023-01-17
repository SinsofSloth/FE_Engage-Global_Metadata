// Namespace: App
public class ChallengeMapSelectMenuItem : BasicMenuItem // TypeDefIndex: 9781
{
	// Fields
	protected ChallengeMapSelectMenu.SelectEventHandler m_SelectEventHandler; // 0x68
	protected ChallengeMapSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x70
	protected ChallengeMapSelectMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0x78
	private ChallengeData m_ChallengeData; // 0x80

	// Methods

	// RVA: 0x29B1150 Offset: 0x29B1251 VA: 0x29B1150
	public bool IsNew() { }

	// RVA: 0x29B1040 Offset: 0x29B1141 VA: 0x29B1040
	public void SawNewAccess() { }

	// RVA: 0x29B0D40 Offset: 0x29B0E41 VA: 0x29B0D40
	public void .ctor(ChallengeData challengeData, ChallengeMapSelectMenu.SelectEventHandler selectEventHandler, ChallengeMapSelectMenu.DecideEventHandler decideEventHandler, ChallengeMapSelectMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x29B1160 Offset: 0x29B1261 VA: 0x29B1160 Slot: 4
	public override string GetName() { }

	// RVA: 0x29B11D0 Offset: 0x29B12D1 VA: 0x29B11D0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x29B11F0 Offset: 0x29B12F1 VA: 0x29B11F0 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x29B1300 Offset: 0x29B1401 VA: 0x29B1300 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x29B1200 Offset: 0x29B1301 VA: 0x29B1200
	public void SetInitialColor() { }

	// RVA: 0x29B1450 Offset: 0x29B1551 VA: 0x29B1450 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x29B1490 Offset: 0x29B1591 VA: 0x29B1490 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x29B14E0 Offset: 0x29B15E1 VA: 0x29B14E0 Slot: 19
	public override BasicMenu.Result BCall() { }
}


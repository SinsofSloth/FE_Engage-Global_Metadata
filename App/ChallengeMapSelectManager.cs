// Namespace: App
public class ChallengeMapSelectManager // TypeDefIndex: 9776
{
	// Fields
	protected ChallengeMapSelectManager.ReturnEventHandler m_ReturnEventHandler; // 0x10
	private ChallengeMapSelectMenu m_Menu; // 0x18
	private ChallengeMapSelectRoot m_Root; // 0x20

	// Methods

	// RVA: 0x29B0180 Offset: 0x29B0281 VA: 0x29B0180
	public static ChallengeMapSelectManager Create(ProcInst super, ChallengeMapSelectRoot root, ChallengeData defaultChallengeData, ChallengeMapSelectManager.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x29B0250 Offset: 0x29B0351 VA: 0x29B0250
	private void .ctor(ProcInst super, ChallengeMapSelectRoot root, ChallengeData defaultChallengeData, ChallengeMapSelectManager.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x29B07C0 Offset: 0x29B08C1 VA: 0x29B07C0
	public void OnSelect(ChallengeData challengeData) { }

	// RVA: 0x29B0CD0 Offset: 0x29B0DD1 VA: 0x29B0CD0
	public void OnDecide(ChallengeData challengeData) { }

	// RVA: 0x29B0D20 Offset: 0x29B0E21 VA: 0x29B0D20
	public void OnRequestClose() { }
}


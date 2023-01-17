// Namespace: App
public class ChallengeDifficultyManager // TypeDefIndex: 9769
{
	// Fields
	private ChallengeDifficultyManager.ReturnEventHandler m_ReturnEventHandler; // 0x10
	private ChallengeDifficultyMenu m_Menu; // 0x18
	private ChallengeData m_ChallengeData; // 0x20
	private int m_Difficulty; // 0x28

	// Methods

	// RVA: 0x29AE1C0 Offset: 0x29AE2C1 VA: 0x29AE1C0
	public static ChallengeDifficultyManager Create(ProcInst super, ChallengeMapSelectRoot root, ChallengeData challengeData, ChallengeDifficultyManager.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x29AE290 Offset: 0x29AE391 VA: 0x29AE290
	private void .ctor(ProcInst super, ChallengeMapSelectRoot root, ChallengeData challengeData, ChallengeDifficultyManager.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x29AE550 Offset: 0x29AE651 VA: 0x29AE550
	public void OnDecide(int difficulty) { }

	// RVA: 0x29AE720 Offset: 0x29AE821 VA: 0x29AE720
	public void OnDecideYes() { }

	// RVA: 0x29AE770 Offset: 0x29AE871 VA: 0x29AE770
	public void OnRequestClose(int difficulty) { }
}


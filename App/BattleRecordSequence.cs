// Namespace: App
internal class BattleRecordSequence : SingletonProcInst<BattleRecordSequence> // TypeDefIndex: 12979
{
	// Fields
	private const string PrefabPath = "UI/Ending/Prefabs/BattleRecordRoot";
	private string m_BgmHeader; // 0x78
	private TResourceHandle<GameObject> m_PrefabHandle; // 0x80
	private BattleRecordSetter m_Setter; // 0x88
	private bool m_IsSkipped; // 0x90

	// Methods

	// RVA: 0x225C5D0 Offset: 0x225C6D1 VA: 0x225C5D0
	public static void CreateBind(ProcInst super, string bgmHeader) { }

	// RVA: 0x225CC70 Offset: 0x225CD71 VA: 0x225CC70
	private void LoadScene() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CA390 Offset: 0x2CA491 VA: 0x2CA390
	// RVA: 0x225CD70 Offset: 0x225CE71 VA: 0x225CD70
	private IEnumerator WaitLoad() { }

	// RVA: 0x225CDF0 Offset: 0x225CEF1 VA: 0x225CDF0
	private void Setup() { }

	// RVA: 0x225D360 Offset: 0x225D461 VA: 0x225D360
	private void Unload() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CA400 Offset: 0x2CA501 VA: 0x2CA400
	// RVA: 0x225D420 Offset: 0x225D521 VA: 0x225D420
	private IEnumerator Tick() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CA470 Offset: 0x2CA571 VA: 0x2CA470
	// RVA: 0x225D4A0 Offset: 0x225D5A1 VA: 0x225D4A0
	private IEnumerator FadeOut() { }

	// RVA: 0x225CBF0 Offset: 0x225CCF1 VA: 0x225CBF0
	public void .ctor() { }
}


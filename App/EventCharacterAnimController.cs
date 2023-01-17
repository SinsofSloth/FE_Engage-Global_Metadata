// Namespace: App
internal class EventCharacterAnimController : MonoBehaviour // TypeDefIndex: 10193
{
	// Fields
	private Character m_character; // 0x18
	private EventCharacterSimpleAnimation m_simpleAnimation; // 0x20
	private Animator m_animator; // 0x28
	private string m_curBodyAnimName; // 0x30
	private Dictionary<string, TResourceHandle<AnimationClip>> m_resHandleDictionary; // 0x38

	// Methods

	// RVA: 0x2606B60 Offset: 0x2606C61 VA: 0x2606B60
	public void .ctor() { }

	// RVA: 0x2606BF0 Offset: 0x2606CF1 VA: 0x2606BF0
	public void Init() { }

	// RVA: 0x2606D10 Offset: 0x2606E11 VA: 0x2606D10
	private void Update() { }

	// RVA: 0x2606D20 Offset: 0x2606E21 VA: 0x2606D20
	public void LoadBodyAnimAsync(string bodyAnimName) { }

	// RVA: 0x2606F00 Offset: 0x2607001 VA: 0x2606F00
	public bool IsLoadingBodyAnim(string bodyAnimName) { }

	// RVA: 0x2606ED0 Offset: 0x2606FD1 VA: 0x2606ED0
	public bool IsLoadedBodyAnim(string bodyAnimName) { }

	// RVA: 0x2606FA0 Offset: 0x26070A1 VA: 0x2606FA0
	public void PlayBodyAnim(string bodyAnimName, float fadeSec = 0) { }

	[IteratorStateMachineAttribute] // RVA: 0x2BD370 Offset: 0x2BD471 VA: 0x2BD370
	// RVA: 0x2607080 Offset: 0x2607181 VA: 0x2607080
	private IEnumerator Co_PlayBodyAnim(string bodyAnimName, float fadeSec) { }
}


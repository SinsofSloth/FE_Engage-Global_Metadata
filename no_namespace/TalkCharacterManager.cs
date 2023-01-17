// Namespace: 
public sealed class TalkCharacterManager.onLoad : MulticastDelegate // TypeDefIndex: 14119
{
	// Methods

	// RVA: 0x2057440 Offset: 0x2057541 VA: 0x2057440
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x20566F0 Offset: 0x20567F1 VA: 0x20566F0 Slot: 13
	public virtual void Invoke(string pid, string locationName) { }

	// RVA: 0x2057460 Offset: 0x2057561 VA: 0x2057460 Slot: 14
	public virtual IAsyncResult BeginInvoke(string pid, string locationName, AsyncCallback callback, object object) { }

	// RVA: 0x2057490 Offset: 0x2057591 VA: 0x2057490 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class TalkCharacterManager.ProcFadeInCharacter : ProcInst // TypeDefIndex: 14120
{
	// Fields
	private TalkCharacterController m_talkCharacterController; // 0x70
	private float m_fadeTime; // 0x78

	// Methods

	// RVA: 0x2056A60 Offset: 0x2056B61 VA: 0x2056A60
	private void .ctor(TalkCharacterController talkCharacterController, float fadeTime) { }

	// RVA: 0x2056AB0 Offset: 0x2056BB1 VA: 0x2056AB0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2056AC0 Offset: 0x2056BC1 VA: 0x2056AC0
	private void StartFadeInCharacter() { }

	// RVA: 0x2056BC0 Offset: 0x2056CC1 VA: 0x2056BC0
	private bool IsFadingCharacter() { }

	// RVA: 0x2056C60 Offset: 0x2056D61 VA: 0x2056C60
	public static void Create(ProcInst super, TalkCharacterController talkCharacterController, float fadeTime) { }
}

// Namespace: 
private class TalkCharacterManager.ProcFadeOutCharacter : ProcInst // TypeDefIndex: 14121
{
	// Fields
	private TalkCharacterController m_talkCharacterController; // 0x70
	private float m_fadeTime; // 0x78

	// Methods

	// RVA: 0x2056EC0 Offset: 0x2056FC1 VA: 0x2056EC0
	private void .ctor(TalkCharacterController talkCharacterController, float fadeTime) { }

	// RVA: 0x2056F10 Offset: 0x2057011 VA: 0x2056F10 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2057040 Offset: 0x2057141 VA: 0x2057040
	private void StartFadeOutCharacter() { }

	// RVA: 0x2057140 Offset: 0x2057241 VA: 0x2057140
	private bool IsFadingCharacter() { }

	// RVA: 0x2056F20 Offset: 0x2057021 VA: 0x2056F20
	private void DeleteCharacter() { }

	// RVA: 0x20571E0 Offset: 0x20572E1 VA: 0x20571E0
	public static void Create(ProcInst super, TalkCharacterController talkCharacterController, float fadeTime) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279780 Offset: 0x279881 VA: 0x279780
private sealed class TalkCharacterManager.<>c__DisplayClass27_0 // TypeDefIndex: 14122
{
	// Fields
	public Character chara; // 0x10

	// Methods

	// RVA: 0x2056560 Offset: 0x2056661 VA: 0x2056560
	public void .ctor() { }

	// RVA: 0x2056570 Offset: 0x2056671 VA: 0x2056570
	internal void <PreLoadCharacter>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279790 Offset: 0x279891 VA: 0x279790
private sealed class TalkCharacterManager.<>c__DisplayClass30_0 // TypeDefIndex: 14123
{
	// Fields
	public TalkCharacterManager <>4__this; // 0x10
	public string pid; // 0x18
	public string locationName; // 0x20
	public GameObject locator; // 0x28
	public TalkCharacterManager.onLoad callback; // 0x30
	public Character chr; // 0x38

	// Methods

	// RVA: 0x20565A0 Offset: 0x20566A1 VA: 0x20565A0
	public void .ctor() { }

	// RVA: 0x20565B0 Offset: 0x20566B1 VA: 0x20565B0
	internal void <CreateCharacterImpl>b__0() { }
}


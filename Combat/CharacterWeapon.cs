// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x274090 Offset: 0x274191 VA: 0x274090
public sealed class CharacterWeapon : MonoBehaviour // TypeDefIndex: 8658
{
	// Fields
	private Character _cp; // 0x18
	private const int Right = 0;
	private const int Left = 1;
	private const int NumHands = 2;
	private TrailHand[] m_Hands; // 0x20
	private CompositeDisposable m_Disposables; // 0x28

	// Properties
	private Character CP { get; }

	// Methods

	// RVA: 0x22BD860 Offset: 0x22BD961 VA: 0x22BD860
	private Character get_CP() { }

	// RVA: 0x22BD920 Offset: 0x22BDA21 VA: 0x22BD920
	private void Start() { }

	// RVA: 0x22BDA00 Offset: 0x22BDB01 VA: 0x22BDA00
	private void MyStart() { }

	// RVA: 0x22BE370 Offset: 0x22BE471 VA: 0x22BE370
	private void MyLateUpdate() { }

	// RVA: 0x22BE440 Offset: 0x22BE541 VA: 0x22BE440
	public static void Play(Character CP, string name, float duration) { }

	// RVA: 0x22BE6F0 Offset: 0x22BE7F1 VA: 0x22BE6F0
	public void Stop() { }

	// RVA: 0x22BE7D0 Offset: 0x22BE8D1 VA: 0x22BE7D0
	private void OnDestroy() { }

	// RVA: 0x22BE7E0 Offset: 0x22BE8E1 VA: 0x22BE7E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB9E0 Offset: 0x2ABAE1 VA: 0x2AB9E0
	// RVA: 0x22BE890 Offset: 0x22BE991 VA: 0x22BE890
	private void <Start>b__8_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB9F0 Offset: 0x2ABAF1 VA: 0x2AB9F0
	// RVA: 0x22BE8A0 Offset: 0x22BE9A1 VA: 0x22BE8A0
	private void <Start>b__8_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABA00 Offset: 0x2ABB01 VA: 0x2ABA00
	// RVA: 0x22BE630 Offset: 0x22BE731 VA: 0x22BE630
	internal static void <Play>g__ani|11_0(Animator a, ref CharacterWeapon.<>c__DisplayClass11_0 ) { }
}


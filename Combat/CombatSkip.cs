// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x274280 Offset: 0x274381 VA: 0x274280
public sealed class CombatSkip : MonoBehaviour // TypeDefIndex: 8697
{
	// Fields
	private CombatSkip.State state; // 0x18
	private bool isSoundSkipEnable; // 0x1C

	// Properties
	public bool IsSkipping { get; }
	public bool IsBlackout { get; }
	public bool IsWaiting { get; }
	public bool IsSkipped { get; }

	// Methods

	// RVA: 0x2570C90 Offset: 0x2570D91 VA: 0x2570C90
	private void NextState() { }

	// RVA: 0x2570CA0 Offset: 0x2570DA1 VA: 0x2570CA0
	public bool get_IsSkipping() { }

	// RVA: 0x2570CC0 Offset: 0x2570DC1 VA: 0x2570CC0
	public bool get_IsBlackout() { }

	// RVA: 0x2570CE0 Offset: 0x2570DE1 VA: 0x2570CE0
	public bool get_IsWaiting() { }

	// RVA: 0x2570CF0 Offset: 0x2570DF1 VA: 0x2570CF0
	public bool get_IsSkipped() { }

	// RVA: 0x2570D00 Offset: 0x2570E01 VA: 0x2570D00
	public void Enable() { }

	// RVA: 0x2570D20 Offset: 0x2570E21 VA: 0x2570D20
	public void Skip() { }

	// RVA: 0x2570D40 Offset: 0x2570E41 VA: 0x2570D40
	private bool IsInstantComeback(CombatRecord rec) { }

	// RVA: 0x2570DA0 Offset: 0x2570EA1 VA: 0x2570DA0
	private void InstantComeback() { }

	// RVA: 0x2570F20 Offset: 0x2571021 VA: 0x2570F20
	public void Disable() { }

	// RVA: 0x2570F40 Offset: 0x2571041 VA: 0x2570F40
	private void Start() { }

	// RVA: 0x2570F60 Offset: 0x2571061 VA: 0x2570F60
	private void OnDestroy() { }

	// RVA: 0x2570FF0 Offset: 0x25710F1 VA: 0x2570FF0
	private void Update() { }

	// RVA: 0x25711C0 Offset: 0x25712C1 VA: 0x25711C0
	private void Cleanup1() { }

	// RVA: 0x2571670 Offset: 0x2571771 VA: 0x2571670
	private void Cleanup2() { }

	// RVA: 0x2571C10 Offset: 0x2571D11 VA: 0x2571C10
	private static void CleanupHUDs(CombatWorld world) { }

	// RVA: 0x2571CA0 Offset: 0x2571DA1 VA: 0x2571CA0
	private static void SkipCharacters(CombatWorld world) { }

	// RVA: 0x2571A80 Offset: 0x2571B81 VA: 0x2571A80
	private void Cleanup4() { }

	// RVA: 0x25721A0 Offset: 0x25722A1 VA: 0x25721A0
	public void .ctor() { }
}


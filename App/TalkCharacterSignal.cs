// Namespace: App
public abstract class TalkCharacterSignal : MonoBehaviour // TypeDefIndex: 14057
{
	// Fields
	private Character _cp; // 0x18
	private StringBuilder sb; // 0x20
	private static readonly string FootStepLabel; // 0x0
	private static readonly string HubLabel; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x29D810 Offset: 0x29D911 VA: 0x29D810
	private bool <IsPlayer>k__BackingField; // 0x28

	// Properties
	private Character CP { get; }
	private bool IsPlayer { get; set; }

	// Methods

	// RVA: 0x2C28B50 Offset: 0x2C28C51 VA: 0x2C28B50
	private Character get_CP() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDC80 Offset: 0x2CDD81 VA: 0x2CDC80
	// RVA: 0x2C28C10 Offset: 0x2C28D11 VA: 0x2C28C10
	private bool get_IsPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDC90 Offset: 0x2CDD91 VA: 0x2CDC90
	// RVA: 0x2C28C20 Offset: 0x2C28D21 VA: 0x2C28C20
	private void set_IsPlayer(bool value) { }

	// RVA: 0x2C28C30 Offset: 0x2C28D31 VA: 0x2C28C30
	private void Start() { }

	// RVA: 0x2C28D00 Offset: 0x2C28E01 VA: 0x2C28D00
	private void GroundAttrDirt(StringBuilder sb, Vector3 pos) { }

	// RVA: 0x2C28F10 Offset: 0x2C29011 VA: 0x2C28F10
	private void 左足接地() { }

	// RVA: 0x2C29060 Offset: 0x2C29161 VA: 0x2C29060
	private void 右足接地() { }

	// RVA: 0x2C291B0 Offset: 0x2C292B1 VA: 0x2C291B0
	private void 羽ばたき() { }

	// RVA: 0x2C291C0 Offset: 0x2C292C1 VA: 0x2C291C0
	private void 音汎用(string strParam) { }

	// RVA: 0x2C292A0 Offset: 0x2C293A1 VA: 0x2C292A0
	private void 音ボイス() { }

	// RVA: 0x2C292B0 Offset: 0x2C293B1 VA: 0x2C292B0
	private void 武器軌跡始() { }

	// RVA: 0x2C292C0 Offset: 0x2C293C1 VA: 0x2C292C0
	private void 武器軌跡終() { }

	// RVA: 0x2C292D0 Offset: 0x2C293D1 VA: 0x2C292D0
	private void パーティクル(AnimationEvent ev) { }

	// RVA: 0x2C29320 Offset: 0x2C29421 VA: 0x2C29320
	public static void SetEnable(GameObject go, bool enabled) { }

	// RVA: 0x2C293A0 Offset: 0x2C294A1 VA: 0x2C293A0
	protected void .ctor() { }

	// RVA: 0x2C29420 Offset: 0x2C29521 VA: 0x2C29420
	private static void .cctor() { }
}


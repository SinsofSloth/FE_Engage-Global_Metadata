// Namespace: Combat
public abstract class MagicSub : MonoBehaviour // TypeDefIndex: 8788
{
	// Fields
	[HideInInspector] // RVA: 0x284550 Offset: 0x284651 VA: 0x284550
	public MagicBulletSettings BulletSettings; // 0x18
	[HideInInspector] // RVA: 0x284560 Offset: 0x284661 VA: 0x284560
	public MagicSignalTrack Trackヒット時処理; // 0x20
	[HideInInspector] // RVA: 0x284570 Offset: 0x284671 VA: 0x284570
	public MagicSignalTrack Trackミス時処理; // 0x28
	[HideInInspector] // RVA: 0x284580 Offset: 0x284681 VA: 0x284580
	public MagicSignalTrack Trackガード時処理; // 0x30
	[HideInInspector] // RVA: 0x284590 Offset: 0x284691 VA: 0x284590
	public MagicSignalTrack Trackパリィ時処理; // 0x38
	[HideInInspector] // RVA: 0x2845A0 Offset: 0x2846A1 VA: 0x2845A0
	public MagicSignalTrack Track衝突時処理; // 0x40
	[HideInInspector] // RVA: 0x2845B0 Offset: 0x2846B1 VA: 0x2845B0
	public MagicSignalTrack Track自然消滅処理; // 0x48

	// Methods

	// RVA: 0x1F974E0 Offset: 0x1F975E1 VA: 0x1F974E0
	public MagicSignalTrack Track(int i) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Setup(Character chr, in Vector3 initialStartPos, in Vector3 initialEndPos);

	// RVA: 0x1F97560 Offset: 0x1F97661 VA: 0x1F97560
	protected void ManualUpdate() { }

	// RVA: 0x1F97570 Offset: 0x1F97671 VA: 0x1F97570
	protected void .ctor() { }
}


// Namespace: Combat
internal class AutoCamera : AutoCameraBase // TypeDefIndex: 8523
{
	// Fields
	[RangeAttribute] // RVA: 0x27FF50 Offset: 0x280051 VA: 0x27FF50
	[HeaderAttribute] // RVA: 0x27FF50 Offset: 0x280051 VA: 0x27FF50
	public float BirdsViewRatio; // 0xD8
	[HeaderAttribute] // RVA: 0x27FFB0 Offset: 0x2800B1 VA: 0x27FFB0
	[RangeAttribute] // RVA: 0x27FFB0 Offset: 0x2800B1 VA: 0x27FFB0
	public float DeltaLongitudeScale; // 0xDC
	[RangeAttribute] // RVA: 0x280010 Offset: 0x280111 VA: 0x280010
	[HeaderAttribute] // RVA: 0x280010 Offset: 0x280111 VA: 0x280010
	public float DeltaLatitudeScale; // 0xE0
	private float m_Time; // 0xE4
	private float m_DeltaLongitude; // 0xE8
	private float m_DeltaLatitude; // 0xEC
	private bool m_IsBirdsView; // 0xF0

	// Methods

	// RVA: 0x2610120 Offset: 0x2610221 VA: 0x2610120
	private static float rr(float r) { }

	// RVA: 0x2610150 Offset: 0x2610251 VA: 0x2610150
	private void Init() { }

	// RVA: 0x2610690 Offset: 0x2610791 VA: 0x2610690
	public void ChangeCut() { }

	// RVA: 0x2610A00 Offset: 0x2610B01 VA: 0x2610A00 Slot: 13
	protected override void Tick() { }

	// RVA: 0x2610E00 Offset: 0x2610F01 VA: 0x2610E00 Slot: 10
	public override void Activate() { }

	// RVA: 0x2610C70 Offset: 0x2610D71 VA: 0x2610C70
	private void UpdateMove() { }

	// RVA: 0x2610D50 Offset: 0x2610E51 VA: 0x2610D50
	private bool Clamp() { }

	// RVA: 0x2610640 Offset: 0x2610741 VA: 0x2610640
	private static bool IsOut(float longitude, float latitude) { }

	// RVA: 0x2610CD0 Offset: 0x2610DD1 VA: 0x2610CD0
	private static bool InRedZone(float longitude, float latitude) { }

	// RVA: 0x2610EA0 Offset: 0x2610FA1 VA: 0x2610EA0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9420 Offset: 0x2A9521 VA: 0x2A9420
	// RVA: 0x2610D20 Offset: 0x2610E21 VA: 0x2610D20
	internal static float <Tick>g__abssub|10_0(float value, float sub) { }
}


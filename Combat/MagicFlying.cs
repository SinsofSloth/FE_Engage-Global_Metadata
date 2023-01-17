// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x2746D0 Offset: 0x2747D1 VA: 0x2746D0
internal sealed class MagicFlying : MonoBehaviour // TypeDefIndex: 8779
{
	// Fields
	private Vector3 m_StartPos; // 0x18
	private Vector3 m_EndPos; // 0x24
	private float m_Time; // 0x30
	private float m_ArrivalTime; // 0x34
	private Curve.Type easeType; // 0x38
	private int easePower; // 0x3C

	// Methods

	// RVA: 0x1F93810 Offset: 0x1F93911 VA: 0x1F93810
	public void SetEase(Curve.Type easeType, int easePower) { }

	// RVA: 0x1F94710 Offset: 0x1F94811 VA: 0x1F94710
	public void Shoot(in Vector3 startPos, in Vector3 endPos, float arrivalTime) { }

	// RVA: 0x1F94810 Offset: 0x1F94911 VA: 0x1F94810
	public void Stop() { }

	// RVA: 0x1F94820 Offset: 0x1F94921 VA: 0x1F94820
	public void ChangeStartEndPos(Vector3 startPos, Vector3 endPos) { }

	// RVA: 0x1F94880 Offset: 0x1F94981 VA: 0x1F94880
	private void Update() { }

	// RVA: 0x1F94950 Offset: 0x1F94A51 VA: 0x1F94950
	public void SetPositionToEnd_IfUnShoot(Vector3 targetPos) { }

	// RVA: 0x1F949D0 Offset: 0x1F94AD1 VA: 0x1F949D0
	public void .ctor() { }
}


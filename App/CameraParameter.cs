// Namespace: App
internal struct CameraParameter // TypeDefIndex: 14079
{
	// Fields
	public Vector3 position; // 0x0
	public Vector3 eulerAngles; // 0xC
	public float fieldOfView; // 0x18

	// Methods

	// RVA: 0x29A5720 Offset: 0x29A5821 VA: 0x29A5720
	public void CopyFrom(Camera camera) { }

	// RVA: 0x29A57F0 Offset: 0x29A58F1 VA: 0x29A57F0
	public void CopyTo(Camera camera) { }

	// RVA: 0x29A58C0 Offset: 0x29A59C1 VA: 0x29A58C0
	public void CopyFrom(CameraParameter param) { }

	// RVA: 0x29A58F0 Offset: 0x29A59F1 VA: 0x29A58F0
	public Vector3 GetForward() { }

	// RVA: 0x29A5920 Offset: 0x29A5A21 VA: 0x29A5920
	public Vector3 GetSide() { }

	// RVA: 0x29A5950 Offset: 0x29A5A51 VA: 0x29A5950
	public Vector3 GetUp() { }
}


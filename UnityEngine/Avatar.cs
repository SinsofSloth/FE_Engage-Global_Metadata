// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x34C00 Offset: 0x34D01 VA: 0x34C00
[NativeHeaderAttribute] // RVA: 0x34C00 Offset: 0x34D01 VA: 0x34C00
public class Avatar : Object // TypeDefIndex: 4105
{
	// Properties
	public bool isValid { get; }
	public bool isHuman { get; }
	public HumanDescription humanDescription { get; }

	// Methods

	// RVA: 0x3EDD160 Offset: 0x3EDD261 VA: 0x3EDD160
	private void .ctor() { }

	[NativeMethodAttribute] // RVA: 0x382C0 Offset: 0x383C1 VA: 0x382C0
	// RVA: 0x3EDD1D0 Offset: 0x3EDD2D1 VA: 0x3EDD1D0
	public bool get_isValid() { }

	[NativeMethodAttribute] // RVA: 0x38300 Offset: 0x38401 VA: 0x38300
	// RVA: 0x3EDD220 Offset: 0x3EDD321 VA: 0x3EDD220
	public bool get_isHuman() { }

	// RVA: 0x3EDD270 Offset: 0x3EDD371 VA: 0x3EDD270
	public HumanDescription get_humanDescription() { }

	// RVA: 0x3EDD350 Offset: 0x3EDD451 VA: 0x3EDD350
	internal void SetMuscleMinMax(int muscleId, float min, float max) { }

	// RVA: 0x3EDD3C0 Offset: 0x3EDD4C1 VA: 0x3EDD3C0
	internal void SetParameter(int parameterId, float value) { }

	// RVA: 0x3EDD420 Offset: 0x3EDD521 VA: 0x3EDD420
	internal float GetAxisLength(int humanId) { }

	// RVA: 0x3EDD4F0 Offset: 0x3EDD5F1 VA: 0x3EDD4F0
	internal Quaternion GetPreRotation(int humanId) { }

	// RVA: 0x3EDD600 Offset: 0x3EDD701 VA: 0x3EDD600
	internal Quaternion GetPostRotation(int humanId) { }

	// RVA: 0x3EDD710 Offset: 0x3EDD811 VA: 0x3EDD710
	internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) { }

	// RVA: 0x3EDD890 Offset: 0x3EDD991 VA: 0x3EDD890
	internal Quaternion GetZYRoll(int humanId, Vector3 uvw) { }

	// RVA: 0x3EDD9D0 Offset: 0x3EDDAD1 VA: 0x3EDD9D0
	internal Vector3 GetLimitSign(int humanId) { }

	[NativeMethodAttribute] // RVA: 0x38340 Offset: 0x38441 VA: 0x38340
	// RVA: 0x3EDD4A0 Offset: 0x3EDD5A1 VA: 0x3EDD4A0
	internal float Internal_GetAxisLength(int humanId) { }

	[NativeMethodAttribute] // RVA: 0x38380 Offset: 0x38481 VA: 0x38380
	// RVA: 0x3EDD590 Offset: 0x3EDD691 VA: 0x3EDD590
	internal Quaternion Internal_GetPreRotation(int humanId) { }

	[NativeMethodAttribute] // RVA: 0x383C0 Offset: 0x384C1 VA: 0x383C0
	// RVA: 0x3EDD6A0 Offset: 0x3EDD7A1 VA: 0x3EDD6A0
	internal Quaternion Internal_GetPostRotation(int humanId) { }

	[NativeMethodAttribute] // RVA: 0x38400 Offset: 0x38501 VA: 0x38400
	// RVA: 0x3EDD800 Offset: 0x3EDD901 VA: 0x3EDD800
	internal Quaternion Internal_GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) { }

	[NativeMethodAttribute] // RVA: 0x38440 Offset: 0x38541 VA: 0x38440
	// RVA: 0x3EDD950 Offset: 0x3EDDA51 VA: 0x3EDD950
	internal Quaternion Internal_GetZYRoll(int humanId, Vector3 uvw) { }

	[NativeMethodAttribute] // RVA: 0x38480 Offset: 0x38581 VA: 0x38480
	// RVA: 0x3EDDA70 Offset: 0x3EDDB71 VA: 0x3EDDA70
	internal Vector3 Internal_GetLimitSign(int humanId) { }

	// RVA: 0x3EDD300 Offset: 0x3EDD401 VA: 0x3EDD300
	private void get_humanDescription_Injected(out HumanDescription ret) { }

	// RVA: 0x3EDDAE0 Offset: 0x3EDDBE1 VA: 0x3EDDAE0
	private void Internal_GetPreRotation_Injected(int humanId, out Quaternion ret) { }

	// RVA: 0x3EDDB40 Offset: 0x3EDDC41 VA: 0x3EDDB40
	private void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret) { }

	// RVA: 0x3EDDBA0 Offset: 0x3EDDCA1 VA: 0x3EDDBA0
	private void Internal_GetZYPostQ_Injected(int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion ret) { }

	// RVA: 0x3EDDC10 Offset: 0x3EDDD11 VA: 0x3EDDC10
	private void Internal_GetZYRoll_Injected(int humanId, ref Vector3 uvw, out Quaternion ret) { }

	// RVA: 0x3EDDC80 Offset: 0x3EDDD81 VA: 0x3EDDC80
	private void Internal_GetLimitSign_Injected(int humanId, out Vector3 ret) { }
}


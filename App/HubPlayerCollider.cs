// Namespace: App
public class HubPlayerCollider : MonoBehaviour // TypeDefIndex: 10774
{
	// Fields
	public bool m_isFront; // 0x18
	public HubPlayerController m_Notification; // 0x20
	public Queue<Collider> m_EnterColliders; // 0x28
	public Queue<Collider> m_ExitColliders; // 0x30

	// Methods

	// RVA: 0x28BA300 Offset: 0x28BA401 VA: 0x28BA300
	public void SetHubPlayerController(HubPlayerController hpc) { }

	// RVA: 0x28BA310 Offset: 0x28BA411 VA: 0x28BA310
	private bool IsTarget(Collider other) { }

	// RVA: 0x28BA440 Offset: 0x28BA541 VA: 0x28BA440
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x28BA4E0 Offset: 0x28BA5E1 VA: 0x28BA4E0
	private void CallTriggerEnter(Collider other) { }

	// RVA: 0x28BA800 Offset: 0x28BA901 VA: 0x28BA800
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x28BA8A0 Offset: 0x28BA9A1 VA: 0x28BA8A0
	private void CallTriggerExit(Collider other) { }

	// RVA: 0x28BABC0 Offset: 0x28BACC1 VA: 0x28BABC0
	public void Clear() { }

	// RVA: 0x28BAC80 Offset: 0x28BAD81 VA: 0x28BAC80
	public void Polling() { }

	// RVA: 0x28BAD40 Offset: 0x28BAE41 VA: 0x28BAD40
	public void .ctor() { }
}


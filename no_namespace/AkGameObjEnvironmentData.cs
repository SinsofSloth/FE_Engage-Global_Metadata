// Namespace: 
public class AkGameObjEnvironmentData // TypeDefIndex: 8024
{
	// Fields
	private readonly List<AkEnvironment> activeEnvironments; // 0x10
	private readonly List<AkEnvironment> activeEnvironmentsFromPortals; // 0x18
	private readonly List<AkEnvironmentPortal> activePortals; // 0x20
	private readonly AkAuxSendArray auxSendValues; // 0x28
	private Vector3 lastPosition; // 0x30
	private bool hasEnvironmentListChanged; // 0x3C
	private bool hasActivePortalListChanged; // 0x3D
	private bool hasSentZero; // 0x3E

	// Methods

	// RVA: 0x3176990 Offset: 0x3176A91 VA: 0x3176990
	private void AddHighestPriorityEnvironmentsFromPortals(Vector3 position) { }

	// RVA: 0x3176D20 Offset: 0x3176E21 VA: 0x3176D20
	private void AddHighestPriorityEnvironments(Vector3 position) { }

	// RVA: 0x3175F10 Offset: 0x3176011 VA: 0x3175F10
	public void UpdateAuxSend(GameObject gameObject, Vector3 position) { }

	// RVA: 0x3176E40 Offset: 0x3176F41 VA: 0x3176E40
	private void TryAddEnvironment(AkEnvironment env) { }

	// RVA: 0x3176FB0 Offset: 0x31770B1 VA: 0x3176FB0
	private void RemoveEnvironment(AkEnvironment env) { }

	// RVA: 0x3175DD0 Offset: 0x3175ED1 VA: 0x3175DD0
	public void AddAkEnvironment(Collider environmentCollider, Collider gameObjectCollider) { }

	// RVA: 0x3177030 Offset: 0x3177131 VA: 0x3177030
	private bool AkEnvironmentBelongsToActivePortals(AkEnvironment env) { }

	// RVA: 0x3176460 Offset: 0x3176561 VA: 0x3176460
	public void RemoveAkEnvironment(Collider environmentCollider, Collider gameObjectCollider) { }

	// RVA: 0x3175C70 Offset: 0x3175D71 VA: 0x3175C70
	public void .ctor() { }
}


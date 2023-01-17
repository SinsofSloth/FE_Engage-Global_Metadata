// Namespace: 
[Serializable]
private class SignalReceiver.EventKeyValue // TypeDefIndex: 5671
{
	// Fields
	[SerializeField] // RVA: 0x57D20 Offset: 0x57E21 VA: 0x57D20
	private List<SignalAsset> m_Signals; // 0x10
	[CustomSignalEventDrawer] // RVA: 0x57D30 Offset: 0x57E31 VA: 0x57D30
	[SerializeField] // RVA: 0x57D30 Offset: 0x57E31 VA: 0x57D30
	private List<UnityEvent> m_Events; // 0x18

	// Properties
	public List<SignalAsset> signals { get; }
	public List<UnityEvent> events { get; }

	// Methods

	// RVA: 0x36A8EA0 Offset: 0x36A8FA1 VA: 0x36A8EA0
	public bool TryGetValue(SignalAsset key, out UnityEvent value) { }

	// RVA: 0x36A9100 Offset: 0x36A9201 VA: 0x36A9100
	public void Append(SignalAsset key, UnityEvent value) { }

	// RVA: 0x36A97D0 Offset: 0x36A98D1 VA: 0x36A97D0
	public void Remove(int idx) { }

	// RVA: 0x36A9310 Offset: 0x36A9411 VA: 0x36A9310
	public void Remove(SignalAsset key) { }

	// RVA: 0x36B94F0 Offset: 0x36B95F1 VA: 0x36B94F0
	public List<SignalAsset> get_signals() { }

	// RVA: 0x36B9500 Offset: 0x36B9601 VA: 0x36B9500
	public List<UnityEvent> get_events() { }

	// RVA: 0x36A9B40 Offset: 0x36A9C41 VA: 0x36A9B40
	public void .ctor() { }
}


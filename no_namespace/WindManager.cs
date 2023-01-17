// Namespace: 
public abstract class WindManager : SingletonMonoBehaviour<WindManager> // TypeDefIndex: 7768
{
	// Fields
	public GameObject m_Actor; // 0x20
	public GameObject m_Sampler; // 0x28
	private List<WindActor> m_Actors; // 0x30

	// Methods

	// RVA: 0x26D8620 Offset: 0x26D8721 VA: 0x26D8620
	private void Start() { }

	// RVA: 0x26D8630 Offset: 0x26D8731 VA: 0x26D8630
	private void Update() { }

	// RVA: 0x26D8640 Offset: 0x26D8741 VA: 0x26D8640
	private Vector3 Calculate(Vector3 pos) { }

	// RVA: 0x26D8760 Offset: 0x26D8861 VA: 0x26D8760
	public static Vector3 GetWind(Vector3 pos) { }

	// RVA: 0x26D8890 Offset: 0x26D8991 VA: 0x26D8890
	public WindActor CreateActor() { }

	// RVA: 0x26D8930 Offset: 0x26D8A31 VA: 0x26D8930
	public WindSampler CreateSampler() { }

	// RVA: 0x26D89D0 Offset: 0x26D8AD1 VA: 0x26D89D0
	public static WindActor TryCreateActor() { }

	// RVA: 0x26D8AD0 Offset: 0x26D8BD1 VA: 0x26D8AD0
	private void OnValidate() { }

	// RVA: 0x26D8370 Offset: 0x26D8471 VA: 0x26D8370
	public static void Attach(WindActor actor) { }

	// RVA: 0x26D84A0 Offset: 0x26D85A1 VA: 0x26D84A0
	public static void Detach(WindActor actor) { }

	// RVA: 0x26D8AE0 Offset: 0x26D8BE1 VA: 0x26D8AE0
	protected void .ctor() { }
}


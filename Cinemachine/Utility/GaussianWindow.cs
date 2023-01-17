// Namespace: Cinemachine.Utility
internal abstract class GaussianWindow1d<T> // TypeDefIndex: 5899
{
	// Fields
	protected T[] mData; // 0x0
	protected float[] mKernel; // 0x0
	protected int mCurrentPos; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x23440 Offset: 0x23541 VA: 0x23440
	private float <Sigma>k__BackingField; // 0x0

	// Properties
	public float Sigma { get; set; }
	public int KernelSize { get; }
	public int BufferLength { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x240D0 Offset: 0x241D1 VA: 0x240D0
	// RVA: -1 Offset: -1
	public float get_Sigma() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8DDE0 Offset: 0x1E8DEE1 VA: 0x1E8DDE0
	|-GaussianWindow1d<object>.get_Sigma
	|
	|-RVA: 0x1E8E3A0 Offset: 0x1E8E4A1 VA: 0x1E8E3A0
	|-GaussianWindow1d<Quaternion>.get_Sigma
	|
	|-RVA: 0x1E8E9B0 Offset: 0x1E8EAB1 VA: 0x1E8E9B0
	|-GaussianWindow1d<Vector2>.get_Sigma
	|
	|-RVA: 0x1E8EF80 Offset: 0x1E8F081 VA: 0x1E8EF80
	|-GaussianWindow1d<Vector3>.get_Sigma
	*/

	[CompilerGeneratedAttribute] // RVA: 0x240E0 Offset: 0x241E1 VA: 0x240E0
	// RVA: -1 Offset: -1
	private void set_Sigma(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8DDF0 Offset: 0x1E8DEF1 VA: 0x1E8DDF0
	|-GaussianWindow1d<object>.set_Sigma
	|
	|-RVA: 0x1E8E3B0 Offset: 0x1E8E4B1 VA: 0x1E8E3B0
	|-GaussianWindow1d<Quaternion>.set_Sigma
	|
	|-RVA: 0x1E8E9C0 Offset: 0x1E8EAC1 VA: 0x1E8E9C0
	|-GaussianWindow1d<Vector2>.set_Sigma
	|
	|-RVA: 0x1E8EF90 Offset: 0x1E8F091 VA: 0x1E8EF90
	|-GaussianWindow1d<Vector3>.set_Sigma
	*/

	// RVA: -1 Offset: -1
	public int get_KernelSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8DE00 Offset: 0x1E8DF01 VA: 0x1E8DE00
	|-GaussianWindow1d<object>.get_KernelSize
	|
	|-RVA: 0x1E8E3C0 Offset: 0x1E8E4C1 VA: 0x1E8E3C0
	|-GaussianWindow1d<Quaternion>.get_KernelSize
	|
	|-RVA: 0x1E8E9D0 Offset: 0x1E8EAD1 VA: 0x1E8E9D0
	|-GaussianWindow1d<Vector2>.get_KernelSize
	|
	|-RVA: 0x1E8EFA0 Offset: 0x1E8F0A1 VA: 0x1E8EFA0
	|-GaussianWindow1d<Vector3>.get_KernelSize
	*/

	// RVA: -1 Offset: -1
	private void GenerateKernel(float sigma, int maxKernelRadius) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8DE10 Offset: 0x1E8DF11 VA: 0x1E8DE10
	|-GaussianWindow1d<object>.GenerateKernel
	|
	|-RVA: 0x1E8E3D0 Offset: 0x1E8E4D1 VA: 0x1E8E3D0
	|-GaussianWindow1d<Quaternion>.GenerateKernel
	|
	|-RVA: 0x1E8E9E0 Offset: 0x1E8EAE1 VA: 0x1E8E9E0
	|-GaussianWindow1d<Vector2>.GenerateKernel
	|
	|-RVA: 0x1E8EFB0 Offset: 0x1E8F0B1 VA: 0x1E8EFB0
	|-GaussianWindow1d<Vector3>.GenerateKernel
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract T Compute(int windowPos);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-GaussianWindow1d<object>.Compute
	*/

	// RVA: -1 Offset: -1
	public void .ctor(float sigma, int maxKernelRadius = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8E050 Offset: 0x1E8E151 VA: 0x1E8E050
	|-GaussianWindow1d<object>..ctor
	|
	|-RVA: 0x1E8E610 Offset: 0x1E8E711 VA: 0x1E8E610
	|-GaussianWindow1d<Quaternion>..ctor
	|
	|-RVA: 0x1E8EC20 Offset: 0x1E8ED21 VA: 0x1E8EC20
	|-GaussianWindow1d<Vector2>..ctor
	|
	|-RVA: 0x1E8F1F0 Offset: 0x1E8F2F1 VA: 0x1E8F1F0
	|-GaussianWindow1d<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8E110 Offset: 0x1E8E211 VA: 0x1E8E110
	|-GaussianWindow1d<object>.Reset
	|
	|-RVA: 0x1E8E6D0 Offset: 0x1E8E7D1 VA: 0x1E8E6D0
	|-GaussianWindow1d<Quaternion>.Reset
	|
	|-RVA: 0x1E8ECE0 Offset: 0x1E8EDE1 VA: 0x1E8ECE0
	|-GaussianWindow1d<Vector2>.Reset
	|
	|-RVA: 0x1E8F2B0 Offset: 0x1E8F3B1 VA: 0x1E8F2B0
	|-GaussianWindow1d<Vector3>.Reset
	*/

	// RVA: -1 Offset: -1
	public bool IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8E120 Offset: 0x1E8E221 VA: 0x1E8E120
	|-GaussianWindow1d<object>.IsEmpty
	|
	|-RVA: 0x1E8E6E0 Offset: 0x1E8E7E1 VA: 0x1E8E6E0
	|-GaussianWindow1d<Quaternion>.IsEmpty
	|
	|-RVA: 0x1E8ECF0 Offset: 0x1E8EDF1 VA: 0x1E8ECF0
	|-GaussianWindow1d<Vector2>.IsEmpty
	|
	|-RVA: 0x1E8F2C0 Offset: 0x1E8F3C1 VA: 0x1E8F2C0
	|-GaussianWindow1d<Vector3>.IsEmpty
	*/

	// RVA: -1 Offset: -1
	public void AddValue(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8E130 Offset: 0x1E8E231 VA: 0x1E8E130
	|-GaussianWindow1d<object>.AddValue
	|
	|-RVA: 0x1E8E6F0 Offset: 0x1E8E7F1 VA: 0x1E8E6F0
	|-GaussianWindow1d<Quaternion>.AddValue
	|
	|-RVA: 0x1E8ED00 Offset: 0x1E8EE01 VA: 0x1E8ED00
	|-GaussianWindow1d<Vector2>.AddValue
	|
	|-RVA: 0x1E8F2D0 Offset: 0x1E8F3D1 VA: 0x1E8F2D0
	|-GaussianWindow1d<Vector3>.AddValue
	*/

	// RVA: -1 Offset: -1
	public T Filter(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8E270 Offset: 0x1E8E371 VA: 0x1E8E270
	|-GaussianWindow1d<object>.Filter
	|
	|-RVA: 0x1E8E840 Offset: 0x1E8E941 VA: 0x1E8E840
	|-GaussianWindow1d<Quaternion>.Filter
	|
	|-RVA: 0x1E8EE40 Offset: 0x1E8EF41 VA: 0x1E8EE40
	|-GaussianWindow1d<Vector2>.Filter
	|
	|-RVA: 0x1E8F420 Offset: 0x1E8F521 VA: 0x1E8F420
	|-GaussianWindow1d<Vector3>.Filter
	*/

	// RVA: -1 Offset: -1
	public T Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8E300 Offset: 0x1E8E401 VA: 0x1E8E300
	|-GaussianWindow1d<object>.Value
	|
	|-RVA: 0x1E8E900 Offset: 0x1E8EA01 VA: 0x1E8E900
	|-GaussianWindow1d<Quaternion>.Value
	|
	|-RVA: 0x1E8EEE0 Offset: 0x1E8EFE1 VA: 0x1E8EEE0
	|-GaussianWindow1d<Vector2>.Value
	|
	|-RVA: 0x1E8F4D0 Offset: 0x1E8F5D1 VA: 0x1E8F4D0
	|-GaussianWindow1d<Vector3>.Value
	*/

	// RVA: -1 Offset: -1
	public int get_BufferLength() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8E310 Offset: 0x1E8E411 VA: 0x1E8E310
	|-GaussianWindow1d<object>.get_BufferLength
	|
	|-RVA: 0x1E8E910 Offset: 0x1E8EA11 VA: 0x1E8E910
	|-GaussianWindow1d<Quaternion>.get_BufferLength
	|
	|-RVA: 0x1E8EEF0 Offset: 0x1E8EFF1 VA: 0x1E8EEF0
	|-GaussianWindow1d<Vector2>.get_BufferLength
	|
	|-RVA: 0x1E8F4E0 Offset: 0x1E8F5E1 VA: 0x1E8F4E0
	|-GaussianWindow1d<Vector3>.get_BufferLength
	*/

	// RVA: -1 Offset: -1
	public void SetBufferValue(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8E320 Offset: 0x1E8E421 VA: 0x1E8E320
	|-GaussianWindow1d<object>.SetBufferValue
	|
	|-RVA: 0x1E8E920 Offset: 0x1E8EA21 VA: 0x1E8E920
	|-GaussianWindow1d<Quaternion>.SetBufferValue
	|
	|-RVA: 0x1E8EF00 Offset: 0x1E8F001 VA: 0x1E8EF00
	|-GaussianWindow1d<Vector2>.SetBufferValue
	|
	|-RVA: 0x1E8F4F0 Offset: 0x1E8F5F1 VA: 0x1E8F4F0
	|-GaussianWindow1d<Vector3>.SetBufferValue
	*/

	// RVA: -1 Offset: -1
	public T GetBufferValue(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8E360 Offset: 0x1E8E461 VA: 0x1E8E360
	|-GaussianWindow1d<object>.GetBufferValue
	|
	|-RVA: 0x1E8E970 Offset: 0x1E8EA71 VA: 0x1E8E970
	|-GaussianWindow1d<Quaternion>.GetBufferValue
	|
	|-RVA: 0x1E8EF40 Offset: 0x1E8F041 VA: 0x1E8EF40
	|-GaussianWindow1d<Vector2>.GetBufferValue
	|
	|-RVA: 0x1E8F540 Offset: 0x1E8F641 VA: 0x1E8F540
	|-GaussianWindow1d<Vector3>.GetBufferValue
	*/
}

// Namespace: Cinemachine.Utility
internal class GaussianWindow1D_Vector3 : GaussianWindow1d<Vector3> // TypeDefIndex: 5900
{
	// Methods

	// RVA: 0x1A81A70 Offset: 0x1A81B71 VA: 0x1A81A70
	public void .ctor(float sigma, int maxKernelRadius = 10) { }

	// RVA: 0x1A81AE0 Offset: 0x1A81BE1 VA: 0x1A81AE0 Slot: 4
	protected override Vector3 Compute(int windowPos) { }
}

// Namespace: Cinemachine.Utility
internal class GaussianWindow1D_Quaternion : GaussianWindow1d<Quaternion> // TypeDefIndex: 5901
{
	// Methods

	// RVA: 0x1A817D0 Offset: 0x1A818D1 VA: 0x1A817D0
	public void .ctor(float sigma, int maxKernelRadius = 10) { }

	// RVA: 0x1A81840 Offset: 0x1A81941 VA: 0x1A81840 Slot: 4
	protected override Quaternion Compute(int windowPos) { }
}

// Namespace: Cinemachine.Utility
internal class GaussianWindow1D_CameraRotation : GaussianWindow1d<Vector2> // TypeDefIndex: 5902
{
	// Methods

	// RVA: 0x1A815D0 Offset: 0x1A816D1 VA: 0x1A815D0
	public void .ctor(float sigma, int maxKernelRadius = 10) { }

	// RVA: 0x1A81640 Offset: 0x1A81741 VA: 0x1A81640 Slot: 4
	protected override Vector2 Compute(int windowPos) { }
}


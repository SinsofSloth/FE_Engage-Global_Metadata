// Namespace: 
internal enum Camera.ProjectionMatrixMode // TypeDefIndex: 3405
{
	// Fields
	public int value__; // 0x0
	public const Camera.ProjectionMatrixMode Explicit = 0;
	public const Camera.ProjectionMatrixMode Implicit = 1;
	public const Camera.ProjectionMatrixMode PhysicalPropertiesBased = 2;
}

// Namespace: 
public enum Camera.GateFitMode // TypeDefIndex: 3406
{
	// Fields
	public int value__; // 0x0
	public const Camera.GateFitMode Vertical = 1;
	public const Camera.GateFitMode Horizontal = 2;
	public const Camera.GateFitMode Fill = 3;
	public const Camera.GateFitMode Overscan = 4;
	public const Camera.GateFitMode None = 0;
}

// Namespace: 
public struct Camera.GateFitParameters // TypeDefIndex: 3407
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x442520 Offset: 0x442621 VA: 0x442520
	[CompilerGeneratedAttribute] // RVA: 0x442520 Offset: 0x442621 VA: 0x442520
	private Camera.GateFitMode <mode>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x442560 Offset: 0x442661 VA: 0x442560
	[CompilerGeneratedAttribute] // RVA: 0x442560 Offset: 0x442661 VA: 0x442560
	private float <aspect>k__BackingField; // 0x4

	// Properties
	public Camera.GateFitMode mode { get; }
	public float aspect { get; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x4470B0 Offset: 0x4471B1 VA: 0x4470B0
	[CompilerGeneratedAttribute] // RVA: 0x4470B0 Offset: 0x4471B1 VA: 0x4470B0
	// RVA: 0x3853390 Offset: 0x3853491 VA: 0x3853390
	public Camera.GateFitMode get_mode() { }

	[CompilerGeneratedAttribute] // RVA: 0x4470F0 Offset: 0x4471F1 VA: 0x4470F0
	[IsReadOnlyAttribute] // RVA: 0x4470F0 Offset: 0x4471F1 VA: 0x4470F0
	// RVA: 0x38533A0 Offset: 0x38534A1 VA: 0x38533A0
	public float get_aspect() { }
}

// Namespace: 
public enum Camera.StereoscopicEye // TypeDefIndex: 3408
{
	// Fields
	public int value__; // 0x0
	public const Camera.StereoscopicEye Left = 0;
	public const Camera.StereoscopicEye Right = 1;
}

// Namespace: 
public enum Camera.MonoOrStereoscopicEye // TypeDefIndex: 3409
{
	// Fields
	public int value__; // 0x0
	public const Camera.MonoOrStereoscopicEye Left = 0;
	public const Camera.MonoOrStereoscopicEye Right = 1;
	public const Camera.MonoOrStereoscopicEye Mono = 2;
}

// Namespace: 
public enum Camera.RenderRequestMode // TypeDefIndex: 3410
{
	// Fields
	public int value__; // 0x0
	public const Camera.RenderRequestMode None = 0;
	public const Camera.RenderRequestMode ObjectId = 1;
	public const Camera.RenderRequestMode Depth = 2;
	public const Camera.RenderRequestMode VertexNormal = 3;
	public const Camera.RenderRequestMode WorldPosition = 4;
	public const Camera.RenderRequestMode EntityId = 5;
	public const Camera.RenderRequestMode BaseColor = 6;
	public const Camera.RenderRequestMode SpecularColor = 7;
	public const Camera.RenderRequestMode Metallic = 8;
	public const Camera.RenderRequestMode Emission = 9;
	public const Camera.RenderRequestMode Normal = 10;
	public const Camera.RenderRequestMode Smoothness = 11;
	public const Camera.RenderRequestMode Occlusion = 12;
	public const Camera.RenderRequestMode DiffuseColor = 13;
}

// Namespace: 
public enum Camera.RenderRequestOutputSpace // TypeDefIndex: 3411
{
	// Fields
	public int value__; // 0x0
	public const Camera.RenderRequestOutputSpace ScreenSpace = -1;
	public const Camera.RenderRequestOutputSpace UV0 = 0;
	public const Camera.RenderRequestOutputSpace UV1 = 1;
	public const Camera.RenderRequestOutputSpace UV2 = 2;
	public const Camera.RenderRequestOutputSpace UV3 = 3;
	public const Camera.RenderRequestOutputSpace UV4 = 4;
	public const Camera.RenderRequestOutputSpace UV5 = 5;
	public const Camera.RenderRequestOutputSpace UV6 = 6;
	public const Camera.RenderRequestOutputSpace UV7 = 7;
	public const Camera.RenderRequestOutputSpace UV8 = 8;
}

// Namespace: 
public struct Camera.RenderRequest // TypeDefIndex: 3412
{
	// Fields
	private readonly Camera.RenderRequestMode m_CameraRenderMode; // 0x0
	private readonly RenderTexture m_ResultRT; // 0x8
	private readonly Camera.RenderRequestOutputSpace m_OutputSpace; // 0x10
}

// Namespace: 
public sealed class Camera.CameraCallback : MulticastDelegate // TypeDefIndex: 3413
{
	// Methods

	// RVA: 0x3852FD0 Offset: 0x38530D1 VA: 0x3852FD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3852FF0 Offset: 0x38530F1 VA: 0x3852FF0 Slot: 13
	public virtual void Invoke(Camera cam) { }

	// RVA: 0x3853350 Offset: 0x3853451 VA: 0x3853350 Slot: 14
	public virtual IAsyncResult BeginInvoke(Camera cam, AsyncCallback callback, object object) { }

	// RVA: 0x3853380 Offset: 0x3853481 VA: 0x3853380 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


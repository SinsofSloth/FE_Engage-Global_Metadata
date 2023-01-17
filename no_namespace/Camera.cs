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
public enum Camera.StereoscopicEye // TypeDefIndex: 3408
{
	// Fields
	public int value__; // 0x0
	public const Camera.StereoscopicEye Left = 0;
	public const Camera.StereoscopicEye Right = 1;
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
public struct Camera.RenderRequest // TypeDefIndex: 3412
{
	// Fields
	private readonly Camera.RenderRequestMode m_CameraRenderMode; // 0x0
	private readonly RenderTexture m_ResultRT; // 0x8
	private readonly Camera.RenderRequestOutputSpace m_OutputSpace; // 0x10
}


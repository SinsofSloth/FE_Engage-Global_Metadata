// Namespace: 
private struct CinemachineComposer.FovCache // TypeDefIndex: 5784
{
	// Fields
	public Rect mFovSoftGuideRect; // 0x0
	public Rect mFovHardGuideRect; // 0x10
	public float mFovH; // 0x20
	public float mFov; // 0x24
	private float mOrthoSizeOverDistance; // 0x28
	private float mAspect; // 0x2C
	private Rect mSoftGuideRect; // 0x30
	private Rect mHardGuideRect; // 0x40

	// Methods

	// RVA: 0x1A88500 Offset: 0x1A88601 VA: 0x1A88500
	public void UpdateCache(LensSettings lens, Rect softGuide, Rect hardGuide, float targetDistance) { }

	// RVA: 0x1A88800 Offset: 0x1A88901 VA: 0x1A88800
	private Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect) { }
}


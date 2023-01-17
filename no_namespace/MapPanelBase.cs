// Namespace: 
protected sealed class MapPanelBase.ImageGetFunction<T> : MulticastDelegate // TypeDefIndex: 7631
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB03A0 Offset: 0x1EB04A1 VA: 0x1EB03A0
	|-MapPanelBase.ImageGetFunction<MapPanelActive>..ctor
	|-MapPanelBase.ImageGetFunction<MapPanelDanger>..ctor
	|-MapPanelBase.ImageGetFunction<MapPanelDangerAll>..ctor
	|-MapPanelBase.ImageGetFunction<MapPanelDeploy>..ctor
	|-MapPanelBase.ImageGetFunction<MapPanelGimmick>..ctor
	|-MapPanelBase.ImageGetFunction<MapPanelImpact>..ctor
	|-MapPanelBase.ImageGetFunction<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(int x, int z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB03C0 Offset: 0x1EB04C1 VA: 0x1EB03C0
	|-MapPanelBase.ImageGetFunction<MapPanelDanger>.Invoke
	|-MapPanelBase.ImageGetFunction<MapPanelDangerAll>.Invoke
	|-MapPanelBase.ImageGetFunction<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(int x, int z, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB0610 Offset: 0x1EB0711 VA: 0x1EB0610
	|-MapPanelBase.ImageGetFunction<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB06B0 Offset: 0x1EB07B1 VA: 0x1EB06B0
	|-MapPanelBase.ImageGetFunction<object>.EndInvoke
	*/
}

// Namespace: 
protected enum MapPanelBase.PanelType<T> // TypeDefIndex: 7632
{
	// Fields
	public int value__; // 0x0
	public const MapPanelBase.PanelType<T> Move = 0;
	public const MapPanelBase.PanelType<T> Attack = 1;
	public const MapPanelBase.PanelType<T> Rod = 2;
	public const MapPanelBase.PanelType<T> Talk = 3;
	public const MapPanelBase.PanelType<T> Target = 4;
	public const MapPanelBase.PanelType<T> Rescuer = 5;
}

// Namespace: 
[RequireComponent] // RVA: 0x271690 Offset: 0x271791 VA: 0x271690
[RequireComponent] // RVA: 0x271690 Offset: 0x271791 VA: 0x271690
public class MapPanelBase<T> : SingletonMonoBehaviour<T> // TypeDefIndex: 7633
{
	// Fields
	public Material[] m_Materials; // 0x0
	protected Map.CellMesh m_Mesh; // 0x0
	protected float m_HalfTexelX; // 0x0
	protected float m_HalfTexelY; // 0x0
	protected Material[] m_RendererMaterials; // 0x0
	private static readonly int[] CheckImageOffsetXTable; // 0x0
	private static readonly int[] CheckIMageOffsetZTable; // 0x0

	// Properties
	public Mesh Mesh { get; }
	public DynamicMesh DynamicMesh { get; }
	public virtual int SubMeshCount { get; }
	public Material[] Materials { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected override void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29348D0 Offset: 0x29349D1 VA: 0x29348D0
	|-MapPanelBase<MapPanelActive>.Awake
	|-MapPanelBase<MapPanelDanger>.Awake
	|-MapPanelBase<MapPanelDangerAll>.Awake
	|-MapPanelBase<MapPanelDebug>.Awake
	|-MapPanelBase<MapPanelDeploy>.Awake
	|-MapPanelBase<MapPanelGimmick>.Awake
	|-MapPanelBase<MapPanelHistory>.Awake
	|-MapPanelBase<MapPanelImpact>.Awake
	|-MapPanelBase<MapPanelRoute>.Awake
	|-MapPanelBase<MapPanelSortie>.Awake
	|-MapPanelBase<MapPanelTarget>.Awake
	|-MapPanelBase<object>.Awake
	*/

	// RVA: -1 Offset: -1
	protected Color GetDensity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2934BB0 Offset: 0x2934CB1 VA: 0x2934BB0
	|-MapPanelBase<MapPanelDanger>.GetDensity
	|-MapPanelBase<MapPanelDangerAll>.GetDensity
	|-MapPanelBase<MapPanelSortie>.GetDensity
	|-MapPanelBase<object>.GetDensity
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual Material[] GetSourceMaterials() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2934BC0 Offset: 0x2934CC1 VA: 0x2934BC0
	|-MapPanelBase<MapPanelDebug>.GetSourceMaterials
	|-MapPanelBase<MapPanelHistory>.GetSourceMaterials
	|-MapPanelBase<MapPanelRoute>.GetSourceMaterials
	|-MapPanelBase<MapPanelSortie>.GetSourceMaterials
	|-MapPanelBase<object>.GetSourceMaterials
	*/

	// RVA: -1 Offset: -1
	public Mesh get_Mesh() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2934BD0 Offset: 0x2934CD1 VA: 0x2934BD0
	|-MapPanelBase<MapPanelDanger>.get_Mesh
	|-MapPanelBase<MapPanelDangerAll>.get_Mesh
	|-MapPanelBase<MapPanelDeploy>.get_Mesh
	|-MapPanelBase<MapPanelRoute>.get_Mesh
	|-MapPanelBase<object>.get_Mesh
	*/

	// RVA: -1 Offset: -1
	public DynamicMesh get_DynamicMesh() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2934BF0 Offset: 0x2934CF1 VA: 0x2934BF0
	|-MapPanelBase<object>.get_DynamicMesh
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual int get_SubMeshCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2934C00 Offset: 0x2934D01 VA: 0x2934C00
	|-MapPanelBase<MapPanelDebug>.get_SubMeshCount
	|-MapPanelBase<MapPanelHistory>.get_SubMeshCount
	|-MapPanelBase<MapPanelRoute>.get_SubMeshCount
	|-MapPanelBase<MapPanelSortie>.get_SubMeshCount
	|-MapPanelBase<object>.get_SubMeshCount
	*/

	// RVA: -1 Offset: -1
	public Material[] get_Materials() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2934C10 Offset: 0x2934D11 VA: 0x2934C10
	|-MapPanelBase<MapPanelDanger>.get_Materials
	|-MapPanelBase<MapPanelDeploy>.get_Materials
	|-MapPanelBase<MapPanelRoute>.get_Materials
	|-MapPanelBase<object>.get_Materials
	*/

	// RVA: -1 Offset: -1
	protected float GetMapPosY(float x, float z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2934C20 Offset: 0x2934D21 VA: 0x2934C20
	|-MapPanelBase<object>.GetMapPosY
	*/

	// RVA: -1 Offset: -1
	protected Vector3 GetMapPos(float x, float z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29357F0 Offset: 0x29358F1 VA: 0x29357F0
	|-MapPanelBase<object>.GetMapPos
	*/

	// RVA: -1 Offset: -1
	public static void Show() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2935830 Offset: 0x2935931 VA: 0x2935830
	|-MapPanelBase<object>.Show
	*/

	// RVA: -1 Offset: -1
	protected static float GetPanelAlpha() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2935B40 Offset: 0x2935C41 VA: 0x2935B40
	|-MapPanelBase<MapPanelActive>.GetPanelAlpha
	|-MapPanelBase<MapPanelDanger>.GetPanelAlpha
	|-MapPanelBase<MapPanelDangerAll>.GetPanelAlpha
	|-MapPanelBase<MapPanelDeploy>.GetPanelAlpha
	|-MapPanelBase<object>.GetPanelAlpha
	*/

	// RVA: -1 Offset: -1
	public static void Hide() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2935B90 Offset: 0x2935C91 VA: 0x2935B90
	|-MapPanelBase<object>.Hide
	*/

	// RVA: -1 Offset: -1
	private bool IsConnect(int x1, int z1, int x2, int z2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2935EA0 Offset: 0x2935FA1 VA: 0x2935EA0
	|-MapPanelBase<object>.IsConnect
	*/

	// RVA: -1 Offset: -1
	protected uint CheckImage(MapPanelBase.ImageGetFunction<T> func, int x, int z, bool stepCheck = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2936D70 Offset: 0x2936E71 VA: 0x2936D70
	|-MapPanelBase<MapPanelActive>.CheckImage
	|-MapPanelBase<MapPanelDanger>.CheckImage
	|-MapPanelBase<MapPanelDangerAll>.CheckImage
	|-MapPanelBase<MapPanelDeploy>.CheckImage
	|-MapPanelBase<object>.CheckImage
	*/

	// RVA: -1 Offset: -1
	protected uint CheckWholeDangerImageForGunner(MapPanelBase.ImageGetFunction<T> gunner, MapPanelBase.ImageGetFunction<T> attack, MapPanelBase.ImageGetFunction<T> rod, int x, int z, bool isImageFilled = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2937080 Offset: 0x2937181 VA: 0x2937080
	|-MapPanelBase<MapPanelDangerAll>.CheckWholeDangerImageForGunner
	|-MapPanelBase<object>.CheckWholeDangerImageForGunner
	*/

	// RVA: -1 Offset: -1
	protected uint CheckImageNotImmobile(MapPanelBase.ImageGetFunction<T> func, int x, int z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29374B0 Offset: 0x29375B1 VA: 0x29374B0
	|-MapPanelBase<MapPanelGimmick>.CheckImageNotImmobile
	|-MapPanelBase<MapPanelImpact>.CheckImageNotImmobile
	|-MapPanelBase<object>.CheckImageNotImmobile
	*/

	// RVA: -1 Offset: -1
	protected uint CheckImageForAct(MapPanelBase.ImageGetFunction<T> imageFunc, MapPanelBase.ImageGetFunction<T> moveFunc, int x, int z, bool isConsiderMove = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2937700 Offset: 0x2937801 VA: 0x2937700
	|-MapPanelBase<MapPanelActive>.CheckImageForAct
	|-MapPanelBase<MapPanelDeploy>.CheckImageForAct
	|-MapPanelBase<object>.CheckImageForAct
	*/

	// RVA: -1 Offset: -1
	protected void CalcUV(uint mask, out float u, out float v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2937A80 Offset: 0x2937B81 VA: 0x2937A80
	|-MapPanelBase<MapPanelDanger>.CalcUV
	|-MapPanelBase<object>.CalcUV
	*/

	// RVA: -1 Offset: -1
	protected void AddCell(int x, int z, Color color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2937AC0 Offset: 0x2937BC1 VA: 0x2937AC0
	|-MapPanelBase<MapPanelSortie>.AddCell
	|-MapPanelBase<object>.AddCell
	*/

	// RVA: -1 Offset: -1
	protected void AddCell(int x, int z, float u, float v, Color color, float distance = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2937AF0 Offset: 0x2937BF1 VA: 0x2937AF0
	|-MapPanelBase<MapPanelDanger>.AddCell
	|-MapPanelBase<object>.AddCell
	*/

	// RVA: -1 Offset: -1
	protected void AddCell(int x, int z, uint mask, Color color, float distance = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2938290 Offset: 0x2938391 VA: 0x2938290
	|-MapPanelBase<MapPanelActive>.AddCell
	|-MapPanelBase<MapPanelDangerAll>.AddCell
	|-MapPanelBase<MapPanelDeploy>.AddCell
	|-MapPanelBase<MapPanelGimmick>.AddCell
	|-MapPanelBase<MapPanelImpact>.AddCell
	|-MapPanelBase<object>.AddCell
	*/

	// RVA: -1 Offset: -1
	protected void AddCell(MapPanelBase.ImageGetFunction<T> func, int x, int z, Color color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2938350 Offset: 0x2938451 VA: 0x2938350
	|-MapPanelBase<object>.AddCell
	*/

	// RVA: -1 Offset: -1
	protected float GetU0(float unit, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2938420 Offset: 0x2938521 VA: 0x2938420
	|-MapPanelBase<object>.GetU0
	*/

	// RVA: -1 Offset: -1
	protected float GetU2(float unit, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2938440 Offset: 0x2938541 VA: 0x2938440
	|-MapPanelBase<object>.GetU2
	*/

	// RVA: -1 Offset: -1
	protected float GetV0(float unit, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2938460 Offset: 0x2938561 VA: 0x2938460
	|-MapPanelBase<object>.GetV0
	*/

	// RVA: -1 Offset: -1
	protected float GetV2(float unit, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2938480 Offset: 0x2938581 VA: 0x2938480
	|-MapPanelBase<object>.GetV2
	*/

	// RVA: -1 Offset: -1
	protected Vector2 GetUV0(float unitX, float unitY, int indexX, int indexY) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29384A0 Offset: 0x29385A1 VA: 0x29384A0
	|-MapPanelBase<object>.GetUV0
	*/

	// RVA: -1 Offset: -1
	protected Vector2 GetUV2(float unitX, float unitY, int indexX, int indexY) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2938520 Offset: 0x2938621 VA: 0x2938520
	|-MapPanelBase<object>.GetUV2
	*/

	// RVA: -1 Offset: -1
	protected void AddCell(int x, int z, Color color, MapPanelBase.PanelType<T> panel, float distance = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29385A0 Offset: 0x29386A1 VA: 0x29385A0
	|-MapPanelBase<MapPanelActive>.AddCell
	|-MapPanelBase<MapPanelDeploy>.AddCell
	|-MapPanelBase<object>.AddCell
	*/

	// RVA: -1 Offset: -1
	protected void SetMaterialFloat(string keyword, float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2938D70 Offset: 0x2938E71 VA: 0x2938D70
	|-MapPanelBase<MapPanelDeploy>.SetMaterialFloat
	|-MapPanelBase<object>.SetMaterialFloat
	*/

	// RVA: -1 Offset: -1
	protected void SetMaterialColor(float r, float g, float b, float a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2938EA0 Offset: 0x2938FA1 VA: 0x2938EA0
	|-MapPanelBase<object>.SetMaterialColor
	*/

	// RVA: -1 Offset: -1
	protected void SetMaterialAlpha(float a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2938FD0 Offset: 0x29390D1 VA: 0x2938FD0
	|-MapPanelBase<MapPanelActive>.SetMaterialAlpha
	|-MapPanelBase<MapPanelDanger>.SetMaterialAlpha
	|-MapPanelBase<MapPanelDangerAll>.SetMaterialAlpha
	|-MapPanelBase<MapPanelDeploy>.SetMaterialAlpha
	|-MapPanelBase<MapPanelRoute>.SetMaterialAlpha
	|-MapPanelBase<object>.SetMaterialAlpha
	*/

	// RVA: -1 Offset: -1
	protected void SetMaterialAlpha(int index, float a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29390D0 Offset: 0x29391D1 VA: 0x29390D0
	|-MapPanelBase<MapPanelActive>.SetMaterialAlpha
	|-MapPanelBase<MapPanelDanger>.SetMaterialAlpha
	|-MapPanelBase<MapPanelDangerAll>.SetMaterialAlpha
	|-MapPanelBase<MapPanelDeploy>.SetMaterialAlpha
	|-MapPanelBase<MapPanelGimmick>.SetMaterialAlpha
	|-MapPanelBase<MapPanelImpact>.SetMaterialAlpha
	|-MapPanelBase<object>.SetMaterialAlpha
	*/

	// RVA: -1 Offset: -1
	public void UpdateTexel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29391D0 Offset: 0x29392D1 VA: 0x29391D0
	|-MapPanelBase<object>.UpdateTexel
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2939300 Offset: 0x2939401 VA: 0x2939300
	|-MapPanelBase<MapPanelActive>.Clear
	|-MapPanelBase<MapPanelDanger>.Clear
	|-MapPanelBase<MapPanelDangerAll>.Clear
	|-MapPanelBase<MapPanelDebug>.Clear
	|-MapPanelBase<MapPanelDeploy>.Clear
	|-MapPanelBase<MapPanelGimmick>.Clear
	|-MapPanelBase<MapPanelHistory>.Clear
	|-MapPanelBase<MapPanelImpact>.Clear
	|-MapPanelBase<MapPanelRoute>.Clear
	|-MapPanelBase<MapPanelSortie>.Clear
	|-MapPanelBase<MapPanelTarget>.Clear
	|-MapPanelBase<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2939320 Offset: 0x2939421 VA: 0x2939320
	|-MapPanelBase<MapPanelActive>..ctor
	|-MapPanelBase<MapPanelDanger>..ctor
	|-MapPanelBase<MapPanelDangerAll>..ctor
	|-MapPanelBase<MapPanelDebug>..ctor
	|-MapPanelBase<MapPanelDeploy>..ctor
	|-MapPanelBase<MapPanelGimmick>..ctor
	|-MapPanelBase<MapPanelHistory>..ctor
	|-MapPanelBase<MapPanelImpact>..ctor
	|-MapPanelBase<MapPanelRoute>..ctor
	|-MapPanelBase<MapPanelSortie>..ctor
	|-MapPanelBase<MapPanelTarget>..ctor
	|-MapPanelBase<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29393D0 Offset: 0x29394D1 VA: 0x29393D0
	|-MapPanelBase<object>..cctor
	*/
}


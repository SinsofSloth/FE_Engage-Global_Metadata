// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x34990 Offset: 0x34A91 VA: 0x34990
[UsedByNativeCodeAttribute] // RVA: 0x34990 Offset: 0x34A91 VA: 0x34990
[NativeHeaderAttribute] // RVA: 0x34990 Offset: 0x34A91 VA: 0x34990
[NativeHeaderAttribute] // RVA: 0x34990 Offset: 0x34A91 VA: 0x34990
public class Animator : Behaviour // TypeDefIndex: 4098
{
	// Properties
	public bool isOptimizable { get; }
	public bool isHuman { get; }
	public bool hasRootMotion { get; }
	internal bool isRootPositionOrRotationControlledByCurves { get; }
	public float humanScale { get; }
	public bool isInitialized { get; }
	public Vector3 deltaPosition { get; }
	public Quaternion deltaRotation { get; }
	public Vector3 velocity { get; }
	public Vector3 angularVelocity { get; }
	public Vector3 rootPosition { get; set; }
	public Quaternion rootRotation { get; set; }
	public bool applyRootMotion { get; set; }
	[ObsoleteAttribute] // RVA: 0x39C00 Offset: 0x39D01 VA: 0x39C00
	public bool linearVelocityBlending { get; set; }
	[ObsoleteAttribute] // RVA: 0x39C40 Offset: 0x39D41 VA: 0x39C40
	public bool animatePhysics { get; set; }
	public AnimatorUpdateMode updateMode { get; set; }
	public bool hasTransformHierarchy { get; }
	internal bool allowConstantClipSamplingOptimization { get; set; }
	public float gravityWeight { get; }
	public Vector3 bodyPosition { get; set; }
	internal Vector3 bodyPositionInternal { get; set; }
	public Quaternion bodyRotation { get; set; }
	internal Quaternion bodyRotationInternal { get; set; }
	public bool stabilizeFeet { get; set; }
	public int layerCount { get; }
	public AnimatorControllerParameter[] parameters { get; }
	public int parameterCount { get; }
	public float feetPivotActive { get; set; }
	public float pivotWeight { get; }
	public Vector3 pivotPosition { get; }
	public bool isMatchingTarget { get; }
	public float speed { get; set; }
	public Vector3 targetPosition { get; }
	public Quaternion targetRotation { get; }
	internal Transform avatarRoot { get; }
	public AnimatorCullingMode cullingMode { get; set; }
	public float playbackTime { get; set; }
	public float recorderStartTime { get; set; }
	public float recorderStopTime { get; set; }
	public AnimatorRecorderMode recorderMode { get; }
	public RuntimeAnimatorController runtimeAnimatorController { get; set; }
	public bool hasBoundPlayables { get; }
	public Avatar avatar { get; set; }
	public PlayableGraph playableGraph { get; }
	public bool layersAffectMassCenter { get; set; }
	public float leftFeetBottomHeight { get; }
	public float rightFeetBottomHeight { get; }
	[NativeConditionalAttribute] // RVA: 0x39C80 Offset: 0x39D81 VA: 0x39C80
	internal bool supportsOnAnimatorMove { get; }
	public bool logWarnings { get; set; }
	public bool fireEvents { get; set; }
	public bool keepAnimatorControllerStateOnDisable { get; set; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x36CB0 Offset: 0x36DB1 VA: 0x36CB0
	// RVA: 0x3ED5090 Offset: 0x3ED5191 VA: 0x3ED5090
	public bool get_isOptimizable() { }

	[NativeMethodAttribute] // RVA: 0x36CF0 Offset: 0x36DF1 VA: 0x36CF0
	// RVA: 0x3ED50E0 Offset: 0x3ED51E1 VA: 0x3ED50E0
	public bool get_isHuman() { }

	[NativeMethodAttribute] // RVA: 0x36D30 Offset: 0x36E31 VA: 0x36D30
	// RVA: 0x3ED5130 Offset: 0x3ED5231 VA: 0x3ED5130
	public bool get_hasRootMotion() { }

	[NativeMethodAttribute] // RVA: 0x36D70 Offset: 0x36E71 VA: 0x36D70
	// RVA: 0x3ED5180 Offset: 0x3ED5281 VA: 0x3ED5180
	internal bool get_isRootPositionOrRotationControlledByCurves() { }

	// RVA: 0x3ED51D0 Offset: 0x3ED52D1 VA: 0x3ED51D0
	public float get_humanScale() { }

	[NativeMethodAttribute] // RVA: 0x36DB0 Offset: 0x36EB1 VA: 0x36DB0
	// RVA: 0x3ED5220 Offset: 0x3ED5321 VA: 0x3ED5220
	public bool get_isInitialized() { }

	// RVA: 0x3ED5270 Offset: 0x3ED5371 VA: 0x3ED5270
	public float GetFloat(string name) { }

	// RVA: 0x3ED5310 Offset: 0x3ED5411 VA: 0x3ED5310
	public float GetFloat(int id) { }

	// RVA: 0x3ED53B0 Offset: 0x3ED54B1 VA: 0x3ED53B0
	public void SetFloat(string name, float value) { }

	// RVA: 0x3ED5470 Offset: 0x3ED5571 VA: 0x3ED5470
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x3ED5570 Offset: 0x3ED5671 VA: 0x3ED5570
	public void SetFloat(int id, float value) { }

	// RVA: 0x3ED5630 Offset: 0x3ED5731 VA: 0x3ED5630
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x3ED5730 Offset: 0x3ED5831 VA: 0x3ED5730
	public bool GetBool(string name) { }

	// RVA: 0x3ED57D0 Offset: 0x3ED58D1 VA: 0x3ED57D0
	public bool GetBool(int id) { }

	// RVA: 0x3ED5870 Offset: 0x3ED5971 VA: 0x3ED5870
	public void SetBool(string name, bool value) { }

	// RVA: 0x3ED5930 Offset: 0x3ED5A31 VA: 0x3ED5930
	public void SetBool(int id, bool value) { }

	// RVA: 0x3ED59F0 Offset: 0x3ED5AF1 VA: 0x3ED59F0
	public int GetInteger(string name) { }

	// RVA: 0x3ED5A90 Offset: 0x3ED5B91 VA: 0x3ED5A90
	public int GetInteger(int id) { }

	// RVA: 0x3ED5B30 Offset: 0x3ED5C31 VA: 0x3ED5B30
	public void SetInteger(string name, int value) { }

	// RVA: 0x3ED5BF0 Offset: 0x3ED5CF1 VA: 0x3ED5BF0
	public void SetInteger(int id, int value) { }

	// RVA: 0x3ED5CB0 Offset: 0x3ED5DB1 VA: 0x3ED5CB0
	public void SetTrigger(string name) { }

	// RVA: 0x3ED5D50 Offset: 0x3ED5E51 VA: 0x3ED5D50
	public void SetTrigger(int id) { }

	// RVA: 0x3ED5DF0 Offset: 0x3ED5EF1 VA: 0x3ED5DF0
	public void ResetTrigger(string name) { }

	// RVA: 0x3ED5E90 Offset: 0x3ED5F91 VA: 0x3ED5E90
	public void ResetTrigger(int id) { }

	// RVA: 0x3ED5F30 Offset: 0x3ED6031 VA: 0x3ED5F30
	public bool IsParameterControlledByCurve(string name) { }

	// RVA: 0x3ED5FD0 Offset: 0x3ED60D1 VA: 0x3ED5FD0
	public bool IsParameterControlledByCurve(int id) { }

	// RVA: 0x3ED6070 Offset: 0x3ED6171 VA: 0x3ED6070
	public Vector3 get_deltaPosition() { }

	// RVA: 0x3ED6120 Offset: 0x3ED6221 VA: 0x3ED6120
	public Quaternion get_deltaRotation() { }

	// RVA: 0x3ED61D0 Offset: 0x3ED62D1 VA: 0x3ED61D0
	public Vector3 get_velocity() { }

	// RVA: 0x3ED6280 Offset: 0x3ED6381 VA: 0x3ED6280
	public Vector3 get_angularVelocity() { }

	[NativeMethodAttribute] // RVA: 0x36DF0 Offset: 0x36EF1 VA: 0x36DF0
	// RVA: 0x3ED6330 Offset: 0x3ED6431 VA: 0x3ED6330
	public Vector3 get_rootPosition() { }

	[NativeMethodAttribute] // RVA: 0x36E30 Offset: 0x36F31 VA: 0x36E30
	// RVA: 0x3ED63E0 Offset: 0x3ED64E1 VA: 0x3ED63E0
	public void set_rootPosition(Vector3 value) { }

	[NativeMethodAttribute] // RVA: 0x36E70 Offset: 0x36F71 VA: 0x36E70
	// RVA: 0x3ED6490 Offset: 0x3ED6591 VA: 0x3ED6490
	public Quaternion get_rootRotation() { }

	[NativeMethodAttribute] // RVA: 0x36EB0 Offset: 0x36FB1 VA: 0x36EB0
	// RVA: 0x3ED6540 Offset: 0x3ED6641 VA: 0x3ED6540
	public void set_rootRotation(Quaternion value) { }

	// RVA: 0x3ED65F0 Offset: 0x3ED66F1 VA: 0x3ED65F0
	public bool get_applyRootMotion() { }

	// RVA: 0x3ED6640 Offset: 0x3ED6741 VA: 0x3ED6640
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x3ED6690 Offset: 0x3ED6791 VA: 0x3ED6690
	public bool get_linearVelocityBlending() { }

	// RVA: 0x3ED66E0 Offset: 0x3ED67E1 VA: 0x3ED66E0
	public void set_linearVelocityBlending(bool value) { }

	// RVA: 0x3ED6730 Offset: 0x3ED6831 VA: 0x3ED6730
	public bool get_animatePhysics() { }

	// RVA: 0x3ED67D0 Offset: 0x3ED68D1 VA: 0x3ED67D0
	public void set_animatePhysics(bool value) { }

	// RVA: 0x3ED6780 Offset: 0x3ED6881 VA: 0x3ED6780
	public AnimatorUpdateMode get_updateMode() { }

	// RVA: 0x3ED6860 Offset: 0x3ED6961 VA: 0x3ED6860
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x3ED68B0 Offset: 0x3ED69B1 VA: 0x3ED68B0
	public bool get_hasTransformHierarchy() { }

	// RVA: 0x3ED6900 Offset: 0x3ED6A01 VA: 0x3ED6900
	internal bool get_allowConstantClipSamplingOptimization() { }

	// RVA: 0x3ED6950 Offset: 0x3ED6A51 VA: 0x3ED6950
	internal void set_allowConstantClipSamplingOptimization(bool value) { }

	// RVA: 0x3ED69A0 Offset: 0x3ED6AA1 VA: 0x3ED69A0
	public float get_gravityWeight() { }

	// RVA: 0x3ED69F0 Offset: 0x3ED6AF1 VA: 0x3ED69F0
	public Vector3 get_bodyPosition() { }

	// RVA: 0x3ED6BD0 Offset: 0x3ED6CD1 VA: 0x3ED6BD0
	public void set_bodyPosition(Vector3 value) { }

	[NativeMethodAttribute] // RVA: 0x36EF0 Offset: 0x36FF1 VA: 0x36EF0
	// RVA: 0x3ED6B70 Offset: 0x3ED6C71 VA: 0x3ED6B70
	internal Vector3 get_bodyPositionInternal() { }

	[NativeMethodAttribute] // RVA: 0x36F30 Offset: 0x37031 VA: 0x36F30
	// RVA: 0x3ED6C50 Offset: 0x3ED6D51 VA: 0x3ED6C50
	internal void set_bodyPositionInternal(Vector3 value) { }

	// RVA: 0x3ED6D50 Offset: 0x3ED6E51 VA: 0x3ED6D50
	public Quaternion get_bodyRotation() { }

	// RVA: 0x3ED6E10 Offset: 0x3ED6F11 VA: 0x3ED6E10
	public void set_bodyRotation(Quaternion value) { }

	[NativeMethodAttribute] // RVA: 0x36F70 Offset: 0x37071 VA: 0x36F70
	// RVA: 0x3ED6DB0 Offset: 0x3ED6EB1 VA: 0x3ED6DB0
	internal Quaternion get_bodyRotationInternal() { }

	[NativeMethodAttribute] // RVA: 0x36FB0 Offset: 0x370B1 VA: 0x36FB0
	// RVA: 0x3ED6E90 Offset: 0x3ED6F91 VA: 0x3ED6E90
	internal void set_bodyRotationInternal(Quaternion value) { }

	// RVA: 0x3ED6F90 Offset: 0x3ED7091 VA: 0x3ED6F90
	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	// RVA: 0x3ED7010 Offset: 0x3ED7111 VA: 0x3ED7010
	private Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	// RVA: 0x3ED70E0 Offset: 0x3ED71E1 VA: 0x3ED70E0
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x3ED7170 Offset: 0x3ED7271 VA: 0x3ED7170
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x3ED7240 Offset: 0x3ED7341 VA: 0x3ED7240
	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	// RVA: 0x3ED72B0 Offset: 0x3ED73B1 VA: 0x3ED72B0
	private Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	// RVA: 0x3ED7380 Offset: 0x3ED7481 VA: 0x3ED7380
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x3ED7410 Offset: 0x3ED7511 VA: 0x3ED7410
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x3ED74E0 Offset: 0x3ED75E1 VA: 0x3ED74E0
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x3ED7540 Offset: 0x3ED7641 VA: 0x3ED7540
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x3ED7590 Offset: 0x3ED7691 VA: 0x3ED7590
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x3ED7600 Offset: 0x3ED7701 VA: 0x3ED7600
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x3ED7660 Offset: 0x3ED7761 VA: 0x3ED7660
	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	// RVA: 0x3ED76C0 Offset: 0x3ED77C1 VA: 0x3ED76C0
	private float GetGoalWeightRotation(AvatarIKGoal goal) { }

	// RVA: 0x3ED7710 Offset: 0x3ED7811 VA: 0x3ED7710
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x3ED7780 Offset: 0x3ED7881 VA: 0x3ED7780
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x3ED77E0 Offset: 0x3ED78E1 VA: 0x3ED77E0
	public Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	// RVA: 0x3ED7860 Offset: 0x3ED7961 VA: 0x3ED7860
	private Vector3 GetHintPosition(AvatarIKHint hint) { }

	// RVA: 0x3ED7930 Offset: 0x3ED7A31 VA: 0x3ED7930
	public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x3ED79C0 Offset: 0x3ED7AC1 VA: 0x3ED79C0
	private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x3ED7A90 Offset: 0x3ED7B91 VA: 0x3ED7A90
	public float GetIKHintPositionWeight(AvatarIKHint hint) { }

	// RVA: 0x3ED7AF0 Offset: 0x3ED7BF1 VA: 0x3ED7AF0
	private float GetHintWeightPosition(AvatarIKHint hint) { }

	// RVA: 0x3ED7B40 Offset: 0x3ED7C41 VA: 0x3ED7B40
	public void SetIKHintPositionWeight(AvatarIKHint hint, float value) { }

	// RVA: 0x3ED7BB0 Offset: 0x3ED7CB1 VA: 0x3ED7BB0
	private void SetHintWeightPosition(AvatarIKHint hint, float value) { }

	// RVA: 0x3ED7C10 Offset: 0x3ED7D11 VA: 0x3ED7C10
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethodAttribute] // RVA: 0x36FF0 Offset: 0x370F1 VA: 0x36FF0
	// RVA: 0x3ED7C90 Offset: 0x3ED7D91 VA: 0x3ED7C90
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x3ED7D40 Offset: 0x3ED7E41 VA: 0x3ED7D40
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x3ED7E30 Offset: 0x3ED7F31 VA: 0x3ED7E30
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x3ED7EA0 Offset: 0x3ED7FA1 VA: 0x3ED7EA0
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x3ED7F20 Offset: 0x3ED8021 VA: 0x3ED7F20
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x3ED7FA0 Offset: 0x3ED80A1 VA: 0x3ED7FA0
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethodAttribute] // RVA: 0x37030 Offset: 0x37131 VA: 0x37030
	// RVA: 0x3ED7DB0 Offset: 0x3ED7EB1 VA: 0x3ED7DB0
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x3ED8030 Offset: 0x3ED8131 VA: 0x3ED8030
	public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	[NativeMethodAttribute] // RVA: 0x37070 Offset: 0x37171 VA: 0x37070
	// RVA: 0x3ED8140 Offset: 0x3ED8241 VA: 0x3ED8140
	private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) { }

	// RVA: 0x3ED8210 Offset: 0x3ED8311 VA: 0x3ED8210
	private ScriptableObject GetBehaviour(Type type) { }

	// RVA: -1 Offset: -1
	public T GetBehaviour<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32808C0 Offset: 0x32809C1 VA: 0x32808C0
	|-Animator.GetBehaviour<object>
	*/

	// RVA: -1 Offset: -1
	private static T[] ConvertStateMachineBehaviour<T>(ScriptableObject[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3280790 Offset: 0x3280891 VA: 0x3280790
	|-Animator.ConvertStateMachineBehaviour<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetBehaviours<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32809D0 Offset: 0x3280AD1 VA: 0x32809D0
	|-Animator.GetBehaviours<object>
	*/

	[FreeFunctionAttribute] // RVA: 0x370B0 Offset: 0x371B1 VA: 0x370B0
	// RVA: 0x3ED8260 Offset: 0x3ED8361 VA: 0x3ED8260
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	// RVA: 0x3ED82B0 Offset: 0x3ED83B1 VA: 0x3ED82B0
	public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0x37100 Offset: 0x37201 VA: 0x37100
	// RVA: 0x3ED83A0 Offset: 0x3ED84A1 VA: 0x3ED83A0
	internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type) { }

	// RVA: 0x3ED8410 Offset: 0x3ED8511 VA: 0x3ED8410
	public bool get_stabilizeFeet() { }

	// RVA: 0x3ED8460 Offset: 0x3ED8561 VA: 0x3ED8460
	public void set_stabilizeFeet(bool value) { }

	// RVA: 0x3ED84B0 Offset: 0x3ED85B1 VA: 0x3ED84B0
	public int get_layerCount() { }

	// RVA: 0x3ED8500 Offset: 0x3ED8601 VA: 0x3ED8500
	public string GetLayerName(int layerIndex) { }

	// RVA: 0x3ED8550 Offset: 0x3ED8651 VA: 0x3ED8550
	public int GetLayerIndex(string layerName) { }

	// RVA: 0x3ED85A0 Offset: 0x3ED86A1 VA: 0x3ED85A0
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x3ED85F0 Offset: 0x3ED86F1 VA: 0x3ED85F0
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x3ED8650 Offset: 0x3ED8751 VA: 0x3ED8650
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0x3ED86C0 Offset: 0x3ED87C1 VA: 0x3ED86C0
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x3ED8750 Offset: 0x3ED8851 VA: 0x3ED8750
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x3ED87E0 Offset: 0x3ED88E1 VA: 0x3ED87E0
	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) { }

	// RVA: 0x3ED8840 Offset: 0x3ED8941 VA: 0x3ED8840
	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	// RVA: 0x3ED88C0 Offset: 0x3ED89C1 VA: 0x3ED88C0
	internal int GetAnimatorClipInfoCount(int layerIndex, bool current) { }

	// RVA: 0x3ED8920 Offset: 0x3ED8A21 VA: 0x3ED8920
	public int GetCurrentAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x3ED8980 Offset: 0x3ED8A81 VA: 0x3ED8980
	public int GetNextAnimatorClipInfoCount(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0x37150 Offset: 0x37251 VA: 0x37150
	// RVA: 0x3ED89E0 Offset: 0x3ED8AE1 VA: 0x3ED89E0
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0x371A0 Offset: 0x372A1 VA: 0x371A0
	// RVA: 0x3ED8A30 Offset: 0x3ED8B31 VA: 0x3ED8A30
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x3ED8A80 Offset: 0x3ED8B81 VA: 0x3ED8A80
	public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	[FreeFunctionAttribute] // RVA: 0x371F0 Offset: 0x372F1 VA: 0x371F0
	// RVA: 0x3ED8B30 Offset: 0x3ED8C31 VA: 0x3ED8B30
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	// RVA: 0x3ED8BA0 Offset: 0x3ED8CA1 VA: 0x3ED8BA0
	public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	// RVA: 0x3ED8C50 Offset: 0x3ED8D51 VA: 0x3ED8C50
	public bool IsInTransition(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0x37240 Offset: 0x37341 VA: 0x37240
	// RVA: 0x3ED8CA0 Offset: 0x3ED8DA1 VA: 0x3ED8CA0
	public AnimatorControllerParameter[] get_parameters() { }

	// RVA: 0x3ED8CF0 Offset: 0x3ED8DF1 VA: 0x3ED8CF0
	public int get_parameterCount() { }

	// RVA: 0x3ED8D40 Offset: 0x3ED8E41 VA: 0x3ED8D40
	public AnimatorControllerParameter GetParameter(int index) { }

	// RVA: 0x3ED8E70 Offset: 0x3ED8F71 VA: 0x3ED8E70
	public float get_feetPivotActive() { }

	// RVA: 0x3ED8EC0 Offset: 0x3ED8FC1 VA: 0x3ED8EC0
	public void set_feetPivotActive(float value) { }

	// RVA: 0x3ED8F10 Offset: 0x3ED9011 VA: 0x3ED8F10
	public float get_pivotWeight() { }

	// RVA: 0x3ED8F60 Offset: 0x3ED9061 VA: 0x3ED8F60
	public Vector3 get_pivotPosition() { }

	// RVA: 0x3ED9010 Offset: 0x3ED9111 VA: 0x3ED9010
	private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x3ED9160 Offset: 0x3ED9261 VA: 0x3ED9160
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) { }

	// RVA: 0x3ED9200 Offset: 0x3ED9301 VA: 0x3ED9200
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) { }

	// RVA: 0x3ED92B0 Offset: 0x3ED93B1 VA: 0x3ED92B0
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x3ED9360 Offset: 0x3ED9461 VA: 0x3ED9360
	public void InterruptMatchTarget() { }

	// RVA: 0x3ED93B0 Offset: 0x3ED94B1 VA: 0x3ED93B0
	public void InterruptMatchTarget(bool completeMatch) { }

	[NativeMethodAttribute] // RVA: 0x37290 Offset: 0x37391 VA: 0x37290
	// RVA: 0x3ED9400 Offset: 0x3ED9501 VA: 0x3ED9400
	public bool get_isMatchingTarget() { }

	// RVA: 0x3ED9450 Offset: 0x3ED9551 VA: 0x3ED9450
	public float get_speed() { }

	// RVA: 0x3ED94A0 Offset: 0x3ED95A1 VA: 0x3ED94A0
	public void set_speed(float value) { }

	[ObsoleteAttribute] // RVA: 0x372D0 Offset: 0x373D1 VA: 0x372D0
	// RVA: 0x3ED94F0 Offset: 0x3ED95F1 VA: 0x3ED94F0
	public void ForceStateNormalizedTime(float normalizedTime) { }

	// RVA: 0x3ED95C0 Offset: 0x3ED96C1 VA: 0x3ED95C0
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) { }

	// RVA: 0x3ED9730 Offset: 0x3ED9831 VA: 0x3ED9730
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x3ED97D0 Offset: 0x3ED98D1 VA: 0x3ED97D0
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x3ED9870 Offset: 0x3ED9971 VA: 0x3ED9870
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x3ED9920 Offset: 0x3ED9A21 VA: 0x3ED9920
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x3ED99A0 Offset: 0x3ED9AA1 VA: 0x3ED99A0
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x3ED9A10 Offset: 0x3ED9B11 VA: 0x3ED9A10
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) { }

	[FreeFunctionAttribute] // RVA: 0x37310 Offset: 0x37411 VA: 0x37310
	// RVA: 0x3ED96B0 Offset: 0x3ED97B1 VA: 0x3ED96B0
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunctionAttribute] // RVA: 0x37360 Offset: 0x37461 VA: 0x37360
	// RVA: 0x3ED9A80 Offset: 0x3ED9B81 VA: 0x3ED9A80
	public void WriteDefaultValues() { }

	// RVA: 0x3ED9AD0 Offset: 0x3ED9BD1 VA: 0x3ED9AD0
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x3ED9C20 Offset: 0x3ED9D21 VA: 0x3ED9C20
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x3ED9CC0 Offset: 0x3ED9DC1 VA: 0x3ED9CC0
	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	// RVA: 0x3ED9B70 Offset: 0x3ED9C71 VA: 0x3ED9B70
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunctionAttribute] // RVA: 0x373B0 Offset: 0x374B1 VA: 0x373B0
	// RVA: 0x3ED9D60 Offset: 0x3ED9E61 VA: 0x3ED9D60
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x3ED9DE0 Offset: 0x3ED9EE1 VA: 0x3ED9DE0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x3ED9E60 Offset: 0x3ED9F61 VA: 0x3ED9E60
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x3ED9EE0 Offset: 0x3ED9FE1 VA: 0x3ED9EE0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration) { }

	// RVA: 0x3ED9F50 Offset: 0x3EDA051 VA: 0x3ED9F50
	public void PlayInFixedTime(string stateName, int layer) { }

	// RVA: 0x3EDA080 Offset: 0x3EDA181 VA: 0x3EDA080
	public void PlayInFixedTime(string stateName) { }

	// RVA: 0x3ED9FE0 Offset: 0x3EDA0E1 VA: 0x3ED9FE0
	public void PlayInFixedTime(string stateName, int layer, float fixedTime) { }

	[FreeFunctionAttribute] // RVA: 0x37400 Offset: 0x37501 VA: 0x37400
	// RVA: 0x3EDA110 Offset: 0x3EDA211 VA: 0x3EDA110
	public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	// RVA: 0x3EDA180 Offset: 0x3EDA281 VA: 0x3EDA180
	public void PlayInFixedTime(int stateNameHash, int layer) { }

	// RVA: 0x3EDA1E0 Offset: 0x3EDA2E1 VA: 0x3EDA1E0
	public void PlayInFixedTime(int stateNameHash) { }

	// RVA: 0x3EDA240 Offset: 0x3EDA341 VA: 0x3EDA240
	public void Play(string stateName, int layer) { }

	// RVA: 0x3EDA370 Offset: 0x3EDA471 VA: 0x3EDA370
	public void Play(string stateName) { }

	// RVA: 0x3EDA2D0 Offset: 0x3EDA3D1 VA: 0x3EDA2D0
	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunctionAttribute] // RVA: 0x37450 Offset: 0x37551 VA: 0x37450
	// RVA: 0x3ED9550 Offset: 0x3ED9651 VA: 0x3ED9550
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x3EDA400 Offset: 0x3EDA501 VA: 0x3EDA400
	public void Play(int stateNameHash, int layer) { }

	// RVA: 0x3EDA460 Offset: 0x3EDA561 VA: 0x3EDA460
	public void Play(int stateNameHash) { }

	// RVA: 0x3EDA4C0 Offset: 0x3EDA5C1 VA: 0x3EDA4C0
	public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) { }

	// RVA: 0x3EDA520 Offset: 0x3EDA621 VA: 0x3EDA520
	public Vector3 get_targetPosition() { }

	// RVA: 0x3EDA5D0 Offset: 0x3EDA6D1 VA: 0x3EDA5D0
	public Quaternion get_targetRotation() { }

	[ObsoleteAttribute] // RVA: 0x374A0 Offset: 0x375A1 VA: 0x374A0
	[EditorBrowsableAttribute] // RVA: 0x374A0 Offset: 0x375A1 VA: 0x374A0
	// RVA: 0x3EDA680 Offset: 0x3EDA781 VA: 0x3EDA680
	public bool IsControlled(Transform transform) { }

	// RVA: 0x3EDA690 Offset: 0x3EDA791 VA: 0x3EDA690
	internal bool IsBoneTransform(Transform transform) { }

	// RVA: 0x3EDA6E0 Offset: 0x3EDA7E1 VA: 0x3EDA6E0
	internal Transform get_avatarRoot() { }

	// RVA: 0x3EDA730 Offset: 0x3EDA831 VA: 0x3EDA730
	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	[NativeMethodAttribute] // RVA: 0x37500 Offset: 0x37601 VA: 0x37500
	// RVA: 0x3EDA850 Offset: 0x3EDA951 VA: 0x3EDA850
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	// RVA: 0x3EDA8A0 Offset: 0x3EDA9A1 VA: 0x3EDA8A0
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x3EDA8F0 Offset: 0x3EDA9F1 VA: 0x3EDA8F0
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x3EDA940 Offset: 0x3EDAA41 VA: 0x3EDA940
	public void StartPlayback() { }

	// RVA: 0x3EDA990 Offset: 0x3EDAA91 VA: 0x3EDA990
	public void StopPlayback() { }

	// RVA: 0x3EDA9E0 Offset: 0x3EDAAE1 VA: 0x3EDA9E0
	public float get_playbackTime() { }

	// RVA: 0x3EDAA30 Offset: 0x3EDAB31 VA: 0x3EDAA30
	public void set_playbackTime(float value) { }

	// RVA: 0x3EDAA80 Offset: 0x3EDAB81 VA: 0x3EDAA80
	public void StartRecording(int frameCount) { }

	// RVA: 0x3EDAAD0 Offset: 0x3EDABD1 VA: 0x3EDAAD0
	public void StopRecording() { }

	// RVA: 0x3EDAB20 Offset: 0x3EDAC21 VA: 0x3EDAB20
	public float get_recorderStartTime() { }

	// RVA: 0x3EDABC0 Offset: 0x3EDACC1 VA: 0x3EDABC0
	public void set_recorderStartTime(float value) { }

	// RVA: 0x3EDAB70 Offset: 0x3EDAC71 VA: 0x3EDAB70
	private float GetRecorderStartTime() { }

	// RVA: 0x3EDABD0 Offset: 0x3EDACD1 VA: 0x3EDABD0
	public float get_recorderStopTime() { }

	// RVA: 0x3EDAC70 Offset: 0x3EDAD71 VA: 0x3EDAC70
	public void set_recorderStopTime(float value) { }

	// RVA: 0x3EDAC20 Offset: 0x3EDAD21 VA: 0x3EDAC20
	private float GetRecorderStopTime() { }

	// RVA: 0x3EDAC80 Offset: 0x3EDAD81 VA: 0x3EDAC80
	public AnimatorRecorderMode get_recorderMode() { }

	// RVA: 0x3EDACD0 Offset: 0x3EDADD1 VA: 0x3EDACD0
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x3EDAD20 Offset: 0x3EDAE21 VA: 0x3EDAD20
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethodAttribute] // RVA: 0x37540 Offset: 0x37641 VA: 0x37540
	// RVA: 0x3EDAD70 Offset: 0x3EDAE71 VA: 0x3EDAD70
	public bool get_hasBoundPlayables() { }

	// RVA: 0x3EDADC0 Offset: 0x3EDAEC1 VA: 0x3EDADC0
	internal void ClearInternalControllerPlayable() { }

	// RVA: 0x3EDAE10 Offset: 0x3EDAF11 VA: 0x3EDAE10
	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethodAttribute] // RVA: 0x37580 Offset: 0x37681 VA: 0x37580
	// RVA: 0x3ED9660 Offset: 0x3ED9761 VA: 0x3ED9660
	public static int StringToHash(string name) { }

	// RVA: 0x3EDAE70 Offset: 0x3EDAF71 VA: 0x3EDAE70
	public Avatar get_avatar() { }

	// RVA: 0x3EDAEC0 Offset: 0x3EDAFC1 VA: 0x3EDAEC0
	public void set_avatar(Avatar value) { }

	// RVA: 0x3EDAF10 Offset: 0x3EDB011 VA: 0x3EDAF10
	internal string GetStats() { }

	// RVA: 0x3EDAF60 Offset: 0x3EDB061 VA: 0x3EDAF60
	public PlayableGraph get_playableGraph() { }

	[FreeFunctionAttribute] // RVA: 0x375D0 Offset: 0x376D1 VA: 0x375D0
	// RVA: 0x3EDAFC0 Offset: 0x3EDB0C1 VA: 0x3EDAFC0
	private void GetCurrentGraph(ref PlayableGraph graph) { }

	// RVA: 0x3ED6A60 Offset: 0x3ED6B61 VA: 0x3ED6A60
	private void CheckIfInIKPass() { }

	// RVA: 0x3EDB060 Offset: 0x3EDB161 VA: 0x3EDB060
	private bool IsInIKPass() { }

	[FreeFunctionAttribute] // RVA: 0x37620 Offset: 0x37721 VA: 0x37620
	// RVA: 0x3ED5410 Offset: 0x3ED5511 VA: 0x3ED5410
	private void SetFloatString(string name, float value) { }

	[FreeFunctionAttribute] // RVA: 0x37670 Offset: 0x37771 VA: 0x37670
	// RVA: 0x3ED55D0 Offset: 0x3ED56D1 VA: 0x3ED55D0
	private void SetFloatID(int id, float value) { }

	[FreeFunctionAttribute] // RVA: 0x376C0 Offset: 0x377C1 VA: 0x376C0
	// RVA: 0x3ED52C0 Offset: 0x3ED53C1 VA: 0x3ED52C0
	private float GetFloatString(string name) { }

	[FreeFunctionAttribute] // RVA: 0x37710 Offset: 0x37811 VA: 0x37710
	// RVA: 0x3ED5360 Offset: 0x3ED5461 VA: 0x3ED5360
	private float GetFloatID(int id) { }

	[FreeFunctionAttribute] // RVA: 0x37760 Offset: 0x37861 VA: 0x37760
	// RVA: 0x3ED58D0 Offset: 0x3ED59D1 VA: 0x3ED58D0
	private void SetBoolString(string name, bool value) { }

	[FreeFunctionAttribute] // RVA: 0x377B0 Offset: 0x378B1 VA: 0x377B0
	// RVA: 0x3ED5990 Offset: 0x3ED5A91 VA: 0x3ED5990
	private void SetBoolID(int id, bool value) { }

	[FreeFunctionAttribute] // RVA: 0x37800 Offset: 0x37901 VA: 0x37800
	// RVA: 0x3ED5780 Offset: 0x3ED5881 VA: 0x3ED5780
	private bool GetBoolString(string name) { }

	[FreeFunctionAttribute] // RVA: 0x37850 Offset: 0x37951 VA: 0x37850
	// RVA: 0x3ED5820 Offset: 0x3ED5921 VA: 0x3ED5820
	private bool GetBoolID(int id) { }

	[FreeFunctionAttribute] // RVA: 0x378A0 Offset: 0x379A1 VA: 0x378A0
	// RVA: 0x3ED5B90 Offset: 0x3ED5C91 VA: 0x3ED5B90
	private void SetIntegerString(string name, int value) { }

	[FreeFunctionAttribute] // RVA: 0x378F0 Offset: 0x379F1 VA: 0x378F0
	// RVA: 0x3ED5C50 Offset: 0x3ED5D51 VA: 0x3ED5C50
	private void SetIntegerID(int id, int value) { }

	[FreeFunctionAttribute] // RVA: 0x37940 Offset: 0x37A41 VA: 0x37940
	// RVA: 0x3ED5A40 Offset: 0x3ED5B41 VA: 0x3ED5A40
	private int GetIntegerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0x37990 Offset: 0x37A91 VA: 0x37990
	// RVA: 0x3ED5AE0 Offset: 0x3ED5BE1 VA: 0x3ED5AE0
	private int GetIntegerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0x379E0 Offset: 0x37AE1 VA: 0x379E0
	// RVA: 0x3ED5D00 Offset: 0x3ED5E01 VA: 0x3ED5D00
	private void SetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0x37A30 Offset: 0x37B31 VA: 0x37A30
	// RVA: 0x3ED5DA0 Offset: 0x3ED5EA1 VA: 0x3ED5DA0
	private void SetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0x37A80 Offset: 0x37B81 VA: 0x37A80
	// RVA: 0x3ED5E40 Offset: 0x3ED5F41 VA: 0x3ED5E40
	private void ResetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0x37AD0 Offset: 0x37BD1 VA: 0x37AD0
	// RVA: 0x3ED5EE0 Offset: 0x3ED5FE1 VA: 0x3ED5EE0
	private void ResetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0x37B20 Offset: 0x37C21 VA: 0x37B20
	// RVA: 0x3ED5F80 Offset: 0x3ED6081 VA: 0x3ED5F80
	private bool IsParameterControlledByCurveString(string name) { }

	[FreeFunctionAttribute] // RVA: 0x37B70 Offset: 0x37C71 VA: 0x37B70
	// RVA: 0x3ED6020 Offset: 0x3ED6121 VA: 0x3ED6020
	private bool IsParameterControlledByCurveID(int id) { }

	[FreeFunctionAttribute] // RVA: 0x37BC0 Offset: 0x37CC1 VA: 0x37BC0
	// RVA: 0x3ED54F0 Offset: 0x3ED55F1 VA: 0x3ED54F0
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunctionAttribute] // RVA: 0x37C10 Offset: 0x37D11 VA: 0x37C10
	// RVA: 0x3ED56B0 Offset: 0x3ED57B1 VA: 0x3ED56B0
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x3EDB0B0 Offset: 0x3EDB1B1 VA: 0x3EDB0B0
	public bool get_layersAffectMassCenter() { }

	// RVA: 0x3EDB100 Offset: 0x3EDB201 VA: 0x3EDB100
	public void set_layersAffectMassCenter(bool value) { }

	// RVA: 0x3EDB150 Offset: 0x3EDB251 VA: 0x3EDB150
	public float get_leftFeetBottomHeight() { }

	// RVA: 0x3EDB1A0 Offset: 0x3EDB2A1 VA: 0x3EDB1A0
	public float get_rightFeetBottomHeight() { }

	[NativeMethodAttribute] // RVA: 0x37C60 Offset: 0x37D61 VA: 0x37C60
	// RVA: 0x3EDB1F0 Offset: 0x3EDB2F1 VA: 0x3EDB1F0
	internal bool get_supportsOnAnimatorMove() { }

	[NativeConditionalAttribute] // RVA: 0x37CA0 Offset: 0x37DA1 VA: 0x37CA0
	// RVA: 0x3EDB240 Offset: 0x3EDB341 VA: 0x3EDB240
	internal void OnUpdateModeChanged() { }

	[NativeConditionalAttribute] // RVA: 0x37CE0 Offset: 0x37DE1 VA: 0x37CE0
	// RVA: 0x3EDB290 Offset: 0x3EDB391 VA: 0x3EDB290
	internal void OnCullingModeChanged() { }

	[NativeConditionalAttribute] // RVA: 0x37D20 Offset: 0x37E21 VA: 0x37D20
	// RVA: 0x3EDB2E0 Offset: 0x3EDB3E1 VA: 0x3EDB2E0
	internal void WriteDefaultPose() { }

	[NativeMethodAttribute] // RVA: 0x37D60 Offset: 0x37E61 VA: 0x37D60
	// RVA: 0x3EDB330 Offset: 0x3EDB431 VA: 0x3EDB330
	public void Update(float deltaTime) { }

	// RVA: 0x3EDB380 Offset: 0x3EDB481 VA: 0x3EDB380
	public void Rebind() { }

	// RVA: 0x3EDB3D0 Offset: 0x3EDB4D1 VA: 0x3EDB3D0
	private void Rebind(bool writeDefaultValues) { }

	// RVA: 0x3EDB420 Offset: 0x3EDB521 VA: 0x3EDB420
	public void ApplyBuiltinRootMotion() { }

	[NativeConditionalAttribute] // RVA: 0x37DA0 Offset: 0x37EA1 VA: 0x37DA0
	// RVA: 0x3EDB470 Offset: 0x3EDB571 VA: 0x3EDB470
	internal void EvaluateController() { }

	// RVA: 0x3EDB4C0 Offset: 0x3EDB5C1 VA: 0x3EDB4C0
	private void EvaluateController(float deltaTime) { }

	[NativeConditionalAttribute] // RVA: 0x37DE0 Offset: 0x37EE1 VA: 0x37DE0
	// RVA: 0x3EDB510 Offset: 0x3EDB611 VA: 0x3EDB510
	internal string GetCurrentStateName(int layerIndex) { }

	[NativeConditionalAttribute] // RVA: 0x37E20 Offset: 0x37F21 VA: 0x37E20
	// RVA: 0x3EDB5D0 Offset: 0x3EDB6D1 VA: 0x3EDB5D0
	internal string GetNextStateName(int layerIndex) { }

	[NativeConditionalAttribute] // RVA: 0x37E60 Offset: 0x37F61 VA: 0x37E60
	// RVA: 0x3EDB570 Offset: 0x3EDB671 VA: 0x3EDB570
	private string GetAnimatorStateName(int layerIndex, bool current) { }

	// RVA: 0x3EDB630 Offset: 0x3EDB731 VA: 0x3EDB630
	internal string ResolveHash(int hash) { }

	// RVA: 0x3EDB010 Offset: 0x3EDB111 VA: 0x3EDB010
	public bool get_logWarnings() { }

	// RVA: 0x3EDB680 Offset: 0x3EDB781 VA: 0x3EDB680
	public void set_logWarnings(bool value) { }

	// RVA: 0x3EDB6D0 Offset: 0x3EDB7D1 VA: 0x3EDB6D0
	public bool get_fireEvents() { }

	// RVA: 0x3EDB720 Offset: 0x3EDB821 VA: 0x3EDB720
	public void set_fireEvents(bool value) { }

	// RVA: 0x3EDB770 Offset: 0x3EDB871 VA: 0x3EDB770
	public bool get_keepAnimatorControllerStateOnDisable() { }

	// RVA: 0x3EDB7C0 Offset: 0x3EDB8C1 VA: 0x3EDB7C0
	public void set_keepAnimatorControllerStateOnDisable(bool value) { }

	[ObsoleteAttribute] // RVA: 0x37EA0 Offset: 0x37FA1 VA: 0x37EA0
	// RVA: 0x3EDB810 Offset: 0x3EDB911 VA: 0x3EDB810
	public Vector3 GetVector(string name) { }

	[ObsoleteAttribute] // RVA: 0x37EE0 Offset: 0x37FE1 VA: 0x37EE0
	// RVA: 0x3EDB820 Offset: 0x3EDB921 VA: 0x3EDB820
	public Vector3 GetVector(int id) { }

	[ObsoleteAttribute] // RVA: 0x37F20 Offset: 0x38021 VA: 0x37F20
	// RVA: 0x3EDB830 Offset: 0x3EDB931 VA: 0x3EDB830
	public void SetVector(string name, Vector3 value) { }

	[ObsoleteAttribute] // RVA: 0x37F60 Offset: 0x38061 VA: 0x37F60
	// RVA: 0x3EDB840 Offset: 0x3EDB941 VA: 0x3EDB840
	public void SetVector(int id, Vector3 value) { }

	[ObsoleteAttribute] // RVA: 0x37FA0 Offset: 0x380A1 VA: 0x37FA0
	// RVA: 0x3EDB850 Offset: 0x3EDB951 VA: 0x3EDB850
	public Quaternion GetQuaternion(string name) { }

	[ObsoleteAttribute] // RVA: 0x37FE0 Offset: 0x380E1 VA: 0x37FE0
	// RVA: 0x3EDB860 Offset: 0x3EDB961 VA: 0x3EDB860
	public Quaternion GetQuaternion(int id) { }

	[ObsoleteAttribute] // RVA: 0x38020 Offset: 0x38121 VA: 0x38020
	// RVA: 0x3EDB870 Offset: 0x3EDB971 VA: 0x3EDB870
	public void SetQuaternion(string name, Quaternion value) { }

	[ObsoleteAttribute] // RVA: 0x38060 Offset: 0x38161 VA: 0x38060
	// RVA: 0x3EDB880 Offset: 0x3EDB981 VA: 0x3EDB880
	public void SetQuaternion(int id, Quaternion value) { }

	// RVA: 0x3EDB890 Offset: 0x3EDB991 VA: 0x3EDB890
	public void .ctor() { }

	// RVA: 0x3ED60D0 Offset: 0x3ED61D1 VA: 0x3ED60D0
	private void get_deltaPosition_Injected(out Vector3 ret) { }

	// RVA: 0x3ED6180 Offset: 0x3ED6281 VA: 0x3ED6180
	private void get_deltaRotation_Injected(out Quaternion ret) { }

	// RVA: 0x3ED6230 Offset: 0x3ED6331 VA: 0x3ED6230
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x3ED62E0 Offset: 0x3ED63E1 VA: 0x3ED62E0
	private void get_angularVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x3ED6390 Offset: 0x3ED6491 VA: 0x3ED6390
	private void get_rootPosition_Injected(out Vector3 ret) { }

	// RVA: 0x3ED6440 Offset: 0x3ED6541 VA: 0x3ED6440
	private void set_rootPosition_Injected(ref Vector3 value) { }

	// RVA: 0x3ED64F0 Offset: 0x3ED65F1 VA: 0x3ED64F0
	private void get_rootRotation_Injected(out Quaternion ret) { }

	// RVA: 0x3ED65A0 Offset: 0x3ED66A1 VA: 0x3ED65A0
	private void set_rootRotation_Injected(ref Quaternion value) { }

	// RVA: 0x3ED6CB0 Offset: 0x3ED6DB1 VA: 0x3ED6CB0
	private void get_bodyPositionInternal_Injected(out Vector3 ret) { }

	// RVA: 0x3ED6D00 Offset: 0x3ED6E01 VA: 0x3ED6D00
	private void set_bodyPositionInternal_Injected(ref Vector3 value) { }

	// RVA: 0x3ED6EF0 Offset: 0x3ED6FF1 VA: 0x3ED6EF0
	private void get_bodyRotationInternal_Injected(out Quaternion ret) { }

	// RVA: 0x3ED6F40 Offset: 0x3ED7041 VA: 0x3ED6F40
	private void set_bodyRotationInternal_Injected(ref Quaternion value) { }

	// RVA: 0x3ED7080 Offset: 0x3ED7181 VA: 0x3ED7080
	private void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret) { }

	// RVA: 0x3ED71E0 Offset: 0x3ED72E1 VA: 0x3ED71E0
	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	// RVA: 0x3ED7320 Offset: 0x3ED7421 VA: 0x3ED7320
	private void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret) { }

	// RVA: 0x3ED7480 Offset: 0x3ED7581 VA: 0x3ED7480
	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	// RVA: 0x3ED78D0 Offset: 0x3ED79D1 VA: 0x3ED78D0
	private void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret) { }

	// RVA: 0x3ED7A30 Offset: 0x3ED7B31 VA: 0x3ED7A30
	private void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition) { }

	// RVA: 0x3ED7CF0 Offset: 0x3ED7DF1 VA: 0x3ED7CF0
	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

	// RVA: 0x3ED81B0 Offset: 0x3ED82B1 VA: 0x3ED81B0
	private void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref Quaternion rotation) { }

	// RVA: 0x3ED8FC0 Offset: 0x3ED90C1 VA: 0x3ED8FC0
	private void get_pivotPosition_Injected(out Vector3 ret) { }

	// RVA: 0x3ED90C0 Offset: 0x3ED91C1 VA: 0x3ED90C0
	private void MatchTarget_Injected(ref Vector3 matchPosition, ref Quaternion matchRotation, int targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x3EDA580 Offset: 0x3EDA681 VA: 0x3EDA580
	private void get_targetPosition_Injected(out Vector3 ret) { }

	// RVA: 0x3EDA630 Offset: 0x3EDA731 VA: 0x3EDA630
	private void get_targetRotation_Injected(out Quaternion ret) { }
}


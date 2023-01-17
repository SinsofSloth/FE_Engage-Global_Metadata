// Namespace: System.Linq.Expressions
internal static class Error // TypeDefIndex: 2814
{
	// Methods

	// RVA: 0x2E5A160 Offset: 0x2E5A261 VA: 0x2E5A160
	internal static Exception ReducibleMustOverrideReduce() { }

	// RVA: 0x2E5A1D0 Offset: 0x2E5A2D1 VA: 0x2E5A1D0
	internal static Exception CollectionModifiedWhileEnumerating() { }

	// RVA: 0x2E5A240 Offset: 0x2E5A341 VA: 0x2E5A240
	internal static Exception MustReduceToDifferent() { }

	// RVA: 0x2E5A2B0 Offset: 0x2E5A3B1 VA: 0x2E5A2B0
	internal static Exception ReducedNotCompatible() { }

	// RVA: 0x2E5A320 Offset: 0x2E5A421 VA: 0x2E5A320
	internal static Exception SetterHasNoParams(string paramName) { }

	// RVA: 0x2E5A3A0 Offset: 0x2E5A4A1 VA: 0x2E5A3A0
	internal static Exception PropertyCannotHaveRefType(string paramName) { }

	// RVA: 0x2E5A420 Offset: 0x2E5A521 VA: 0x2E5A420
	internal static Exception IndexesOfSetGetMustMatch(string paramName) { }

	// RVA: 0x2E5A4A0 Offset: 0x2E5A5A1 VA: 0x2E5A4A0
	internal static Exception AccessorsCannotHaveVarArgs(string paramName) { }

	// RVA: 0x2E5A520 Offset: 0x2E5A621 VA: 0x2E5A520
	private static Exception AccessorsCannotHaveByRefArgs(string paramName) { }

	// RVA: 0x2E5A5A0 Offset: 0x2E5A6A1 VA: 0x2E5A5A0
	internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index) { }

	// RVA: 0x2E5A730 Offset: 0x2E5A831 VA: 0x2E5A730
	internal static Exception BoundsCannotBeLessThanOne(string paramName) { }

	// RVA: 0x2E5A7B0 Offset: 0x2E5A8B1 VA: 0x2E5A7B0
	internal static Exception TypeMustNotBeByRef(string paramName) { }

	// RVA: 0x2E5A830 Offset: 0x2E5A931 VA: 0x2E5A830
	internal static Exception TypeMustNotBePointer(string paramName) { }

	// RVA: 0x2E5A8B0 Offset: 0x2E5A9B1 VA: 0x2E5A8B0
	internal static Exception SetterMustBeVoid(string paramName) { }

	// RVA: 0x2E5A930 Offset: 0x2E5AA31 VA: 0x2E5A930
	internal static Exception PropertyTypeMustMatchGetter(string paramName) { }

	// RVA: 0x2E5A9B0 Offset: 0x2E5AAB1 VA: 0x2E5A9B0
	internal static Exception PropertyTypeMustMatchSetter(string paramName) { }

	// RVA: 0x2E5AA30 Offset: 0x2E5AB31 VA: 0x2E5AA30
	internal static Exception BothAccessorsMustBeStatic(string paramName) { }

	// RVA: 0x2E5AAB0 Offset: 0x2E5ABB1 VA: 0x2E5AAB0
	internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName) { }

	// RVA: 0x2E5AB30 Offset: 0x2E5AC31 VA: 0x2E5AB30
	internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName) { }

	// RVA: 0x2E5ABB0 Offset: 0x2E5ACB1 VA: 0x2E5ABB0
	internal static Exception OnlyStaticMethodsHaveNullInstance() { }

	// RVA: 0x2E5AC20 Offset: 0x2E5AD21 VA: 0x2E5AC20
	internal static Exception PropertyTypeCannotBeVoid(string paramName) { }

	// RVA: 0x2E5ACA0 Offset: 0x2E5ADA1 VA: 0x2E5ACA0
	internal static Exception InvalidUnboxType(string paramName) { }

	// RVA: 0x2E5AD20 Offset: 0x2E5AE21 VA: 0x2E5AD20
	internal static Exception ExpressionMustBeWriteable(string paramName) { }

	// RVA: 0x2E5ADA0 Offset: 0x2E5AEA1 VA: 0x2E5ADA0
	internal static Exception ArgumentMustNotHaveValueType(string paramName) { }

	// RVA: 0x2E5AE20 Offset: 0x2E5AF21 VA: 0x2E5AE20
	internal static Exception MustBeReducible() { }

	// RVA: 0x2E5AE90 Offset: 0x2E5AF91 VA: 0x2E5AE90
	internal static Exception LabelMustBeVoidOrHaveExpression(string paramName) { }

	// RVA: 0x2E5AF10 Offset: 0x2E5B011 VA: 0x2E5AF10
	internal static Exception QuotedExpressionMustBeLambda(string paramName) { }

	// RVA: 0x2E5AF90 Offset: 0x2E5B091 VA: 0x2E5AF90
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName) { }

	// RVA: 0x2E5B020 Offset: 0x2E5B121 VA: 0x2E5B020
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index) { }

	// RVA: 0x2E5B120 Offset: 0x2E5B221 VA: 0x2E5B120
	private static Exception DuplicateVariable(object p0, string paramName) { }

	// RVA: 0x2E5B1A0 Offset: 0x2E5B2A1 VA: 0x2E5B1A0
	internal static Exception DuplicateVariable(object p0, string paramName, int index) { }

	// RVA: 0x2E5B2A0 Offset: 0x2E5B3A1 VA: 0x2E5B2A0
	internal static Exception FaultCannotHaveCatchOrFinally(string paramName) { }

	// RVA: 0x2E5B320 Offset: 0x2E5B421 VA: 0x2E5B320
	internal static Exception TryMustHaveCatchFinallyOrFault() { }

	// RVA: 0x2E5B390 Offset: 0x2E5B491 VA: 0x2E5B390
	internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	// RVA: 0x2E5B400 Offset: 0x2E5B501 VA: 0x2E5B400
	internal static Exception ExtensionNodeMustOverrideProperty(object p0) { }

	// RVA: 0x2E5B480 Offset: 0x2E5B581 VA: 0x2E5B480
	internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName) { }

	// RVA: 0x2E5B500 Offset: 0x2E5B601 VA: 0x2E5B500
	internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName) { }

	// RVA: 0x2E5B580 Offset: 0x2E5B681 VA: 0x2E5B580
	internal static Exception CoercionOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x2E5B600 Offset: 0x2E5B701 VA: 0x2E5B600
	internal static Exception UnaryOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x2E5B680 Offset: 0x2E5B781 VA: 0x2E5B680
	internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	// RVA: 0x2E5B710 Offset: 0x2E5B811 VA: 0x2E5B710
	internal static Exception ReferenceEqualityNotDefined(object p0, object p1) { }

	// RVA: 0x2E5B790 Offset: 0x2E5B891 VA: 0x2E5B790
	internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1) { }

	// RVA: 0x2E5B810 Offset: 0x2E5B911 VA: 0x2E5B810
	internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	// RVA: 0x2E5B890 Offset: 0x2E5B991 VA: 0x2E5B890
	internal static Exception ConversionIsNotSupportedForArithmeticTypes() { }

	// RVA: 0x2E5B900 Offset: 0x2E5BA01 VA: 0x2E5B900
	internal static Exception ArgumentMustBeArray(string paramName) { }

	// RVA: 0x2E5B980 Offset: 0x2E5BA81 VA: 0x2E5B980
	internal static Exception ArgumentMustBeBoolean(string paramName) { }

	// RVA: 0x2E5BA00 Offset: 0x2E5BB01 VA: 0x2E5BA00
	private static Exception ArgumentMustBeInteger(string paramName) { }

	// RVA: 0x2E5BA80 Offset: 0x2E5BB81 VA: 0x2E5BA80
	internal static Exception ArgumentMustBeInteger(string paramName, int index) { }

	// RVA: 0x2E5BB70 Offset: 0x2E5BC71 VA: 0x2E5BB70
	internal static Exception ArgumentMustBeArrayIndexType(string paramName) { }

	// RVA: 0x2E5BBF0 Offset: 0x2E5BCF1 VA: 0x2E5BBF0
	internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName) { }

	// RVA: 0x2E5BC70 Offset: 0x2E5BD71 VA: 0x2E5BC70
	internal static Exception ArgumentTypesMustMatch() { }

	// RVA: 0x2E5BCE0 Offset: 0x2E5BDE1 VA: 0x2E5BCE0
	internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	// RVA: 0x2E5BD60 Offset: 0x2E5BE61 VA: 0x2E5BD60
	internal static Exception IncorrectTypeForTypeAs(object p0, string paramName) { }

	// RVA: 0x2E5BDE0 Offset: 0x2E5BEE1 VA: 0x2E5BDE0
	internal static Exception CoalesceUsedOnNonNullType() { }

	// RVA: 0x2E5BE50 Offset: 0x2E5BF51 VA: 0x2E5BE50
	internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	// RVA: 0x2E5BED0 Offset: 0x2E5BFD1 VA: 0x2E5BED0
	internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	// RVA: 0x2E5BF50 Offset: 0x2E5C051 VA: 0x2E5BF50
	internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	// RVA: 0x2E5BFD0 Offset: 0x2E5C0D1 VA: 0x2E5BFD0
	internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	// RVA: 0x2E5C050 Offset: 0x2E5C151 VA: 0x2E5C050
	internal static Exception ExpressionTypeNotInvocable(object p0, string paramName) { }

	// RVA: 0x2E5C0D0 Offset: 0x2E5C1D1 VA: 0x2E5C0D0
	internal static Exception InstanceFieldNotDefinedForType(object p0, object p1) { }

	// RVA: 0x2E5C150 Offset: 0x2E5C251 VA: 0x2E5C150
	internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	// RVA: 0x2E5C1E0 Offset: 0x2E5C2E1 VA: 0x2E5C1E0
	internal static Exception IncorrectNumberOfIndexes() { }

	// RVA: 0x2E5C250 Offset: 0x2E5C351 VA: 0x2E5C250
	internal static Exception IncorrectNumberOfLambdaDeclarationParameters() { }

	// RVA: 0x2E5C2C0 Offset: 0x2E5C3C1 VA: 0x2E5C2C0
	internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName) { }

	// RVA: 0x2E5C340 Offset: 0x2E5C441 VA: 0x2E5C340
	internal static Exception MemberNotFieldOrProperty(object p0, string paramName) { }

	// RVA: 0x2E5C3C0 Offset: 0x2E5C4C1 VA: 0x2E5C3C0
	internal static Exception MethodContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x2E5C440 Offset: 0x2E5C541 VA: 0x2E5C440
	internal static Exception MethodIsGeneric(object p0, string paramName) { }

	// RVA: 0x2E5C4C0 Offset: 0x2E5C5C1 VA: 0x2E5C4C0
	internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName) { }

	// RVA: 0x2E5C540 Offset: 0x2E5C641 VA: 0x2E5C540
	internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	// RVA: 0x2E5C5C0 Offset: 0x2E5C6C1 VA: 0x2E5C5C0
	internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x2E5C650 Offset: 0x2E5C751 VA: 0x2E5C650
	internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x2E5C6E0 Offset: 0x2E5C7E1 VA: 0x2E5C6E0
	internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	// RVA: 0x2E5C770 Offset: 0x2E5C871 VA: 0x2E5C770
	internal static Exception UnhandledBinary(object p0, string paramName) { }

	// RVA: 0x2E5C7F0 Offset: 0x2E5C8F1 VA: 0x2E5C7F0
	internal static Exception UnhandledUnary(object p0, string paramName) { }

	// RVA: 0x2E5C870 Offset: 0x2E5C971 VA: 0x2E5C870
	internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	// RVA: 0x2E5C8F0 Offset: 0x2E5C9F1 VA: 0x2E5C8F0
	internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	// RVA: 0x2E5C970 Offset: 0x2E5CA71 VA: 0x2E5C970
	internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	// RVA: 0x2E5C9F0 Offset: 0x2E5CAF1 VA: 0x2E5C9F0
	internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x2E5CA70 Offset: 0x2E5CB71 VA: 0x2E5CA70
	internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x2E5CAF0 Offset: 0x2E5CBF1 VA: 0x2E5CAF0
	internal static Exception MethodWithMoreThanOneMatch(object p0, object p1) { }

	// RVA: 0x2E5CB70 Offset: 0x2E5CC71 VA: 0x2E5CB70
	internal static Exception ArgumentCannotBeOfTypeVoid(string paramName) { }

	// RVA: 0x2E5CBF0 Offset: 0x2E5CCF1 VA: 0x2E5CBF0
	internal static Exception LabelTargetAlreadyDefined(object p0) { }

	// RVA: 0x2E5CC70 Offset: 0x2E5CD71 VA: 0x2E5CC70
	internal static Exception LabelTargetUndefined(object p0) { }

	// RVA: 0x2E5CCF0 Offset: 0x2E5CDF1 VA: 0x2E5CCF0
	internal static Exception ControlCannotLeaveFinally() { }

	// RVA: 0x2E5CD60 Offset: 0x2E5CE61 VA: 0x2E5CD60
	internal static Exception ControlCannotLeaveFilterTest() { }

	// RVA: 0x2E5CDD0 Offset: 0x2E5CED1 VA: 0x2E5CDD0
	internal static Exception AmbiguousJump(object p0) { }

	// RVA: 0x2E5CE50 Offset: 0x2E5CF51 VA: 0x2E5CE50
	internal static Exception ControlCannotEnterTry() { }

	// RVA: 0x2E5CEC0 Offset: 0x2E5CFC1 VA: 0x2E5CEC0
	internal static Exception ControlCannotEnterExpression() { }

	// RVA: 0x2E5CF30 Offset: 0x2E5D031 VA: 0x2E5CF30
	internal static Exception NonLocalJumpWithValue(object p0) { }

	// RVA: 0x2E5CFB0 Offset: 0x2E5D0B1 VA: 0x2E5CFB0
	internal static Exception InvalidLvalue(ExpressionType p0) { }

	// RVA: 0x2E5D050 Offset: 0x2E5D151 VA: 0x2E5D050
	internal static Exception RethrowRequiresCatch() { }

	// RVA: 0x2E5D0C0 Offset: 0x2E5D1C1 VA: 0x2E5D0C0
	internal static Exception MustRewriteToSameNode(object p0, object p1, object p2) { }

	// RVA: 0x2E5D150 Offset: 0x2E5D251 VA: 0x2E5D150
	internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2) { }

	// RVA: 0x2E5D1E0 Offset: 0x2E5D2E1 VA: 0x2E5D1E0
	internal static Exception MustRewriteWithoutMethod(object p0, object p1) { }

	// RVA: 0x2E50C70 Offset: 0x2E50D71 VA: 0x2E50C70
	internal static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x2E5D260 Offset: 0x2E5D361 VA: 0x2E5D260
	internal static Exception NotSupported() { }

	// RVA: 0x2E5D2C0 Offset: 0x2E5D3C1 VA: 0x2E5D2C0
	internal static Exception NonAbstractConstructorRequired() { }

	// RVA: 0x2E5D330 Offset: 0x2E5D431 VA: 0x2E5D330
	internal static Exception InvalidProgram() { }

	// RVA: 0x2E5D390 Offset: 0x2E5D491 VA: 0x2E5D390
	internal static Exception EnumerationIsDone() { }

	// RVA: 0x2E5D400 Offset: 0x2E5D501 VA: 0x2E5D400
	private static Exception TypeContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x2E5D480 Offset: 0x2E5D581 VA: 0x2E5D480
	internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index) { }

	// RVA: 0x2E5D580 Offset: 0x2E5D681 VA: 0x2E5D580
	internal static Exception TypeIsGeneric(object p0, string paramName) { }

	// RVA: 0x2E5D600 Offset: 0x2E5D701 VA: 0x2E5D600
	internal static Exception TypeIsGeneric(object p0, string paramName, int index) { }

	// RVA: 0x2E5D700 Offset: 0x2E5D801 VA: 0x2E5D700
	internal static Exception IncorrectNumberOfConstructorArguments() { }

	// RVA: 0x2E5D770 Offset: 0x2E5D871 VA: 0x2E5D770
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName) { }

	// RVA: 0x2E5D810 Offset: 0x2E5D911 VA: 0x2E5D810
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index) { }

	// RVA: 0x2E5D920 Offset: 0x2E5DA21 VA: 0x2E5D920
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName) { }

	// RVA: 0x2E5D9B0 Offset: 0x2E5DAB1 VA: 0x2E5D9B0
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x2E5DAB0 Offset: 0x2E5DBB1 VA: 0x2E5DAB0
	internal static Exception IncorrectNumberOfLambdaArguments() { }

	// RVA: 0x2E5DB20 Offset: 0x2E5DC21 VA: 0x2E5DB20
	internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName) { }

	// RVA: 0x2E5DBA0 Offset: 0x2E5DCA1 VA: 0x2E5DBA0
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName) { }

	// RVA: 0x2E5DC30 Offset: 0x2E5DD31 VA: 0x2E5DC30
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x2E5DD30 Offset: 0x2E5DE31 VA: 0x2E5DD30
	internal static Exception ExpressionMustBeReadable(string paramName) { }

	// RVA: 0x2E5DDB0 Offset: 0x2E5DEB1 VA: 0x2E5DDB0
	internal static Exception ExpressionMustBeReadable(string paramName, int index) { }

	// RVA: 0x2E562F0 Offset: 0x2E563F1 VA: 0x2E562F0
	internal static Exception InvalidArgumentValue(string paramName) { }

	// RVA: 0x2E5DEA0 Offset: 0x2E5DFA1 VA: 0x2E5DEA0
	internal static Exception InvalidNullValue(Type type, string paramName) { }

	// RVA: 0x2E5DF20 Offset: 0x2E5E021 VA: 0x2E5DF20
	internal static Exception InvalidTypeException(object value, Type type, string paramName) { }

	// RVA: 0x2E5A690 Offset: 0x2E5A791 VA: 0x2E5A690
	private static string GetParamName(string paramName, int index) { }
}


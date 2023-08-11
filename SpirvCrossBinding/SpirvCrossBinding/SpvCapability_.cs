namespace SpirvCrossBinding
{
    public enum SpvCapability_ : int
    {
        SpvCapabilityMatrix = 0,
        SpvCapabilityShader = 1,
        SpvCapabilityGeometry = 2,
        SpvCapabilityTessellation = 3,
        SpvCapabilityAddresses = 4,
        SpvCapabilityLinkage = 5,
        SpvCapabilityKernel = 6,
        SpvCapabilityVector16 = 7,
        SpvCapabilityFloat16Buffer = 8,
        SpvCapabilityFloat16 = 9,
        SpvCapabilityFloat64 = 10,
        SpvCapabilityInt64 = 11,
        SpvCapabilityInt64Atomics = 12,
        SpvCapabilityImageBasic = 13,
        SpvCapabilityImageReadWrite = 14,
        SpvCapabilityImageMipmap = 15,
        SpvCapabilityPipes = 17,
        SpvCapabilityGroups = 18,
        SpvCapabilityDeviceEnqueue = 19,
        SpvCapabilityLiteralSampler = 20,
        SpvCapabilityAtomicStorage = 21,
        SpvCapabilityInt16 = 22,
        SpvCapabilityTessellationPointSize = 23,
        SpvCapabilityGeometryPointSize = 24,
        SpvCapabilityImageGatherExtended = 25,
        SpvCapabilityStorageImageMultisample = 27,
        SpvCapabilityUniformBufferArrayDynamicIndexing = 28,
        SpvCapabilitySampledImageArrayDynamicIndexing = 29,
        SpvCapabilityStorageBufferArrayDynamicIndexing = 30,
        SpvCapabilityStorageImageArrayDynamicIndexing = 31,
        SpvCapabilityClipDistance = 32,
        SpvCapabilityCullDistance = 33,
        SpvCapabilityImageCubeArray = 34,
        SpvCapabilitySampleRateShading = 35,
        SpvCapabilityImageRect = 36,
        SpvCapabilitySampledRect = 37,
        SpvCapabilityGenericPointer = 38,
        SpvCapabilityInt8 = 39,
        SpvCapabilityInputAttachment = 40,
        SpvCapabilitySparseResidency = 41,
        SpvCapabilityMinLod = 42,
        SpvCapabilitySampled1D = 43,
        SpvCapabilityImage1D = 44,
        SpvCapabilitySampledCubeArray = 45,
        SpvCapabilitySampledBuffer = 46,
        SpvCapabilityImageBuffer = 47,
        SpvCapabilityImageMSArray = 48,
        SpvCapabilityStorageImageExtendedFormats = 49,
        SpvCapabilityImageQuery = 50,
        SpvCapabilityDerivativeControl = 51,
        SpvCapabilityInterpolationFunction = 52,
        SpvCapabilityTransformFeedback = 53,
        SpvCapabilityGeometryStreams = 54,
        SpvCapabilityStorageImageReadWithoutFormat = 55,
        SpvCapabilityStorageImageWriteWithoutFormat = 56,
        SpvCapabilityMultiViewport = 57,
        SpvCapabilitySubgroupDispatch = 58,
        SpvCapabilityNamedBarrier = 59,
        SpvCapabilityPipeStorage = 60,
        SpvCapabilityGroupNonUniform = 61,
        SpvCapabilityGroupNonUniformVote = 62,
        SpvCapabilityGroupNonUniformArithmetic = 63,
        SpvCapabilityGroupNonUniformBallot = 64,
        SpvCapabilityGroupNonUniformShuffle = 65,
        SpvCapabilityGroupNonUniformShuffleRelative = 66,
        SpvCapabilityGroupNonUniformClustered = 67,
        SpvCapabilityGroupNonUniformQuad = 68,
        SpvCapabilityShaderLayer = 69,
        SpvCapabilityShaderViewportIndex = 70,
        SpvCapabilityUniformDecoration = 71,
        SpvCapabilityFragmentShadingRateKHR = 4422,
        SpvCapabilitySubgroupBallotKHR = 4423,
        SpvCapabilityDrawParameters = 4427,
        SpvCapabilityWorkgroupMemoryExplicitLayoutKHR = 4428,
        SpvCapabilityWorkgroupMemoryExplicitLayout8BitAccessKHR = 4429,
        SpvCapabilityWorkgroupMemoryExplicitLayout16BitAccessKHR = 4430,
        SpvCapabilitySubgroupVoteKHR = 4431,
        SpvCapabilityStorageBuffer16BitAccess = 4433,
        SpvCapabilityStorageUniformBufferBlock16 = 4433,
        SpvCapabilityStorageUniform16 = 4434,
        SpvCapabilityUniformAndStorageBuffer16BitAccess = 4434,
        SpvCapabilityStoragePushConstant16 = 4435,
        SpvCapabilityStorageInputOutput16 = 4436,
        SpvCapabilityDeviceGroup = 4437,
        SpvCapabilityMultiView = 4439,
        SpvCapabilityVariablePointersStorageBuffer = 4441,
        SpvCapabilityVariablePointers = 4442,
        SpvCapabilityAtomicStorageOps = 4445,
        SpvCapabilitySampleMaskPostDepthCoverage = 4447,
        SpvCapabilityStorageBuffer8BitAccess = 4448,
        SpvCapabilityUniformAndStorageBuffer8BitAccess = 4449,
        SpvCapabilityStoragePushConstant8 = 4450,
        SpvCapabilityDenormPreserve = 4464,
        SpvCapabilityDenormFlushToZero = 4465,
        SpvCapabilitySignedZeroInfNanPreserve = 4466,
        SpvCapabilityRoundingModeRTE = 4467,
        SpvCapabilityRoundingModeRTZ = 4468,
        SpvCapabilityRayQueryProvisionalKHR = 4471,
        SpvCapabilityRayQueryKHR = 4472,
        SpvCapabilityRayTraversalPrimitiveCullingKHR = 4478,
        SpvCapabilityRayTracingKHR = 4479,
        SpvCapabilityFloat16ImageAMD = 5008,
        SpvCapabilityImageGatherBiasLodAMD = 5009,
        SpvCapabilityFragmentMaskAMD = 5010,
        SpvCapabilityStencilExportEXT = 5013,
        SpvCapabilityImageReadWriteLodAMD = 5015,
        SpvCapabilityInt64ImageEXT = 5016,
        SpvCapabilityShaderClockKHR = 5055,
        SpvCapabilitySampleMaskOverrideCoverageNV = 5249,
        SpvCapabilityGeometryShaderPassthroughNV = 5251,
        SpvCapabilityShaderViewportIndexLayerEXT = 5254,
        SpvCapabilityShaderViewportIndexLayerNV = 5254,
        SpvCapabilityShaderViewportMaskNV = 5255,
        SpvCapabilityShaderStereoViewNV = 5259,
        SpvCapabilityPerViewAttributesNV = 5260,
        SpvCapabilityFragmentFullyCoveredEXT = 5265,
        SpvCapabilityMeshShadingNV = 5266,
        SpvCapabilityImageFootprintNV = 5282,
        SpvCapabilityMeshShadingEXT = 5283,
        SpvCapabilityFragmentBarycentricKHR = 5284,
        SpvCapabilityFragmentBarycentricNV = 5284,
        SpvCapabilityComputeDerivativeGroupQuadsNV = 5288,
        SpvCapabilityFragmentDensityEXT = 5291,
        SpvCapabilityShadingRateNV = 5291,
        SpvCapabilityGroupNonUniformPartitionedNV = 5297,
        SpvCapabilityShaderNonUniform = 5301,
        SpvCapabilityShaderNonUniformEXT = 5301,
        SpvCapabilityRuntimeDescriptorArray = 5302,
        SpvCapabilityRuntimeDescriptorArrayEXT = 5302,
        SpvCapabilityInputAttachmentArrayDynamicIndexing = 5303,
        SpvCapabilityInputAttachmentArrayDynamicIndexingEXT = 5303,
        SpvCapabilityUniformTexelBufferArrayDynamicIndexing = 5304,
        SpvCapabilityUniformTexelBufferArrayDynamicIndexingEXT = 5304,
        SpvCapabilityStorageTexelBufferArrayDynamicIndexing = 5305,
        SpvCapabilityStorageTexelBufferArrayDynamicIndexingEXT = 5305,
        SpvCapabilityUniformBufferArrayNonUniformIndexing = 5306,
        SpvCapabilityUniformBufferArrayNonUniformIndexingEXT = 5306,
        SpvCapabilitySampledImageArrayNonUniformIndexing = 5307,
        SpvCapabilitySampledImageArrayNonUniformIndexingEXT = 5307,
        SpvCapabilityStorageBufferArrayNonUniformIndexing = 5308,
        SpvCapabilityStorageBufferArrayNonUniformIndexingEXT = 5308,
        SpvCapabilityStorageImageArrayNonUniformIndexing = 5309,
        SpvCapabilityStorageImageArrayNonUniformIndexingEXT = 5309,
        SpvCapabilityInputAttachmentArrayNonUniformIndexing = 5310,
        SpvCapabilityInputAttachmentArrayNonUniformIndexingEXT = 5310,
        SpvCapabilityUniformTexelBufferArrayNonUniformIndexing = 5311,
        SpvCapabilityUniformTexelBufferArrayNonUniformIndexingEXT = 5311,
        SpvCapabilityStorageTexelBufferArrayNonUniformIndexing = 5312,
        SpvCapabilityStorageTexelBufferArrayNonUniformIndexingEXT = 5312,
        SpvCapabilityRayTracingNV = 5340,
        SpvCapabilityRayTracingMotionBlurNV = 5341,
        SpvCapabilityVulkanMemoryModel = 5345,
        SpvCapabilityVulkanMemoryModelKHR = 5345,
        SpvCapabilityVulkanMemoryModelDeviceScope = 5346,
        SpvCapabilityVulkanMemoryModelDeviceScopeKHR = 5346,
        SpvCapabilityPhysicalStorageBufferAddresses = 5347,
        SpvCapabilityPhysicalStorageBufferAddressesEXT = 5347,
        SpvCapabilityComputeDerivativeGroupLinearNV = 5350,
        SpvCapabilityRayTracingProvisionalKHR = 5353,
        SpvCapabilityCooperativeMatrixNV = 5357,
        SpvCapabilityFragmentShaderSampleInterlockEXT = 5363,
        SpvCapabilityFragmentShaderShadingRateInterlockEXT = 5372,
        SpvCapabilityShaderSMBuiltinsNV = 5373,
        SpvCapabilityFragmentShaderPixelInterlockEXT = 5378,
        SpvCapabilityDemoteToHelperInvocation = 5379,
        SpvCapabilityDemoteToHelperInvocationEXT = 5379,
        SpvCapabilityBindlessTextureNV = 5390,
        SpvCapabilitySubgroupShuffleINTEL = 5568,
        SpvCapabilitySubgroupBufferBlockIOINTEL = 5569,
        SpvCapabilitySubgroupImageBlockIOINTEL = 5570,
        SpvCapabilitySubgroupImageMediaBlockIOINTEL = 5579,
        SpvCapabilityRoundToInfinityINTEL = 5582,
        SpvCapabilityFloatingPointModeINTEL = 5583,
        SpvCapabilityIntegerFunctions2INTEL = 5584,
        SpvCapabilityFunctionPointersINTEL = 5603,
        SpvCapabilityIndirectReferencesINTEL = 5604,
        SpvCapabilityAsmINTEL = 5606,
        SpvCapabilityAtomicFloat32MinMaxEXT = 5612,
        SpvCapabilityAtomicFloat64MinMaxEXT = 5613,
        SpvCapabilityAtomicFloat16MinMaxEXT = 5616,
        SpvCapabilityVectorComputeINTEL = 5617,
        SpvCapabilityVectorAnyINTEL = 5619,
        SpvCapabilityExpectAssumeKHR = 5629,
        SpvCapabilitySubgroupAvcMotionEstimationINTEL = 5696,
        SpvCapabilitySubgroupAvcMotionEstimationIntraINTEL = 5697,
        SpvCapabilitySubgroupAvcMotionEstimationChromaINTEL = 5698,
        SpvCapabilityVariableLengthArrayINTEL = 5817,
        SpvCapabilityFunctionFloatControlINTEL = 5821,
        SpvCapabilityFPGAMemoryAttributesINTEL = 5824,
        SpvCapabilityFPFastMathModeINTEL = 5837,
        SpvCapabilityArbitraryPrecisionIntegersINTEL = 5844,
        SpvCapabilityArbitraryPrecisionFloatingPointINTEL = 5845,
        SpvCapabilityUnstructuredLoopControlsINTEL = 5886,
        SpvCapabilityFPGALoopControlsINTEL = 5888,
        SpvCapabilityKernelAttributesINTEL = 5892,
        SpvCapabilityFPGAKernelAttributesINTEL = 5897,
        SpvCapabilityFPGAMemoryAccessesINTEL = 5898,
        SpvCapabilityFPGAClusterAttributesINTEL = 5904,
        SpvCapabilityLoopFuseINTEL = 5906,
        SpvCapabilityMemoryAccessAliasingINTEL = 5910,
        SpvCapabilityFPGABufferLocationINTEL = 5920,
        SpvCapabilityArbitraryPrecisionFixedPointINTEL = 5922,
        SpvCapabilityUSMStorageClassesINTEL = 5935,
        SpvCapabilityIOPipesINTEL = 5943,
        SpvCapabilityBlockingPipesINTEL = 5945,
        SpvCapabilityFPGARegINTEL = 5948,
        SpvCapabilityDotProductInputAll = 6016,
        SpvCapabilityDotProductInputAllKHR = 6016,
        SpvCapabilityDotProductInput4x8Bit = 6017,
        SpvCapabilityDotProductInput4x8BitKHR = 6017,
        SpvCapabilityDotProductInput4x8BitPacked = 6018,
        SpvCapabilityDotProductInput4x8BitPackedKHR = 6018,
        SpvCapabilityDotProduct = 6019,
        SpvCapabilityDotProductKHR = 6019,
        SpvCapabilityRayCullMaskKHR = 6020,
        SpvCapabilityBitInstructions = 6025,
        SpvCapabilityGroupNonUniformRotateKHR = 6026,
        SpvCapabilityAtomicFloat32AddEXT = 6033,
        SpvCapabilityAtomicFloat64AddEXT = 6034,
        SpvCapabilityLongConstantCompositeINTEL = 6089,
        SpvCapabilityOptNoneINTEL = 6094,
        SpvCapabilityAtomicFloat16AddEXT = 6095,
        SpvCapabilityDebugInfoModuleINTEL = 6114,
        SpvCapabilitySplitBarrierINTEL = 6141,
        SpvCapabilityGroupUniformArithmeticKHR = 6400,
        SpvCapabilityMax = 2147483647
    }
}
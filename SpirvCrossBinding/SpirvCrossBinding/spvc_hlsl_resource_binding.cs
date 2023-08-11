namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_hlsl_resource_binding
    {
        public SpvExecutionModel_ stage;
        public uint desc_set;
        public uint binding;
        public spvc_hlsl_resource_binding_mapping cbv;
        public spvc_hlsl_resource_binding_mapping uav;
        public spvc_hlsl_resource_binding_mapping srv;
        public spvc_hlsl_resource_binding_mapping sampler;
    }
}
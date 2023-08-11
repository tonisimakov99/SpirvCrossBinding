namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_msl_resource_binding
    {
        public SpvExecutionModel_ stage;
        public uint desc_set;
        public uint binding;
        public uint msl_buffer;
        public uint msl_texture;
        public uint msl_sampler;
    }
}
namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_hlsl_resource_binding_mapping
    {
        public uint register_space;
        public uint register_binding;
    }
}
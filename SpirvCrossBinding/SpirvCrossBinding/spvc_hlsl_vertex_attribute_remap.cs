namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_hlsl_vertex_attribute_remap
    {
        public uint location;
        public byte* semantic;
    }
}
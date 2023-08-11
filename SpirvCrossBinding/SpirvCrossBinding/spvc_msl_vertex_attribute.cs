namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_msl_vertex_attribute
    {
        public uint location;
        public uint msl_buffer;
        public uint msl_offset;
        public uint msl_stride;
        public byte per_instance;
        public spvc_msl_shader_variable_format format;
        public SpvBuiltIn_ builtin;
    }
}
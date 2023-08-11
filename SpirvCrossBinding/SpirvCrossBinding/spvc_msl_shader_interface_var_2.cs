namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_msl_shader_interface_var_2
    {
        public uint location;
        public spvc_msl_shader_variable_format format;
        public SpvBuiltIn_ builtin;
        public uint vecsize;
        public spvc_msl_shader_variable_rate rate;
    }
}
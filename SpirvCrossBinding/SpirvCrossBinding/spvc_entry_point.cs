namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_entry_point
    {
        public SpvExecutionModel_ execution_model;
        public byte* name;
    }
}
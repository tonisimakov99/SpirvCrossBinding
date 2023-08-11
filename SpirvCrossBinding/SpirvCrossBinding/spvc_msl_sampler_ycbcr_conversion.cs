namespace SpirvCrossBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct spvc_msl_sampler_ycbcr_conversion
    {
        public uint planes;
        public spvc_msl_format_resolution resolution;
        public spvc_msl_sampler_filter chroma_filter;
        public spvc_msl_chroma_location x_chroma_offset;
        public spvc_msl_chroma_location y_chroma_offset;
        public spvc_msl_component_swizzle swizzle;
        public spvc_msl_sampler_ycbcr_model_conversion ycbcr_model;
        public spvc_msl_sampler_ycbcr_range ycbcr_range;
        public uint bpc;
    }
}
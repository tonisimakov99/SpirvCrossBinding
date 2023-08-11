namespace SpirvCrossBinding
{
    public enum spvc_backend : int
    {
        SPVC_BACKEND_NONE = 0,
        SPVC_BACKEND_GLSL = 1,
        SPVC_BACKEND_HLSL = 2,
        SPVC_BACKEND_MSL = 3,
        SPVC_BACKEND_CPP = 4,
        SPVC_BACKEND_JSON = 5,
        SPVC_BACKEND_INT_MAX = 2147483647
    }
}
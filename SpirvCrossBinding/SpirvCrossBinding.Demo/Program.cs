using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SpirvCrossBinding.Demo
{
    public unsafe class Program
    {
        private static void ErrorCallback(void* userData, byte* error)
        {
            Console.WriteLine(Marshal.PtrToStringAnsi(new IntPtr(error)));

        }

        public unsafe static void Main()
        {
            spvc_context_s* context = default;
            spvc_parsed_ir_s* ir;
            spvc_compiler_s* compiler_glsl;
            spvc_compiler_options_s* options;
            spvc_resources_s* resources;
            spvc_reflected_resource* list;
            char* result;
            int count;
            int i;

            // Create context.
            var execResult = SpirvCross.spvc_context_create(&context);

            // Set debug callback.
            SpirvCross.spvc_context_set_error_callback(context, ErrorCallback, null);

            var bytes = File.ReadAllBytes("uiShader.vert.spv");
            var spirv = Marshal.AllocHGlobal(bytes.Length);


            Marshal.Copy(bytes, 0, spirv, bytes.Length);
            // Parse the SPIR-V.

            execResult = SpirvCross.spvc_context_parse_spirv(context, (uint*)spirv, (ulong)(bytes.Length / 4), &ir);


            //// Hand it off to a compiler instance and give it ownership of the IR.
            //SpirvCross.spvc_context_create_compiler(context, SPVC_BACKEND_GLSL, ir, SPVC_CAPTURE_MODE_TAKE_OWNERSHIP, &compiler_glsl);

            //// Do some basic reflection.
            //SpirvCross.spvc_compiler_create_shader_resources(compiler_glsl, &resources);
            //SpirvCross.spvc_resources_get_resource_list_for_type(resources, SPVC_RESOURCE_TYPE_UNIFORM_BUFFER, &list, &count);

            //for (i = 0; i < count; i++)
            //{
            //    printf("ID: %u, BaseTypeID: %u, TypeID: %u, Name: %s\n", list[i].id, list[i].base_type_id, list[i].type_id,
            //           list[i].name);
            //    printf("  Set: %u, Binding: %u\n",
            //           spvc_compiler_get_decoration(compiler_glsl, list[i].id, SpvDecorationDescriptorSet),
            //           spvc_compiler_get_decoration(compiler_glsl, list[i].id, SpvDecorationBinding));
            //}

            //// Modify options.
            //SpirvCross.spvc_compiler_create_compiler_options(compiler_glsl, &options);
            //SpirvCross.spvc_compiler_options_set_uint(options, SPVC_COMPILER_OPTION_GLSL_VERSION, 330);
            //SpirvCross.spvc_compiler_options_set_bool(options, SPVC_COMPILER_OPTION_GLSL_ES, SPVC_FALSE);
            //SpirvCross.spvc_compiler_install_compiler_options(compiler_glsl, options);

            //SpirvCross.spvc_compiler_compile(compiler_glsl, &result);
            //printf("Cross-compiled source: %s\n", result);

            // Frees all memory we allocated so far.
            SpirvCross.spvc_context_destroy(context);
        }
    }
}
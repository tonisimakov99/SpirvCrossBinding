#version 450

layout(binding = 0) uniform StaticSceneData {
    mat4 proj;
} scene;

layout(location = 0) in vec3 inPosition;
layout(location = 1) in vec2 textCoord;

layout(location = 0) out vec2 fragTexCoord;

void main() {
    gl_Position = scene.proj * vec4(inPosition, 1);
    fragTexCoord = textCoord;
}

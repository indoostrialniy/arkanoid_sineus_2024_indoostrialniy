#version 330 core
layout (location = 0) out vec4 FragColor;

in vec2 TexCoord;

uniform vec3 color;

uniform sampler2D Texture;

uniform float coeff;

uniform int colorable;

uniform int haveBonus;
uniform int autopilotBonus;

void main()
{
	FragColor = texture(Texture, TexCoord);
	
	float alpha = FragColor.w;

    if(alpha < 0.2f)   {  discard;  }

    FragColor += vec4(1,0,0,1)*coeff*colorable;

    if(haveBonus == 1)
    {
        FragColor += vec4(1,0,0,1);
    }

     if(autopilotBonus == 1)
    {
        FragColor += vec4(0,1,0,1);
    }
}

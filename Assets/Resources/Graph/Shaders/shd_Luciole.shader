// Shader created with Shader Forge v1.10 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.10;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,nrsp:0,limd:0,spmd:1,grmd:0,uamb:True,mssp:True,bkdf:False,rprd:False,enco:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:1,bsrc:3,bdst:7,culm:0,dpts:2,wrdp:False,dith:0,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:1366,x:33720,y:32768,varname:node_1366,prsc:2|emission-902-OUT,custl-5025-OUT,alpha-3953-A;n:type:ShaderForge.SFN_Tex2d,id:3953,x:32275,y:32764,ptovrint:False,ptlb:Diffuse Texture,ptin:_DiffuseTexture,varname:node_3953,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:8410,x:33036,y:33148,ptovrint:False,ptlb:Diffuse Color,ptin:_DiffuseColor,varname:node_8410,prsc:2,glob:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:5025,x:33233,y:33129,varname:node_5025,prsc:2|A-2212-OUT,B-8410-RGB;n:type:ShaderForge.SFN_LightColor,id:2966,x:32275,y:32996,varname:node_2966,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2212,x:32859,y:32950,varname:node_2212,prsc:2|A-3953-RGB,B-473-OUT,C-2966-RGB;n:type:ShaderForge.SFN_ValueProperty,id:473,x:32275,y:32933,ptovrint:False,ptlb:Light Intensity,ptin:_LightIntensity,varname:node_473,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:902,x:32996,y:32783,varname:node_902,prsc:2|A-3953-RGB,B-6157-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8523,x:32628,y:32810,ptovrint:False,ptlb:Emission,ptin:_Emission,varname:node_8523,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_Sin,id:6265,x:32807,y:32477,varname:node_6265,prsc:2|IN-7227-OUT;n:type:ShaderForge.SFN_Time,id:4262,x:32390,y:32436,varname:node_4262,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7227,x:32624,y:32477,varname:node_7227,prsc:2|A-4262-T,B-8507-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8507,x:32390,y:32591,ptovrint:False,ptlb:Clignotement Speed,ptin:_ClignotementSpeed,varname:node_8507,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:6157,x:33192,y:32498,varname:node_6157,prsc:2|A-665-OUT,B-6857-OUT,C-8523-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6857,x:32807,y:32649,ptovrint:False,ptlb:Clignotement Strenght,ptin:_ClignotementStrenght,varname:node_6857,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_RemapRange,id:665,x:32979,y:32477,varname:node_665,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-6265-OUT;proporder:3953-8410-473-8523-8507-6857;pass:END;sub:END;*/

Shader "Custom/shd_Luciole" {
    Properties {
        _DiffuseTexture ("Diffuse Texture", 2D) = "white" {}
        _DiffuseColor ("Diffuse Color", Color) = (1,1,1,1)
        _LightIntensity ("Light Intensity", Float ) = 0
        _Emission ("Emission", Float ) = 0
        _ClignotementSpeed ("Clignotement Speed", Float ) = 0
        _ClignotementStrenght ("Clignotement Strenght", Float ) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float4 _TimeEditor;
            uniform sampler2D _DiffuseTexture; uniform float4 _DiffuseTexture_ST;
            uniform float4 _DiffuseColor;
            uniform float _LightIntensity;
            uniform float _Emission;
            uniform float _ClignotementSpeed;
            uniform float _ClignotementStrenght;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
////// Emissive:
                float4 _DiffuseTexture_var = tex2D(_DiffuseTexture,TRANSFORM_TEX(i.uv0, _DiffuseTexture));
                float4 node_4262 = _Time + _TimeEditor;
                float3 emissive = (_DiffuseTexture_var.rgb*((sin((node_4262.g*_ClignotementSpeed))*0.5+0.5)*_ClignotementStrenght*_Emission));
                float3 finalColor = emissive + ((_DiffuseTexture_var.rgb*_LightIntensity*_LightColor0.rgb)*_DiffuseColor.rgb);
                return fixed4(finalColor,_DiffuseTexture_var.a);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float4 _TimeEditor;
            uniform sampler2D _DiffuseTexture; uniform float4 _DiffuseTexture_ST;
            uniform float4 _DiffuseColor;
            uniform float _LightIntensity;
            uniform float _Emission;
            uniform float _ClignotementSpeed;
            uniform float _ClignotementStrenght;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                LIGHTING_COORDS(1,2)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float4 _DiffuseTexture_var = tex2D(_DiffuseTexture,TRANSFORM_TEX(i.uv0, _DiffuseTexture));
                float3 finalColor = ((_DiffuseTexture_var.rgb*_LightIntensity*_LightColor0.rgb)*_DiffuseColor.rgb);
                return fixed4(finalColor * _DiffuseTexture_var.a,0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

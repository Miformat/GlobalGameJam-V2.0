// Shader created with Shader Forge v1.10 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.10;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,nrsp:0,limd:0,spmd:1,grmd:0,uamb:True,mssp:True,bkdf:False,rprd:False,enco:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:1,bsrc:3,bdst:7,culm:2,dpts:2,wrdp:False,dith:0,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:1366,x:34371,y:33151,varname:node_1366,prsc:2|custl-2212-OUT,alpha-8405-OUT;n:type:ShaderForge.SFN_Tex2d,id:3953,x:32275,y:32764,ptovrint:False,ptlb:Diffuse Texture,ptin:_DiffuseTexture,varname:node_3953,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:8410,x:32275,y:32599,ptovrint:False,ptlb:Diffuse Color,ptin:_DiffuseColor,varname:node_8410,prsc:2,glob:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_LightColor,id:2966,x:32275,y:32996,varname:node_2966,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2212,x:33111,y:32968,varname:node_2212,prsc:2|A-9483-OUT,B-473-OUT,C-2966-RGB;n:type:ShaderForge.SFN_ValueProperty,id:473,x:32275,y:32933,ptovrint:False,ptlb:Light Intensity,ptin:_LightIntensity,varname:node_473,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_Slider,id:7857,x:32244,y:33255,ptovrint:False,ptlb:Snow,ptin:_Snow,varname:node_7857,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:6309,x:32490,y:32658,varname:node_6309,prsc:2|A-8410-RGB,B-3953-RGB;n:type:ShaderForge.SFN_Add,id:4541,x:32706,y:32788,varname:node_4541,prsc:2|A-6309-OUT,B-7-OUT;n:type:ShaderForge.SFN_Vector1,id:7,x:32490,y:32809,varname:node_7,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Lerp,id:9483,x:32909,y:32839,varname:node_9483,prsc:2|A-6309-OUT,B-4541-OUT,T-7857-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3698,x:32392,y:33370,ptovrint:False,ptlb:Alpha,ptin:_Alpha,varname:node_3698,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_Lerp,id:8405,x:33242,y:33352,varname:node_8405,prsc:2|A-3698-OUT,B-4912-OUT,T-7857-OUT;n:type:ShaderForge.SFN_Vector1,id:1820,x:32394,y:33433,varname:node_1820,prsc:2,v1:0.3;n:type:ShaderForge.SFN_Add,id:4912,x:32606,y:33433,varname:node_4912,prsc:2|A-3698-OUT,B-1820-OUT;proporder:3953-8410-473-7857-3698;pass:END;sub:END;*/

Shader "Custom/shd_Lac" {
    Properties {
        _DiffuseTexture ("Diffuse Texture", 2D) = "white" {}
        _DiffuseColor ("Diffuse Color", Color) = (1,1,1,1)
        _LightIntensity ("Light Intensity", Float ) = 0
        _Snow ("Snow", Range(0, 1)) = 0
        _Alpha ("Alpha", Float ) = 0
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
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _DiffuseTexture; uniform float4 _DiffuseTexture_ST;
            uniform float4 _DiffuseColor;
            uniform float _LightIntensity;
            uniform float _Snow;
            uniform float _Alpha;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float4 _DiffuseTexture_var = tex2D(_DiffuseTexture,TRANSFORM_TEX(i.uv0, _DiffuseTexture));
                float3 node_6309 = (_DiffuseColor.rgb*_DiffuseTexture_var.rgb);
                float3 finalColor = (lerp(node_6309,(node_6309+0.5),_Snow)*_LightIntensity*_LightColor0.rgb);
                float node_8405 = lerp(_Alpha,(_Alpha+0.3),_Snow);
                fixed4 finalRGBA = fixed4(finalColor,node_8405);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _DiffuseTexture; uniform float4 _DiffuseTexture_ST;
            uniform float4 _DiffuseColor;
            uniform float _LightIntensity;
            uniform float _Snow;
            uniform float _Alpha;
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
                float3 node_6309 = (_DiffuseColor.rgb*_DiffuseTexture_var.rgb);
                float3 finalColor = (lerp(node_6309,(node_6309+0.5),_Snow)*_LightIntensity*_LightColor0.rgb);
                float node_8405 = lerp(_Alpha,(_Alpha+0.3),_Snow);
                return fixed4(finalColor * node_8405,0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

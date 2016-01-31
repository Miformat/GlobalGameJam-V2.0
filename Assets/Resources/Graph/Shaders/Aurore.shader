// Shader created with Shader Forge v1.10 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.10;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,nrsp:0,limd:1,spmd:1,grmd:0,uamb:True,mssp:True,bkdf:False,rprd:False,enco:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:1,bsrc:3,bdst:7,culm:0,dpts:2,wrdp:False,dith:0,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:7569,x:32719,y:32712,varname:node_7569,prsc:2|emission-7381-OUT,alpha-5141-OUT,voffset-9383-RGB;n:type:ShaderForge.SFN_Color,id:8745,x:32472,y:31893,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_8745,prsc:2,glob:False,c1:0.7123882,c2:0.9705882,c3:0.5352508,c4:1;n:type:ShaderForge.SFN_Tex2d,id:1472,x:32100,y:32532,ptovrint:False,ptlb:Alpha,ptin:_Alpha,varname:node_1472,prsc:2,tex:a035c32c48503b04ab617536ce905545,ntxv:0,isnm:False|UVIN-7643-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:9383,x:32105,y:33013,ptovrint:False,ptlb:Gradient,ptin:_Gradient,varname:node_9383,prsc:2,tex:008d5b88506f9264b887aa400fbc91cd,ntxv:0,isnm:False|UVIN-1146-UVOUT;n:type:ShaderForge.SFN_Panner,id:1146,x:31887,y:33013,varname:node_1146,prsc:2,spu:1,spv:0|DIST-1835-OUT;n:type:ShaderForge.SFN_Time,id:8865,x:31512,y:33045,varname:node_8865,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1835,x:31696,y:33058,varname:node_1835,prsc:2|A-8865-T,B-1901-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1901,x:31512,y:33212,ptovrint:False,ptlb:speed_vertex_offset,ptin:_speed_vertex_offset,varname:node_1901,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_Tex2d,id:9491,x:32100,y:32739,ptovrint:False,ptlb:Mask,ptin:_Mask,varname:node_9491,prsc:2,tex:6bde40c7fe2b47d458ccbd9b278e1c42,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:5141,x:32371,y:32685,varname:node_5141,prsc:2|A-3793-OUT,B-9491-R;n:type:ShaderForge.SFN_Panner,id:7643,x:31888,y:32727,varname:node_7643,prsc:2,spu:1,spv:0|DIST-3149-OUT;n:type:ShaderForge.SFN_Multiply,id:3149,x:31723,y:32727,varname:node_3149,prsc:2|A-8865-T,B-707-OUT;n:type:ShaderForge.SFN_ValueProperty,id:707,x:31532,y:32863,ptovrint:False,ptlb:node_707,ptin:_node_707,varname:node_707,prsc:2,glob:False,v1:0.1;n:type:ShaderForge.SFN_Tex2d,id:3993,x:32100,y:32314,ptovrint:False,ptlb:Alpha2,ptin:_Alpha2,varname:node_3993,prsc:2,tex:a035c32c48503b04ab617536ce905545,ntxv:0,isnm:False|UVIN-4015-UVOUT;n:type:ShaderForge.SFN_Multiply,id:3793,x:32364,y:32424,varname:node_3793,prsc:2|A-3993-A,B-1472-A;n:type:ShaderForge.SFN_Panner,id:4015,x:31896,y:32314,varname:node_4015,prsc:2,spu:1,spv:0|DIST-2108-OUT;n:type:ShaderForge.SFN_Multiply,id:2108,x:31732,y:32314,varname:node_2108,prsc:2|A-8865-T,B-1757-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1757,x:31511,y:32347,ptovrint:False,ptlb:speed_alpha2,ptin:_speed_alpha2,varname:node_1757,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_Tex2d,id:6389,x:32472,y:31696,ptovrint:False,ptlb:node_6389,ptin:_node_6389,varname:node_6389,prsc:2,tex:298da226211b2904da874dd8762fdbae,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Blend,id:529,x:32804,y:31837,varname:node_529,prsc:2,blmd:10,clmp:True|SRC-6389-RGB,DST-8745-RGB;n:type:ShaderForge.SFN_Tex2d,id:1158,x:32778,y:32093,ptovrint:False,ptlb:noise,ptin:_noise,varname:node_1158,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-1349-UVOUT;n:type:ShaderForge.SFN_Blend,id:7381,x:33022,y:32003,varname:node_7381,prsc:2,blmd:10,clmp:True|SRC-5427-OUT,DST-529-OUT;n:type:ShaderForge.SFN_Panner,id:1349,x:32549,y:32074,varname:node_1349,prsc:2,spu:1,spv:0|DIST-5761-OUT;n:type:ShaderForge.SFN_Multiply,id:5761,x:32352,y:32074,varname:node_5761,prsc:2|A-8865-T,B-1001-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1001,x:32352,y:32251,ptovrint:False,ptlb:speed_noise,ptin:_speed_noise,varname:node_1001,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_Vector1,id:4653,x:32774,y:32335,varname:node_4653,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:5427,x:32984,y:32207,varname:node_5427,prsc:2|A-1158-RGB,B-4653-OUT;proporder:8745-1472-9383-1901-9491-707-3993-1757-6389-1158-1001;pass:END;sub:END;*/

Shader "Custom/Aurore" {
    Properties {
        _Color ("Color", Color) = (0.7123882,0.9705882,0.5352508,1)
        _Alpha ("Alpha", 2D) = "white" {}
        _Gradient ("Gradient", 2D) = "white" {}
        _speed_vertex_offset ("speed_vertex_offset", Float ) = 0
        _Mask ("Mask", 2D) = "white" {}
        _node_707 ("node_707", Float ) = 0.1
        _Alpha2 ("Alpha2", 2D) = "white" {}
        _speed_alpha2 ("speed_alpha2", Float ) = 0
        _node_6389 ("node_6389", 2D) = "white" {}
        _noise ("noise", 2D) = "white" {}
        _speed_noise ("speed_noise", Float ) = 0
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
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform sampler2D _Alpha; uniform float4 _Alpha_ST;
            uniform sampler2D _Gradient; uniform float4 _Gradient_ST;
            uniform float _speed_vertex_offset;
            uniform sampler2D _Mask; uniform float4 _Mask_ST;
            uniform float _node_707;
            uniform sampler2D _Alpha2; uniform float4 _Alpha2_ST;
            uniform float _speed_alpha2;
            uniform sampler2D _node_6389; uniform float4 _node_6389_ST;
            uniform sampler2D _noise; uniform float4 _noise_ST;
            uniform float _speed_noise;
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
                float4 node_8865 = _Time + _TimeEditor;
                float2 node_1146 = (o.uv0+(node_8865.g*_speed_vertex_offset)*float2(1,0));
                float4 _Gradient_var = tex2Dlod(_Gradient,float4(TRANSFORM_TEX(node_1146, _Gradient),0.0,0));
                v.vertex.xyz += _Gradient_var.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
////// Lighting:
////// Emissive:
                float4 node_8865 = _Time + _TimeEditor;
                float2 node_1349 = (i.uv0+(node_8865.g*_speed_noise)*float2(1,0));
                float4 _noise_var = tex2D(_noise,TRANSFORM_TEX(node_1349, _noise));
                float4 _node_6389_var = tex2D(_node_6389,TRANSFORM_TEX(i.uv0, _node_6389));
                float3 emissive = saturate(( saturate(( _Color.rgb > 0.5 ? (1.0-(1.0-2.0*(_Color.rgb-0.5))*(1.0-_node_6389_var.rgb)) : (2.0*_Color.rgb*_node_6389_var.rgb) )) > 0.5 ? (1.0-(1.0-2.0*(saturate(( _Color.rgb > 0.5 ? (1.0-(1.0-2.0*(_Color.rgb-0.5))*(1.0-_node_6389_var.rgb)) : (2.0*_Color.rgb*_node_6389_var.rgb) ))-0.5))*(1.0-(_noise_var.rgb*0.5))) : (2.0*saturate(( _Color.rgb > 0.5 ? (1.0-(1.0-2.0*(_Color.rgb-0.5))*(1.0-_node_6389_var.rgb)) : (2.0*_Color.rgb*_node_6389_var.rgb) ))*(_noise_var.rgb*0.5)) ));
                float3 finalColor = emissive;
                float2 node_4015 = (i.uv0+(node_8865.g*_speed_alpha2)*float2(1,0));
                float4 _Alpha2_var = tex2D(_Alpha2,TRANSFORM_TEX(node_4015, _Alpha2));
                float2 node_7643 = (i.uv0+(node_8865.g*_node_707)*float2(1,0));
                float4 _Alpha_var = tex2D(_Alpha,TRANSFORM_TEX(node_7643, _Alpha));
                float4 _Mask_var = tex2D(_Mask,TRANSFORM_TEX(i.uv0, _Mask));
                return fixed4(finalColor,((_Alpha2_var.a*_Alpha_var.a)*_Mask_var.r));
            }
            ENDCG
        }
        Pass {
            Name "ShadowCollector"
            Tags {
                "LightMode"="ShadowCollector"
            }
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCOLLECTOR
            #define SHADOW_COLLECTOR_PASS
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcollector
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform sampler2D _Gradient; uniform float4 _Gradient_ST;
            uniform float _speed_vertex_offset;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_COLLECTOR;
                float2 uv0 : TEXCOORD5;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 node_8865 = _Time + _TimeEditor;
                float2 node_1146 = (o.uv0+(node_8865.g*_speed_vertex_offset)*float2(1,0));
                float4 _Gradient_var = tex2Dlod(_Gradient,float4(TRANSFORM_TEX(node_1146, _Gradient),0.0,0));
                v.vertex.xyz += _Gradient_var.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_SHADOW_COLLECTOR(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
                SHADOW_COLLECTOR_FRAGMENT(i)
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform sampler2D _Gradient; uniform float4 _Gradient_ST;
            uniform float _speed_vertex_offset;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 node_8865 = _Time + _TimeEditor;
                float2 node_1146 = (o.uv0+(node_8865.g*_speed_vertex_offset)*float2(1,0));
                float4 _Gradient_var = tex2Dlod(_Gradient,float4(TRANSFORM_TEX(node_1146, _Gradient),0.0,0));
                v.vertex.xyz += _Gradient_var.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

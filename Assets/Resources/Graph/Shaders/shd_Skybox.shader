// Shader created with Shader Forge v1.10 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.10;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,nrsp:0,limd:0,spmd:1,grmd:0,uamb:True,mssp:True,bkdf:False,rprd:False,enco:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:0,bsrc:0,bdst:1,culm:0,dpts:2,wrdp:True,dith:0,ufog:False,aust:False,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:9322,x:33337,y:32737,varname:node_9322,prsc:2|custl-1477-OUT;n:type:ShaderForge.SFN_Tex2d,id:3419,x:32093,y:33252,ptovrint:False,ptlb:Night,ptin:_Night,varname:node_3419,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:8542,x:32093,y:33443,ptovrint:False,ptlb:Night_Snow,ptin:_Night_Snow,varname:node_8542,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:4777,x:32093,y:33625,ptovrint:False,ptlb:Night_Rain,ptin:_Night_Rain,varname:node_4777,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:4085,x:32084,y:32805,ptovrint:False,ptlb:Day_Rain,ptin:_Day_Rain,varname:node_4085,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:5523,x:32084,y:32444,ptovrint:False,ptlb:Day,ptin:_Day,varname:node_5523,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:7030,x:32084,y:32622,ptovrint:False,ptlb:Day_Snow,ptin:_Day_Snow,varname:node_7030,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:3076,x:32576,y:32592,varname:node_3076,prsc:2|A-4085-RGB,B-7030-RGB,T-7373-OUT;n:type:ShaderForge.SFN_Lerp,id:1479,x:32988,y:32549,varname:node_1479,prsc:2|A-5523-RGB,B-1467-OUT,T-5072-OUT;n:type:ShaderForge.SFN_Lerp,id:1477,x:33220,y:32737,varname:node_1477,prsc:2|A-1479-OUT,B-4654-OUT,T-5909-OUT;n:type:ShaderForge.SFN_Lerp,id:7044,x:32580,y:33257,varname:node_7044,prsc:2|A-4777-RGB,B-8542-RGB,T-7373-OUT;n:type:ShaderForge.SFN_Lerp,id:4654,x:33023,y:33026,varname:node_4654,prsc:2|A-3419-RGB,B-3783-OUT,T-5072-OUT;n:type:ShaderForge.SFN_Slider,id:7373,x:32255,y:32774,ptovrint:False,ptlb:Rain To Snow,ptin:_RainToSnow,varname:node_7373,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:5909,x:32831,y:32785,ptovrint:False,ptlb:Day To Night,ptin:_DayToNight,varname:node_5909,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:5072,x:32255,y:32874,ptovrint:False,ptlb:Normal To Rain/Snow,ptin:_NormalToRainSnow,varname:node_5072,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Tex2d,id:3932,x:32084,y:32989,ptovrint:False,ptlb:Day_Special,ptin:_Day_Special,varname:node_3932,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:6107,x:32093,y:33806,ptovrint:False,ptlb:Night_Special,ptin:_Night_Special,varname:_Day_Special_copy,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Slider,id:2846,x:32255,y:33004,ptovrint:False,ptlb:Rain/Snow to Special,ptin:_RainSnowtoSpecial,varname:node_2846,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Lerp,id:1467,x:32790,y:32592,varname:node_1467,prsc:2|A-3076-OUT,B-3932-RGB,T-2846-OUT;n:type:ShaderForge.SFN_Lerp,id:3783,x:32831,y:33149,varname:node_3783,prsc:2|A-7044-OUT,B-6107-RGB,T-2846-OUT;proporder:3419-8542-4777-6107-5523-4085-7030-3932-7373-5909-5072-2846;pass:END;sub:END;*/

Shader "Custom/shd_Skybox" {
    Properties {
        _Night ("Night", 2D) = "white" {}
        _Night_Snow ("Night_Snow", 2D) = "white" {}
        _Night_Rain ("Night_Rain", 2D) = "white" {}
        _Night_Special ("Night_Special", 2D) = "white" {}
        _Day ("Day", 2D) = "white" {}
        _Day_Rain ("Day_Rain", 2D) = "white" {}
        _Day_Snow ("Day_Snow", 2D) = "white" {}
        _Day_Special ("Day_Special", 2D) = "white" {}
        _RainToSnow ("Rain To Snow", Range(0, 1)) = 0
        _DayToNight ("Day To Night", Range(0, 1)) = 0
        _NormalToRainSnow ("Normal To Rain/Snow", Range(0, 1)) = 0
        _RainSnowtoSpecial ("Rain/Snow to Special", Range(0, 1)) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        LOD 200
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _Night; uniform float4 _Night_ST;
            uniform sampler2D _Night_Snow; uniform float4 _Night_Snow_ST;
            uniform sampler2D _Night_Rain; uniform float4 _Night_Rain_ST;
            uniform sampler2D _Day_Rain; uniform float4 _Day_Rain_ST;
            uniform sampler2D _Day; uniform float4 _Day_ST;
            uniform sampler2D _Day_Snow; uniform float4 _Day_Snow_ST;
            uniform float _RainToSnow;
            uniform float _DayToNight;
            uniform float _NormalToRainSnow;
            uniform sampler2D _Day_Special; uniform float4 _Day_Special_ST;
            uniform sampler2D _Night_Special; uniform float4 _Night_Special_ST;
            uniform float _RainSnowtoSpecial;
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
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
////// Lighting:
                float4 _Day_var = tex2D(_Day,TRANSFORM_TEX(i.uv0, _Day));
                float4 _Day_Rain_var = tex2D(_Day_Rain,TRANSFORM_TEX(i.uv0, _Day_Rain));
                float4 _Day_Snow_var = tex2D(_Day_Snow,TRANSFORM_TEX(i.uv0, _Day_Snow));
                float4 _Day_Special_var = tex2D(_Day_Special,TRANSFORM_TEX(i.uv0, _Day_Special));
                float4 _Night_var = tex2D(_Night,TRANSFORM_TEX(i.uv0, _Night));
                float4 _Night_Rain_var = tex2D(_Night_Rain,TRANSFORM_TEX(i.uv0, _Night_Rain));
                float4 _Night_Snow_var = tex2D(_Night_Snow,TRANSFORM_TEX(i.uv0, _Night_Snow));
                float4 _Night_Special_var = tex2D(_Night_Special,TRANSFORM_TEX(i.uv0, _Night_Special));
                float3 finalColor = lerp(lerp(_Day_var.rgb,lerp(lerp(_Day_Rain_var.rgb,_Day_Snow_var.rgb,_RainToSnow),_Day_Special_var.rgb,_RainSnowtoSpecial),_NormalToRainSnow),lerp(_Night_var.rgb,lerp(lerp(_Night_Rain_var.rgb,_Night_Snow_var.rgb,_RainToSnow),_Night_Special_var.rgb,_RainSnowtoSpecial),_NormalToRainSnow),_DayToNight);
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

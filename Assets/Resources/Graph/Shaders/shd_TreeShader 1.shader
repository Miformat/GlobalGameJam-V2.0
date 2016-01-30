// Shader created with Shader Forge v1.10 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.10;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,nrsp:0,limd:0,spmd:1,grmd:0,uamb:True,mssp:True,bkdf:False,rprd:False,enco:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:0,bsrc:0,bdst:1,culm:2,dpts:2,wrdp:True,dith:0,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:1366,x:33716,y:32930,varname:node_1366,prsc:2|custl-5025-OUT,clip-7251-OUT;n:type:ShaderForge.SFN_Tex2d,id:3953,x:32275,y:32764,ptovrint:False,ptlb:Diffuse Texture,ptin:_DiffuseTexture,varname:node_3953,prsc:2,tex:c2ad97974dd4fa342b6732a7a74d86bf,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:8410,x:33036,y:33148,ptovrint:False,ptlb:Diffuse Color,ptin:_DiffuseColor,varname:node_8410,prsc:2,glob:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:5025,x:33233,y:33129,varname:node_5025,prsc:2|A-2212-OUT,B-8410-RGB;n:type:ShaderForge.SFN_LightColor,id:2966,x:32275,y:32996,varname:node_2966,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2212,x:32859,y:32950,varname:node_2212,prsc:2|A-8082-OUT,B-473-OUT,C-2966-RGB;n:type:ShaderForge.SFN_ValueProperty,id:473,x:32275,y:32938,ptovrint:False,ptlb:Light Intensity,ptin:_LightIntensity,varname:node_473,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_If,id:6977,x:32580,y:33165,varname:node_6977,prsc:2|A-4597-OUT,B-9980-OUT,GT-9434-OUT,EQ-3953-RGB,LT-3953-RGB;n:type:ShaderForge.SFN_ValueProperty,id:4390,x:32148,y:33304,ptovrint:False,ptlb:Limite Snow,ptin:_LimiteSnow,varname:node_4390,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_ComponentMask,id:9705,x:31952,y:33149,varname:node_9705,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-6039-OUT;n:type:ShaderForge.SFN_Vector1,id:9434,x:32148,y:33372,varname:node_9434,prsc:2,v1:1;n:type:ShaderForge.SFN_Slider,id:7857,x:31806,y:33503,ptovrint:False,ptlb:Snow,ptin:_Snow,varname:node_7857,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Tex2d,id:3136,x:31952,y:33321,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:node_3136,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:4597,x:32148,y:33149,varname:node_4597,prsc:2|A-9705-OUT,B-3136-RGB;n:type:ShaderForge.SFN_Lerp,id:8082,x:32798,y:33164,varname:node_8082,prsc:2|A-3953-RGB,B-6977-OUT,T-7857-OUT;n:type:ShaderForge.SFN_NormalVector,id:6039,x:31785,y:33149,prsc:2,pt:False;n:type:ShaderForge.SFN_Lerp,id:9980,x:32352,y:33304,varname:node_9980,prsc:2|A-9822-OUT,B-4390-OUT,T-7857-OUT;n:type:ShaderForge.SFN_Vector1,id:9822,x:32148,y:33433,varname:node_9822,prsc:2,v1:1;n:type:ShaderForge.SFN_Tex2d,id:8165,x:32275,y:32583,ptovrint:False,ptlb:Leaves Mask,ptin:_LeavesMask,varname:node_8165,prsc:2,tex:2287882e753e036439cc9be87fec3135,ntxv:0,isnm:False;n:type:ShaderForge.SFN_TexCoord,id:9699,x:32275,y:32408,varname:node_9699,prsc:2,uv:0;n:type:ShaderForge.SFN_OneMinus,id:2918,x:32448,y:32418,varname:node_2918,prsc:2|IN-9699-U;n:type:ShaderForge.SFN_Multiply,id:2293,x:32995,y:32592,varname:node_2293,prsc:2|A-2918-OUT,B-3953-A,C-3136-RGB;n:type:ShaderForge.SFN_Add,id:9744,x:33208,y:32592,varname:node_9744,prsc:2|A-2293-OUT,B-8165-RGB,C-9496-OUT;n:type:ShaderForge.SFN_Slider,id:7917,x:32665,y:32743,ptovrint:False,ptlb:Leaves,ptin:_Leaves,varname:node_7917,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_RemapRange,id:9496,x:32995,y:32743,varname:node_9496,prsc:2,frmn:0,frmx:1,tomn:0.2,tomx:0.48|IN-7917-OUT;n:type:ShaderForge.SFN_ComponentMask,id:7251,x:33413,y:32592,varname:node_7251,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-9744-OUT;proporder:3953-8410-473-4390-7857-3136-8165-7917;pass:END;sub:END;*/

Shader "Custom/shd_TreeShader" {
    Properties {
        _DiffuseTexture ("Diffuse Texture", 2D) = "white" {}
        _DiffuseColor ("Diffuse Color", Color) = (1,1,1,1)
        _LightIntensity ("Light Intensity", Float ) = 0
        _LimiteSnow ("Limite Snow", Float ) = 0
        _Snow ("Snow", Range(0, 1)) = 0
        _Noise ("Noise", 2D) = "white" {}
        _LeavesMask ("Leaves Mask", 2D) = "white" {}
        _Leaves ("Leaves", Range(0, 1)) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
        }
        LOD 200
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _DiffuseTexture; uniform float4 _DiffuseTexture_ST;
            uniform float4 _DiffuseColor;
            uniform float _LightIntensity;
            uniform float _LimiteSnow;
            uniform float _Snow;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform sampler2D _LeavesMask; uniform float4 _LeavesMask_ST;
            uniform float _Leaves;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                
                float nSign = sign( dot( viewDirection, i.normalDir ) ); // Reverse normal if this is a backface
                i.normalDir *= nSign;
                normalDirection *= nSign;
                
                float4 _DiffuseTexture_var = tex2D(_DiffuseTexture,TRANSFORM_TEX(i.uv0, _DiffuseTexture));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float4 _LeavesMask_var = tex2D(_LeavesMask,TRANSFORM_TEX(i.uv0, _LeavesMask));
                clip((((1.0 - i.uv0.r)*_DiffuseTexture_var.a*_Noise_var.rgb)+_LeavesMask_var.rgb+(_Leaves*0.28+0.2)).r - 0.5);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float node_6977_if_leA = step((i.normalDir.g*_Noise_var.rgb),lerp(1.0,_LimiteSnow,_Snow));
                float node_6977_if_leB = step(lerp(1.0,_LimiteSnow,_Snow),(i.normalDir.g*_Noise_var.rgb));
                float3 finalColor = ((lerp(_DiffuseTexture_var.rgb,lerp((node_6977_if_leA*_DiffuseTexture_var.rgb)+(node_6977_if_leB*1.0),_DiffuseTexture_var.rgb,node_6977_if_leA*node_6977_if_leB),_Snow)*_LightIntensity*_LightColor0.rgb)*_DiffuseColor.rgb);
                fixed4 finalRGBA = fixed4(finalColor,1);
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
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _DiffuseTexture; uniform float4 _DiffuseTexture_ST;
            uniform float4 _DiffuseColor;
            uniform float _LightIntensity;
            uniform float _LimiteSnow;
            uniform float _Snow;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform sampler2D _LeavesMask; uniform float4 _LeavesMask_ST;
            uniform float _Leaves;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                
                float nSign = sign( dot( viewDirection, i.normalDir ) ); // Reverse normal if this is a backface
                i.normalDir *= nSign;
                normalDirection *= nSign;
                
                float4 _DiffuseTexture_var = tex2D(_DiffuseTexture,TRANSFORM_TEX(i.uv0, _DiffuseTexture));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float4 _LeavesMask_var = tex2D(_LeavesMask,TRANSFORM_TEX(i.uv0, _LeavesMask));
                clip((((1.0 - i.uv0.r)*_DiffuseTexture_var.a*_Noise_var.rgb)+_LeavesMask_var.rgb+(_Leaves*0.28+0.2)).r - 0.5);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float node_6977_if_leA = step((i.normalDir.g*_Noise_var.rgb),lerp(1.0,_LimiteSnow,_Snow));
                float node_6977_if_leB = step(lerp(1.0,_LimiteSnow,_Snow),(i.normalDir.g*_Noise_var.rgb));
                float3 finalColor = ((lerp(_DiffuseTexture_var.rgb,lerp((node_6977_if_leA*_DiffuseTexture_var.rgb)+(node_6977_if_leB*1.0),_DiffuseTexture_var.rgb,node_6977_if_leA*node_6977_if_leB),_Snow)*_LightIntensity*_LightColor0.rgb)*_DiffuseColor.rgb);
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCollector"
            Tags {
                "LightMode"="ShadowCollector"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCOLLECTOR
            #define SHADOW_COLLECTOR_PASS
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcollector
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _DiffuseTexture; uniform float4 _DiffuseTexture_ST;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform sampler2D _LeavesMask; uniform float4 _LeavesMask_ST;
            uniform float _Leaves;
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
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_SHADOW_COLLECTOR(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
                float4 _DiffuseTexture_var = tex2D(_DiffuseTexture,TRANSFORM_TEX(i.uv0, _DiffuseTexture));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float4 _LeavesMask_var = tex2D(_LeavesMask,TRANSFORM_TEX(i.uv0, _LeavesMask));
                clip((((1.0 - i.uv0.r)*_DiffuseTexture_var.a*_Noise_var.rgb)+_LeavesMask_var.rgb+(_Leaves*0.28+0.2)).r - 0.5);
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
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _DiffuseTexture; uniform float4 _DiffuseTexture_ST;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform sampler2D _LeavesMask; uniform float4 _LeavesMask_ST;
            uniform float _Leaves;
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
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
                float4 _DiffuseTexture_var = tex2D(_DiffuseTexture,TRANSFORM_TEX(i.uv0, _DiffuseTexture));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float4 _LeavesMask_var = tex2D(_LeavesMask,TRANSFORM_TEX(i.uv0, _LeavesMask));
                clip((((1.0 - i.uv0.r)*_DiffuseTexture_var.a*_Noise_var.rgb)+_LeavesMask_var.rgb+(_Leaves*0.28+0.2)).r - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

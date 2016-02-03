// Shader created with Shader Forge v1.10 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.10;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,nrsp:0,limd:0,spmd:1,grmd:0,uamb:True,mssp:True,bkdf:False,rprd:False,enco:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:0,bsrc:0,bdst:1,culm:2,dpts:2,wrdp:True,dith:0,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:1366,x:34297,y:33496,varname:node_1366,prsc:2|custl-2212-OUT,clip-8212-OUT,voffset-1947-OUT;n:type:ShaderForge.SFN_Tex2d,id:3953,x:32275,y:32764,ptovrint:False,ptlb:Diffuse Texture,ptin:_DiffuseTexture,varname:node_3953,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:8410,x:33036,y:33148,ptovrint:False,ptlb:Diffuse Color,ptin:_DiffuseColor,varname:node_8410,prsc:2,glob:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_LightColor,id:2966,x:32275,y:32996,varname:node_2966,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2212,x:32859,y:32950,varname:node_2212,prsc:2|A-8082-OUT,B-473-OUT,C-2966-RGB;n:type:ShaderForge.SFN_ValueProperty,id:473,x:32275,y:32933,ptovrint:False,ptlb:Light Intensity,ptin:_LightIntensity,varname:node_473,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_If,id:6977,x:32580,y:33165,varname:node_6977,prsc:2|A-4597-OUT,B-9980-OUT,GT-9434-OUT,EQ-5957-OUT,LT-5957-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4390,x:32148,y:33304,ptovrint:False,ptlb:Limite Snow,ptin:_LimiteSnow,varname:node_4390,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_ComponentMask,id:9705,x:31952,y:33149,varname:node_9705,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-6039-OUT;n:type:ShaderForge.SFN_Vector1,id:9434,x:32148,y:33372,varname:node_9434,prsc:2,v1:1;n:type:ShaderForge.SFN_Slider,id:7857,x:31806,y:33503,ptovrint:False,ptlb:Snow,ptin:_Snow,varname:node_7857,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Tex2d,id:3136,x:31952,y:33321,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:node_3136,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:4597,x:32148,y:33149,varname:node_4597,prsc:2|A-9705-OUT,B-3136-RGB;n:type:ShaderForge.SFN_Lerp,id:8082,x:32798,y:33164,varname:node_8082,prsc:2|A-5957-OUT,B-6977-OUT,T-7857-OUT;n:type:ShaderForge.SFN_NormalVector,id:6039,x:31785,y:33149,prsc:2,pt:False;n:type:ShaderForge.SFN_Lerp,id:9980,x:32352,y:33304,varname:node_9980,prsc:2|A-9822-OUT,B-4390-OUT,T-7857-OUT;n:type:ShaderForge.SFN_Vector1,id:9822,x:32148,y:33433,varname:node_9822,prsc:2,v1:1;n:type:ShaderForge.SFN_Tex2d,id:9886,x:32275,y:32588,ptovrint:False,ptlb:LeavesTex,ptin:_LeavesTex,varname:node_9886,prsc:2,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:8979,x:32275,y:32411,ptovrint:False,ptlb:FlowersTex,ptin:_FlowersTex,varname:node_8979,prsc:2,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Add,id:8629,x:32641,y:32666,varname:node_8629,prsc:2|A-9886-A,B-3953-A;n:type:ShaderForge.SFN_Lerp,id:3572,x:33330,y:32504,varname:node_3572,prsc:2|A-3953-A,B-8629-OUT,T-6507-OUT;n:type:ShaderForge.SFN_Slider,id:7200,x:32454,y:32440,ptovrint:False,ptlb:Leaves,ptin:_Leaves,varname:node_7200,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_TexCoord,id:8109,x:32279,y:32217,varname:node_8109,prsc:2,uv:0;n:type:ShaderForge.SFN_OneMinus,id:1719,x:32454,y:32227,varname:node_1719,prsc:2|IN-8109-U;n:type:ShaderForge.SFN_Multiply,id:7739,x:32627,y:32227,varname:node_7739,prsc:2|A-1719-OUT,B-3136-RGB;n:type:ShaderForge.SFN_Slider,id:8474,x:32454,y:32532,ptovrint:False,ptlb:Flowers,ptin:_Flowers,varname:node_8474,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Add,id:3530,x:32788,y:32227,varname:node_3530,prsc:2|A-7739-OUT,B-7200-OUT;n:type:ShaderForge.SFN_RemapRange,id:6507,x:33155,y:32504,varname:node_6507,prsc:2,frmn:0,frmx:1.5,tomn:0,tomx:1|IN-3530-OUT;n:type:ShaderForge.SFN_Add,id:6099,x:32788,y:32365,varname:node_6099,prsc:2|A-7739-OUT,B-8474-OUT;n:type:ShaderForge.SFN_RemapRange,id:731,x:33157,y:32665,varname:node_731,prsc:2,frmn:0,frmx:1.5,tomn:0,tomx:1|IN-6099-OUT;n:type:ShaderForge.SFN_Lerp,id:8212,x:33536,y:32610,varname:node_8212,prsc:2|A-3572-OUT,B-4730-OUT,T-731-OUT;n:type:ShaderForge.SFN_Add,id:4730,x:33330,y:32665,varname:node_4730,prsc:2|A-3572-OUT,B-8979-A;n:type:ShaderForge.SFN_Multiply,id:8248,x:32622,y:32838,varname:node_8248,prsc:2|A-3953-RGB,B-8696-OUT;n:type:ShaderForge.SFN_Lerp,id:8696,x:32847,y:32694,varname:node_8696,prsc:2|A-9886-RGB,B-8979-RGB,T-6422-OUT;n:type:ShaderForge.SFN_Multiply,id:6422,x:32874,y:32526,varname:node_6422,prsc:2|A-8979-A,B-8474-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:6973,x:33206,y:33828,varname:node_6973,prsc:2;n:type:ShaderForge.SFN_ObjectPosition,id:1247,x:33206,y:33955,varname:node_1247,prsc:2;n:type:ShaderForge.SFN_OneMinus,id:901,x:33394,y:33955,varname:node_901,prsc:2|IN-1247-XYZ;n:type:ShaderForge.SFN_Add,id:9209,x:33582,y:33927,varname:node_9209,prsc:2|A-6973-XYZ,B-901-OUT;n:type:ShaderForge.SFN_ComponentMask,id:7731,x:33771,y:33927,varname:node_7731,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-9209-OUT;n:type:ShaderForge.SFN_Multiply,id:1947,x:33942,y:33927,varname:node_1947,prsc:2|A-7731-OUT,B-9582-OUT,C-344-OUT;n:type:ShaderForge.SFN_Slider,id:3701,x:33263,y:34304,ptovrint:False,ptlb:DisplacementStrength,ptin:_DisplacementStrength,varname:node_3701,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Sin,id:9154,x:33456,y:34125,varname:node_9154,prsc:2|IN-357-OUT;n:type:ShaderForge.SFN_Time,id:2923,x:33089,y:34125,varname:node_2923,prsc:2;n:type:ShaderForge.SFN_Multiply,id:357,x:33291,y:34125,varname:node_357,prsc:2|A-2923-T,B-9193-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9193,x:33089,y:34273,ptovrint:False,ptlb:DisplacementSpeed,ptin:_DisplacementSpeed,varname:node_9193,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:9582,x:33697,y:34230,varname:node_9582,prsc:2|A-9154-OUT,B-3701-OUT;n:type:ShaderForge.SFN_Vector3,id:344,x:33960,y:34175,varname:node_344,prsc:2,v1:0,v2:0,v3:1;n:type:ShaderForge.SFN_Add,id:5957,x:33192,y:32914,varname:node_5957,prsc:2|A-8248-OUT,B-8410-RGB;proporder:3953-8410-473-4390-7857-3136-8979-8474-9886-7200-3701-9193;pass:END;sub:END;*/

Shader "Custom/shd_TreeShader" {
    Properties {
        _DiffuseTexture ("Diffuse Texture", 2D) = "white" {}
        _DiffuseColor ("Diffuse Color", Color) = (1,1,1,1)
        _LightIntensity ("Light Intensity", Float ) = 0
        _LimiteSnow ("Limite Snow", Float ) = 0
        _Snow ("Snow", Range(0, 1)) = 0
        _Noise ("Noise", 2D) = "white" {}
        _FlowersTex ("FlowersTex", 2D) = "black" {}
        _Flowers ("Flowers", Range(0, 1)) = 0
        _LeavesTex ("LeavesTex", 2D) = "black" {}
        _Leaves ("Leaves", Range(0, 1)) = 0
        _DisplacementStrength ("DisplacementStrength", Range(0, 1)) = 0
        _DisplacementSpeed ("DisplacementSpeed", Float ) = 0
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
            uniform float4 _TimeEditor;
            uniform sampler2D _DiffuseTexture; uniform float4 _DiffuseTexture_ST;
            uniform float4 _DiffuseColor;
            uniform float _LightIntensity;
            uniform float _LimiteSnow;
            uniform float _Snow;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform sampler2D _LeavesTex; uniform float4 _LeavesTex_ST;
            uniform sampler2D _FlowersTex; uniform float4 _FlowersTex_ST;
            uniform float _Leaves;
            uniform float _Flowers;
            uniform float _DisplacementStrength;
            uniform float _DisplacementSpeed;
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
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                float4 node_2923 = _Time + _TimeEditor;
                v.vertex.xyz += ((mul(_Object2World, v.vertex).rgb+(1.0 - objPos.rgb)).g*(sin((node_2923.g*_DisplacementSpeed))*_DisplacementStrength)*float3(0,0,1));
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                
                float nSign = sign( dot( viewDirection, i.normalDir ) ); // Reverse normal if this is a backface
                i.normalDir *= nSign;
                normalDirection *= nSign;
                
                float4 _DiffuseTexture_var = tex2D(_DiffuseTexture,TRANSFORM_TEX(i.uv0, _DiffuseTexture));
                float4 _LeavesTex_var = tex2D(_LeavesTex,TRANSFORM_TEX(i.uv0, _LeavesTex));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float3 node_7739 = ((1.0 - i.uv0.r)*_Noise_var.rgb);
                float node_3572 = lerp(_DiffuseTexture_var.a,(_LeavesTex_var.a+_DiffuseTexture_var.a),((node_7739+_Leaves)*0.6666667+0.0));
                float4 _FlowersTex_var = tex2D(_FlowersTex,TRANSFORM_TEX(i.uv0, _FlowersTex));
                clip(lerp(node_3572,(node_3572+_FlowersTex_var.a),((node_7739+_Flowers)*0.6666667+0.0)) - 0.5);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float3 node_5957 = ((_DiffuseTexture_var.rgb*lerp(_LeavesTex_var.rgb,_FlowersTex_var.rgb,(_FlowersTex_var.a*_Flowers)))+_DiffuseColor.rgb);
                float node_6977_if_leA = step((i.normalDir.g*_Noise_var.rgb),lerp(1.0,_LimiteSnow,_Snow));
                float node_6977_if_leB = step(lerp(1.0,_LimiteSnow,_Snow),(i.normalDir.g*_Noise_var.rgb));
                float3 finalColor = (lerp(node_5957,lerp((node_6977_if_leA*node_5957)+(node_6977_if_leB*1.0),node_5957,node_6977_if_leA*node_6977_if_leB),_Snow)*_LightIntensity*_LightColor0.rgb);
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
            uniform float4 _TimeEditor;
            uniform sampler2D _DiffuseTexture; uniform float4 _DiffuseTexture_ST;
            uniform float4 _DiffuseColor;
            uniform float _LightIntensity;
            uniform float _LimiteSnow;
            uniform float _Snow;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform sampler2D _LeavesTex; uniform float4 _LeavesTex_ST;
            uniform sampler2D _FlowersTex; uniform float4 _FlowersTex_ST;
            uniform float _Leaves;
            uniform float _Flowers;
            uniform float _DisplacementStrength;
            uniform float _DisplacementSpeed;
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
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                float4 node_2923 = _Time + _TimeEditor;
                v.vertex.xyz += ((mul(_Object2World, v.vertex).rgb+(1.0 - objPos.rgb)).g*(sin((node_2923.g*_DisplacementSpeed))*_DisplacementStrength)*float3(0,0,1));
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                
                float nSign = sign( dot( viewDirection, i.normalDir ) ); // Reverse normal if this is a backface
                i.normalDir *= nSign;
                normalDirection *= nSign;
                
                float4 _DiffuseTexture_var = tex2D(_DiffuseTexture,TRANSFORM_TEX(i.uv0, _DiffuseTexture));
                float4 _LeavesTex_var = tex2D(_LeavesTex,TRANSFORM_TEX(i.uv0, _LeavesTex));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float3 node_7739 = ((1.0 - i.uv0.r)*_Noise_var.rgb);
                float node_3572 = lerp(_DiffuseTexture_var.a,(_LeavesTex_var.a+_DiffuseTexture_var.a),((node_7739+_Leaves)*0.6666667+0.0));
                float4 _FlowersTex_var = tex2D(_FlowersTex,TRANSFORM_TEX(i.uv0, _FlowersTex));
                clip(lerp(node_3572,(node_3572+_FlowersTex_var.a),((node_7739+_Flowers)*0.6666667+0.0)) - 0.5);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float3 node_5957 = ((_DiffuseTexture_var.rgb*lerp(_LeavesTex_var.rgb,_FlowersTex_var.rgb,(_FlowersTex_var.a*_Flowers)))+_DiffuseColor.rgb);
                float node_6977_if_leA = step((i.normalDir.g*_Noise_var.rgb),lerp(1.0,_LimiteSnow,_Snow));
                float node_6977_if_leB = step(lerp(1.0,_LimiteSnow,_Snow),(i.normalDir.g*_Noise_var.rgb));
                float3 finalColor = (lerp(node_5957,lerp((node_6977_if_leA*node_5957)+(node_6977_if_leB*1.0),node_5957,node_6977_if_leA*node_6977_if_leB),_Snow)*_LightIntensity*_LightColor0.rgb);
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
            uniform float4 _TimeEditor;
            uniform sampler2D _DiffuseTexture; uniform float4 _DiffuseTexture_ST;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform sampler2D _LeavesTex; uniform float4 _LeavesTex_ST;
            uniform sampler2D _FlowersTex; uniform float4 _FlowersTex_ST;
            uniform float _Leaves;
            uniform float _Flowers;
            uniform float _DisplacementStrength;
            uniform float _DisplacementSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_COLLECTOR;
                float2 uv0 : TEXCOORD5;
                float4 posWorld : TEXCOORD6;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                float4 node_2923 = _Time + _TimeEditor;
                v.vertex.xyz += ((mul(_Object2World, v.vertex).rgb+(1.0 - objPos.rgb)).g*(sin((node_2923.g*_DisplacementSpeed))*_DisplacementStrength)*float3(0,0,1));
                o.posWorld = mul(_Object2World, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_SHADOW_COLLECTOR(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
/////// Vectors:
                float4 _DiffuseTexture_var = tex2D(_DiffuseTexture,TRANSFORM_TEX(i.uv0, _DiffuseTexture));
                float4 _LeavesTex_var = tex2D(_LeavesTex,TRANSFORM_TEX(i.uv0, _LeavesTex));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float3 node_7739 = ((1.0 - i.uv0.r)*_Noise_var.rgb);
                float node_3572 = lerp(_DiffuseTexture_var.a,(_LeavesTex_var.a+_DiffuseTexture_var.a),((node_7739+_Leaves)*0.6666667+0.0));
                float4 _FlowersTex_var = tex2D(_FlowersTex,TRANSFORM_TEX(i.uv0, _FlowersTex));
                clip(lerp(node_3572,(node_3572+_FlowersTex_var.a),((node_7739+_Flowers)*0.6666667+0.0)) - 0.5);
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
            uniform float4 _TimeEditor;
            uniform sampler2D _DiffuseTexture; uniform float4 _DiffuseTexture_ST;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform sampler2D _LeavesTex; uniform float4 _LeavesTex_ST;
            uniform sampler2D _FlowersTex; uniform float4 _FlowersTex_ST;
            uniform float _Leaves;
            uniform float _Flowers;
            uniform float _DisplacementStrength;
            uniform float _DisplacementSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                float4 node_2923 = _Time + _TimeEditor;
                v.vertex.xyz += ((mul(_Object2World, v.vertex).rgb+(1.0 - objPos.rgb)).g*(sin((node_2923.g*_DisplacementSpeed))*_DisplacementStrength)*float3(0,0,1));
                o.posWorld = mul(_Object2World, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
/////// Vectors:
                float4 _DiffuseTexture_var = tex2D(_DiffuseTexture,TRANSFORM_TEX(i.uv0, _DiffuseTexture));
                float4 _LeavesTex_var = tex2D(_LeavesTex,TRANSFORM_TEX(i.uv0, _LeavesTex));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float3 node_7739 = ((1.0 - i.uv0.r)*_Noise_var.rgb);
                float node_3572 = lerp(_DiffuseTexture_var.a,(_LeavesTex_var.a+_DiffuseTexture_var.a),((node_7739+_Leaves)*0.6666667+0.0));
                float4 _FlowersTex_var = tex2D(_FlowersTex,TRANSFORM_TEX(i.uv0, _FlowersTex));
                clip(lerp(node_3572,(node_3572+_FlowersTex_var.a),((node_7739+_Flowers)*0.6666667+0.0)) - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

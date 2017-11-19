// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:1,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33096,y:32732,varname:node_3138,prsc:2|emission-2552-RGB,voffset-3940-OUT;n:type:ShaderForge.SFN_Tex2d,id:2552,x:32572,y:32644,ptovrint:False,ptlb:Atlas2,ptin:_Atlas2,varname:node_2552,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:97cac9a7a1dad594f92f34e782df61fb,ntxv:0,isnm:False;n:type:ShaderForge.SFN_VertexColor,id:2975,x:32393,y:33108,varname:node_2975,prsc:2;n:type:ShaderForge.SFN_Time,id:4856,x:31249,y:32718,varname:node_4856,prsc:2;n:type:ShaderForge.SFN_Sin,id:7675,x:32289,y:32870,varname:node_7675,prsc:2|IN-3649-OUT;n:type:ShaderForge.SFN_Multiply,id:3649,x:31940,y:32872,varname:node_3649,prsc:2|A-4856-T,B-6880-OUT;n:type:ShaderForge.SFN_Slider,id:6880,x:31211,y:33033,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:node_6880,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:4.507107,max:50;n:type:ShaderForge.SFN_RemapRange,id:8532,x:32458,y:32891,varname:node_8532,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-7675-OUT;n:type:ShaderForge.SFN_Multiply,id:3940,x:32702,y:32959,varname:node_3940,prsc:2|A-8532-OUT,B-2975-R,C-181-OUT,D-5879-OUT,E-7502-OUT;n:type:ShaderForge.SFN_Slider,id:181,x:32557,y:33157,ptovrint:False,ptlb:Power,ptin:_Power,varname:node_181,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.005507762,max:1;n:type:ShaderForge.SFN_NormalVector,id:5879,x:32591,y:33335,prsc:2,pt:False;n:type:ShaderForge.SFN_Multiply,id:3472,x:31760,y:33246,varname:node_3472,prsc:2|A-1445-OUT,B-2017-OUT;n:type:ShaderForge.SFN_Slider,id:2017,x:31224,y:33486,ptovrint:False,ptlb:speed2,ptin:_speed2,varname:node_2017,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2.654685,max:30;n:type:ShaderForge.SFN_Sin,id:8457,x:31940,y:33243,varname:node_8457,prsc:2|IN-3472-OUT;n:type:ShaderForge.SFN_RemapRange,id:7502,x:32092,y:33227,varname:node_7502,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-8457-OUT;n:type:ShaderForge.SFN_Add,id:1445,x:31609,y:33181,varname:node_1445,prsc:2|A-4856-T,B-4387-OUT;n:type:ShaderForge.SFN_Vector1,id:4387,x:31345,y:33346,varname:node_4387,prsc:2,v1:0.5;proporder:2552-6880-181-2017;pass:END;sub:END;*/

Shader "Shader Forge/S_radio" {
    Properties {
        _Atlas2 ("Atlas2", 2D) = "white" {}
        _Speed ("Speed", Range(0, 50)) = 4.507107
        _Power ("Power", Range(0, 1)) = 0.005507762
        _speed2 ("speed2", Range(0, 30)) = 2.654685
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "DEFERRED"
            Tags {
                "LightMode"="Deferred"
            }
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_DEFERRED
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile ___ UNITY_HDR_ON
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Atlas2; uniform float4 _Atlas2_ST;
            uniform float _Speed;
            uniform float _Power;
            uniform float _speed2;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_4856 = _Time;
                v.vertex.xyz += ((sin((node_4856.g*_Speed))*0.5+0.5)*o.vertexColor.r*_Power*v.normal*(sin(((node_4856.g+0.5)*_speed2))*0.5+0.5));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            void frag(
                VertexOutput i,
                out half4 outDiffuse : SV_Target0,
                out half4 outSpecSmoothness : SV_Target1,
                out half4 outNormal : SV_Target2,
                out half4 outEmission : SV_Target3,
                float facing : VFACE )
            {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
////// Lighting:
////// Emissive:
                float4 _Atlas2_var = tex2D(_Atlas2,TRANSFORM_TEX(i.uv0, _Atlas2));
                float3 emissive = _Atlas2_var.rgb;
                float3 finalColor = emissive;
                outDiffuse = half4( 0, 0, 0, 1 );
                outSpecSmoothness = half4(0,0,0,0);
                outNormal = half4( normalDirection * 0.5 + 0.5, 1 );
                outEmission = half4( _Atlas2_var.rgb, 1 );
                #ifndef UNITY_HDR_ON
                    outEmission.rgb = exp2(-outEmission.rgb);
                #endif
            }
            ENDCG
        }
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
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Atlas2; uniform float4 _Atlas2_ST;
            uniform float _Speed;
            uniform float _Power;
            uniform float _speed2;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_4856 = _Time;
                v.vertex.xyz += ((sin((node_4856.g*_Speed))*0.5+0.5)*o.vertexColor.r*_Power*v.normal*(sin(((node_4856.g+0.5)*_speed2))*0.5+0.5));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
////// Lighting:
////// Emissive:
                float4 _Atlas2_var = tex2D(_Atlas2,TRANSFORM_TEX(i.uv0, _Atlas2));
                float3 emissive = _Atlas2_var.rgb;
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float _Speed;
            uniform float _Power;
            uniform float _speed2;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_4856 = _Time;
                v.vertex.xyz += ((sin((node_4856.g*_Speed))*0.5+0.5)*o.vertexColor.r*_Power*v.normal*(sin(((node_4856.g+0.5)*_speed2))*0.5+0.5));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

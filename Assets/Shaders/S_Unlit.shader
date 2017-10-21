// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33252,y:32686,varname:node_3138,prsc:2|emission-3113-OUT;n:type:ShaderForge.SFN_Tex2d,id:7045,x:31813,y:30805,ptovrint:False,ptlb:Red1,ptin:_Red1,varname:node_7045,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:615fd09e270ce1a41a8a103ebffbcedc,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:3985,x:31814,y:31157,ptovrint:False,ptlb:Red2,ptin:_Red2,varname:node_3985,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:fd01db91bebae5a4cbce04ccc4f406b7,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:1512,x:31817,y:31541,ptovrint:False,ptlb:Red3,ptin:_Red3,varname:node_1512,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3e47dd8bc6e3a62409e8c9f750bcb9a8,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:2608,x:31820,y:30634,ptovrint:False,ptlb:red1,ptin:_red1,varname:node_2608,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5372549,c2:0.254902,c3:0.2588235,c4:1;n:type:ShaderForge.SFN_Multiply,id:6841,x:32072,y:30701,varname:node_6841,prsc:2|A-2608-RGB,B-7045-RGB;n:type:ShaderForge.SFN_Add,id:8401,x:32699,y:31271,varname:node_8401,prsc:2|A-6841-OUT,B-2326-OUT,C-7787-OUT;n:type:ShaderForge.SFN_Color,id:5487,x:31814,y:30982,ptovrint:False,ptlb:red2,ptin:_red2,varname:node_5487,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.6117647,c2:0.3333333,c3:0.3333333,c4:1;n:type:ShaderForge.SFN_Multiply,id:2326,x:32063,y:30983,varname:node_2326,prsc:2|A-5487-RGB,B-3985-RGB;n:type:ShaderForge.SFN_Color,id:3479,x:31811,y:31348,ptovrint:False,ptlb:red3,ptin:_red3,varname:node_3479,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.3333333,c2:0.09019608,c3:0.08627451,c4:1;n:type:ShaderForge.SFN_Multiply,id:7787,x:32001,y:31361,varname:node_7787,prsc:2|A-3479-RGB,B-1512-RGB;n:type:ShaderForge.SFN_Tex2d,id:4819,x:30714,y:32286,ptovrint:False,ptlb:Blue1,ptin:_Blue1,varname:node_4819,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2388829a91b124045b5cb4c657645f5d,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:6157,x:30719,y:32652,ptovrint:False,ptlb:Blue2,ptin:_Blue2,varname:node_6157,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:cbbf37d108e2d404aa3f2804a82d82ac,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:2857,x:30714,y:33007,ptovrint:False,ptlb:Blue3,ptin:_Blue3,varname:node_2857,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:aa79c1da9b20f2d42ad9289f8d20e8bb,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:562,x:30712,y:32116,ptovrint:False,ptlb:blue1,ptin:_blue1,varname:node_562,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.345098,c2:0.4,c3:0.4941177,c4:1;n:type:ShaderForge.SFN_Color,id:2036,x:30713,y:32482,ptovrint:False,ptlb:blue2,ptin:_blue2,varname:node_2036,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4196079,c2:0.4745098,c3:0.5686275,c4:1;n:type:ShaderForge.SFN_Color,id:4854,x:30715,y:32835,ptovrint:False,ptlb:blue3,ptin:_blue3,varname:node_4854,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.08627451,c2:0.1607843,c3:0.2901961,c4:1;n:type:ShaderForge.SFN_Multiply,id:8225,x:30906,y:32111,varname:node_8225,prsc:2|A-562-RGB,B-4819-RGB;n:type:ShaderForge.SFN_Multiply,id:9972,x:30912,y:32830,varname:node_9972,prsc:2|A-4854-RGB,B-2857-RGB;n:type:ShaderForge.SFN_Multiply,id:7742,x:30918,y:32483,varname:node_7742,prsc:2|A-2036-RGB,B-6157-RGB;n:type:ShaderForge.SFN_Add,id:7769,x:31602,y:31813,varname:node_7769,prsc:2|A-8225-OUT,B-7742-OUT,C-9972-OUT;n:type:ShaderForge.SFN_Add,id:3113,x:33061,y:32766,varname:node_3113,prsc:2|A-8401-OUT,B-7769-OUT,C-1356-OUT,D-1532-OUT,E-2606-OUT;n:type:ShaderForge.SFN_Tex2d,id:6190,x:31656,y:32504,ptovrint:False,ptlb:Yellow1,ptin:_Yellow1,varname:node_6190,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:cde6a40526f34494489be1e9d2b367e3,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:3420,x:31661,y:32837,ptovrint:False,ptlb:Yellow2,ptin:_Yellow2,varname:node_3420,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2e12b629abfc60a49b13478d64c25a86,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:9260,x:30745,y:33511,ptovrint:False,ptlb:Brown1,ptin:_Brown1,varname:node_9260,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:bb5a9396f766ec141a7bb93b3388108a,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:4781,x:30743,y:33840,ptovrint:False,ptlb:Brown2,ptin:_Brown2,varname:node_4781,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:135096c9712a4e94eb9d1405ed237e26,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:2618,x:31656,y:32347,ptovrint:False,ptlb:yellow1,ptin:_yellow1,varname:node_2618,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.7411765,c2:0.6470588,c3:0.345098,c4:1;n:type:ShaderForge.SFN_Color,id:5626,x:31656,y:32678,ptovrint:False,ptlb:yellow2,ptin:_yellow2,varname:node_5626,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8509805,c2:0.7803922,c3:0.5490196,c4:1;n:type:ShaderForge.SFN_Color,id:6012,x:30744,y:33356,ptovrint:False,ptlb:brown1,ptin:_brown1,varname:node_6012,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.3372549,c2:0.2627451,c3:0.2392157,c4:1;n:type:ShaderForge.SFN_Color,id:8819,x:30741,y:33686,ptovrint:False,ptlb:brown2,ptin:_brown2,varname:node_8819,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4509804,c2:0.3686275,c3:0.345098,c4:1;n:type:ShaderForge.SFN_Multiply,id:3351,x:31828,y:32348,varname:node_3351,prsc:2|A-2618-RGB,B-6190-RGB;n:type:ShaderForge.SFN_Multiply,id:4177,x:31829,y:32675,varname:node_4177,prsc:2|A-5626-RGB,B-3420-RGB;n:type:ShaderForge.SFN_Multiply,id:711,x:30912,y:33354,varname:node_711,prsc:2|A-6012-RGB,B-9260-RGB;n:type:ShaderForge.SFN_Multiply,id:4459,x:30910,y:33688,varname:node_4459,prsc:2|A-8819-RGB,B-4781-RGB;n:type:ShaderForge.SFN_Add,id:1356,x:32108,y:32345,varname:node_1356,prsc:2|A-3351-OUT,B-4177-OUT;n:type:ShaderForge.SFN_Add,id:1532,x:31202,y:33354,varname:node_1532,prsc:2|A-711-OUT,B-4459-OUT;n:type:ShaderForge.SFN_Tex2d,id:8277,x:31832,y:33589,ptovrint:False,ptlb:Pink1,ptin:_Pink1,varname:node_8277,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c3400414857cc0e4aa2f801abe81bec8,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:4596,x:31830,y:33929,ptovrint:False,ptlb:Pink2,ptin:_Pink2,varname:node_4596,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c49bb54af79a413499b3eb944993f860,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:1496,x:31832,y:34265,ptovrint:False,ptlb:Pink3,ptin:_Pink3,varname:node_1496,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c995ffa744675fe4fa806b0014b2f1d5,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:8243,x:31833,y:33429,ptovrint:False,ptlb:pink1,ptin:_pink1,varname:node_8243,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.6980392,c2:0.5529412,c3:0.6235294,c4:1;n:type:ShaderForge.SFN_Color,id:1028,x:31834,y:33769,ptovrint:False,ptlb:pink2,ptin:_pink2,varname:node_1028,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.7960785,c2:0.764706,c3:0.7843138,c4:1;n:type:ShaderForge.SFN_Color,id:4763,x:31832,y:34102,ptovrint:False,ptlb:pink3,ptin:_pink3,varname:node_4763,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.345098,c2:0.1215686,c3:0.2235294,c4:1;n:type:ShaderForge.SFN_Multiply,id:6057,x:32000,y:33431,varname:node_6057,prsc:2|A-8243-RGB,B-8277-RGB;n:type:ShaderForge.SFN_Multiply,id:9062,x:31999,y:34104,varname:node_9062,prsc:2|A-4763-RGB,B-1496-RGB;n:type:ShaderForge.SFN_Multiply,id:1695,x:32004,y:33767,varname:node_1695,prsc:2|A-1028-RGB,B-4596-RGB;n:type:ShaderForge.SFN_Add,id:2606,x:32218,y:33431,varname:node_2606,prsc:2|A-6057-OUT,B-1695-OUT,C-9062-OUT;proporder:2608-5487-3479-562-2036-4854-2618-5626-6012-8819-8243-1028-4763-7045-3985-1512-4819-6157-2857-6190-3420-9260-4781-8277-4596-1496;pass:END;sub:END;*/

Shader "Shader Forge/S_Unlit" {
    Properties {
        _red1 ("red1", Color) = (0.5372549,0.254902,0.2588235,1)
        _red2 ("red2", Color) = (0.6117647,0.3333333,0.3333333,1)
        _red3 ("red3", Color) = (0.3333333,0.09019608,0.08627451,1)
        _blue1 ("blue1", Color) = (0.345098,0.4,0.4941177,1)
        _blue2 ("blue2", Color) = (0.4196079,0.4745098,0.5686275,1)
        _blue3 ("blue3", Color) = (0.08627451,0.1607843,0.2901961,1)
        _yellow1 ("yellow1", Color) = (0.7411765,0.6470588,0.345098,1)
        _yellow2 ("yellow2", Color) = (0.8509805,0.7803922,0.5490196,1)
        _brown1 ("brown1", Color) = (0.3372549,0.2627451,0.2392157,1)
        _brown2 ("brown2", Color) = (0.4509804,0.3686275,0.345098,1)
        _pink1 ("pink1", Color) = (0.6980392,0.5529412,0.6235294,1)
        _pink2 ("pink2", Color) = (0.7960785,0.764706,0.7843138,1)
        _pink3 ("pink3", Color) = (0.345098,0.1215686,0.2235294,1)
        _Red1 ("Red1", 2D) = "white" {}
        _Red2 ("Red2", 2D) = "white" {}
        _Red3 ("Red3", 2D) = "white" {}
        _Blue1 ("Blue1", 2D) = "white" {}
        _Blue2 ("Blue2", 2D) = "white" {}
        _Blue3 ("Blue3", 2D) = "white" {}
        _Yellow1 ("Yellow1", 2D) = "white" {}
        _Yellow2 ("Yellow2", 2D) = "white" {}
        _Brown1 ("Brown1", 2D) = "white" {}
        _Brown2 ("Brown2", 2D) = "white" {}
        _Pink1 ("Pink1", 2D) = "white" {}
        _Pink2 ("Pink2", 2D) = "white" {}
        _Pink3 ("Pink3", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
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
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Red1; uniform float4 _Red1_ST;
            uniform sampler2D _Red2; uniform float4 _Red2_ST;
            uniform sampler2D _Red3; uniform float4 _Red3_ST;
            uniform float4 _red1;
            uniform float4 _red2;
            uniform float4 _red3;
            uniform sampler2D _Blue1; uniform float4 _Blue1_ST;
            uniform sampler2D _Blue2; uniform float4 _Blue2_ST;
            uniform sampler2D _Blue3; uniform float4 _Blue3_ST;
            uniform float4 _blue1;
            uniform float4 _blue2;
            uniform float4 _blue3;
            uniform sampler2D _Yellow1; uniform float4 _Yellow1_ST;
            uniform sampler2D _Yellow2; uniform float4 _Yellow2_ST;
            uniform sampler2D _Brown1; uniform float4 _Brown1_ST;
            uniform sampler2D _Brown2; uniform float4 _Brown2_ST;
            uniform float4 _yellow1;
            uniform float4 _yellow2;
            uniform float4 _brown1;
            uniform float4 _brown2;
            uniform sampler2D _Pink1; uniform float4 _Pink1_ST;
            uniform sampler2D _Pink2; uniform float4 _Pink2_ST;
            uniform sampler2D _Pink3; uniform float4 _Pink3_ST;
            uniform float4 _pink1;
            uniform float4 _pink2;
            uniform float4 _pink3;
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
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float4 _Red1_var = tex2D(_Red1,TRANSFORM_TEX(i.uv0, _Red1));
                float4 _Red2_var = tex2D(_Red2,TRANSFORM_TEX(i.uv0, _Red2));
                float4 _Red3_var = tex2D(_Red3,TRANSFORM_TEX(i.uv0, _Red3));
                float4 _Blue1_var = tex2D(_Blue1,TRANSFORM_TEX(i.uv0, _Blue1));
                float4 _Blue2_var = tex2D(_Blue2,TRANSFORM_TEX(i.uv0, _Blue2));
                float4 _Blue3_var = tex2D(_Blue3,TRANSFORM_TEX(i.uv0, _Blue3));
                float4 _Yellow1_var = tex2D(_Yellow1,TRANSFORM_TEX(i.uv0, _Yellow1));
                float4 _Yellow2_var = tex2D(_Yellow2,TRANSFORM_TEX(i.uv0, _Yellow2));
                float4 _Brown1_var = tex2D(_Brown1,TRANSFORM_TEX(i.uv0, _Brown1));
                float4 _Brown2_var = tex2D(_Brown2,TRANSFORM_TEX(i.uv0, _Brown2));
                float4 _Pink1_var = tex2D(_Pink1,TRANSFORM_TEX(i.uv0, _Pink1));
                float4 _Pink2_var = tex2D(_Pink2,TRANSFORM_TEX(i.uv0, _Pink2));
                float4 _Pink3_var = tex2D(_Pink3,TRANSFORM_TEX(i.uv0, _Pink3));
                float3 emissive = (((_red1.rgb*_Red1_var.rgb)+(_red2.rgb*_Red2_var.rgb)+(_red3.rgb*_Red3_var.rgb))+((_blue1.rgb*_Blue1_var.rgb)+(_blue2.rgb*_Blue2_var.rgb)+(_blue3.rgb*_Blue3_var.rgb))+((_yellow1.rgb*_Yellow1_var.rgb)+(_yellow2.rgb*_Yellow2_var.rgb))+((_brown1.rgb*_Brown1_var.rgb)+(_brown2.rgb*_Brown2_var.rgb))+((_pink1.rgb*_Pink1_var.rgb)+(_pink2.rgb*_Pink2_var.rgb)+(_pink3.rgb*_Pink3_var.rgb)));
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
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

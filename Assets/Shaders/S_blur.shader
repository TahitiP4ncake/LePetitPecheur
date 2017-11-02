// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33762,y:32844,varname:node_3138,prsc:2|custl-2787-OUT;n:type:ShaderForge.SFN_Slider,id:655,x:32111,y:32608,ptovrint:False,ptlb:Offset,ptin:_Offset,varname:node_655,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:0.05;n:type:ShaderForge.SFN_ScreenPos,id:6299,x:31591,y:32723,varname:node_6299,prsc:2,sctp:2;n:type:ShaderForge.SFN_Set,id:1457,x:31769,y:32687,varname:screenPos,prsc:2|IN-6299-UVOUT;n:type:ShaderForge.SFN_SceneColor,id:4848,x:32851,y:33321,varname:node_4848,prsc:2|UVIN-8048-OUT;n:type:ShaderForge.SFN_Set,id:8840,x:32958,y:32635,varname:Offset,prsc:2|IN-655-OUT;n:type:ShaderForge.SFN_Set,id:1026,x:31757,y:32747,varname:U,prsc:2|IN-6299-U;n:type:ShaderForge.SFN_Set,id:6132,x:31758,y:32797,varname:V,prsc:2|IN-6299-V;n:type:ShaderForge.SFN_Get,id:1635,x:32120,y:33015,varname:node_1635,prsc:2|IN-1026-OUT;n:type:ShaderForge.SFN_Add,id:1973,x:32392,y:33065,varname:node_1973,prsc:2|A-1635-OUT,B-4164-OUT;n:type:ShaderForge.SFN_Get,id:4164,x:32119,y:33117,varname:node_4164,prsc:2|IN-8840-OUT;n:type:ShaderForge.SFN_Append,id:8894,x:32675,y:33065,varname:node_8894,prsc:2|A-1973-OUT,B-6004-OUT;n:type:ShaderForge.SFN_Get,id:6004,x:32412,y:32975,varname:node_6004,prsc:2|IN-6132-OUT;n:type:ShaderForge.SFN_Get,id:7076,x:32119,y:33272,varname:node_7076,prsc:2|IN-6132-OUT;n:type:ShaderForge.SFN_Add,id:627,x:32391,y:33322,varname:node_627,prsc:2|A-7076-OUT,B-483-OUT;n:type:ShaderForge.SFN_Get,id:483,x:32118,y:33374,varname:node_483,prsc:2|IN-8840-OUT;n:type:ShaderForge.SFN_Append,id:8048,x:32673,y:33322,varname:node_8048,prsc:2|A-7360-OUT,B-627-OUT;n:type:ShaderForge.SFN_Get,id:7360,x:32410,y:33233,varname:node_7360,prsc:2|IN-1026-OUT;n:type:ShaderForge.SFN_SceneColor,id:873,x:32845,y:33072,varname:node_873,prsc:2|UVIN-8894-OUT;n:type:ShaderForge.SFN_Add,id:1075,x:33259,y:33139,varname:node_1075,prsc:2|A-5899-RGB,B-873-RGB,C-4848-RGB,D-5416-RGB,E-450-OUT;n:type:ShaderForge.SFN_Divide,id:2787,x:33463,y:33137,varname:node_2787,prsc:2|A-1075-OUT,B-1001-OUT;n:type:ShaderForge.SFN_Vector1,id:1001,x:33470,y:33330,varname:node_1001,prsc:2,v1:9;n:type:ShaderForge.SFN_SceneColor,id:5416,x:32856,y:33559,varname:node_5416,prsc:2|UVIN-2327-OUT;n:type:ShaderForge.SFN_Get,id:8271,x:32124,y:33510,varname:node_8271,prsc:2|IN-6132-OUT;n:type:ShaderForge.SFN_Get,id:1589,x:32065,y:33614,varname:node_1589,prsc:2|IN-8840-OUT;n:type:ShaderForge.SFN_Append,id:2327,x:32678,y:33560,varname:node_2327,prsc:2|A-688-OUT,B-4713-OUT;n:type:ShaderForge.SFN_Get,id:688,x:32415,y:33471,varname:node_688,prsc:2|IN-1026-OUT;n:type:ShaderForge.SFN_SceneColor,id:5899,x:32834,y:32935,varname:node_5899,prsc:2|UVIN-470-OUT;n:type:ShaderForge.SFN_Get,id:470,x:32632,y:32919,varname:node_470,prsc:2|IN-1457-OUT;n:type:ShaderForge.SFN_Subtract,id:4713,x:32424,y:33563,varname:node_4713,prsc:2|A-8271-OUT,B-1589-OUT;n:type:ShaderForge.SFN_SceneColor,id:6988,x:32846,y:33807,varname:node_6988,prsc:2|UVIN-8664-OUT;n:type:ShaderForge.SFN_Get,id:5593,x:32114,y:33758,varname:node_5593,prsc:2|IN-1026-OUT;n:type:ShaderForge.SFN_Get,id:7370,x:32055,y:33862,varname:node_7370,prsc:2|IN-8840-OUT;n:type:ShaderForge.SFN_Append,id:8664,x:32668,y:33808,varname:node_8664,prsc:2|A-1618-OUT,B-6058-OUT;n:type:ShaderForge.SFN_Get,id:6058,x:32405,y:33719,varname:node_6058,prsc:2|IN-6132-OUT;n:type:ShaderForge.SFN_Subtract,id:1618,x:32414,y:33811,varname:node_1618,prsc:2|A-5593-OUT,B-7370-OUT;n:type:ShaderForge.SFN_Add,id:3054,x:32665,y:33962,varname:node_3054,prsc:2|A-2955-OUT,B-7234-OUT;n:type:ShaderForge.SFN_Get,id:2955,x:32443,y:33996,varname:node_2955,prsc:2|IN-1457-OUT;n:type:ShaderForge.SFN_Get,id:7234,x:32438,y:34075,varname:node_7234,prsc:2|IN-8840-OUT;n:type:ShaderForge.SFN_SceneColor,id:3832,x:32844,y:33963,varname:node_3832,prsc:2|UVIN-3054-OUT;n:type:ShaderForge.SFN_Get,id:5651,x:32443,y:34160,varname:node_5651,prsc:2|IN-1457-OUT;n:type:ShaderForge.SFN_Get,id:1143,x:32437,y:34239,varname:node_1143,prsc:2|IN-8840-OUT;n:type:ShaderForge.SFN_SceneColor,id:425,x:32843,y:34127,varname:node_425,prsc:2|UVIN-495-OUT;n:type:ShaderForge.SFN_Subtract,id:495,x:32689,y:34122,varname:node_495,prsc:2|A-5651-OUT,B-1143-OUT;n:type:ShaderForge.SFN_Add,id:450,x:33373,y:34095,varname:node_450,prsc:2|A-6988-RGB,B-3832-RGB,C-425-RGB,D-1842-RGB,E-2126-RGB;n:type:ShaderForge.SFN_Get,id:6682,x:32423,y:34415,varname:node_6682,prsc:2|IN-1026-OUT;n:type:ShaderForge.SFN_Get,id:998,x:32415,y:34486,varname:node_998,prsc:2|IN-6132-OUT;n:type:ShaderForge.SFN_Get,id:53,x:32440,y:34346,varname:node_53,prsc:2|IN-8840-OUT;n:type:ShaderForge.SFN_Add,id:5474,x:32672,y:34380,varname:node_5474,prsc:2|A-6682-OUT,B-53-OUT;n:type:ShaderForge.SFN_Subtract,id:8755,x:32676,y:34515,varname:node_8755,prsc:2|A-998-OUT,B-53-OUT;n:type:ShaderForge.SFN_Append,id:7912,x:32904,y:34438,varname:node_7912,prsc:2|A-5474-OUT,B-8755-OUT;n:type:ShaderForge.SFN_SceneColor,id:1842,x:33121,y:34437,varname:node_1842,prsc:2|UVIN-7912-OUT;n:type:ShaderForge.SFN_Add,id:2610,x:32704,y:34663,varname:node_2610,prsc:2|A-998-OUT,B-53-OUT;n:type:ShaderForge.SFN_Subtract,id:4295,x:32714,y:34794,varname:node_4295,prsc:2|A-6682-OUT,B-53-OUT;n:type:ShaderForge.SFN_Append,id:904,x:32926,y:34736,varname:node_904,prsc:2|A-4295-OUT,B-2610-OUT;n:type:ShaderForge.SFN_SceneColor,id:2126,x:33121,y:34696,varname:node_2126,prsc:2|UVIN-904-OUT;proporder:655;pass:END;sub:END;*/

Shader "Shader Forge/S_blur" {
    Properties {
        _Offset ("Offset", Range(0, 0.05)) = 0
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform float _Offset;
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 projPos : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
////// Lighting:
                float2 screenPos = sceneUVs.rg;
                float U = sceneUVs.r;
                float Offset = _Offset;
                float V = sceneUVs.g;
                float node_6682 = U;
                float node_53 = Offset;
                float node_998 = V;
                float3 finalColor = ((tex2D( _GrabTexture, screenPos).rgb+tex2D( _GrabTexture, float2((U+Offset),V)).rgb+tex2D( _GrabTexture, float2(U,(V+Offset))).rgb+tex2D( _GrabTexture, float2(U,(V-Offset))).rgb+(tex2D( _GrabTexture, float2((U-Offset),V)).rgb+tex2D( _GrabTexture, (screenPos+Offset)).rgb+tex2D( _GrabTexture, (screenPos-Offset)).rgb+tex2D( _GrabTexture, float2((node_6682+node_53),(node_998-node_53))).rgb+tex2D( _GrabTexture, float2((node_6682-node_53),(node_998+node_53))).rgb))/9.0);
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

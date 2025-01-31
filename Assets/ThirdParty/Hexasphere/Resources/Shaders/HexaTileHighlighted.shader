﻿Shader "Hexasphere/HexaTileHighlight" {
    Properties {
        _Color ("Main Color", Color) = (0,0.25,1,0.8)
        _Color2 ("Second Color", Color) = (0,0.25,1,0.2)
        _ColorShift("Color Shift", Float) = 0
        _MainTex ("Main Texture (RGBA)", 2D) = "white"
        
    }


        SubShader{
                Tags { "Queue" = "Transparent" "RenderType" = "Transparent" "RenderPipeline" = "UniversalPipeline" }
                Blend SrcAlpha OneMinusSrcAlpha
                Pass {

                 CGPROGRAM
                 #pragma vertex vert
                 #pragma fragment frag
                 #pragma fragmentoption ARB_precision_hint_fastest
                 #include "UnityCG.cginc"

                 sampler2D _MainTex;
                 half4 _Color, _Color2;
                 half _ColorShift;

                 struct appdata {
                     float4 vertex : POSITION;
                     float2 texcoord : TEXCOORD0;
                     UNITY_VERTEX_INPUT_INSTANCE_ID
                 };

                 struct v2f {
                     float4 pos : SV_POSITION;
                     float2 uv: TEXCOORD0;
                     half4 color : COLOR;
                     UNITY_VERTEX_OUTPUT_STEREO
                 };

                 v2f vert(appdata v) {
                     v2f o;
                UNITY_SETUP_INSTANCE_ID(v);
                UNITY_INITIALIZE_OUTPUT(v2f, o);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);

                     o.pos = UnityObjectToClipPos(v.vertex);
                     o.uv = v.texcoord;
                     o.color = lerp(_Color, _Color2, _ColorShift);
                     return o;
                 }

                 half4 frag(v2f i) : SV_Target {
                    half4 color = tex2D(_MainTex, i.uv);
                    if (color.a < 0.001) color = 1.0;
                    return color;
                 }
                 ENDCG
           }
    }



   SubShader {
        Tags { "Queue"="Transparent" "RenderType"="Transparent" }
        Blend SrcAlpha OneMinusSrcAlpha
        Pass {
                CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag
				#pragma fragmentoption ARB_precision_hint_fastest
				#include "UnityCG.cginc"

                sampler2D _MainTex;
                half4 _Color, _Color2;
                half _ColorShift;

                struct appdata {
    				float4 vertex : POSITION;
					float2 texcoord : TEXCOORD0;
                    UNITY_VERTEX_INPUT_INSTANCE_ID
    			};

				struct v2f {
	    			float4 pos : SV_POSITION;
	    			float2 uv: TEXCOORD0;
	    			half4 color: COLOR;
                    UNITY_VERTEX_OUTPUT_STEREO
				};

				v2f vert(appdata v) {
    				v2f o;
                UNITY_SETUP_INSTANCE_ID(v);
                UNITY_INITIALIZE_OUTPUT(v2f, o);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);

    				o.pos = UnityObjectToClipPos(v.vertex);
    				o.uv = v.texcoord;
    				o.color = lerp(_Color, _Color2, _ColorShift);
    				return o;
    			}

    			half4 frag (v2f i) : SV_Target {
                    half4 color = tex2D(_MainTex, i.uv);
                    if (color.a < 0.001) color = 1.0;
                    return i.color * color;
                }
                ENDCG
          }
    }


}

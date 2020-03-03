Shader "Custom/ColorSwap" {
	Properties
	{
	   _BlockSize("BlockSize",Float) = 10
	}
		SubShader
	{
		Tags {
		"Queue" = "Transparent"
		"RenderType" = "Opaque" }
		LOD 200
		//Blend SrcAlpha OneMinusSrcAlpha
		GrabPass{}

		Pass{

		//Cull Off

		CGPROGRAM
#pragma vertex vert
#pragma fragment frag
#include "UnityCG.cginc"

		sampler2D _GrabTexture;

	float _BlockSize;

	struct appdata {
		float4 vertex : POSITION;
	};

	struct v2f {
		float4 grabPos :TEXCOOD0;
			float4 pos : SV_POSITION;
	};

	v2f vert(appdata v) {

		v2f o;
		o.pos = UnityObjectToClipPos(v.vertex);
		o.grabPos = ComputeGrabScreenPos(o.pos);
		return o;
	}

	fixed4 frag(v2f i) : SV_Target
	{

		fixed4 col = tex2D(_GrabTexture, i.grabPos);
		//float4 col = tex2D(_GrabTexture, float4(1.5, 2, 0,0));
		col =1-col;
		return col;

		}
			ENDCG
	}


	}
		FallBack "Diffuse"
}

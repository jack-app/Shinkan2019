Shader "Custom/GUNYAGUNYA" {
	Properties
	{
	   _WaveSize("WaveSize",Float) = 1
		_WaveWidth("WaveWidth",Float) = 1
		_WaveSpeed("WaveSpeed",Float) = 1

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

		float _WaveSize;
		float _WaveWidth;
		float _WaveSpeed;

		sampler2D _GrabTexture;


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

		i.grabPos.y += sin(i.grabPos.x*_WaveWidth+_Time*_WaveSpeed)*sin( i.grabPos.y*10 ) *_WaveSize;

		fixed4 col = tex2D(_GrabTexture, i.grabPos);
	return col;

	}
		ENDCG
}


	}
		FallBack "Diffuse"
}

public static class EaseBouncePMO
{
    public static float ZestOut( float t, float d )
    {
        return EaseOut( t, 0, 1, d );
    }

	public static float EaseOut( float t, float b, float c, float d )
	{
		float bounce = 2.75f;
		if( ( t /= d ) < ( 1 / bounce ) )
		{
			return c * ( 7.5625f * t * t ) + b;
		}
		else if( t < ( 2 / bounce ) )
		{
//			return c * ( 7.5625f * ( t -= ( 1.5f / bounce ) ) * t + .75f ) + b;

			t -= 1.5f / bounce;
			return c * ( 7.5625f * t * t + 0.75f ) + b;
		}
		else if( t < ( 2.5 / bounce ) )
		{
//			return c * ( 7.5625f * ( t -= ( 2.25f / bounce ) ) * t + .9375f ) + b;

			t -= 2.25f / bounce;
			return c * ( 7.5625f * t * t + 0.9375f ) + b;
		}
		else
		{
//			return c * ( 7.5625f * ( t -= ( 2.625f / bounce ) ) * t + .984375f ) + b;

			t -= 2.625f / bounce;
			return c * ( 7.5625f * t * t + 0.984375f ) + b;
		}

//		PMO's Original Stuff:
//		float bounce = 2.75f;
//		
//		if (t < 1 / bounce) {
//			return 7.5625f * t * t;
//		}
//		else if (t < 2 / bounce) {
//			t -= 1.5f / bounce;
//			return 7.5625f * t * t + 0.75f;
//		}
//		else if (t < 2.5 / bounce) {
//			t -= 2.25f / bounce;
//			//return 7.5625f * t * t + 0.75f;
//			return 7.5625f * t * t + 0.9375f;
//		}
//		
//		t -= 2.625f / bounce;
//		return 7.5625f * t * t + 0.984375f;
	}
}

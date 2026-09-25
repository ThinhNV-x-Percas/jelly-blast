using UnityEngine;

// Normalized (0..1) variant of the public-domain UnityEasingFunctions by Cristian Mihai.
public static class EasingFunction
{
    public enum Ease
    {
        EaseInQuad = 0,
        EaseOutQuad = 1,
        EaseInOutQuad = 2,
        EaseInCubic = 3,
        EaseOutCubic = 4,
        EaseInOutCubic = 5,
        EaseInQuart = 6,
        EaseOutQuart = 7,
        EaseInOutQuart = 8,
        EaseInQuint = 9,
        EaseOutQuint = 10,
        EaseInOutQuint = 11,
        EaseInSine = 12,
        EaseOutSine = 13,
        EaseInOutSine = 14,
        EaseInExpo = 15,
        EaseOutExpo = 16,
        EaseInOutExpo = 17,
        EaseInCirc = 18,
        EaseOutCirc = 19,
        EaseInOutCirc = 20,
        Linear = 21,
        Spring = 22,
        EaseInBounce = 23,
        EaseOutBounce = 24,
        EaseInOutBounce = 25,
        EaseInBack = 26,
        EaseOutBack = 27,
        EaseInOutBack = 28,
        EaseInElastic = 29,
        EaseOutElastic = 30,
        EaseInOutElastic = 31
    }

    public delegate float Function(float t);

    private const float NATURAL_LOG_OF_2 = 0.6931472f;

    private const float TWO_PI = Mathf.PI * 2f;
    private const float HALF_PI = Mathf.PI / 2f;

    // Back overshoot (s) and the in-out variant (s * 1.525).
    private const float BACK_S = 1.70158f;
    private const float BACK_S_IN_OUT = 2.5949094f;

    // Elastic period p and phase s = p / 4.
    private const float ELASTIC_P = 0.3f;
    private const float ELASTIC_S = 0.075f;

    //
    // Easing functions
    //

    public static float Linear(float t)
    {
        return t;
    }

    public static float Spring(float t)
    {
        t = Mathf.Clamp01(t);
        float x = Mathf.PI * t * (0.2f + 2.5f * t * t * t);
        return (Mathf.Sin(x) * Mathf.Pow(1f - t, 2.2f) + t) * (1f + 1.2f * (1f - t));
    }

    public static float EaseInQuad(float t)
    {
        return t * t;
    }

    public static float EaseOutQuad(float t)
    {
        return -t * (t - 2f);
    }

    public static float EaseInOutQuad(float t)
    {
        t *= 2f;
        if (t < 1f)
            return 0.5f * t * t;
        t -= 1f;
        return -0.5f * (t * (t - 2f) - 1f);
    }

    public static float EaseInCubic(float t)
    {
        return t * t * t;
    }

    public static float EaseOutCubic(float t)
    {
        t -= 1f;
        return t * t * t + 1f;
    }

    public static float EaseInOutCubic(float t)
    {
        t *= 2f;
        if (t < 1f)
            return 0.5f * t * t * t;
        t -= 2f;
        return 0.5f * (t * t * t + 2f);
    }

    public static float EaseInQuart(float t)
    {
        return t * t * t * t;
    }

    public static float EaseOutQuart(float t)
    {
        t -= 1f;
        return -(t * t * t * t - 1f);
    }

    public static float EaseInOutQuart(float t)
    {
        t *= 2f;
        if (t < 1f)
            return 0.5f * t * t * t * t;
        t -= 2f;
        return -0.5f * (t * t * t * t - 2f);
    }

    public static float EaseInQuint(float t)
    {
        return t * t * t * t * t;
    }

    public static float EaseOutQuint(float t)
    {
        t -= 1f;
        return t * t * t * t * t + 1f;
    }

    public static float EaseInOutQuint(float t)
    {
        t *= 2f;
        if (t < 1f)
            return 0.5f * t * t * t * t * t;
        t -= 2f;
        return 0.5f * (t * t * t * t * t + 2f);
    }

    public static float EaseInSine(float t)
    {
        return 1f - Mathf.Cos(t * HALF_PI);
    }

    public static float EaseOutSine(float t)
    {
        return Mathf.Sin(t * HALF_PI);
    }

    public static float EaseInOutSine(float t)
    {
        return -0.5f * (Mathf.Cos(Mathf.PI * t) - 1f);
    }

    public static float EaseInExpo(float t)
    {
        return Mathf.Pow(2f, 10f * (t - 1f));
    }

    public static float EaseOutExpo(float t)
    {
        return 1f - Mathf.Pow(2f, -10f * t);
    }

    public static float EaseInOutExpo(float t)
    {
        t *= 2f;
        if (t < 1f)
            return 0.5f * Mathf.Pow(2f, 10f * (t - 1f));
        t -= 1f;
        return 0.5f * (2f - Mathf.Pow(2f, -10f * t));
    }

    public static float EaseInCirc(float t)
    {
        return 1f - Mathf.Sqrt(1f - t * t);
    }

    public static float EaseOutCirc(float t)
    {
        t -= 1f;
        return Mathf.Sqrt(1f - t * t);
    }

    public static float EaseInOutCirc(float t)
    {
        t *= 2f;
        if (t < 1f)
            return -0.5f * (Mathf.Sqrt(1f - t * t) - 1f);
        t -= 2f;
        return 0.5f * (Mathf.Sqrt(1f - t * t) + 1f);
    }

    public static float EaseOutBounce(float t)
    {
        if (t < 1f / 2.75f)
            return 7.5625f * t * t;
        if (t < 2f / 2.75f)
        {
            t -= 1.5f / 2.75f;
            return 7.5625f * t * t + 0.75f;
        }
        if (t < 2.5f / 2.75f)
        {
            t -= 2.25f / 2.75f;
            return 7.5625f * t * t + 0.9375f;
        }
        t -= 2.625f / 2.75f;
        return 7.5625f * t * t + 0.984375f;
    }

    public static float EaseInBounce(float t)
    {
        return 1f - EaseOutBounce(1f - t);
    }

    public static float EaseInOutBounce(float t)
    {
        if (t < 0.5f)
            return EaseInBounce(t * 2f) * 0.5f;
        return EaseOutBounce(t * 2f - 1f) * 0.5f + 0.5f;
    }

    // Note: the shipped build uses t^3 here (not the usual t^2), so EaseInBackD below
    // is not its exact derivative. Kept as shipped because it defines the feel.
    public static float EaseInBack(float t)
    {
        return t * t * t * ((BACK_S + 1f) * t - BACK_S);
    }

    public static float EaseOutBack(float t)
    {
        t -= 1f;
        return t * t * t * ((BACK_S + 1f) * t + BACK_S) + 1f;
    }

    public static float EaseInOutBack(float t)
    {
        t *= 2f;
        if (t < 1f)
            return 0.5f * (t * t * t * ((BACK_S_IN_OUT + 1f) * t - BACK_S_IN_OUT));
        t -= 2f;
        return 0.5f * (t * t * t * ((BACK_S_IN_OUT + 1f) * t + BACK_S_IN_OUT) + 2f);
    }

    public static float EaseInElastic(float t)
    {
        if (t == 0f)
            return 0f;
        if (t == 1f)
            return 1f;
        t -= 1f;
        return -(Mathf.Pow(2f, 10f * t) * Mathf.Sin((t - ELASTIC_S) * TWO_PI / ELASTIC_P));
    }

    public static float EaseOutElastic(float t)
    {
        if (t == 0f)
            return 0f;
        if (t == 1f)
            return 1f;
        return Mathf.Pow(2f, -10f * t) * Mathf.Sin((t - ELASTIC_S) * TWO_PI / ELASTIC_P) + 1f;
    }

    public static float EaseOutElastic(float t, float overshoot = 1f, float period = 0.3f)
    {
        if (t == 0f)
            return 0f;
        if (t == 1f)
            return 1f;

        float amplitude;
        float phase;
        if (overshoot < 1f)
        {
            amplitude = 1f;
            phase = period * 0.25f;
        }
        else
        {
            amplitude = overshoot;
            phase = period / TWO_PI * Mathf.Asin(1f / overshoot);
        }
        return amplitude * Mathf.Pow(2f, -10f * t) * Mathf.Sin((t - phase) * TWO_PI / period) + 1f;
    }

    // Parabola through (0,0) and (1,1) that peaks at 1 + overshoot.
    public static float EaseParabolaOvershoot(float t, float overshoot = 0.2f)
    {
        if (t <= 0f)
            return 0f;
        if (t >= 1f)
            return 1f;
        if (overshoot <= 0f)
            return 1f;

        float peak = overshoot + 1f;
        float r = peak - Mathf.Sqrt(peak * (peak - 1f));
        float a = (peak + peak) / r;
        float b = peak / (r * r);
        return a * t - b * t * t;
    }

    public static float EaseInOutElastic(float t)
    {
        if (t == 0f)
            return 0f;
        if (t == 1f)
            return 1f;
        t *= 2f;
        float u = t - 1f;
        float wave = Mathf.Sin((u - ELASTIC_S) * TWO_PI / ELASTIC_P);
        if (t < 1f)
            return -0.5f * (Mathf.Pow(2f, 10f * u) * wave);
        return Mathf.Pow(2f, -10f * u) * wave * 0.5f + 1f;
    }

    //
    // Derivatives
    //

    public static float LinearD(float t)
    {
        return 1f;
    }

    public static float EaseInQuadD(float t)
    {
        return 2f * t;
    }

    public static float EaseOutQuadD(float t)
    {
        return 2f - 2f * t;
    }

    public static float EaseInOutQuadD(float t)
    {
        t *= 2f;
        if (t < 1f)
            return t;
        t -= 1f;
        return 1f - t;
    }

    public static float EaseInCubicD(float t)
    {
        return 3f * t * t;
    }

    public static float EaseOutCubicD(float t)
    {
        t -= 1f;
        return 3f * t * t;
    }

    // The shipped in-out derivatives shift the second half by 1 (not 2); kept as shipped.
    public static float EaseInOutCubicD(float t)
    {
        t *= 2f;
        if (t >= 1f)
            t -= 1f;
        return 1.5f * t * t;
    }

    public static float EaseInQuartD(float t)
    {
        return 4f * t * t * t;
    }

    public static float EaseOutQuartD(float t)
    {
        t -= 1f;
        return -4f * t * t * t;
    }

    public static float EaseInOutQuartD(float t)
    {
        t *= 2f;
        if (t < 1f)
            return 2f * t * t * t;
        t -= 1f;
        return -2f * t * t * t;
    }

    public static float EaseInQuintD(float t)
    {
        return 5f * t * t * t * t;
    }

    public static float EaseOutQuintD(float t)
    {
        t -= 1f;
        return 5f * t * t * t * t;
    }

    public static float EaseInOutQuintD(float t)
    {
        t *= 2f;
        if (t >= 1f)
            t -= 1f;
        return 2.5f * t * t * t * t;
    }

    public static float EaseInSineD(float t)
    {
        return Mathf.Sin(t * HALF_PI) * HALF_PI;
    }

    public static float EaseOutSineD(float t)
    {
        return Mathf.Cos(t * HALF_PI) * HALF_PI;
    }

    public static float EaseInOutSineD(float t)
    {
        return Mathf.Sin(Mathf.PI * t) * HALF_PI;
    }

    public static float EaseInExpoD(float t)
    {
        return Mathf.Pow(2f, 10f * (t - 1f)) * (NATURAL_LOG_OF_2 * 10f);
    }

    public static float EaseOutExpoD(float t)
    {
        return Mathf.Pow(2f, -10f * t) * (NATURAL_LOG_OF_2 * 10f);
    }

    public static float EaseInOutExpoD(float t)
    {
        t *= 2f;
        float pow = Mathf.Pow(2f, 10f * (t - 1f));
        if (t < 1f)
            return pow * (NATURAL_LOG_OF_2 * 5f);
        return NATURAL_LOG_OF_2 * 5f / pow;
    }

    public static float EaseInCircD(float t)
    {
        return t / Mathf.Sqrt(1f - t * t);
    }

    public static float EaseOutCircD(float t)
    {
        t -= 1f;
        return -t / Mathf.Sqrt(1f - t * t);
    }

    public static float EaseInOutCircD(float t)
    {
        t *= 2f;
        if (t < 1f)
            return t / (2f * Mathf.Sqrt(1f - t * t));
        t -= 1f;
        return -t / (2f * Mathf.Sqrt(1f - t * t));
    }

    public static float EaseInBounceD(float t)
    {
        return EaseOutBounceD(1f - t);
    }

    public static float EaseOutBounceD(float t)
    {
        if (t < 1f / 2.75f)
            return 2f * 7.5625f * t;
        if (t < 2f / 2.75f)
            t -= 1.5f / 2.75f;
        else if (t < 2.5f / 2.75f)
            t -= 2.25f / 2.75f;
        else
            t -= 2.625f / 2.75f;
        return 2f * 7.5625f * t;
    }

    public static float EaseInOutBounceD(float t)
    {
        if (t < 0.5f)
            return EaseInBounceD(t * 2f) * 0.5f;
        return EaseOutBounceD(t * 2f - 1f) * 0.5f;
    }

    public static float EaseInBackD(float t)
    {
        return 3f * (BACK_S + 1f) * t * t - 2f * BACK_S * t;
    }

    public static float EaseOutBackD(float t)
    {
        t -= 1f;
        return 2f * BACK_S * t + 3f * (BACK_S + 1f) * t * t;
    }

    public static float EaseInOutBackD(float t)
    {
        t *= 2f;
        if (t < 1f)
            return 0.5f * (3f * (BACK_S_IN_OUT + 1f) * t * t - 2f * BACK_S_IN_OUT * t);
        t -= 1f;
        return 0.5f * (2f * BACK_S_IN_OUT * t + 3f * (BACK_S_IN_OUT + 1f) * t * t);
    }

    public static float EaseInElasticD(float t)
    {
        return EaseOutElasticD(1f - t);
    }

    public static float EaseOutElasticD(float t)
    {
        return Mathf.Pow(2f, -10f * t) * TWO_PI * Mathf.Cos((t - ELASTIC_S) * TWO_PI / ELASTIC_P) / ELASTIC_P;
    }

    public static float EaseInOutElasticD(float t)
    {
        float u = t * 2f - 1f;
        float wave = Mathf.Cos((u - ELASTIC_S) * TWO_PI / ELASTIC_P);
        if (t < 0.5f)
            return Mathf.Pow(2f, 10f * u) * TWO_PI * wave * -0.5f;
        return Mathf.Pow(2f, -10f * u) * TWO_PI * wave * 0.5f;
    }

    public static float SpringD(float t)
    {
        t = Mathf.Clamp01(t);
        float u = 1f - t;
        float b = 2.5f * t * t * t + 0.2f;
        float x = Mathf.PI * t * b;
        float sin = Mathf.Sin(x);
        float cos = Mathf.Cos(x);
        float dx = Mathf.PI * b + 7.5f * Mathf.PI * t * t * t;
        return (1.2f * u + 1f) * (-2.2f * Mathf.Pow(u, 1.2f) * sin + Mathf.Pow(u, 2.2f) * dx * cos + 1f)
            - 1.2f * (Mathf.Pow(u, 2.2f) * sin + t * 0.2f);
    }

    public static Function GetEasingFunction(Ease easingFunction)
    {
        switch (easingFunction)
        {
            case Ease.EaseInQuad: return EaseInQuad;
            case Ease.EaseOutQuad: return EaseOutQuad;
            case Ease.EaseInOutQuad: return EaseInOutQuad;
            case Ease.EaseInCubic: return EaseInCubic;
            case Ease.EaseOutCubic: return EaseOutCubic;
            case Ease.EaseInOutCubic: return EaseInOutCubic;
            case Ease.EaseInQuart: return EaseInQuart;
            case Ease.EaseOutQuart: return EaseOutQuart;
            case Ease.EaseInOutQuart: return EaseInOutQuart;
            case Ease.EaseInQuint: return EaseInQuint;
            case Ease.EaseOutQuint: return EaseOutQuint;
            case Ease.EaseInOutQuint: return EaseInOutQuint;
            case Ease.EaseInSine: return EaseInSine;
            case Ease.EaseOutSine: return EaseOutSine;
            case Ease.EaseInOutSine: return EaseInOutSine;
            case Ease.EaseInExpo: return EaseInExpo;
            case Ease.EaseOutExpo: return EaseOutExpo;
            case Ease.EaseInOutExpo: return EaseInOutExpo;
            case Ease.EaseInCirc: return EaseInCirc;
            case Ease.EaseOutCirc: return EaseOutCirc;
            case Ease.EaseInOutCirc: return EaseInOutCirc;
            case Ease.Linear: return Linear;
            case Ease.Spring: return Spring;
            case Ease.EaseInBounce: return EaseInBounce;
            case Ease.EaseOutBounce: return EaseOutBounce;
            case Ease.EaseInOutBounce: return EaseInOutBounce;
            case Ease.EaseInBack: return EaseInBack;
            case Ease.EaseOutBack: return EaseOutBack;
            case Ease.EaseInOutBack: return EaseInOutBack;
            case Ease.EaseInElastic: return EaseInElastic;
            case Ease.EaseOutElastic: return EaseOutElastic;
            case Ease.EaseInOutElastic: return EaseInOutElastic;
            default: return Linear;
        }
    }

    public static Function GetEasingFunctionDerivative(Ease easingFunction)
    {
        switch (easingFunction)
        {
            case Ease.EaseInQuad: return EaseInQuadD;
            case Ease.EaseOutQuad: return EaseOutQuadD;
            case Ease.EaseInOutQuad: return EaseInOutQuadD;
            case Ease.EaseInCubic: return EaseInCubicD;
            case Ease.EaseOutCubic: return EaseOutCubicD;
            case Ease.EaseInOutCubic: return EaseInOutCubicD;
            case Ease.EaseInQuart: return EaseInQuartD;
            case Ease.EaseOutQuart: return EaseOutQuartD;
            case Ease.EaseInOutQuart: return EaseInOutQuartD;
            case Ease.EaseInQuint: return EaseInQuintD;
            case Ease.EaseOutQuint: return EaseOutQuintD;
            case Ease.EaseInOutQuint: return EaseInOutQuintD;
            case Ease.EaseInSine: return EaseInSineD;
            case Ease.EaseOutSine: return EaseOutSineD;
            case Ease.EaseInOutSine: return EaseInOutSineD;
            case Ease.EaseInExpo: return EaseInExpoD;
            case Ease.EaseOutExpo: return EaseOutExpoD;
            case Ease.EaseInOutExpo: return EaseInOutExpoD;
            case Ease.EaseInCirc: return EaseInCircD;
            case Ease.EaseOutCirc: return EaseOutCircD;
            case Ease.EaseInOutCirc: return EaseInOutCircD;
            case Ease.Linear: return LinearD;
            case Ease.Spring: return SpringD;
            case Ease.EaseInBounce: return EaseInBounceD;
            case Ease.EaseOutBounce: return EaseOutBounceD;
            case Ease.EaseInOutBounce: return EaseInOutBounceD;
            case Ease.EaseInBack: return EaseInBackD;
            case Ease.EaseOutBack: return EaseOutBackD;
            case Ease.EaseInOutBack: return EaseInOutBackD;
            case Ease.EaseInElastic: return EaseInElasticD;
            case Ease.EaseOutElastic: return EaseOutElasticD;
            case Ease.EaseInOutElastic: return EaseInOutElasticD;
            default: return LinearD;
        }
    }
}

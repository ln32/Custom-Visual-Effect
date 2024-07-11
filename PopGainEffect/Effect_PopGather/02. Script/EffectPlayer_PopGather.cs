using System.Collections;
using UnityEngine;

public class EffectPlayer_PopGather : MonoBehaviour
{
    public GameObject particleObj;
    public float totalTime;
    public float coef;

    public void PlayEffect_byV3(Vector3 _srcV3, Vector3 _dstV3)
    {
        StartCoroutine(moveBlockTime());

        IEnumerator moveBlockTime()
        {
            ParticleSystem particle = Instantiate(particleObj, transform).GetComponent<ParticleSystem>();

            float lifeTime = totalTime;
            Transform movObj = particle.transform;
            movObj.position = _srcV3;

            var _particleMain = particle.main;
            _particleMain.startLifetime = totalTime;

            float elapsedTime = 0.0f;
            if (!particle.isPlaying)
                particle.Play();

            while (true)
            {
                if (elapsedTime > lifeTime) break;

                movObj.position = Vector3.Lerp(_srcV3, _dstV3, Mathf.Pow((elapsedTime / lifeTime), coef));
                elapsedTime += Time.deltaTime;

                yield return null;
            }
            yield return new WaitForSeconds(0.2f);
            movObj.position = _dstV3;

            Destroy(particle.gameObject);
        }
    }
}

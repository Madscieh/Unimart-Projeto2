using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstro : MonoBehaviour
{
    public Animator anim;

    public int saudeMax = 100;
    int saudeAtual;

    // Start is called before the first frame update
    void Start()
    {
        saudeAtual = saudeMax;
    }

    public void LevaDano (int dano)
    {
        saudeAtual -= dano;

        // anim.SetTrigger("Ferido");

        if (saudeAtual <= 0)
        {
            Desmaio();
        }
    }

    void Desmaio()
    {
        anim.SetBool("Desmaio", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

        Desaparece();
    }

    void Desaparece()
    {
        Destroy(gameObject, 0.4f);
    }
}

/*
    public void UpdateAnimClipTimes()
    {
        AnimationClip[] clips = anim.runtimeAnimatorController.animationClips;
        foreach(AnimationClip clip in clips)
        {
            switch(clip.name)
            {
                case "Attacking":
                    attackTime = clip.length;
                    break;
                case "Damage":
                    damageTime = clip.length;
                    break;
                case "Dead":
                    deathTime = clip.length;
                    break;
                case "Idle":
                    idleTime = clip.length;
                    break;
            }
        }
    }
*/

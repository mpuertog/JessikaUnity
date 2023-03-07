using Platformer.Core;
using Platformer.Mechanics;
using UnityEngine;
namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the player performs a Jump.
    /// </summary>
    /// <typeparam name="PlayerJumped"></typeparam>
    public class PlayerJumped : Simulation.Event<PlayerJumped>
    {
        public PlayerController player;
	
        public override void Execute()
        {
      	    AudioClip[] audioClips = {player.jumpAudio,player.jumpAudio2,player.jumpAudio3};
      	    AudioClip selectedAudio = audioClips[Random.Range(0, audioClips.Length)];
            if (player.audioSource && selectedAudio)
                player.audioSource.PlayOneShot(selectedAudio);
        }
    }
}

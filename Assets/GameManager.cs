using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DIPProject
{
    public class GameManager : MonoBehaviourPunCallbacks
    {
        #region MonoBehavior Callbacks
        // Start is called before the first frame update
        void Start()
        {

        }


        // Update is called once per frame
        void Update()
        {

        }

        #endregion

        #region MonoBehaviorPunCallbacks Callbacks
        /// <summary>
        /// Once the player joins the room, we instantiate it in the middle with some height
        /// </summary>
        public override void OnJoinedRoom()
        {
            PhotonNetwork.Instantiate("Player", new Vector3(0, 1, 0), Quaternion.identity);
            base.OnJoinedRoom();
        }
        #endregion
    }
}
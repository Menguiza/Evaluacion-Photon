using Photon.Pun;

public class Player : MonoBehaviourPun, IPunInstantiateMagicCallback
{
    private PhotonView _photonView;
    public void OnPhotonInstantiate(PhotonMessageInfo info)
    {
        _photonView = GetComponent<PhotonView>();
        if (_photonView.IsMine)
        {
            _photonView.RPC("MisionRPC", RpcTarget.MasterClient);
            print("Se envia el RPC");
        }
    }
}

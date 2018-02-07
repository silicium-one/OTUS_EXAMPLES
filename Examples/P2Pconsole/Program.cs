using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer;
using System.Net.PeerToPeer.Collaboration;
using System.Text;

namespace P2Pconsole
{
    class Program
    {
        static void Main(string[] args)
        {
/*            PeerName pn = new PeerName("Peer classifier", PeerNameType.Unsecured);
            PeerNameRegistration pnr = new PeerNameRegistration(pn, 8080);
            pnr.Comment = "Комментарий";
            pnr.Cloud = Cloud.Available;
            pnr.Start();*/

            //PeerCollaboration.SignIn(PeerScope.Internet);
            var peers = PeerCollaboration.GetPeersNearMe();
            peers[0].AddToContactManager("displayName", "nickName", null);
            

            Console.ReadKey();

//            PeerName pn = new PeerName("0.Peer classifier");
            //PeerNameResolver pnres = new PeerNameResolver();
            //PeerNameRecordCollection pnrc = pnres.Resolve(pn, Cloud.AllLinkLocal, 5);
            //Console.ReadKey();
        }
    }
}

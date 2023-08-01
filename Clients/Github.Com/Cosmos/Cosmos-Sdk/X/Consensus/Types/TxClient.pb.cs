// Code generated by lxgr
using Cosmcs.Client;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;

namespace Cosmos.Consensus.V1 {
	
	public class MsgClient {
		public IClient Client { get; }

		public MsgClient (IClient client) {
			Client = client;
		}

		public Task<Cosmos.Base.Abci.V1beta1.TxResponse> SendMsgUpdateParams(Cosmos.Consensus.V1.MsgUpdateParams msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.consensus.v1.MsgUpdateParams"
				}
			).ContinueWith(r => Cosmos.Base.Abci.V1beta1.TxResponse.Parser.ParseJson(r.Result));
		}

	}
}

// Code generated by lxgr
using Cosmcs.Client;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;

namespace Cosmos.Gov.V1beta1 {
	
	public class MsgClient {
		public EasyClient EasyClient { get; }

		public MsgClient (EasyClient client) {
			EasyClient = client;
		}

		public Task<string> SendMsgSubmitProposal(Cosmos.Gov.V1beta1.MsgSubmitProposal msg) {
			return EasyClient.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.gov.v1beta1.MsgSubmitProposal"
				}
			);
		}

		public Task<string> SendMsgVote(Cosmos.Gov.V1beta1.MsgVote msg) {
			return EasyClient.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.gov.v1beta1.MsgVote"
				}
			);
		}

		public Task<string> SendMsgVoteWeighted(Cosmos.Gov.V1beta1.MsgVoteWeighted msg) {
			return EasyClient.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.gov.v1beta1.MsgVoteWeighted"
				}
			);
		}

		public Task<string> SendMsgDeposit(Cosmos.Gov.V1beta1.MsgDeposit msg) {
			return EasyClient.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.gov.v1beta1.MsgDeposit"
				}
			);
		}

	}
}

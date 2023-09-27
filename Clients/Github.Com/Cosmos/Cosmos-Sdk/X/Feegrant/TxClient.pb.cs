// <auto-generated>
//    Code generated by protoc-gen-cosmosCsharp plugin.  DO NOT EDIT!
//    The plugin is part of the DecentralCardgame project and written by lxgr@protonmail.com
// </auto-generated>

using Cosmcs.Client;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;

namespace Cosmos.Feegrant.V1beta1 {
	
	public class MsgClient {
		public IClient Client { get; }

		public MsgClient (IClient client) {
			Client = client;
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgGrantAllowanceResponse>> SendMsgGrantAllowance(Cosmos.Feegrant.V1beta1.MsgGrantAllowance msg) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.feegrant.v1beta1.MsgGrantAllowance"
				}}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgGrantAllowanceResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Feegrant.V1beta1.MsgGrantAllowanceResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgRevokeAllowanceResponse>> SendMsgRevokeAllowance(Cosmos.Feegrant.V1beta1.MsgRevokeAllowance msg) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.feegrant.v1beta1.MsgRevokeAllowance"
				}}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgRevokeAllowanceResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Feegrant.V1beta1.MsgRevokeAllowanceResponse.Parser
			));
		}

	}
}

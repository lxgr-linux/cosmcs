// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/gov/v1/genesis.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Gov.V1 {

  /// <summary>Holder for reflection information generated from cosmos/gov/v1/genesis.proto</summary>
  public static partial class GenesisReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/gov/v1/genesis.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GenesisReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chtjb3Ntb3MvZ292L3YxL2dlbmVzaXMucHJvdG8SDWNvc21vcy5nb3YudjEa",
            "F2Nvc21vcy9nb3YvdjEvZ292LnByb3RvItcDCgxHZW5lc2lzU3RhdGUSMAoU",
            "c3RhcnRpbmdfcHJvcG9zYWxfaWQYASABKARSEnN0YXJ0aW5nUHJvcG9zYWxJ",
            "ZBIyCghkZXBvc2l0cxgCIAMoCzIWLmNvc21vcy5nb3YudjEuRGVwb3NpdFII",
            "ZGVwb3NpdHMSKQoFdm90ZXMYAyADKAsyEy5jb3Ntb3MuZ292LnYxLlZvdGVS",
            "BXZvdGVzEjUKCXByb3Bvc2FscxgEIAMoCzIXLmNvc21vcy5nb3YudjEuUHJv",
            "cG9zYWxSCXByb3Bvc2FscxJHCg5kZXBvc2l0X3BhcmFtcxgFIAEoCzIcLmNv",
            "c21vcy5nb3YudjEuRGVwb3NpdFBhcmFtc0ICGAFSDWRlcG9zaXRQYXJhbXMS",
            "RAoNdm90aW5nX3BhcmFtcxgGIAEoCzIbLmNvc21vcy5nb3YudjEuVm90aW5n",
            "UGFyYW1zQgIYAVIMdm90aW5nUGFyYW1zEkEKDHRhbGx5X3BhcmFtcxgHIAEo",
            "CzIaLmNvc21vcy5nb3YudjEuVGFsbHlQYXJhbXNCAhgBUgt0YWxseVBhcmFt",
            "cxItCgZwYXJhbXMYCCABKAsyFS5jb3Ntb3MuZ292LnYxLlBhcmFtc1IGcGFy",
            "YW1zQqQBChFjb20uY29zbW9zLmdvdi52MUIMR2VuZXNpc1Byb3RvUAFaK2dp",
            "dGh1Yi5jb20vY29zbW9zL2Nvc21vcy1zZGsveC9nb3YvdHlwZXMvdjGiAgND",
            "R1iqAg1Db3Ntb3MuR292LlYxygINQ29zbW9zXEdvdlxWMeICGUNvc21vc1xH",
            "b3ZcVjFcR1BCTWV0YWRhdGHqAg9Db3Ntb3M6Okdvdjo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cosmos.Gov.V1.GovReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Gov.V1.GenesisState), global::Cosmos.Gov.V1.GenesisState.Parser, new[]{ "StartingProposalId", "Deposits", "Votes", "Proposals", "DepositParams", "VotingParams", "TallyParams", "Params" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// GenesisState defines the gov module's genesis state.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GenesisState : pb::IMessage<GenesisState>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GenesisState> _parser = new pb::MessageParser<GenesisState>(() => new GenesisState());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GenesisState> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Gov.V1.GenesisReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisState() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisState(GenesisState other) : this() {
      startingProposalId_ = other.startingProposalId_;
      deposits_ = other.deposits_.Clone();
      votes_ = other.votes_.Clone();
      proposals_ = other.proposals_.Clone();
      depositParams_ = other.depositParams_ != null ? other.depositParams_.Clone() : null;
      votingParams_ = other.votingParams_ != null ? other.votingParams_.Clone() : null;
      tallyParams_ = other.tallyParams_ != null ? other.tallyParams_.Clone() : null;
      params_ = other.params_ != null ? other.params_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisState Clone() {
      return new GenesisState(this);
    }

    /// <summary>Field number for the "starting_proposal_id" field.</summary>
    public const int StartingProposalIdFieldNumber = 1;
    private ulong startingProposalId_;
    /// <summary>
    /// starting_proposal_id is the ID of the starting proposal.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong StartingProposalId {
      get { return startingProposalId_; }
      set {
        startingProposalId_ = value;
      }
    }

    /// <summary>Field number for the "deposits" field.</summary>
    public const int DepositsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Cosmos.Gov.V1.Deposit> _repeated_deposits_codec
        = pb::FieldCodec.ForMessage(18, global::Cosmos.Gov.V1.Deposit.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Gov.V1.Deposit> deposits_ = new pbc::RepeatedField<global::Cosmos.Gov.V1.Deposit>();
    /// <summary>
    /// deposits defines all the deposits present at genesis.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Gov.V1.Deposit> Deposits {
      get { return deposits_; }
    }

    /// <summary>Field number for the "votes" field.</summary>
    public const int VotesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Cosmos.Gov.V1.Vote> _repeated_votes_codec
        = pb::FieldCodec.ForMessage(26, global::Cosmos.Gov.V1.Vote.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Gov.V1.Vote> votes_ = new pbc::RepeatedField<global::Cosmos.Gov.V1.Vote>();
    /// <summary>
    /// votes defines all the votes present at genesis.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Gov.V1.Vote> Votes {
      get { return votes_; }
    }

    /// <summary>Field number for the "proposals" field.</summary>
    public const int ProposalsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Cosmos.Gov.V1.Proposal> _repeated_proposals_codec
        = pb::FieldCodec.ForMessage(34, global::Cosmos.Gov.V1.Proposal.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Gov.V1.Proposal> proposals_ = new pbc::RepeatedField<global::Cosmos.Gov.V1.Proposal>();
    /// <summary>
    /// proposals defines all the proposals present at genesis.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Gov.V1.Proposal> Proposals {
      get { return proposals_; }
    }

    /// <summary>Field number for the "deposit_params" field.</summary>
    public const int DepositParamsFieldNumber = 5;
    private global::Cosmos.Gov.V1.DepositParams depositParams_;
    /// <summary>
    /// Deprecated: Prefer to use `params` instead.
    /// deposit_params defines all the paramaters of related to deposit.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cosmos.Gov.V1.DepositParams DepositParams {
      get { return depositParams_; }
      set {
        depositParams_ = value;
      }
    }

    /// <summary>Field number for the "voting_params" field.</summary>
    public const int VotingParamsFieldNumber = 6;
    private global::Cosmos.Gov.V1.VotingParams votingParams_;
    /// <summary>
    /// Deprecated: Prefer to use `params` instead.
    /// voting_params defines all the paramaters of related to voting.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cosmos.Gov.V1.VotingParams VotingParams {
      get { return votingParams_; }
      set {
        votingParams_ = value;
      }
    }

    /// <summary>Field number for the "tally_params" field.</summary>
    public const int TallyParamsFieldNumber = 7;
    private global::Cosmos.Gov.V1.TallyParams tallyParams_;
    /// <summary>
    /// Deprecated: Prefer to use `params` instead.
    /// tally_params defines all the paramaters of related to tally.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cosmos.Gov.V1.TallyParams TallyParams {
      get { return tallyParams_; }
      set {
        tallyParams_ = value;
      }
    }

    /// <summary>Field number for the "params" field.</summary>
    public const int ParamsFieldNumber = 8;
    private global::Cosmos.Gov.V1.Params params_;
    /// <summary>
    /// params defines all the paramaters of x/gov module.
    ///
    /// Since: cosmos-sdk 0.47
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cosmos.Gov.V1.Params Params {
      get { return params_; }
      set {
        params_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GenesisState);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GenesisState other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StartingProposalId != other.StartingProposalId) return false;
      if(!deposits_.Equals(other.deposits_)) return false;
      if(!votes_.Equals(other.votes_)) return false;
      if(!proposals_.Equals(other.proposals_)) return false;
      if (!object.Equals(DepositParams, other.DepositParams)) return false;
      if (!object.Equals(VotingParams, other.VotingParams)) return false;
      if (!object.Equals(TallyParams, other.TallyParams)) return false;
      if (!object.Equals(Params, other.Params)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StartingProposalId != 0UL) hash ^= StartingProposalId.GetHashCode();
      hash ^= deposits_.GetHashCode();
      hash ^= votes_.GetHashCode();
      hash ^= proposals_.GetHashCode();
      if (depositParams_ != null) hash ^= DepositParams.GetHashCode();
      if (votingParams_ != null) hash ^= VotingParams.GetHashCode();
      if (tallyParams_ != null) hash ^= TallyParams.GetHashCode();
      if (params_ != null) hash ^= Params.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (StartingProposalId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(StartingProposalId);
      }
      deposits_.WriteTo(output, _repeated_deposits_codec);
      votes_.WriteTo(output, _repeated_votes_codec);
      proposals_.WriteTo(output, _repeated_proposals_codec);
      if (depositParams_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(DepositParams);
      }
      if (votingParams_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(VotingParams);
      }
      if (tallyParams_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(TallyParams);
      }
      if (params_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Params);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (StartingProposalId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(StartingProposalId);
      }
      deposits_.WriteTo(ref output, _repeated_deposits_codec);
      votes_.WriteTo(ref output, _repeated_votes_codec);
      proposals_.WriteTo(ref output, _repeated_proposals_codec);
      if (depositParams_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(DepositParams);
      }
      if (votingParams_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(VotingParams);
      }
      if (tallyParams_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(TallyParams);
      }
      if (params_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Params);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (StartingProposalId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(StartingProposalId);
      }
      size += deposits_.CalculateSize(_repeated_deposits_codec);
      size += votes_.CalculateSize(_repeated_votes_codec);
      size += proposals_.CalculateSize(_repeated_proposals_codec);
      if (depositParams_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DepositParams);
      }
      if (votingParams_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VotingParams);
      }
      if (tallyParams_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TallyParams);
      }
      if (params_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Params);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GenesisState other) {
      if (other == null) {
        return;
      }
      if (other.StartingProposalId != 0UL) {
        StartingProposalId = other.StartingProposalId;
      }
      deposits_.Add(other.deposits_);
      votes_.Add(other.votes_);
      proposals_.Add(other.proposals_);
      if (other.depositParams_ != null) {
        if (depositParams_ == null) {
          DepositParams = new global::Cosmos.Gov.V1.DepositParams();
        }
        DepositParams.MergeFrom(other.DepositParams);
      }
      if (other.votingParams_ != null) {
        if (votingParams_ == null) {
          VotingParams = new global::Cosmos.Gov.V1.VotingParams();
        }
        VotingParams.MergeFrom(other.VotingParams);
      }
      if (other.tallyParams_ != null) {
        if (tallyParams_ == null) {
          TallyParams = new global::Cosmos.Gov.V1.TallyParams();
        }
        TallyParams.MergeFrom(other.TallyParams);
      }
      if (other.params_ != null) {
        if (params_ == null) {
          Params = new global::Cosmos.Gov.V1.Params();
        }
        Params.MergeFrom(other.Params);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            StartingProposalId = input.ReadUInt64();
            break;
          }
          case 18: {
            deposits_.AddEntriesFrom(input, _repeated_deposits_codec);
            break;
          }
          case 26: {
            votes_.AddEntriesFrom(input, _repeated_votes_codec);
            break;
          }
          case 34: {
            proposals_.AddEntriesFrom(input, _repeated_proposals_codec);
            break;
          }
          case 42: {
            if (depositParams_ == null) {
              DepositParams = new global::Cosmos.Gov.V1.DepositParams();
            }
            input.ReadMessage(DepositParams);
            break;
          }
          case 50: {
            if (votingParams_ == null) {
              VotingParams = new global::Cosmos.Gov.V1.VotingParams();
            }
            input.ReadMessage(VotingParams);
            break;
          }
          case 58: {
            if (tallyParams_ == null) {
              TallyParams = new global::Cosmos.Gov.V1.TallyParams();
            }
            input.ReadMessage(TallyParams);
            break;
          }
          case 66: {
            if (params_ == null) {
              Params = new global::Cosmos.Gov.V1.Params();
            }
            input.ReadMessage(Params);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            StartingProposalId = input.ReadUInt64();
            break;
          }
          case 18: {
            deposits_.AddEntriesFrom(ref input, _repeated_deposits_codec);
            break;
          }
          case 26: {
            votes_.AddEntriesFrom(ref input, _repeated_votes_codec);
            break;
          }
          case 34: {
            proposals_.AddEntriesFrom(ref input, _repeated_proposals_codec);
            break;
          }
          case 42: {
            if (depositParams_ == null) {
              DepositParams = new global::Cosmos.Gov.V1.DepositParams();
            }
            input.ReadMessage(DepositParams);
            break;
          }
          case 50: {
            if (votingParams_ == null) {
              VotingParams = new global::Cosmos.Gov.V1.VotingParams();
            }
            input.ReadMessage(VotingParams);
            break;
          }
          case 58: {
            if (tallyParams_ == null) {
              TallyParams = new global::Cosmos.Gov.V1.TallyParams();
            }
            input.ReadMessage(TallyParams);
            break;
          }
          case 66: {
            if (params_ == null) {
              Params = new global::Cosmos.Gov.V1.Params();
            }
            input.ReadMessage(Params);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code

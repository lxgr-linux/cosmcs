// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/crypto/multisig/keys.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Crypto.Multisig {

  /// <summary>Holder for reflection information generated from cosmos/crypto/multisig/keys.proto</summary>
  public static partial class KeysReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/crypto/multisig/keys.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeysReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFjb3Ntb3MvY3J5cHRvL211bHRpc2lnL2tleXMucHJvdG8SFmNvc21vcy5j",
            "cnlwdG8ubXVsdGlzaWcaFGdvZ29wcm90by9nb2dvLnByb3RvGhlnb29nbGUv",
            "cHJvdG9idWYvYW55LnByb3RvGhFhbWluby9hbWluby5wcm90byLDAQoRTGVn",
            "YWN5QW1pbm9QdWJLZXkSHAoJdGhyZXNob2xkGAEgASgNUgl0aHJlc2hvbGQS",
            "TgoLcHVibGljX2tleXMYAiADKAsyFC5nb29nbGUucHJvdG9idWYuQW55Qhfi",
            "3h8HUHViS2V5c6LnsCoHcHVia2V5c1IKcHVibGljS2V5czpAiKAfAIrnsCoi",
            "dGVuZGVybWludC9QdWJLZXlNdWx0aXNpZ1RocmVzaG9sZJLnsCoQdGhyZXNo",
            "b2xkX3N0cmluZ0LUAQoaY29tLmNvc21vcy5jcnlwdG8ubXVsdGlzaWdCCUtl",
            "eXNQcm90b1ABWjFnaXRodWIuY29tL2Nvc21vcy9jb3Ntb3Mtc2RrL2NyeXB0",
            "by9rZXlzL211bHRpc2lnogIDQ0NNqgIWQ29zbW9zLkNyeXB0by5NdWx0aXNp",
            "Z8oCFkNvc21vc1xDcnlwdG9cTXVsdGlzaWfiAiJDb3Ntb3NcQ3J5cHRvXE11",
            "bHRpc2lnXEdQQk1ldGFkYXRh6gIYQ29zbW9zOjpDcnlwdG86Ok11bHRpc2ln",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Gogoproto.GogoReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Amino.AminoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Crypto.Multisig.LegacyAminoPubKey), global::Cosmos.Crypto.Multisig.LegacyAminoPubKey.Parser, new[]{ "Threshold", "PublicKeys" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// LegacyAminoPubKey specifies a public key type
  /// which nests multiple public keys and a threshold,
  /// it uses legacy amino address rules.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LegacyAminoPubKey : pb::IMessage<LegacyAminoPubKey>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LegacyAminoPubKey> _parser = new pb::MessageParser<LegacyAminoPubKey>(() => new LegacyAminoPubKey());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LegacyAminoPubKey> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Crypto.Multisig.KeysReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LegacyAminoPubKey() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LegacyAminoPubKey(LegacyAminoPubKey other) : this() {
      threshold_ = other.threshold_;
      publicKeys_ = other.publicKeys_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LegacyAminoPubKey Clone() {
      return new LegacyAminoPubKey(this);
    }

    /// <summary>Field number for the "threshold" field.</summary>
    public const int ThresholdFieldNumber = 1;
    private uint threshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Threshold {
      get { return threshold_; }
      set {
        threshold_ = value;
      }
    }

    /// <summary>Field number for the "public_keys" field.</summary>
    public const int PublicKeysFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Any> _repeated_publicKeys_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Protobuf.WellKnownTypes.Any.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> publicKeys_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> PublicKeys {
      get { return publicKeys_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LegacyAminoPubKey);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LegacyAminoPubKey other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Threshold != other.Threshold) return false;
      if(!publicKeys_.Equals(other.publicKeys_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Threshold != 0) hash ^= Threshold.GetHashCode();
      hash ^= publicKeys_.GetHashCode();
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
      if (Threshold != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Threshold);
      }
      publicKeys_.WriteTo(output, _repeated_publicKeys_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Threshold != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Threshold);
      }
      publicKeys_.WriteTo(ref output, _repeated_publicKeys_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Threshold != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Threshold);
      }
      size += publicKeys_.CalculateSize(_repeated_publicKeys_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LegacyAminoPubKey other) {
      if (other == null) {
        return;
      }
      if (other.Threshold != 0) {
        Threshold = other.Threshold;
      }
      publicKeys_.Add(other.publicKeys_);
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
            Threshold = input.ReadUInt32();
            break;
          }
          case 18: {
            publicKeys_.AddEntriesFrom(input, _repeated_publicKeys_codec);
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
            Threshold = input.ReadUInt32();
            break;
          }
          case 18: {
            publicKeys_.AddEntriesFrom(ref input, _repeated_publicKeys_codec);
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

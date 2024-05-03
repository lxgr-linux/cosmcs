// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/group/module/v1/module.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Group.Module.V1 {

  /// <summary>Holder for reflection information generated from cosmos/group/module/v1/module.proto</summary>
  public static partial class ModuleReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/group/module/v1/module.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModuleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNjb3Ntb3MvZ3JvdXAvbW9kdWxlL3YxL21vZHVsZS5wcm90bxIWY29zbW9z",
            "Lmdyb3VwLm1vZHVsZS52MRogY29zbW9zL2FwcC92MWFscGhhMS9tb2R1bGUu",
            "cHJvdG8aFGdvZ29wcm90by9nb2dvLnByb3RvGh5nb29nbGUvcHJvdG9idWYv",
            "ZHVyYXRpb24ucHJvdG8aEWFtaW5vL2FtaW5vLnByb3RvIrwBCgZNb2R1bGUS",
            "WgoUbWF4X2V4ZWN1dGlvbl9wZXJpb2QYASABKAsyGS5nb29nbGUucHJvdG9i",
            "dWYuRHVyYXRpb25CDcjeHwCY3x8BqOewKgFSEm1heEV4ZWN1dGlvblBlcmlv",
            "ZBIoChBtYXhfbWV0YWRhdGFfbGVuGAIgASgEUg5tYXhNZXRhZGF0YUxlbjos",
            "usCW2gEmCiRnaXRodWIuY29tL2Nvc21vcy9jb3Ntb3Mtc2RrL3gvZ3JvdXBC",
            "pAEKGmNvbS5jb3Ntb3MuZ3JvdXAubW9kdWxlLnYxQgtNb2R1bGVQcm90b1AB",
            "ogIDQ0dNqgIWQ29zbW9zLkdyb3VwLk1vZHVsZS5WMcoCFkNvc21vc1xHcm91",
            "cFxNb2R1bGVcVjHiAiJDb3Ntb3NcR3JvdXBcTW9kdWxlXFYxXEdQQk1ldGFk",
            "YXRh6gIZQ29zbW9zOjpHcm91cDo6TW9kdWxlOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cosmos.App.V1alpha1.ModuleReflection.Descriptor, global::Gogoproto.GogoReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Amino.AminoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Group.Module.V1.Module), global::Cosmos.Group.Module.V1.Module.Parser, new[]{ "MaxExecutionPeriod", "MaxMetadataLen" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Module is the config object of the group module.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Module : pb::IMessage<Module>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Module> _parser = new pb::MessageParser<Module>(() => new Module());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Module> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Group.Module.V1.ModuleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Module() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Module(Module other) : this() {
      maxExecutionPeriod_ = other.maxExecutionPeriod_ != null ? other.maxExecutionPeriod_.Clone() : null;
      maxMetadataLen_ = other.maxMetadataLen_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Module Clone() {
      return new Module(this);
    }

    /// <summary>Field number for the "max_execution_period" field.</summary>
    public const int MaxExecutionPeriodFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Duration maxExecutionPeriod_;
    /// <summary>
    /// max_execution_period defines the max duration after a proposal's voting period ends that members can send a MsgExec
    /// to execute the proposal.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration MaxExecutionPeriod {
      get { return maxExecutionPeriod_; }
      set {
        maxExecutionPeriod_ = value;
      }
    }

    /// <summary>Field number for the "max_metadata_len" field.</summary>
    public const int MaxMetadataLenFieldNumber = 2;
    private ulong maxMetadataLen_;
    /// <summary>
    /// max_metadata_len defines the max length of the metadata bytes field for various entities within the group module.
    /// Defaults to 255 if not explicitly set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong MaxMetadataLen {
      get { return maxMetadataLen_; }
      set {
        maxMetadataLen_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Module);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Module other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MaxExecutionPeriod, other.MaxExecutionPeriod)) return false;
      if (MaxMetadataLen != other.MaxMetadataLen) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (maxExecutionPeriod_ != null) hash ^= MaxExecutionPeriod.GetHashCode();
      if (MaxMetadataLen != 0UL) hash ^= MaxMetadataLen.GetHashCode();
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
      if (maxExecutionPeriod_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MaxExecutionPeriod);
      }
      if (MaxMetadataLen != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(MaxMetadataLen);
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
      if (maxExecutionPeriod_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MaxExecutionPeriod);
      }
      if (MaxMetadataLen != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(MaxMetadataLen);
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
      if (maxExecutionPeriod_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MaxExecutionPeriod);
      }
      if (MaxMetadataLen != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(MaxMetadataLen);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Module other) {
      if (other == null) {
        return;
      }
      if (other.maxExecutionPeriod_ != null) {
        if (maxExecutionPeriod_ == null) {
          MaxExecutionPeriod = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        MaxExecutionPeriod.MergeFrom(other.MaxExecutionPeriod);
      }
      if (other.MaxMetadataLen != 0UL) {
        MaxMetadataLen = other.MaxMetadataLen;
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
          case 10: {
            if (maxExecutionPeriod_ == null) {
              MaxExecutionPeriod = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(MaxExecutionPeriod);
            break;
          }
          case 16: {
            MaxMetadataLen = input.ReadUInt64();
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
          case 10: {
            if (maxExecutionPeriod_ == null) {
              MaxExecutionPeriod = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(MaxExecutionPeriod);
            break;
          }
          case 16: {
            MaxMetadataLen = input.ReadUInt64();
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

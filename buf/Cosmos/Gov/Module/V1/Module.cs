// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/gov/module/v1/module.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Gov.Module.V1 {

  /// <summary>Holder for reflection information generated from cosmos/gov/module/v1/module.proto</summary>
  public static partial class ModuleReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/gov/module/v1/module.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModuleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFjb3Ntb3MvZ292L21vZHVsZS92MS9tb2R1bGUucHJvdG8SFGNvc21vcy5n",
            "b3YubW9kdWxlLnYxGiBjb3Ntb3MvYXBwL3YxYWxwaGExL21vZHVsZS5wcm90",
            "byJ8CgZNb2R1bGUSKAoQbWF4X21ldGFkYXRhX2xlbhgBIAEoBFIObWF4TWV0",
            "YWRhdGFMZW4SHAoJYXV0aG9yaXR5GAIgASgJUglhdXRob3JpdHk6KrrAltoB",
            "JAoiZ2l0aHViLmNvbS9jb3Ntb3MvY29zbW9zLXNkay94L2dvdkKaAQoYY29t",
            "LmNvc21vcy5nb3YubW9kdWxlLnYxQgtNb2R1bGVQcm90b1ABogIDQ0dNqgIU",
            "Q29zbW9zLkdvdi5Nb2R1bGUuVjHKAhRDb3Ntb3NcR292XE1vZHVsZVxWMeIC",
            "IENvc21vc1xHb3ZcTW9kdWxlXFYxXEdQQk1ldGFkYXRh6gIXQ29zbW9zOjpH",
            "b3Y6Ok1vZHVsZTo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cosmos.App.V1alpha1.ModuleReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Gov.Module.V1.Module), global::Cosmos.Gov.Module.V1.Module.Parser, new[]{ "MaxMetadataLen", "Authority" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Module is the config object of the gov module.
  /// </summary>
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
      get { return global::Cosmos.Gov.Module.V1.ModuleReflection.Descriptor.MessageTypes[0]; }
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
      maxMetadataLen_ = other.maxMetadataLen_;
      authority_ = other.authority_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Module Clone() {
      return new Module(this);
    }

    /// <summary>Field number for the "max_metadata_len" field.</summary>
    public const int MaxMetadataLenFieldNumber = 1;
    private ulong maxMetadataLen_;
    /// <summary>
    /// max_metadata_len defines the maximum proposal metadata length.
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

    /// <summary>Field number for the "authority" field.</summary>
    public const int AuthorityFieldNumber = 2;
    private string authority_ = "";
    /// <summary>
    /// authority defines the custom module authority. If not set, defaults to the governance module.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Authority {
      get { return authority_; }
      set {
        authority_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
      if (MaxMetadataLen != other.MaxMetadataLen) return false;
      if (Authority != other.Authority) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MaxMetadataLen != 0UL) hash ^= MaxMetadataLen.GetHashCode();
      if (Authority.Length != 0) hash ^= Authority.GetHashCode();
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
      if (MaxMetadataLen != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(MaxMetadataLen);
      }
      if (Authority.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Authority);
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
      if (MaxMetadataLen != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(MaxMetadataLen);
      }
      if (Authority.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Authority);
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
      if (MaxMetadataLen != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(MaxMetadataLen);
      }
      if (Authority.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Authority);
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
      if (other.MaxMetadataLen != 0UL) {
        MaxMetadataLen = other.MaxMetadataLen;
      }
      if (other.Authority.Length != 0) {
        Authority = other.Authority;
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
            MaxMetadataLen = input.ReadUInt64();
            break;
          }
          case 18: {
            Authority = input.ReadString();
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
            MaxMetadataLen = input.ReadUInt64();
            break;
          }
          case 18: {
            Authority = input.ReadString();
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

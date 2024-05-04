// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/distribution/module/v1/module.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Distribution.Module.V1 {

  /// <summary>Holder for reflection information generated from cosmos/distribution/module/v1/module.proto</summary>
  public static partial class ModuleReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/distribution/module/v1/module.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModuleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipjb3Ntb3MvZGlzdHJpYnV0aW9uL21vZHVsZS92MS9tb2R1bGUucHJvdG8S",
            "HWNvc21vcy5kaXN0cmlidXRpb24ubW9kdWxlLnYxGiBjb3Ntb3MvYXBwL3Yx",
            "YWxwaGExL21vZHVsZS5wcm90byKJAQoGTW9kdWxlEiwKEmZlZV9jb2xsZWN0",
            "b3JfbmFtZRgBIAEoCVIQZmVlQ29sbGVjdG9yTmFtZRIcCglhdXRob3JpdHkY",
            "AiABKAlSCWF1dGhvcml0eTozusCW2gEtCitnaXRodWIuY29tL2Nvc21vcy9j",
            "b3Ntb3Mtc2RrL3gvZGlzdHJpYnV0aW9uQscBCiFjb20uY29zbW9zLmRpc3Ry",
            "aWJ1dGlvbi5tb2R1bGUudjFCC01vZHVsZVByb3RvUAGiAgNDRE2qAh1Db3Nt",
            "b3MuRGlzdHJpYnV0aW9uLk1vZHVsZS5WMcoCHUNvc21vc1xEaXN0cmlidXRp",
            "b25cTW9kdWxlXFYx4gIpQ29zbW9zXERpc3RyaWJ1dGlvblxNb2R1bGVcVjFc",
            "R1BCTWV0YWRhdGHqAiBDb3Ntb3M6OkRpc3RyaWJ1dGlvbjo6TW9kdWxlOjpW",
            "MWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cosmos.App.V1alpha1.ModuleReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Distribution.Module.V1.Module), global::Cosmos.Distribution.Module.V1.Module.Parser, new[]{ "FeeCollectorName", "Authority" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Module is the config object of the distribution module.
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
      get { return global::Cosmos.Distribution.Module.V1.ModuleReflection.Descriptor.MessageTypes[0]; }
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
      feeCollectorName_ = other.feeCollectorName_;
      authority_ = other.authority_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Module Clone() {
      return new Module(this);
    }

    /// <summary>Field number for the "fee_collector_name" field.</summary>
    public const int FeeCollectorNameFieldNumber = 1;
    private string feeCollectorName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FeeCollectorName {
      get { return feeCollectorName_; }
      set {
        feeCollectorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
      if (FeeCollectorName != other.FeeCollectorName) return false;
      if (Authority != other.Authority) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FeeCollectorName.Length != 0) hash ^= FeeCollectorName.GetHashCode();
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
      if (FeeCollectorName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FeeCollectorName);
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
      if (FeeCollectorName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FeeCollectorName);
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
      if (FeeCollectorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FeeCollectorName);
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
      if (other.FeeCollectorName.Length != 0) {
        FeeCollectorName = other.FeeCollectorName;
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
          case 10: {
            FeeCollectorName = input.ReadString();
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
          case 10: {
            FeeCollectorName = input.ReadString();
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

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: filesystem.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Filesystem {

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class Filesystem {

    #region Descriptor
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Filesystem() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBmaWxlc3lzdGVtLnByb3RvEgpmaWxlc3lzdGVtIkMKCFVzZXJJbmZvEg0K", 
            "BXVuYW1lGAEgASgJEg4KBnBhc3N3ZBgCIAEoCRILCgN1aWQYAyABKA0SCwoD", 
            "Z2lkGAQgASgNIjwKDFVzZXJJbmZvTGlzdBIsCg51c2VyX2luZm9fbGlzdBgB", 
            "IAMoCzIULmZpbGVzeXN0ZW0uVXNlckluZm8iJAoGVWlkTWFwEgsKA3VpZBgB", 
            "IAEoDRINCgV1bmFtZRgCIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::Filesystem.UserInfo), new[]{ "Uname", "Passwd", "Uid", "Gid" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Filesystem.UserInfoList), new[]{ "UserInfoList_" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Filesystem.UidMap), new[]{ "Uid", "Uname" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UserInfo : pb::IMessage<UserInfo> {
    private static readonly pb::MessageParser<UserInfo> _parser = new pb::MessageParser<UserInfo>(() => new UserInfo());
    public static pb::MessageParser<UserInfo> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Filesystem.Filesystem.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UserInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UserInfo(UserInfo other) : this() {
      uname_ = other.uname_;
      passwd_ = other.passwd_;
      uid_ = other.uid_;
      gid_ = other.gid_;
    }

    public UserInfo Clone() {
      return new UserInfo(this);
    }

    public const int UnameFieldNumber = 1;
    private string uname_ = "";
    public string Uname {
      get { return uname_; }
      set {
        uname_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int PasswdFieldNumber = 2;
    private string passwd_ = "";
    public string Passwd {
      get { return passwd_; }
      set {
        passwd_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int UidFieldNumber = 3;
    private uint uid_;
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    public const int GidFieldNumber = 4;
    private uint gid_;
    public uint Gid {
      get { return gid_; }
      set {
        gid_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UserInfo);
    }

    public bool Equals(UserInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uname != other.Uname) return false;
      if (Passwd != other.Passwd) return false;
      if (Uid != other.Uid) return false;
      if (Gid != other.Gid) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Uname.Length != 0) hash ^= Uname.GetHashCode();
      if (Passwd.Length != 0) hash ^= Passwd.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (Gid != 0) hash ^= Gid.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Uname.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uname);
      }
      if (Passwd.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Passwd);
      }
      if (Uid != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Uid);
      }
      if (Gid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Gid);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Uname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uname);
      }
      if (Passwd.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Passwd);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (Gid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Gid);
      }
      return size;
    }

    public void MergeFrom(UserInfo other) {
      if (other == null) {
        return;
      }
      if (other.Uname.Length != 0) {
        Uname = other.Uname;
      }
      if (other.Passwd.Length != 0) {
        Passwd = other.Passwd;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.Gid != 0) {
        Gid = other.Gid;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Uname = input.ReadString();
            break;
          }
          case 18: {
            Passwd = input.ReadString();
            break;
          }
          case 24: {
            Uid = input.ReadUInt32();
            break;
          }
          case 32: {
            Gid = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UserInfoList : pb::IMessage<UserInfoList> {
    private static readonly pb::MessageParser<UserInfoList> _parser = new pb::MessageParser<UserInfoList>(() => new UserInfoList());
    public static pb::MessageParser<UserInfoList> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Filesystem.Filesystem.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UserInfoList() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UserInfoList(UserInfoList other) : this() {
      userInfoList_ = other.userInfoList_.Clone();
    }

    public UserInfoList Clone() {
      return new UserInfoList(this);
    }

    public const int UserInfoList_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::Filesystem.UserInfo> _repeated_userInfoList_codec
        = pb::FieldCodec.ForMessage(10, global::Filesystem.UserInfo.Parser);
    private readonly pbc::RepeatedField<global::Filesystem.UserInfo> userInfoList_ = new pbc::RepeatedField<global::Filesystem.UserInfo>();
    public pbc::RepeatedField<global::Filesystem.UserInfo> UserInfoList_ {
      get { return userInfoList_; }
    }

    public override bool Equals(object other) {
      return Equals(other as UserInfoList);
    }

    public bool Equals(UserInfoList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!userInfoList_.Equals(other.userInfoList_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= userInfoList_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      userInfoList_.WriteTo(output, _repeated_userInfoList_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += userInfoList_.CalculateSize(_repeated_userInfoList_codec);
      return size;
    }

    public void MergeFrom(UserInfoList other) {
      if (other == null) {
        return;
      }
      userInfoList_.Add(other.userInfoList_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            userInfoList_.AddEntriesFrom(input, _repeated_userInfoList_codec);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UidMap : pb::IMessage<UidMap> {
    private static readonly pb::MessageParser<UidMap> _parser = new pb::MessageParser<UidMap>(() => new UidMap());
    public static pb::MessageParser<UidMap> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Filesystem.Filesystem.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UidMap() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UidMap(UidMap other) : this() {
      uid_ = other.uid_;
      uname_ = other.uname_;
    }

    public UidMap Clone() {
      return new UidMap(this);
    }

    public const int UidFieldNumber = 1;
    private uint uid_;
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    public const int UnameFieldNumber = 2;
    private string uname_ = "";
    public string Uname {
      get { return uname_; }
      set {
        uname_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UidMap);
    }

    public bool Equals(UidMap other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (Uname != other.Uname) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (Uname.Length != 0) hash ^= Uname.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (Uname.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Uname);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (Uname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uname);
      }
      return size;
    }

    public void MergeFrom(UidMap other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.Uname.Length != 0) {
        Uname = other.Uname;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Uid = input.ReadUInt32();
            break;
          }
          case 18: {
            Uname = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
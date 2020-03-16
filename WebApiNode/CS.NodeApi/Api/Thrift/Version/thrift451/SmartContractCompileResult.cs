/**
 * Autogenerated by Thrift Compiler (0.12.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace NodeApi
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SmartContractCompileResult : TBase
  {
    private NodeApi.APIResponse _status;
    private List<NodeApi.ByteCodeObject> _byteCodeObjects;
    private int _tokenStandard;

    public NodeApi.APIResponse Status
    {
      get
      {
        return _status;
      }
      set
      {
        __isset.status = true;
        this._status = value;
      }
    }

    public List<NodeApi.ByteCodeObject> ByteCodeObjects
    {
      get
      {
        return _byteCodeObjects;
      }
      set
      {
        __isset.byteCodeObjects = true;
        this._byteCodeObjects = value;
      }
    }

    public int TokenStandard
    {
      get
      {
        return _tokenStandard;
      }
      set
      {
        __isset.tokenStandard = true;
        this._tokenStandard = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool status;
      public bool byteCodeObjects;
      public bool tokenStandard;
    }

    public SmartContractCompileResult() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Struct) {
                Status = new NodeApi.APIResponse();
                Status.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.List) {
                {
                  ByteCodeObjects = new List<NodeApi.ByteCodeObject>();
                  TList _list87 = iprot.ReadListBegin();
                  for( int _i88 = 0; _i88 < _list87.Count; ++_i88)
                  {
                    NodeApi.ByteCodeObject _elem89;
                    _elem89 = new NodeApi.ByteCodeObject();
                    _elem89.Read(iprot);
                    ByteCodeObjects.Add(_elem89);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                TokenStandard = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("SmartContractCompileResult");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Status != null && __isset.status) {
          field.Name = "status";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Status.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (ByteCodeObjects != null && __isset.byteCodeObjects) {
          field.Name = "byteCodeObjects";
          field.Type = TType.List;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, ByteCodeObjects.Count));
            foreach (NodeApi.ByteCodeObject _iter90 in ByteCodeObjects)
            {
              _iter90.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (__isset.tokenStandard) {
          field.Name = "tokenStandard";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(TokenStandard);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("SmartContractCompileResult(");
      bool __first = true;
      if (Status != null && __isset.status) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Status: ");
        __sb.Append(Status== null ? "<null>" : Status.ToString());
      }
      if (ByteCodeObjects != null && __isset.byteCodeObjects) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ByteCodeObjects: ");
        __sb.Append(ByteCodeObjects);
      }
      if (__isset.tokenStandard) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TokenStandard: ");
        __sb.Append(TokenStandard);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}

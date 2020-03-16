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
  public partial class ContractAllMethodsGetResult : TBase
  {
    private sbyte _code;
    private string _message;
    private List<NodeApi.MethodDescription> _methods;

    public sbyte Code
    {
      get
      {
        return _code;
      }
      set
      {
        __isset.code = true;
        this._code = value;
      }
    }

    public string Message
    {
      get
      {
        return _message;
      }
      set
      {
        __isset.message = true;
        this._message = value;
      }
    }

    public List<NodeApi.MethodDescription> Methods
    {
      get
      {
        return _methods;
      }
      set
      {
        __isset.methods = true;
        this._methods = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool code;
      public bool message;
      public bool methods;
    }

    public ContractAllMethodsGetResult() {
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
              if (field.Type == TType.Byte) {
                Code = iprot.ReadByte();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Message = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.List) {
                {
                  Methods = new List<NodeApi.MethodDescription>();
                  TList _list70 = iprot.ReadListBegin();
                  for( int _i71 = 0; _i71 < _list70.Count; ++_i71)
                  {
                    NodeApi.MethodDescription _elem72;
                    _elem72 = new NodeApi.MethodDescription();
                    _elem72.Read(iprot);
                    Methods.Add(_elem72);
                  }
                  iprot.ReadListEnd();
                }
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
        TStruct struc = new TStruct("ContractAllMethodsGetResult");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.code) {
          field.Name = "code";
          field.Type = TType.Byte;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteByte(Code);
          oprot.WriteFieldEnd();
        }
        if (Message != null && __isset.message) {
          field.Name = "message";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Message);
          oprot.WriteFieldEnd();
        }
        if (Methods != null && __isset.methods) {
          field.Name = "methods";
          field.Type = TType.List;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Methods.Count));
            foreach (NodeApi.MethodDescription _iter73 in Methods)
            {
              _iter73.Write(oprot);
            }
            oprot.WriteListEnd();
          }
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
      StringBuilder __sb = new StringBuilder("ContractAllMethodsGetResult(");
      bool __first = true;
      if (__isset.code) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Code: ");
        __sb.Append(Code);
      }
      if (Message != null && __isset.message) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Message: ");
        __sb.Append(Message);
      }
      if (Methods != null && __isset.methods) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Methods: ");
        __sb.Append(Methods);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}

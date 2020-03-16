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
  public partial class SmartContractInvocation : TBase
  {
    private string _method;
    private List<NodeApi.Variant> _params;
    private List<byte[]> _usedContracts;
    private bool _forgetNewState;
    private SmartContractDeploy _smartContractDeploy;
    private short _version;

    public string Method
    {
      get
      {
        return _method;
      }
      set
      {
        __isset.method = true;
        this._method = value;
      }
    }

    public List<NodeApi.Variant> Params
    {
      get
      {
        return _params;
      }
      set
      {
        __isset.@params = true;
        this._params = value;
      }
    }

    public List<byte[]> UsedContracts
    {
      get
      {
        return _usedContracts;
      }
      set
      {
        __isset.usedContracts = true;
        this._usedContracts = value;
      }
    }

    public bool ForgetNewState
    {
      get
      {
        return _forgetNewState;
      }
      set
      {
        __isset.forgetNewState = true;
        this._forgetNewState = value;
      }
    }

    public SmartContractDeploy SmartContractDeploy
    {
      get
      {
        return _smartContractDeploy;
      }
      set
      {
        __isset.smartContractDeploy = true;
        this._smartContractDeploy = value;
      }
    }

    public short Version
    {
      get
      {
        return _version;
      }
      set
      {
        __isset.version = true;
        this._version = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool method;
      public bool @params;
      public bool usedContracts;
      public bool forgetNewState;
      public bool smartContractDeploy;
      public bool version;
    }

    public SmartContractInvocation() {
      this._version = 1;
      this.__isset.version = true;
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
              if (field.Type == TType.String) {
                Method = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.List) {
                {
                  Params = new List<NodeApi.Variant>();
                  TList _list4 = iprot.ReadListBegin();
                  for( int _i5 = 0; _i5 < _list4.Count; ++_i5)
                  {
                    NodeApi.Variant _elem6;
                    _elem6 = new NodeApi.Variant();
                    _elem6.Read(iprot);
                    Params.Add(_elem6);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.List) {
                {
                  UsedContracts = new List<byte[]>();
                  TList _list7 = iprot.ReadListBegin();
                  for( int _i8 = 0; _i8 < _list7.Count; ++_i8)
                  {
                    byte[] _elem9;
                    _elem9 = iprot.ReadBinary();
                    UsedContracts.Add(_elem9);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Bool) {
                ForgetNewState = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Struct) {
                SmartContractDeploy = new SmartContractDeploy();
                SmartContractDeploy.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.I16) {
                Version = iprot.ReadI16();
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
        TStruct struc = new TStruct("SmartContractInvocation");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Method != null && __isset.method) {
          field.Name = "method";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Method);
          oprot.WriteFieldEnd();
        }
        if (Params != null && __isset.@params) {
          field.Name = "params";
          field.Type = TType.List;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Params.Count));
            foreach (NodeApi.Variant _iter10 in Params)
            {
              _iter10.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (UsedContracts != null && __isset.usedContracts) {
          field.Name = "usedContracts";
          field.Type = TType.List;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.String, UsedContracts.Count));
            foreach (byte[] _iter11 in UsedContracts)
            {
              oprot.WriteBinary(_iter11);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (__isset.forgetNewState) {
          field.Name = "forgetNewState";
          field.Type = TType.Bool;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(ForgetNewState);
          oprot.WriteFieldEnd();
        }
        if (SmartContractDeploy != null && __isset.smartContractDeploy) {
          field.Name = "smartContractDeploy";
          field.Type = TType.Struct;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          SmartContractDeploy.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.version) {
          field.Name = "version";
          field.Type = TType.I16;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteI16(Version);
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
      StringBuilder __sb = new StringBuilder("SmartContractInvocation(");
      bool __first = true;
      if (Method != null && __isset.method) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Method: ");
        __sb.Append(Method);
      }
      if (Params != null && __isset.@params) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Params: ");
        __sb.Append(Params);
      }
      if (UsedContracts != null && __isset.usedContracts) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("UsedContracts: ");
        __sb.Append(UsedContracts);
      }
      if (__isset.forgetNewState) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ForgetNewState: ");
        __sb.Append(ForgetNewState);
      }
      if (SmartContractDeploy != null && __isset.smartContractDeploy) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SmartContractDeploy: ");
        __sb.Append(SmartContractDeploy== null ? "<null>" : SmartContractDeploy.ToString());
      }
      if (__isset.version) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Version: ");
        __sb.Append(Version);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}

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
  public partial class SmartExecutionTransInfo : TBase
  {
    private string _method;
    private List<NodeApi.Variant> _params;
    private SmartOperationState _state;
    private TransactionId _stateTransaction;

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

    /// <summary>
    /// 
    /// <seealso cref="SmartOperationState"/>
    /// </summary>
    public SmartOperationState State
    {
      get
      {
        return _state;
      }
      set
      {
        __isset.state = true;
        this._state = value;
      }
    }

    public TransactionId StateTransaction
    {
      get
      {
        return _stateTransaction;
      }
      set
      {
        __isset.stateTransaction = true;
        this._stateTransaction = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool method;
      public bool @params;
      public bool state;
      public bool stateTransaction;
    }

    public SmartExecutionTransInfo() {
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
                  TList _list12 = iprot.ReadListBegin();
                  for( int _i13 = 0; _i13 < _list12.Count; ++_i13)
                  {
                    NodeApi.Variant _elem14;
                    _elem14 = new NodeApi.Variant();
                    _elem14.Read(iprot);
                    Params.Add(_elem14);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                State = (SmartOperationState)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Struct) {
                StateTransaction = new TransactionId();
                StateTransaction.Read(iprot);
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
        TStruct struc = new TStruct("SmartExecutionTransInfo");
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
            foreach (NodeApi.Variant _iter15 in Params)
            {
              _iter15.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (__isset.state) {
          field.Name = "state";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)State);
          oprot.WriteFieldEnd();
        }
        if (StateTransaction != null && __isset.stateTransaction) {
          field.Name = "stateTransaction";
          field.Type = TType.Struct;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          StateTransaction.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("SmartExecutionTransInfo(");
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
      if (__isset.state) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("State: ");
        __sb.Append(State);
      }
      if (StateTransaction != null && __isset.stateTransaction) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StateTransaction: ");
        __sb.Append(StateTransaction== null ? "<null>" : StateTransaction.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}

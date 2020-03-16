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
  public partial class TransactionsGetResult : TBase
  {
    private NodeApi.APIResponse _status;
    private bool _result;
    private int _total_trxns_count;
    private List<SealedTransaction> _transactions;

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

    public bool Result
    {
      get
      {
        return _result;
      }
      set
      {
        __isset.result = true;
        this._result = value;
      }
    }

    public int Total_trxns_count
    {
      get
      {
        return _total_trxns_count;
      }
      set
      {
        __isset.total_trxns_count = true;
        this._total_trxns_count = value;
      }
    }

    public List<SealedTransaction> Transactions
    {
      get
      {
        return _transactions;
      }
      set
      {
        __isset.transactions = true;
        this._transactions = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool status;
      public bool result;
      public bool total_trxns_count;
      public bool transactions;
    }

    public TransactionsGetResult() {
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
              if (field.Type == TType.Bool) {
                Result = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                Total_trxns_count = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.List) {
                {
                  Transactions = new List<SealedTransaction>();
                  TList _list37 = iprot.ReadListBegin();
                  for( int _i38 = 0; _i38 < _list37.Count; ++_i38)
                  {
                    SealedTransaction _elem39;
                    _elem39 = new SealedTransaction();
                    _elem39.Read(iprot);
                    Transactions.Add(_elem39);
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
        TStruct struc = new TStruct("TransactionsGetResult");
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
        if (__isset.result) {
          field.Name = "result";
          field.Type = TType.Bool;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Result);
          oprot.WriteFieldEnd();
        }
        if (__isset.total_trxns_count) {
          field.Name = "total_trxns_count";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Total_trxns_count);
          oprot.WriteFieldEnd();
        }
        if (Transactions != null && __isset.transactions) {
          field.Name = "transactions";
          field.Type = TType.List;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Transactions.Count));
            foreach (SealedTransaction _iter40 in Transactions)
            {
              _iter40.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("TransactionsGetResult(");
      bool __first = true;
      if (Status != null && __isset.status) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Status: ");
        __sb.Append(Status== null ? "<null>" : Status.ToString());
      }
      if (__isset.result) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Result: ");
        __sb.Append(Result);
      }
      if (__isset.total_trxns_count) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Total_trxns_count: ");
        __sb.Append(Total_trxns_count);
      }
      if (Transactions != null && __isset.transactions) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Transactions: ");
        __sb.Append(Transactions);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}

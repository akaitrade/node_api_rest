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
  public partial class MethodDescription : TBase
  {
    private string _returnType;
    private string _name;
    private List<MethodArgument> _arguments;
    private List<Annotation> _annotations;

    public string ReturnType
    {
      get
      {
        return _returnType;
      }
      set
      {
        __isset.returnType = true;
        this._returnType = value;
      }
    }

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public List<MethodArgument> Arguments
    {
      get
      {
        return _arguments;
      }
      set
      {
        __isset.arguments = true;
        this._arguments = value;
      }
    }

    public List<Annotation> Annotations
    {
      get
      {
        return _annotations;
      }
      set
      {
        __isset.annotations = true;
        this._annotations = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool returnType;
      public bool name;
      public bool arguments;
      public bool annotations;
    }

    public MethodDescription() {
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
                ReturnType = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Name = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.List) {
                {
                  Arguments = new List<MethodArgument>();
                  TList _list30 = iprot.ReadListBegin();
                  for( int _i31 = 0; _i31 < _list30.Count; ++_i31)
                  {
                    MethodArgument _elem32;
                    _elem32 = new MethodArgument();
                    _elem32.Read(iprot);
                    Arguments.Add(_elem32);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.List) {
                {
                  Annotations = new List<Annotation>();
                  TList _list33 = iprot.ReadListBegin();
                  for( int _i34 = 0; _i34 < _list33.Count; ++_i34)
                  {
                    Annotation _elem35;
                    _elem35 = new Annotation();
                    _elem35.Read(iprot);
                    Annotations.Add(_elem35);
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
        TStruct struc = new TStruct("MethodDescription");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (ReturnType != null && __isset.returnType) {
          field.Name = "returnType";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(ReturnType);
          oprot.WriteFieldEnd();
        }
        if (Name != null && __isset.name) {
          field.Name = "name";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Name);
          oprot.WriteFieldEnd();
        }
        if (Arguments != null && __isset.arguments) {
          field.Name = "arguments";
          field.Type = TType.List;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Arguments.Count));
            foreach (MethodArgument _iter36 in Arguments)
            {
              _iter36.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (Annotations != null && __isset.annotations) {
          field.Name = "annotations";
          field.Type = TType.List;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Annotations.Count));
            foreach (Annotation _iter37 in Annotations)
            {
              _iter37.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("MethodDescription(");
      bool __first = true;
      if (ReturnType != null && __isset.returnType) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ReturnType: ");
        __sb.Append(ReturnType);
      }
      if (Name != null && __isset.name) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Name: ");
        __sb.Append(Name);
      }
      if (Arguments != null && __isset.arguments) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Arguments: ");
        __sb.Append(Arguments);
      }
      if (Annotations != null && __isset.annotations) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Annotations: ");
        __sb.Append(Annotations);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}

// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v2_1
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="EndAttemptInteraction.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("endAttemptInteraction", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1", IsNullable=false)]
public partial class EndAttemptInteractionType : EmptyPrimitiveTypeType
{
    
    #region Private fields
    private string _base;
    
    private string _id;
    
    private List<string> _class;
    
    private string _lang;
    
    private string _label;
    
    private string _responseIdentifier;
    
    private string _title;
    
    private bool _countAttempt;
    #endregion
    
    public EndAttemptInteractionType()
    {
        this._class = new List<string>();
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace", AttributeName="base")]
    public string Base
    {
        get
        {
            return this._base;
        }
        set
        {
            this._base = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID", AttributeName="id")]
    public string Id
    {
        get
        {
            return this._id;
        }
        set
        {
            this._id = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="class")]
    public List<string> Class
    {
        get
        {
            return this._class;
        }
        set
        {
            this._class = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace", AttributeName="lang")]
    public string Lang
    {
        get
        {
            return this._lang;
        }
        set
        {
            this._lang = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="label")]
    public string Label
    {
        get
        {
            return this._label;
        }
        set
        {
            this._label = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName", AttributeName="responseIdentifier")]
    public string ResponseIdentifier
    {
        get
        {
            return this._responseIdentifier;
        }
        set
        {
            this._responseIdentifier = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="title")]
    public string Title
    {
        get
        {
            return this._title;
        }
        set
        {
            this._title = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="countAttempt")]
    public bool CountAttempt
    {
        get
        {
            return this._countAttempt;
        }
        set
        {
            this._countAttempt = value;
        }
    }
}
}
#pragma warning restore
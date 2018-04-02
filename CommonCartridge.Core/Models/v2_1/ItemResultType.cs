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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="ItemResult.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_result_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("ItemResultType")]
public partial class ItemResultType
{
    
    #region Private fields
    private List<object> _items;
    
    private string _candidateComment;
    
    private string _identifier;
    
    private string _sequenceIndex;
    
    private System.DateTime _datestamp;
    
    private ItemResultTypeSessionStatus _sessionStatus;
    #endregion
    
    public ItemResultType()
    {
        this._items = new List<object>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("outcomeVariable", typeof(OutcomeVariableType))]
    [System.Xml.Serialization.XmlElementAttribute("responseVariable", typeof(ResponseVariableType))]
    [System.Xml.Serialization.XmlElementAttribute("templateVariable", typeof(TemplateVariableType))]
    public List<object> Items
    {
        get
        {
            return this._items;
        }
        set
        {
            this._items = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("candidateComment")]
    public string CandidateComment
    {
        get
        {
            return this._candidateComment;
        }
        set
        {
            this._candidateComment = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString", AttributeName="identifier")]
    public string Identifier
    {
        get
        {
            return this._identifier;
        }
        set
        {
            this._identifier = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer", AttributeName="sequenceIndex")]
    public string SequenceIndex
    {
        get
        {
            return this._sequenceIndex;
        }
        set
        {
            this._sequenceIndex = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="datestamp")]
    public System.DateTime Datestamp
    {
        get
        {
            return this._datestamp;
        }
        set
        {
            this._datestamp = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="sessionStatus")]
    public ItemResultTypeSessionStatus SessionStatus
    {
        get
        {
            return this._sessionStatus;
        }
        set
        {
            this._sessionStatus = value;
        }
    }
}
}
#pragma warning restore
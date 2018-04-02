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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="MatchTable.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("matchTable", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1", IsNullable=false)]
public partial class MatchTableType
{
    
    #region Private fields
    private List<MatchTableEntryType> _matchTableEntry;
    
    private string _defaultValue;
    #endregion
    
    public MatchTableType()
    {
        this._matchTableEntry = new List<MatchTableEntryType>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("matchTableEntry", ElementName="matchTableEntry")]
    public List<MatchTableEntryType> MatchTableEntry
    {
        get
        {
            return this._matchTableEntry;
        }
        set
        {
            this._matchTableEntry = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="defaultValue")]
    public string DefaultValue
    {
        get
        {
            return this._defaultValue;
        }
        set
        {
            this._defaultValue = value;
        }
    }
}
}
#pragma warning restore
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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="SimpleMatchSet.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("simpleMatchSet", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1", IsNullable=false)]
public partial class SimpleMatchSetType
{
    
    #region Private fields
    private List<SimpleAssociableChoiceType> _simpleAssociableChoice;
    #endregion
    
    public SimpleMatchSetType()
    {
        this._simpleAssociableChoice = new List<SimpleAssociableChoiceType>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("simpleAssociableChoice", ElementName="simpleAssociableChoice")]
    public List<SimpleAssociableChoiceType> SimpleAssociableChoice
    {
        get
        {
            return this._simpleAssociableChoice;
        }
        set
        {
            this._simpleAssociableChoice = value;
        }
    }
}
}
#pragma warning restore
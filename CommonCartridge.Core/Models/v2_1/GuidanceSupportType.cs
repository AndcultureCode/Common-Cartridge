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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="GuidanceSupport.Type", Namespace="http://www.imsglobal.org/xsd/apip/apipv1p0/imsapip_qtiv1p0")]
[System.Xml.Serialization.XmlRootAttribute("GuidanceSupportType")]
public partial class GuidanceSupportType
{
    
    #region Private fields
    private string _supportOrder;
    
    private LabelledStringType _textString;
    #endregion
    
    public GuidanceSupportType()
    {
        this._textString = new LabelledStringType();
    }
    
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", ElementName="supportOrder")]
    public string SupportOrder
    {
        get
        {
            return this._supportOrder;
        }
        set
        {
            this._supportOrder = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("textString")]
    public LabelledStringType TextString
    {
        get
        {
            return this._textString;
        }
        set
        {
            this._textString = value;
        }
    }
}
}
#pragma warning restore
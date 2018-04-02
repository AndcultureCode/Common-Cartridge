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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="TemplateCondition.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("templateCondition", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1", IsNullable=false)]
public partial class TemplateConditionType
{
    
    #region Private fields
    private TemplateIfType _templateIf;
    
    private List<TemplateIfType> _templateElseIf;
    
    private TemplateElseType _templateElse;
    #endregion
    
    public TemplateConditionType()
    {
        this._templateElse = new TemplateElseType();
        this._templateElseIf = new List<TemplateIfType>();
        this._templateIf = new TemplateIfType();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("templateIf")]
    public TemplateIfType TemplateIf
    {
        get
        {
            return this._templateIf;
        }
        set
        {
            this._templateIf = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("templateElseIf", ElementName="templateElseIf")]
    public List<TemplateIfType> TemplateElseIf
    {
        get
        {
            return this._templateElseIf;
        }
        set
        {
            this._templateElseIf = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("templateElse")]
    public TemplateElseType TemplateElse
    {
        get
        {
            return this._templateElse;
        }
        set
        {
            this._templateElse = value;
        }
    }
}
}
#pragma warning restore
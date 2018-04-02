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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="TestFeedback.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("testFeedback", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1", IsNullable=false)]
public partial class TestFeedbackType
{
    
    #region Private fields
    private object[] _items;
    
    private ItemsChoiceType42[] _itemsElementName;
    
    private List<StyleSheetType> _stylesheet;
    
    private APIPAccessibilityType _apipAccessibility;
    
    private List<string> _text;
    
    private TestFeedbackTypeAccess _access;
    
    private string _outcomeIdentifier;
    
    private TestFeedbackTypeShowHide _showHide;
    
    private string _identifier;
    
    private string _title;
    #endregion
    
    public TestFeedbackType()
    {
        this._text = new List<string>();
        this._apipAccessibility = new APIPAccessibilityType();
        this._stylesheet = new List<StyleSheetType>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("a", typeof(AType))]
    [System.Xml.Serialization.XmlElementAttribute("abbr", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("acronym", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("address", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("b", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("big", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("blockquote", typeof(BlockQuoteType))]
    [System.Xml.Serialization.XmlElementAttribute("br", typeof(BRType))]
    [System.Xml.Serialization.XmlElementAttribute("cite", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("code", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("dfn", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("div", typeof(DivType))]
    [System.Xml.Serialization.XmlElementAttribute("dl", typeof(DLType))]
    [System.Xml.Serialization.XmlElementAttribute("em", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("h1", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("h2", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("h3", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("h4", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("h5", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("h6", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("hottext", typeof(HotTextType))]
    [System.Xml.Serialization.XmlElementAttribute("hr", typeof(HRType))]
    [System.Xml.Serialization.XmlElementAttribute("i", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("img", typeof(ImgType))]
    [System.Xml.Serialization.XmlElementAttribute("kbd", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("object", typeof(ObjectType))]
    [System.Xml.Serialization.XmlElementAttribute("ol", typeof(OULType))]
    [System.Xml.Serialization.XmlElementAttribute("p", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("pre", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("printedVariable", typeof(PrintedVariableType))]
    [System.Xml.Serialization.XmlElementAttribute("q", typeof(QType))]
    [System.Xml.Serialization.XmlElementAttribute("samp", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("small", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("span", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("strong", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("sub", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("sup", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("table", typeof(TableType))]
    [System.Xml.Serialization.XmlElementAttribute("templateBlock", typeof(TemplateBlockType))]
    [System.Xml.Serialization.XmlElementAttribute("templateInline", typeof(TemplateInlineType))]
    [System.Xml.Serialization.XmlElementAttribute("tt", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("ul", typeof(OULType))]
    [System.Xml.Serialization.XmlElementAttribute("var", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("math", typeof(Mathtype), Namespace="http://www.w3.org/1998/Math/MathML")]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(IncludeType), Namespace="http://www.w3.org/2001/XInclude")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
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
    
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType42[] ItemsElementName
    {
        get
        {
            return this._itemsElementName;
        }
        set
        {
            this._itemsElementName = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("stylesheet", ElementName="stylesheet")]
    public List<StyleSheetType> Stylesheet
    {
        get
        {
            return this._stylesheet;
        }
        set
        {
            this._stylesheet = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.imsglobal.org/xsd/apip/apipv1p0/imsapip_qtiv1p0", ElementName="apipAccessibility")]
    public APIPAccessibilityType ApipAccessibility
    {
        get
        {
            return this._apipAccessibility;
        }
        set
        {
            this._apipAccessibility = value;
        }
    }
    
    [System.Xml.Serialization.XmlTextAttribute()]
    public List<string> Text
    {
        get
        {
            return this._text;
        }
        set
        {
            this._text = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="access")]
    public TestFeedbackTypeAccess Access
    {
        get
        {
            return this._access;
        }
        set
        {
            this._access = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName", AttributeName="outcomeIdentifier")]
    public string OutcomeIdentifier
    {
        get
        {
            return this._outcomeIdentifier;
        }
        set
        {
            this._outcomeIdentifier = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="showHide")]
    public TestFeedbackTypeShowHide ShowHide
    {
        get
        {
            return this._showHide;
        }
        set
        {
            this._showHide = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName", AttributeName="identifier")]
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
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString", AttributeName="title")]
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
}
}
#pragma warning restore